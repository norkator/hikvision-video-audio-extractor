using System;
using NVRCsharpDemo;

namespace VideoAudioExtractor
{
    public class NVRConnector
    {
        // Connection variables
        private readonly string _ipAddress;
        private readonly Int16 _port;
        private readonly string _username;
        private readonly string _password;

        // Database
        private Database _database = null;
        private readonly string _dbConnString;

        // Video output
        private string _outputLocationPath;

        // Camera variables
        private Int32 i = 0;
        private bool m_bInitSDK = false;
        private uint iLastErr = 0;
        private Int32 m_lUserID = -1;
        private CHCNetSDK.NET_DVR_DEVICEINFO_V30 DeviceInfo;
        private string _errorMsg = string.Empty;
        private uint dwAChanTotalNum = 0;
        private uint dwDChanTotalNum = 0;
        private Int32 m_lFindHandle = -1;
        private Int32 m_lPlayHandle = -1;
        private Int32 m_lDownHandle = -1;
        private int[] iChannelNum;
        private Int32 m_lTree = 0;
        private long iSelIndex = 0; // Selected channel index

        // Constructor
        public NVRConnector(string ipAddress, int port, string username, string password,
            string dbConnString, string outputLocationPath)
        {
            _ipAddress = ipAddress;
            _port = (Int16) port;
            _username = username;
            _password = password;


            _dbConnString = dbConnString;
            _database = new Database(_dbConnString);

            _outputLocationPath = outputLocationPath;

            m_bInitSDK = CHCNetSDK.NET_DVR_Init();
            if (m_bInitSDK == false)
            {
                Console.WriteLine("NET_DVR_Init error!");
                return;
            }
            else
            {
                //Save log of SDK
                CHCNetSDK.NET_DVR_SetLogToFile(3, "C:\\SdkLog\\", true);
                iChannelNum = new int[96];
            }

            // LoginLogoutNvr();
        }


        private void LoginLogoutNvr()
        {
            if (m_lUserID < 0)
            {
                //Login the device
                Console.WriteLine("Login target: " + _ipAddress + ":" + _port);
                m_lUserID = CHCNetSDK.NET_DVR_Login_V30(_ipAddress, _port, _username, _password,
                    ref DeviceInfo);
                if (m_lUserID < 0)
                {
                    iLastErr = CHCNetSDK.NET_DVR_GetLastError();
                    _errorMsg =
                        "NET_DVR_Login_V30 failed, error code= " + iLastErr; // Login failed, print error code
                    Console.WriteLine(_errorMsg);
                    return;
                }
                else
                {
                    Console.WriteLine("Login Success!");
                    // btnLogin.Text = "Logout";

                    dwAChanTotalNum = (uint) DeviceInfo.byChanNum;
                    dwDChanTotalNum = (uint) DeviceInfo.byIPChanNum + 256 * (uint) DeviceInfo.byHighDChanNum;

                    Console.WriteLine("Count of ip channels: " + dwDChanTotalNum);

                    if (dwDChanTotalNum > 0)
                    {
                        // InfoIPChannel(); TODO: Implement later
                    }
                    else
                    {
                        Console.WriteLine("Channel    |    State");
                        for (i = 0; i < dwAChanTotalNum; i++)
                        {
                            ListAnalogChannel(i + 1, 1);
                            iChannelNum[i] = i + (int) DeviceInfo.byStartChan;
                        }

                        Console.WriteLine("This device has no IP channel!");
                    }
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
                if (!CHCNetSDK.NET_DVR_Logout(m_lUserID))
                {
                    iLastErr = CHCNetSDK.NET_DVR_GetLastError();
                    _errorMsg = "NET_DVR_Logout failed, error code= " + iLastErr;
                    Console.WriteLine(_errorMsg);
                    return;
                }

                m_lUserID = -1;
                Console.WriteLine("Logged out from NVR");
            }

            return;
        }

        public void LogOutNvr()
        {
            LoginLogoutNvr();
        }


        private void ListAnalogChannel(Int32 iChanNo, byte byEnable)
        {
            var str1 = $"Camera {iChanNo}";
            string str2;
            m_lTree++;
            if (byEnable == 0)
            {
                str2 = "Disabled"; // This channel has been disabled               
            }
            else
            {
                str2 = "Enabled"; // This channel has been enabled  
            }

            Console.WriteLine(str1 + "    |    " + str2);
        }


        public void SearchRecordings()
        {
            CHCNetSDK.NET_DVR_FILECOND_V40 struFileCond_V40 = new CHCNetSDK.NET_DVR_FILECOND_V40();

            // TODO: nothing yet selects iSelIndex, or is 0 "first one"?
            struFileCond_V40.lChannel = iChannelNum[(int) iSelIndex]; //Channel number
            struFileCond_V40.dwFileType = 0xff; //0xff-All，0-Timing record，1-Motion detection，2-Alarm trigger，...
            struFileCond_V40.dwIsLocked =
                0xff; //0-unfixed file，1-fixed file，0xff means all files（including fixed and unfixed files）

            DateTime today = DateTime.Now;

            //Set the starting time to search video files
            struFileCond_V40.struStartTime.dwYear = (uint) today.Year;
            struFileCond_V40.struStartTime.dwMonth = (uint) today.Month;
            struFileCond_V40.struStartTime.dwDay = (uint) today.Day;
            struFileCond_V40.struStartTime.dwHour = (uint) 0;
            struFileCond_V40.struStartTime.dwMinute = (uint) 0;
            struFileCond_V40.struStartTime.dwSecond = (uint) 0;

            //Set the stopping time to search video files
            struFileCond_V40.struStopTime.dwYear = (uint) today.Year;
            struFileCond_V40.struStopTime.dwMonth = (uint) today.Month;
            struFileCond_V40.struStopTime.dwDay = (uint) today.Day;
            struFileCond_V40.struStopTime.dwHour = (uint) 23;
            struFileCond_V40.struStopTime.dwMinute = (uint) 59;
            struFileCond_V40.struStopTime.dwSecond = (uint) 59;

            //Start to search video files 
            m_lFindHandle = CHCNetSDK.NET_DVR_FindFile_V40(m_lUserID, ref struFileCond_V40);

            if (m_lFindHandle < 0)
            {
                iLastErr = CHCNetSDK.NET_DVR_GetLastError();
                _errorMsg = "NET_DVR_FindFile_V40 failed, error code= " +
                            iLastErr; // find files failed，print error code
                Console.WriteLine(_errorMsg);
                return;
            }
            else
            {
                CHCNetSDK.NET_DVR_FINDDATA_V30 struFileData = new CHCNetSDK.NET_DVR_FINDDATA_V30();
                ;
                while (true)
                {
                    //Get file information one by one.
                    int result = CHCNetSDK.NET_DVR_FindNextFile_V30(m_lFindHandle, ref struFileData);

                    if (result == CHCNetSDK.NET_DVR_ISFINDING) //Searching, please wait
                    {
                        continue;
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

                        var str3 = Convert.ToString(struFileData.struStopTime.dwYear) + "-" +
                                   Convert.ToString(struFileData.struStopTime.dwMonth) + "-" +
                                   Convert.ToString(struFileData.struStopTime.dwDay) + " " +
                                   Convert.ToString(struFileData.struStopTime.dwHour) + ":" +
                                   Convert.ToString(struFileData.struStopTime.dwMinute) + ":" +
                                   Convert.ToString(struFileData.struStopTime.dwSecond);

                        // Todo: needs file handling and already downloaded checking

                        Console.WriteLine(str1 + " " + str2 + " - " + str3); // Print out found files
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
            }
        }
    }
}