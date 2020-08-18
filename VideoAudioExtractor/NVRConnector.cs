using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Threading;
using System.Threading.Tasks;
using FFMpegCore;
using Npgsql;
using NVRCsharpDemo;
using RunProcessAsTask;

namespace VideoAudioExtractor
{
    public class NvrConnector
    {
        // Connection variables
        private readonly string _ipAddress;
        private readonly Int16 _port;
        private readonly string _username;
        private readonly string _password;

        // Database
        private readonly Database _database = null;

        // Camera
        private readonly string _cameraName;

        // Video output
        private readonly string _videoExtension = $"." + $"mp4";
        private readonly string _audioExtension = $"." + $"mp3";
        private readonly string _outputLocationPath;
        private readonly string _audioExportPath;
        private readonly bool _deleteVideos;
        private readonly bool _audioSilenceRemove;
        private readonly string _audiodBThreshold;

        // Camera variables
        private Int32 _i = 0;
        private uint _iLastErr = 0;
        private Int32 _mLUserId = -1;
        private CHCNetSDK.NET_DVR_DEVICEINFO_V30 _deviceInfo;
        private string _errorMsg = string.Empty;
        private uint _dwAChanTotalNum = 0;
        private uint _dwDChanTotalNum = 0;
        private Int32 _mLFindHandle = -1;
        private Int32 m_lPlayHandle = -1;
        private Int32 _mLDownHandle = -1;
        private readonly int[] _iChannelNum;
        private long iSelIndex = 0; // Selected channel index

        // Constructor
        public NvrConnector(string ipAddress, int port, string username, string password,
            string dbConnString, string outputLocationPath, string audioExportPath, bool deleteVideos,
            string cameraName, bool audioSilenceRemove, string audiodBThreshold)
        {
            _ipAddress = ipAddress;
            _port = (Int16) port;
            _username = username;
            _password = password;

            _cameraName = cameraName;
            _database = new Database(dbConnString);
            _outputLocationPath = outputLocationPath;
            _audioExportPath = audioExportPath;
            _deleteVideos = deleteVideos;
            _audioSilenceRemove = audioSilenceRemove;
            _audiodBThreshold = audiodBThreshold;

            var mBInitSdk = CHCNetSDK.NET_DVR_Init();
            if (mBInitSdk == false)
            {
                Console.WriteLine("NET_DVR_Init error!");
                return;
            }
            else
            {
                //Save log of SDK
                CHCNetSDK.NET_DVR_SetLogToFile(3, "C:\\SdkLog\\", true);
                _iChannelNum = new int[96];
            }
        }


        /**
         * Open database connection,
         * if fails, will try again after 60 seconds
         */
        public async Task StartProcess()
        {
            if (!_database.Connected())
            {
                await _database.OpenDatabaseConnection();
                Console.WriteLine("Was not connected to database, connected now...");
            }

            try
            {
                Console.WriteLine("Starting processor...");
                await Processor();
            }
            catch (System.AggregateException e)
            {
                Console.WriteLine(e);
                Console.WriteLine("Npgsql connection lost? try again on next run...");
            }
            catch (NpgsqlException e)
            {
                Console.WriteLine(e);
            }
        }


        private async Task Processor()
        {
            // Get latest recording end time we have
            var lastRecordingEndTime = GetLastRecordingEndTime();
            if (LoginLogoutNvr())
            {
                try
                {
                    // Find recordings from camera
                    Task<List<Recording>> searchRecordingsTask = SearchRecordings(lastRecordingEndTime);
                    await searchRecordingsTask;
                    List<Recording> recordings = searchRecordingsTask.Result;

                    if (recordings.Count > 0)
                    {
                        // Download recordings which we don't have
                        Task<List<Recording>> downloadedRecordingsTask = DownloadRecordings(recordings);
                        await downloadedRecordingsTask;
                        List<Recording> downloadedRecordings = downloadedRecordingsTask.Result;

                        // Log out from nvr at this point
                        LogOutNvr();
                    }
                    else
                    {
                        Console.WriteLine("No recordings to download...");
                        LogOutNvr();
                    }
                }
                catch (System.AggregateException exception)
                {
                    Console.WriteLine(exception.Message);
                    LogOutNvr();
                }
            }
        }


