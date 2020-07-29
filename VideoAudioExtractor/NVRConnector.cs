using System;
using NVRCsharpDemo;

namespace VideoAudioExtractor
{
    public class NVRConnector
    {
        // Connection variables
        private string _ipAddress = string.Empty;
        private Int16 _port = 8000;
        private string _username = string.Empty;
        private string _password = string.Empty;

        // Camera variables
        private Int32 i = 0;
        private bool m_bInitSDK = false;
        private uint iLastErr = 0;
        private Int32 m_lUserID = -1;
        private CHCNetSDK.NET_DVR_DEVICEINFO_V30 DeviceInfo;
        private string _errorMsg = string.Empty;
        private uint dwAChanTotalNum = 0;
        private uint dwDChanTotalNum = 0;
        private Int32 m_lPlayHandle = -1;
        private Int32 m_lDownHandle = -1;
        private int[] iChannelNum;
        private Int32 m_lTree = 0;

        // Constructor
        public NVRConnector(string ipAddress, int port, string username, string password)
        {
            _ipAddress = ipAddress;
            _port = (Int16) port;
            _username = username;
            _password = password;

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

            LoginLogoutNvr();
        }


        private void LoginLogoutNvr()
        {
            if (m_lUserID < 0)
            {
                //Login the device
                Console.WriteLine("Login spec: " + _ipAddress + " " + _port + " " + _username + " " + _password);
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
            var str1 = String.Format("Camera {0}", iChanNo);
            var str2 = string.Empty;
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
    }
}