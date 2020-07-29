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
        private uint iLastErr = 0;
        private Int32 m_lUserID = -1;
        private CHCNetSDK.NET_DVR_DEVICEINFO_V30 DeviceInfo;
        private string _errorMsg = string.Empty;
        private uint dwAChanTotalNum = 0;
        private uint dwDChanTotalNum = 0;
        private Int32 m_lPlayHandle = -1;
        private Int32 m_lDownHandle = -1;

        // Constructor
        public NVRConnector(string ipAddress, int port, string username, string password)
        {
            _ipAddress = ipAddress;
            _port = (Int16) port;
            _username = username;
            _password = password;

            LoginNvr();
        }


        private void LoginNvr()
        {
            if (m_lUserID < 0)
            {
                //Login the device
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

                    /*
                    if (dwDChanTotalNum > 0)
                    {
                        InfoIPChannel();
                    }
                    else
                    {
                        for (i = 0; i < dwAChanTotalNum; i++)
                        {
                            ListAnalogChannel(i + 1, 1);
                            iChannelNum[i] = i + (int) DeviceInfo.byStartChan;
                        }

                        Console.WriteLine("This device has no IP channel!");
                    }
                    */
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
                // btnLogin.Text = "Login";
            }

            return;
        }
    }
}