        private DateTime GetLastRecordingEndTime()
        {
            Task<DateTime> result = Task.Run(async () => await _database.GetLastRecordingEndTime());
            return result.Result;
        }


        private Boolean LoginLogoutNvr()
        {
            if (_mLUserId < 0)
            {
                //Login the device
                Console.WriteLine("Login target: " + _ipAddress + ":" + _port);
                _mLUserId = CHCNetSDK.NET_DVR_Login_V30(_ipAddress, _port, _username, _password,
                    ref _deviceInfo);
                if (_mLUserId < 0)
                {
                    _iLastErr = CHCNetSDK.NET_DVR_GetLastError();
                    _errorMsg =
                        "NET_DVR_Login_V30 failed, error code= " + _iLastErr; // Login failed, print error code
                    Console.WriteLine(_errorMsg);
                }
                else
                {
                    Console.WriteLine("Login Success!");
                    // btnLogin.Text = "Logout";

                    _dwAChanTotalNum = _deviceInfo.byChanNum;
                    _dwDChanTotalNum = _deviceInfo.byIPChanNum + 256 * (uint) _deviceInfo.byHighDChanNum;

                    Console.WriteLine("Count of ip channels: " + _dwDChanTotalNum);

                    if (_dwDChanTotalNum > 0)
                    {
                        // InfoIPChannel(); TODO: Implement later if needed
                    }
                    else
                    {
                        Console.WriteLine("Channel    |    State");
                        for (_i = 0; _i < _dwAChanTotalNum; _i++)
                        {
                            ListAnalogChannel(_i + 1, 1);
                            _iChannelNum[_i] = _i + _deviceInfo.byStartChan;
                        }

                        Console.WriteLine("This device has no IP channel!");
                    }

                    return true;
                }
            }
            else
            {
                if (m_lPlayHandle >= 0)
                {
                    Console.WriteLine("Please stop playback firstly"); // Please stop playback before logout
                    return false;
                }

                //Logout the device
                if (!CHCNetSDK.NET_DVR_Logout(_mLUserId))
                {
                    _iLastErr = CHCNetSDK.NET_DVR_GetLastError();
                    _errorMsg = "NET_DVR_Logout failed, error code= " + _iLastErr;
                    Console.WriteLine(_errorMsg);
                    return false;
                }

                _mLUserId = -1;
                Console.WriteLine("Logged out from NVR");
            }

            return false;
        }


        public void LogOutNvr()
        {
            if (_mLUserId >= 0)
            {
                LoginLogoutNvr();
            }
            else
            {
                Console.WriteLine("Already logged out from NVR");
            }
        }


        private void ListAnalogChannel(Int32 iChanNo, byte enable)
        {
            var str1 = $"Camera {iChanNo}";
            var str2 = enable == 0 ? "Disabled" : "Enabled";

            Console.WriteLine(str1 + "        " + str2);
        }


