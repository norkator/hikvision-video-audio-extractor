using System;
using System.Collections.Generic;
using System.Globalization;
using System.Threading;
using System.Threading.Tasks;
using NVRCsharpDemo;

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

        // Video output
        private string _outputLocationPath;

        // Variables
        private List<Recording> _recordings = null;

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
        private Int32 _mLTree = 0;
        private long iSelIndex = 0; // Selected channel index

        // Constructor
        public NvrConnector(string ipAddress, int port, string username, string password,
            string dbConnString, string outputLocationPath)
        {
            _ipAddress = ipAddress;
            _port = (Int16) port;
            _username = username;
            _password = password;

            _database = new Database(dbConnString);
            _outputLocationPath = outputLocationPath;

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

            OpenDatabaseConnection();
        }


        /**
         * Open database connection,
         * if fails, will try again after 60 seconds
         */
        private void OpenDatabaseConnection()
        {
            Task<bool> dbConnected = Task.Run(async () => await _database.OpenDatabaseConnection());
            if (dbConnected.Result)
            {
                GetLastRecordingEndTime();
            }
            else
            {
                Thread.Sleep(60 * 1000); // Sleep for a minute
                OpenDatabaseConnection(); // Then try re open connection
            }
        }


        private void GetLastRecordingEndTime()
        {
            Task<DateTime> result = Task.Run(async () => await _database.GetLastRecordingEndTime());
            LoginLogoutNvr(result.Result);
        }


        private void LoginLogoutNvr(DateTime lastRecordingEndTime)
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
                        // InfoIPChannel(); TODO: Implement later
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

                    SearchRecordings(lastRecordingEndTime);
                }
            }
            else
            {
                if (m_lPlayHandle >= 0)
                {
                    Console.WriteLine("Please stop playback firstly"); // Please stop playback before logout
                    return;
                }

                //Logout the device
                if (!CHCNetSDK.NET_DVR_Logout(_mLUserId))
                {
                    _iLastErr = CHCNetSDK.NET_DVR_GetLastError();
                    _errorMsg = "NET_DVR_Logout failed, error code= " + _iLastErr;
                    Console.WriteLine(_errorMsg);
                    return;
                }

                _mLUserId = -1;
                Console.WriteLine("Logged out from NVR");
            }
        }

        public void LogOutNvr()
        {
            if (_mLUserId >= 0)
            {
                LoginLogoutNvr(new DateTime());
            }
            else
            {
                Console.WriteLine("Already logged out from NVR");
            }
        }


        private void ListAnalogChannel(Int32 iChanNo, byte byEnable)
        {
            var str1 = $"Camera {iChanNo}";
            _mLTree++;
            var str2 = byEnable == 0 ? "Disabled" : "Enabled";

            Console.WriteLine(str1 + "        " + str2);
        }


        private void SearchRecordings(DateTime lastRecordingEndTime)
        {
            _recordings = new List<Recording>();

            CHCNetSDK.NET_DVR_FILECOND_V40 struFileCondV40 = new CHCNetSDK.NET_DVR_FILECOND_V40();

            // TODO: nothing yet selects iSelIndex, or is 0 "first one"?
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
            struFileCondV40.struStopTime.dwHour = 23;
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

                        var str2 = Convert.ToString(struFileData.struStartTime.dwYear) + "-" +
                                   Convert.ToString(struFileData.struStartTime.dwMonth) + "-" +
                                   Convert.ToString(struFileData.struStartTime.dwDay) + " " +
                                   Convert.ToString(struFileData.struStartTime.dwHour) + ":" +
                                   Convert.ToString(struFileData.struStartTime.dwMinute) + ":" +
                                   Convert.ToString(struFileData.struStartTime.dwSecond);


                        var eDYear = Convert.ToString(struFileData.struStopTime.dwYear);
                        var eDMonth = Convert.ToString(struFileData.struStopTime.dwMonth);
                        var eDDAy = Convert.ToString(struFileData.struStopTime.dwDay);
                        var eDHour = Convert.ToString(struFileData.struStopTime.dwHour);
                        var eDMinute = Convert.ToString(struFileData.struStopTime.dwMinute);
                        var eDSecond = Convert.ToString(struFileData.struStopTime.dwSecond);

                        var str3 = eDYear + "-" + eDMonth + "-" + eDDAy + " " +
                                   eDHour + ":" + eDMinute + ":" + eDSecond;

                        DateTime recordingDate = DateTime.ParseExact(
                            str3,
                            "yyyy-M-d H:m:s", // Todo: verify later with different cases!
                            CultureInfo.InvariantCulture
                        );

                        if (DateTime.Compare(recordingDate, lastRecordingEndTime) == 1)
                        {
                            _recordings.Add(
                                new Recording(0, str1, str2, str3)
                            );
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

                ValidateRecordings(_recordings);
            }
        }


        private void ValidateRecordings(List<Recording> recordings)
        {
            /*
            recordings.ForEach(recording =>
            {
                // Console.WriteLine(recording.GetFileName());
            });
            */
            Console.WriteLine(recordings.Count + " recordings to download");
        }
    }
}