        private async Task<List<Recording>> SearchRecordings(DateTime lastRecordingEndTime)
        {
            List<Recording> recordings = new List<Recording>();

            CHCNetSDK.NET_DVR_FILECOND_V40 struFileCondV40 = new CHCNetSDK.NET_DVR_FILECOND_V40();

            struFileCondV40.lChannel = _iChannelNum[(int) iSelIndex]; //Channel number
            struFileCondV40.dwFileType = 0xff; //0xff-All，0-Timing record，1-Motion detection，2-Alarm trigger，...
            struFileCondV40.dwIsLocked =
                0xff; //0-unfixed file，1-fixed file，0xff means all files（including fixed and unfixed files）

            DateTime today = DateTime.Now;

            //Set the starting time to search video files
            struFileCondV40.struStartTime.dwYear = (uint) today.Year;
            struFileCondV40.struStartTime.dwMonth = (uint) today.Month;
            struFileCondV40.struStartTime.dwDay = (uint) today.Day;
            struFileCondV40.struStartTime.dwHour = 0;
            struFileCondV40.struStartTime.dwMinute = 0;
            struFileCondV40.struStartTime.dwSecond = 0;

            //Set the stopping time to search video files
            struFileCondV40.struStopTime.dwYear = (uint) today.Year;
            struFileCondV40.struStopTime.dwMonth = (uint) today.Month;
            struFileCondV40.struStopTime.dwDay = (uint) today.Day;
            struFileCondV40.struStopTime.dwHour = 23; // This most likely will miss files when day changes
            struFileCondV40.struStopTime.dwMinute = 59;
            struFileCondV40.struStopTime.dwSecond = 59;

            //Start to search video files 
            _mLFindHandle = CHCNetSDK.NET_DVR_FindFile_V40(_mLUserId, ref struFileCondV40);

            if (_mLFindHandle < 0)
            {
                _iLastErr = CHCNetSDK.NET_DVR_GetLastError();
                _errorMsg = "NET_DVR_FindFile_V40 failed, error code= " +
                            _iLastErr; // find files failed，print error code
                Console.WriteLine(_errorMsg);
            }
            else
            {
                CHCNetSDK.NET_DVR_FINDDATA_V30 struFileData = new CHCNetSDK.NET_DVR_FINDDATA_V30();
                while (true)
                {
                    //Get file information one by one.
                    int result = CHCNetSDK.NET_DVR_FindNextFile_V30(_mLFindHandle, ref struFileData);

                    if (result == CHCNetSDK.NET_DVR_ISFINDING) //Searching, please wait
                    {
                        // continue;
                    }
                    else if (result == CHCNetSDK.NET_DVR_FILE_SUCCESS) //Get the file information successfully
                    {
                        var str1 = struFileData.sFileName;

                        var sDYear = Convert.ToString(struFileData.struStartTime.dwYear);
                        var sDMonth = Convert.ToString(struFileData.struStartTime.dwMonth);
                        var sDDAy = Convert.ToString(struFileData.struStartTime.dwDay);
                        var sDHour = Convert.ToString(struFileData.struStartTime.dwHour);
                        var sDMinute = Convert.ToString(struFileData.struStartTime.dwMinute);
                        var sDSecond = Convert.ToString(struFileData.struStartTime.dwSecond);

                        var str2 = sDYear + "-" + sDMonth + "-" + sDDAy + " " +
                                   sDHour + ":" + sDMinute + ":" + sDSecond;

                        var eDYear = Convert.ToString(struFileData.struStopTime.dwYear);
                        var eDMonth = Convert.ToString(struFileData.struStopTime.dwMonth);
                        var eDDAy = Convert.ToString(struFileData.struStopTime.dwDay);
                        var eDHour = Convert.ToString(struFileData.struStopTime.dwHour);
                        var eDMinute = Convert.ToString(struFileData.struStopTime.dwMinute);
                        var eDSecond = Convert.ToString(struFileData.struStopTime.dwSecond);

                        var str3 = eDYear + "-" + eDMonth + "-" + eDDAy + " " +
                                   eDHour + ":" + eDMinute + ":" + eDSecond;

                        DateTime recordingStartDate =
                            DateTime.ParseExact(str2, "yyyy-M-d H:m:s", CultureInfo.InvariantCulture);

                        DateTime recordingEndDate =
                            DateTime.ParseExact(str3, "yyyy-M-d H:m:s", CultureInfo.InvariantCulture);

                        if (DateTime.Compare(recordingEndDate, lastRecordingEndTime) == 1)
                        {
                            Recording recording = new Recording(_cameraName, 0, str1, str2, str3);
                            recording.SetDtStartTime(recordingStartDate);
                            recording.SetDtEndTime(recordingEndDate);
                            recordings.Add(recording);
                            Console.WriteLine("Found non existing: " + str1 + " - " + str2);
                        }
                    }
                    else if (result == CHCNetSDK.NET_DVR_FILE_NOFIND || result == CHCNetSDK.NET_DVR_NOMOREFILE)
                    {
                        break; //No file found or no more file found, searching is finished 
                    }
                    else
                    {
                        break;
                    }
                }

                return recordings;
            }

            return null;
        }


        private async Task<List<Recording>> DownloadRecordings(List<Recording> recordings)
        {
            Console.WriteLine(recordings.Count + " recordings to download");
            List<Recording> downloadedRecordings = new List<Recording>();
            foreach (var recording in recordings)
            {
                if (await DownloadRecording(recording))
                {
                    downloadedRecordings.Add(recording);
                    bool result = await ExtractAudio(recording);
                    if (result && _audioSilenceRemove)
                    {
                        await AudioSilenceRemove(recording, _audiodBThreshold);
                    }

                    if (_deleteVideos)
                    {
                        DeleteFile(_outputLocationPath + recording.GetFileName() + _videoExtension);
                    }
                }

                // Update database, set as downloaded, no matter is it downloaded successfully or not
                await UpdateDatabase(recording);
            }

            return downloadedRecordings;
        }


        private async Task<Boolean> DownloadRecording(Recording recording)
        {
            if (_mLDownHandle >= 0)
            {
                Console.WriteLine("Error, already downloading!");
                return false;
            }

            var sVideoFileName = _outputLocationPath + recording.GetFileName() + _videoExtension;

            Console.WriteLine("Downloading: " + recording.GetFileName());

            // Download from nvr/camera by file name
            _mLDownHandle = CHCNetSDK.NET_DVR_GetFileByName(_mLUserId, recording.GetFileName(),
                sVideoFileName);
            if (_mLDownHandle < 0)
            {
                _iLastErr = CHCNetSDK.NET_DVR_GetLastError();
                _errorMsg = "NET_DVR_GetFileByName failed, error code= " + _iLastErr;
                Console.WriteLine(_errorMsg);
                if (_iLastErr == 34) // Target folder does not exist, create it
                {
                    System.IO.Directory.CreateDirectory(_outputLocationPath);
                }

                return false;
            }

            uint iOutValue = 0;

            if (!CHCNetSDK.NET_DVR_PlayBackControl_V40(_mLDownHandle, CHCNetSDK.NET_DVR_PLAYSTART,
                IntPtr.Zero, 0, IntPtr.Zero, ref iOutValue))
            {
                _iLastErr = CHCNetSDK.NET_DVR_GetLastError();
                _errorMsg = "NET_DVR_PLAY_START failed, error code= " +
                            _iLastErr; // Download controlling failed, print error code
                Console.WriteLine(_errorMsg);
                return false;
            }

            var downloadProgress = 0;

            while (downloadProgress < 100)
            {
                // Get downloading process
                downloadProgress = CHCNetSDK.NET_DVR_GetDownloadPos(_mLDownHandle);
                Thread.Sleep(1 * 1000);
                Console.WriteLine("Download progress: " + downloadProgress + "%");
            }

            _mLDownHandle = -1;
            return true;
        }


        private async Task<bool> ExtractAudio(Recording recording)
        {
            try
            {
                // Console.WriteLine("Video input path: " + _outputLocationPath + recording.GetFileName() + _videoExtension);
                // Console.WriteLine("Audio export path: " + _audioExportPath + recording.GetFileName() + _audioExtension);

                string audioOutput = _audioExportPath + recording.GetFileName() +
                                     (_audioSilenceRemove ? "_temp" : "") + _audioExtension;

                return FFMpeg.ExtractAudio(_outputLocationPath + recording.GetFileName() + _videoExtension,
                    audioOutput);
            }
            catch (TypeInitializationException e)
            {
                Console.WriteLine(e);
            }

            return false;
        }


        private async Task<bool> AudioSilenceRemove(Recording recording, String dBThreshold = "-40dB")
        {
            Console.WriteLine("Remove audio silence with " + dBThreshold + " from " + recording.GetFileName());
            try
            {
                string audioFileIn = _audioExportPath + recording.GetFileName() + "_temp" + _audioExtension;
                string audioFileOut = _audioExportPath + recording.GetFileName() + _audioExtension;

                string strCmdText =
                    "/c start ffmpeg -y -i " + audioFileIn +
                    " -af silenceremove=stop_periods=-1:stop_duration=1:stop_threshold=" +
                    dBThreshold + " " + audioFileOut;
                
                // System.Diagnostics.Process.Start("CMD.exe", strCmdText);
                Task<ProcessResults> processResults = ProcessEx.RunAsync("CMD.exe", strCmdText);
                await processResults;
                DeleteFile(audioFileIn);
                
                return true;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return false;
            }
        }
        

        private async Task<bool> UpdateDatabase(Recording recording)
        {
            await _database.InsertRecording(recording);
            return true;
        }

        private void DeleteFile(String filePath)
        {
            if (File.Exists(filePath))
            {
                File.Delete(filePath);
            }
        }
    }
}