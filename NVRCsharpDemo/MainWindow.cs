using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Runtime.InteropServices;
namespace NVRCsharpDemo
{
    
    public partial class MainWindow : Form
    {
        private bool m_bInitSDK = false;
        private uint iLastErr = 0;
        private Int32 m_lUserID = -1;
        private Int32 m_lFindHandle = -1;
        private Int32 m_lPlayHandle = -1;
        private Int32 m_lDownHandle = -1;
        private string str;
        private string str1;
        private string str2;
        private string str3;
        private string sPlayBackFileName = null;
        private Int32 i = 0;
        private Int32 m_lTree=0;

        private bool m_bPause = false;
        private bool m_bReverse = false;
        private bool m_bSound = false;

        private long iSelIndex = 0;
        private uint dwAChanTotalNum = 0;
        private uint dwDChanTotalNum = 0;
        public CHCNetSDK.NET_DVR_DEVICEINFO_V30 DeviceInfo;
        public CHCNetSDK.NET_DVR_IPPARACFG_V40 m_struIpParaCfgV40;
        public CHCNetSDK.NET_DVR_GET_STREAM_UNION m_unionGetStream;
        public CHCNetSDK.NET_DVR_IPCHANINFO m_struChanInfo;

        [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 96, ArraySubType = UnmanagedType.U4)]
        private int[] iChannelNum;

        public MainWindow()
        {
            InitializeComponent();
            m_bInitSDK = CHCNetSDK.NET_DVR_Init();
            if (m_bInitSDK == false)
            {
                MessageBox.Show("NET_DVR_Init error!");
                return;
            }
            else
            {
                //Save log of SDK
                CHCNetSDK.NET_DVR_SetLogToFile(3,"C:\\SdkLog\\", true);
                iChannelNum = new int[96];
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (textBoxIP.Text == "" || textBoxPort.Text == "" ||
                textBoxUserName.Text == "" || textBoxPassword.Text == "")
            {
                MessageBox.Show("Please input IP, Port, User name and Password!");
                return;
            }
            if (m_lUserID < 0)
            {
                string DVRIPAddress = textBoxIP.Text; //IP or domain of device
                Int16 DVRPortNumber = Int16.Parse(textBoxPort.Text);//Service port of device
                string DVRUserName = textBoxUserName.Text;//Login name of deivce
                string DVRPassword = textBoxPassword.Text;//Login password of device

            //    DeviceInfo = new CHCNetSDK.NET_DVR_DEVICEINFO_V30();

                //Login the device
                m_lUserID = CHCNetSDK.NET_DVR_Login_V30(DVRIPAddress, DVRPortNumber, DVRUserName, DVRPassword, ref DeviceInfo);
                if (m_lUserID < 0)
                {
                    iLastErr = CHCNetSDK.NET_DVR_GetLastError();
                    str1 = "NET_DVR_Login_V30 failed, error code= " + iLastErr; //Login failed,print error code
                    MessageBox.Show(str1);
                    return;
                }
                else
                {
                    //Login successsfully
                    MessageBox.Show("Login Success!");
                    btnLogin.Text = "Logout";

                    dwAChanTotalNum = (uint)DeviceInfo.byChanNum;
                    dwDChanTotalNum = (uint)DeviceInfo.byIPChanNum + 256 * (uint)DeviceInfo.byHighDChanNum;

                    if (dwDChanTotalNum > 0)
                    {
                        InfoIPChannel();
                    }
                    else
                    {
                        for (i = 0; i < dwAChanTotalNum; i++)
                        {
                            ListAnalogChannel(i+1, 1);
                            iChannelNum[i] = i + (int)DeviceInfo.byStartChan;
                        }
                       // MessageBox.Show("This device has no IP channel!");
                    }
                }

            }
            else
            {                
                if (m_lPlayHandle >= 0) 
                {
                    MessageBox.Show("Please stop playback firstly"); //Please stop playback before logout
                    return;
                }

                //Logout the device
                if (!CHCNetSDK.NET_DVR_Logout(m_lUserID))
                {
                    iLastErr = CHCNetSDK.NET_DVR_GetLastError();
                    str1 = "NET_DVR_Logout failed, error code= " + iLastErr;
                    MessageBox.Show(str1);
                    return;
                }
                listViewIPChannel.Items.Clear();//Clear channel list
                m_lUserID = -1;
                btnLogin.Text = "Login";
            }
            return;
        }

        public void InfoIPChannel()
        {
            uint dwSize = (uint)Marshal.SizeOf(m_struIpParaCfgV40);

            IntPtr ptrIpParaCfgV40 = Marshal.AllocHGlobal((Int32)dwSize);
            Marshal.StructureToPtr(m_struIpParaCfgV40, ptrIpParaCfgV40, false);

            uint dwReturn = 0;
            int iGroupNo = 0; //The demo just acquire 64 channels of first group.If ip channels of device is more than 64,you should call NET_DVR_GET_IPPARACFG_V40 times to acquire more according to group 0~i
            if (!CHCNetSDK.NET_DVR_GetDVRConfig(m_lUserID, CHCNetSDK.NET_DVR_GET_IPPARACFG_V40, iGroupNo, ptrIpParaCfgV40, dwSize, ref dwReturn))
            {
                iLastErr = CHCNetSDK.NET_DVR_GetLastError();
                str1 = "NET_DVR_GET_IPPARACFG_V40 failed, error code= " + iLastErr; //Get IP parameter of configuration failed,print error code.
                MessageBox.Show(str1);
            }
            else
            {
                // succ
                m_struIpParaCfgV40 = (CHCNetSDK.NET_DVR_IPPARACFG_V40)Marshal.PtrToStructure(ptrIpParaCfgV40, typeof(CHCNetSDK.NET_DVR_IPPARACFG_V40));
               
                for (i = 0; i < dwAChanTotalNum; i++)
                {
                    ListAnalogChannel(i+1, m_struIpParaCfgV40.byAnalogChanEnable[i]);
                    iChannelNum[i] = i + (int)DeviceInfo.byStartChan;                     
                }
                
                byte byStreamType;
                uint iDChanNum = 64;

                if (dwDChanTotalNum < 64)
                {
                    iDChanNum = dwDChanTotalNum; //If the ip channels of device is less than 64,will get the real channel of device
                }

                for (i = 0; i < iDChanNum; i++)
                {
                    iChannelNum[i + dwAChanTotalNum] = i + (int)m_struIpParaCfgV40.dwStartDChan;

                    byStreamType = m_struIpParaCfgV40.struStreamMode[i].byGetStreamType;
                    m_unionGetStream = m_struIpParaCfgV40.struStreamMode[i].uGetStream;

                    switch (byStreamType)
                    {
                        //At present NVR just support case 0-one way to get stream from device
                        case 0:
                            dwSize = (uint)Marshal.SizeOf(m_unionGetStream);
                            IntPtr ptrChanInfo = Marshal.AllocHGlobal((Int32)dwSize);
                            Marshal.StructureToPtr(m_unionGetStream, ptrChanInfo, false);
                            m_struChanInfo = (CHCNetSDK.NET_DVR_IPCHANINFO)Marshal.PtrToStructure(ptrChanInfo, typeof(CHCNetSDK.NET_DVR_IPCHANINFO));

                            //List ip channels
                            ListIPChannel(i + 1, m_struChanInfo.byEnable, m_struChanInfo.byIPID);
                            Marshal.FreeHGlobal(ptrChanInfo);
                            break;

                        default:
                            break;
                    }
                }
            }
            Marshal.FreeHGlobal(ptrIpParaCfgV40);
        }
        public void ListIPChannel(Int32 iChanNo, byte byOnline, byte byIPID)
        {
            str1 = String.Format("IPCamera {0}", iChanNo);
            m_lTree++;

            if (byIPID == 0)
            {
                str2 = "X"; //The ip channel is empty,no front-end(such as camera)is added               
            }
            else
            { 
                if(byOnline==0)
                {
                    str2 = "offline"; //The channel is offline
                }
                else
                    str2 = "online"; //The channel is online
            }
            
            listViewIPChannel.Items.Add(new ListViewItem(new string[] {str1, str2}));//Add channels to list
        }
        public void ListAnalogChannel(Int32 iChanNo, byte byEnable)
        {
            str1 = String.Format("Camera {0}", iChanNo);
            m_lTree++;

            if (byEnable == 0)
            {
                str2 = "Disabled"; //This channel has been disabled               
            }
            else
            {
                str2 = "Enabled"; //This channel has been enabled  
            }

            listViewIPChannel.Items.Add(new ListViewItem(new string[] { str1, str2 }));//Add channels to list
        }

        private void listViewIPChannel_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            if (listViewIPChannel.SelectedItems.Count > 0) 
            {
                iSelIndex = listViewIPChannel.SelectedItems[0].Index;  //Select the current items
            }
        }

        private void btnBMP_Click(object sender, EventArgs e)
        {
            if (m_lPlayHandle < 0)
            {
                MessageBox.Show("Please start playback firstly!"); //Playback should be started before BMP Snapshot
                return;
            }

            string sBmpPicFileName;
            //the path and file name to save picture
            sBmpPicFileName = "test.bmp";

            //Capture a BMP picture
            if (!CHCNetSDK.NET_DVR_PlayBackCaptureFile(m_lPlayHandle, sBmpPicFileName))
            {
                iLastErr = CHCNetSDK.NET_DVR_GetLastError();
                str = "NET_DVR_PlayBackCaptureFile failed, error code= " + iLastErr;
                MessageBox.Show(str);
                return;
            }
            else
            {
                str = "Successful to capture the BMP file and the saved file is " + sBmpPicFileName;
                MessageBox.Show(str);
            }
            return;
        }
        
        private void btnSearch_Click(object sender, EventArgs e)
        {

            listViewFile.Items.Clear();//Clear item files

            CHCNetSDK.NET_DVR_FILECOND_V40 struFileCond_V40 = new CHCNetSDK.NET_DVR_FILECOND_V40();

            struFileCond_V40.lChannel = iChannelNum[(int)iSelIndex]; //Channel number
            struFileCond_V40.dwFileType = 0xff; //0xff-All，0-Timing record，1-Motion detection，2-Alarm trigger，...
            struFileCond_V40.dwIsLocked = 0xff; //0-unfixed file，1-fixed file，0xff means all files（including fixed and unfixed files）

            //Set the starting time to search video files
            struFileCond_V40.struStartTime.dwYear   = (uint)dateTimeStart.Value.Year;
            struFileCond_V40.struStartTime.dwMonth  = (uint)dateTimeStart.Value.Month;
            struFileCond_V40.struStartTime.dwDay    = (uint)dateTimeStart.Value.Day;
            struFileCond_V40.struStartTime.dwHour   = (uint)dateTimeStart.Value.Hour;
            struFileCond_V40.struStartTime.dwMinute = (uint)dateTimeStart.Value.Minute;
            struFileCond_V40.struStartTime.dwSecond = (uint)dateTimeStart.Value.Second;

            //Set the stopping time to search video files
            struFileCond_V40.struStopTime.dwYear   = (uint)dateTimeEnd.Value.Year;
            struFileCond_V40.struStopTime.dwMonth  = (uint)dateTimeEnd.Value.Month;
            struFileCond_V40.struStopTime.dwDay    = (uint)dateTimeEnd.Value.Day;
            struFileCond_V40.struStopTime.dwHour   = (uint)dateTimeEnd.Value.Hour;
            struFileCond_V40.struStopTime.dwMinute = (uint)dateTimeEnd.Value.Minute;
            struFileCond_V40.struStopTime.dwSecond = (uint)dateTimeEnd.Value.Second;

            //Start to search video files 
            m_lFindHandle = CHCNetSDK.NET_DVR_FindFile_V40(m_lUserID, ref struFileCond_V40);

            if (m_lFindHandle < 0)
            {
                iLastErr = CHCNetSDK.NET_DVR_GetLastError();
                str = "NET_DVR_FindFile_V40 failed, error code= " + iLastErr; //find files failed，print error code
                MessageBox.Show(str);
                return;
            }
            else
            {
                CHCNetSDK.NET_DVR_FINDDATA_V30 struFileData = new CHCNetSDK.NET_DVR_FINDDATA_V30(); ;
                while(true)
                {
                    //Get file information one by one.
                    int result = CHCNetSDK.NET_DVR_FindNextFile_V30(m_lFindHandle, ref struFileData);

                    if (result == CHCNetSDK.NET_DVR_ISFINDING)  //Searching, please wait
                    {
                        continue;
                    }
                    else if (result == CHCNetSDK.NET_DVR_FILE_SUCCESS) //Get the file information successfully
                    {
                        str1 = struFileData.sFileName;

                        str2= Convert.ToString(struFileData.struStartTime.dwYear) + "-" +
                            Convert.ToString(struFileData.struStartTime.dwMonth) + "-" +
                            Convert.ToString(struFileData.struStartTime.dwDay) + " " +
                            Convert.ToString(struFileData.struStartTime.dwHour) + ":" +
                            Convert.ToString(struFileData.struStartTime.dwMinute) + ":" +
                            Convert.ToString(struFileData.struStartTime.dwSecond);

                        str3 = Convert.ToString(struFileData.struStopTime.dwYear) + "-" +
                            Convert.ToString(struFileData.struStopTime.dwMonth) + "-" +
                            Convert.ToString(struFileData.struStopTime.dwDay) + " " +
                            Convert.ToString(struFileData.struStopTime.dwHour) + ":" +
                            Convert.ToString(struFileData.struStopTime.dwMinute) + ":" +
                            Convert.ToString(struFileData.struStopTime.dwSecond);

                        listViewFile.Items.Add(new ListViewItem(new string[] { str1, str2, str3}));//Add the founed files to the list

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

        private void listViewFile_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listViewFile.SelectedItems.Count > 0)
            {
                sPlayBackFileName = listViewFile.FocusedItem.SubItems[0].Text;
            }
        }

        private void btnPlaybackName_Click(object sender, EventArgs e)
        {
            if (sPlayBackFileName==null)
            {
                MessageBox.Show("Please select one file firstly!");//Select playback files first
                return;
            }

            if (m_lPlayHandle >= 0)
            {
                //Please stop playback if playbacking now.
                if (!CHCNetSDK.NET_DVR_StopPlayBack(m_lPlayHandle))
                {
                    iLastErr = CHCNetSDK.NET_DVR_GetLastError();
                    str = "NET_DVR_StopPlayBack failed, error code= " + iLastErr; //Stop playbacking failed,print error code
                    MessageBox.Show(str);
                    return;
                }

                m_bReverse = false;
                btnReverse.Text = "Reverse";
                labelReverse.Text = "Switch to Reverse";

                m_bPause = false;
                btnPause.Text = "||";
                labelPause.Text = "Pause";

                m_lPlayHandle = -1;
                PlaybackprogressBar.Value = 0;
            }

            //Payback by file name
            m_lPlayHandle = CHCNetSDK.NET_DVR_PlayBackByName(m_lUserID, sPlayBackFileName, VideoPlayWnd.Handle);
            if (m_lPlayHandle<0)
            {
                iLastErr = CHCNetSDK.NET_DVR_GetLastError();
                str = "NET_DVR_PlayBackByName failed, error code= " + iLastErr;
                MessageBox.Show(str);
                return;            
            }
           
            uint iOutValue=0;
            if (!CHCNetSDK.NET_DVR_PlayBackControl_V40(m_lPlayHandle, CHCNetSDK.NET_DVR_PLAYSTART, IntPtr.Zero, 0, IntPtr.Zero, ref iOutValue))
            {
                iLastErr = CHCNetSDK.NET_DVR_GetLastError();
                str = "NET_DVR_PLAYSTART failed, error code= " + iLastErr; //Palyback controlling failed,print error code.
                MessageBox.Show(str);
                return;
            }
            timerPlayback.Interval = 1000;
            timerPlayback.Enabled = true;
            btnStopPlayback.Enabled = true;
        }

        private void btnPlaybackTime_Click(object sender, EventArgs e)
        {
            if (m_lPlayHandle >= 0)
            {
                //Please stop playback if playbacking now.
                if (!CHCNetSDK.NET_DVR_StopPlayBack(m_lPlayHandle))
                {
                    iLastErr = CHCNetSDK.NET_DVR_GetLastError();
                    str = "NET_DVR_StopPlayBack failed, error code= " + iLastErr; 
                    MessageBox.Show(str);
                    return;
                }

                m_bReverse = false;
                btnReverse.Text = "Reverse";
                labelReverse.Text = "Switch to Reverse";

                m_bPause = false;
                btnPause.Text = "||";
                labelPause.Text = "Pause"; 

                m_lPlayHandle = -1;

                PlaybackprogressBar.Value = 0;
            }

            CHCNetSDK.NET_DVR_VOD_PARA struVodPara = new CHCNetSDK.NET_DVR_VOD_PARA();
            struVodPara.dwSize = (uint)Marshal.SizeOf(struVodPara);
            struVodPara.struIDInfo.dwChannel = (uint)iChannelNum[(int)iSelIndex]; //Channel number  
            struVodPara.hWnd = VideoPlayWnd.Handle;//handle of playback

            //Set the starting time to search video files
            struVodPara.struBeginTime.dwYear = (uint)dateTimeStart.Value.Year;
            struVodPara.struBeginTime.dwMonth = (uint)dateTimeStart.Value.Month;
            struVodPara.struBeginTime.dwDay = (uint)dateTimeStart.Value.Day;
            struVodPara.struBeginTime.dwHour = (uint)dateTimeStart.Value.Hour;
            struVodPara.struBeginTime.dwMinute = (uint)dateTimeStart.Value.Minute;
            struVodPara.struBeginTime.dwSecond = (uint)dateTimeStart.Value.Second;

            //Set the stopping time to search video files
            struVodPara.struEndTime.dwYear = (uint)dateTimeEnd.Value.Year;
            struVodPara.struEndTime.dwMonth = (uint)dateTimeEnd.Value.Month;
            struVodPara.struEndTime.dwDay = (uint)dateTimeEnd.Value.Day;
            struVodPara.struEndTime.dwHour = (uint)dateTimeEnd.Value.Hour;
            struVodPara.struEndTime.dwMinute = (uint)dateTimeEnd.Value.Minute;
            struVodPara.struEndTime.dwSecond = (uint)dateTimeEnd.Value.Second;

            //Playback by time
            m_lPlayHandle = CHCNetSDK.NET_DVR_PlayBackByTime_V40(m_lUserID, ref struVodPara);
            if (m_lPlayHandle < 0)
            {
                iLastErr = CHCNetSDK.NET_DVR_GetLastError();
                str = "NET_DVR_PlayBackByTime_V40 failed, error code= " + iLastErr;
                MessageBox.Show(str);
                return;
            }

            uint iOutValue = 0;
            if (!CHCNetSDK.NET_DVR_PlayBackControl_V40(m_lPlayHandle, CHCNetSDK.NET_DVR_PLAYSTART, IntPtr.Zero, 0, IntPtr.Zero, ref iOutValue))
            {
                iLastErr = CHCNetSDK.NET_DVR_GetLastError();
                str = "NET_DVR_PLAYSTART failed, error code= " + iLastErr; //Playback controlling failed,print error code.
                MessageBox.Show(str);
                return;
            }
            timerPlayback.Interval = 1000;
            timerPlayback.Enabled = true;
            btnStopPlayback.Enabled = true;
        }

        private void btnStopPlayback_Click(object sender, EventArgs e)
        {
            if (m_lPlayHandle < 0)
            {
                return;
            }

            //Stop playback
            if (!CHCNetSDK.NET_DVR_StopPlayBack(m_lPlayHandle))
            {
                iLastErr = CHCNetSDK.NET_DVR_GetLastError();
                str = "NET_DVR_StopPlayBack failed, error code= " + iLastErr;
                MessageBox.Show(str);
                return;
            }

            PlaybackprogressBar.Value = 0;
            timerPlayback.Stop();
            
            m_bReverse = false;
            btnReverse.Text = "Reverse";
            labelReverse.Text = "Switch to Reverse";
            
            m_bPause = false;
            btnPause.Text = "||";
            labelPause.Text = "Pause";
            
            m_lPlayHandle = -1;
            VideoPlayWnd.Invalidate();//Refresh window
            btnStopPlayback.Enabled = false;
        }

        private void btnPause_Click(object sender, EventArgs e)
        {
            uint iOutValue = 0;

            if (!m_bPause)
            {
                if (!CHCNetSDK.NET_DVR_PlayBackControl_V40(m_lPlayHandle, CHCNetSDK.NET_DVR_PLAYPAUSE, IntPtr.Zero, 0, IntPtr.Zero, ref iOutValue))
                {
                    iLastErr = CHCNetSDK.NET_DVR_GetLastError();
                    str = "NET_DVR_PLAYPAUSE failed, error code= " + iLastErr; //Playback controlling failed,print error code
                    MessageBox.Show(str);
                    return;
                }
                m_bPause = true;
                btnPause.Text = ">";
                labelPause.Text = "Play";
            }
            else
            {
                if (!CHCNetSDK.NET_DVR_PlayBackControl_V40(m_lPlayHandle, CHCNetSDK.NET_DVR_PLAYRESTART, IntPtr.Zero, 0, IntPtr.Zero, ref iOutValue))
                {
                    iLastErr = CHCNetSDK.NET_DVR_GetLastError();
                    str = "NET_DVR_PLAYRESTART failed, error code= " + iLastErr; //Playback controlling failed,print error code
                    MessageBox.Show(str);
                    return;
                }
                m_bPause = false;
                btnPause.Text = "||";
                labelPause.Text = "Pause";
            }
            return;
        }

        private void btnSlow_Click(object sender, EventArgs e)
        {
            uint iOutValue = 0;

            if (!CHCNetSDK.NET_DVR_PlayBackControl_V40(m_lPlayHandle, CHCNetSDK.NET_DVR_PLAYSLOW, IntPtr.Zero, 0, IntPtr.Zero, ref iOutValue))
            {
                iLastErr = CHCNetSDK.NET_DVR_GetLastError();
                str = "NET_DVR_PLAYSLOW failed, error code= " + iLastErr; //Playback controlling failed,print error code
                MessageBox.Show(str);
                return;
            }
        }

        private void btnFast_Click(object sender, EventArgs e)
        {
            uint iOutValue = 0;

            if (!CHCNetSDK.NET_DVR_PlayBackControl_V40(m_lPlayHandle, CHCNetSDK.NET_DVR_PLAYFAST, IntPtr.Zero, 0, IntPtr.Zero, ref iOutValue))
            {
                iLastErr = CHCNetSDK.NET_DVR_GetLastError();
                str = "NET_DVR_PLAYFAST failed, error code= " + iLastErr; //Playback controlling failed,print error code
                MessageBox.Show(str);
                return;
            }
        }

        private void btnFrame_Click(object sender, EventArgs e)
        {
            uint iOutValue = 0;

            if (!CHCNetSDK.NET_DVR_PlayBackControl_V40(m_lPlayHandle, CHCNetSDK.NET_DVR_PLAYFRAME, IntPtr.Zero, 0, IntPtr.Zero, ref iOutValue))
            {
                iLastErr = CHCNetSDK.NET_DVR_GetLastError();
                str = "NET_DVR_PLAYFRAME failed, error code= " + iLastErr; //Playback controlling failed,print error code
                MessageBox.Show(str);
                return;
            }
        }

        private void btnResume_Click(object sender, EventArgs e)
        {
            uint iOutValue = 0;

            if (!CHCNetSDK.NET_DVR_PlayBackControl_V40(m_lPlayHandle, CHCNetSDK.NET_DVR_PLAYNORMAL, IntPtr.Zero, 0, IntPtr.Zero, ref iOutValue))
            {
                iLastErr = CHCNetSDK.NET_DVR_GetLastError();
                str = "NET_DVR_PLAYNORMAL failed, error code= " + iLastErr; //Playback controlling failed,print error code
                MessageBox.Show(str);
                return;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            uint iOutValue = 0;
            if (!m_bReverse)
            {
                if (!CHCNetSDK.NET_DVR_PlayBackControl_V40(m_lPlayHandle, CHCNetSDK.NET_DVR_PLAY_REVERSE, IntPtr.Zero, 0, IntPtr.Zero, ref iOutValue))
                {
                    iLastErr = CHCNetSDK.NET_DVR_GetLastError();
                    str = "NET_DVR_PLAY_REVERSE failed, error code= " + iLastErr; //Playback controlling failed,print error code
                    MessageBox.Show(str);
                    return;
                }
                m_bReverse = true;
                btnReverse.Text = "Forward";
                labelReverse.Text = "Switch to Forward";
            }
            else
            {
                if (!CHCNetSDK.NET_DVR_PlayBackControl_V40(m_lPlayHandle, CHCNetSDK.NET_DVR_PLAY_FORWARD, IntPtr.Zero, 0, IntPtr.Zero, ref iOutValue))
                {
                    iLastErr = CHCNetSDK.NET_DVR_GetLastError();
                    str = "NET_DVR_PLAY_FORWARD failed, error code= " + iLastErr; //Playback controlling failed,print error code
                    MessageBox.Show(str);
                    return;
                }
                m_bReverse = false;
                btnReverse.Text = "Reverse";
                labelReverse.Text = "Switch to Reverse";       
            }

        }

        private void btnDownloadTime_Click(object sender, EventArgs e)
        {
            if (m_lDownHandle >= 0)
            {
                MessageBox.Show("Downloading, please stop firstly!");//Please stop downloading
                return;
            }

            CHCNetSDK.NET_DVR_PLAYCOND struDownPara = new CHCNetSDK.NET_DVR_PLAYCOND();
            struDownPara.dwChannel = (uint)iChannelNum[(int)iSelIndex]; //Channel number  

            //Set the starting time
            struDownPara.struStartTime.dwYear = (uint)dateTimeStart.Value.Year;
            struDownPara.struStartTime.dwMonth = (uint)dateTimeStart.Value.Month;
            struDownPara.struStartTime.dwDay = (uint)dateTimeStart.Value.Day;
            struDownPara.struStartTime.dwHour = (uint)dateTimeStart.Value.Hour;
            struDownPara.struStartTime.dwMinute = (uint)dateTimeStart.Value.Minute;
            struDownPara.struStartTime.dwSecond = (uint)dateTimeStart.Value.Second;

            //Set the stopping time
            struDownPara.struStopTime.dwYear = (uint)dateTimeEnd.Value.Year;
            struDownPara.struStopTime.dwMonth = (uint)dateTimeEnd.Value.Month;
            struDownPara.struStopTime.dwDay = (uint)dateTimeEnd.Value.Day;
            struDownPara.struStopTime.dwHour = (uint)dateTimeEnd.Value.Hour;
            struDownPara.struStopTime.dwMinute = (uint)dateTimeEnd.Value.Minute;
            struDownPara.struStopTime.dwSecond = (uint)dateTimeEnd.Value.Second;

            string sVideoFileName;  //the path and file name to save      
            sVideoFileName = "D:\\Downtest_Channel"+struDownPara.dwChannel+".mp4";

            //Download by time
            m_lDownHandle = CHCNetSDK.NET_DVR_GetFileByTime_V40(m_lUserID, sVideoFileName, ref struDownPara);
            if (m_lDownHandle < 0)
            {
                iLastErr = CHCNetSDK.NET_DVR_GetLastError();
                str = "NET_DVR_GetFileByTime_V40 failed, error code= " + iLastErr;
                MessageBox.Show(str);
                return;
            }

            uint iOutValue = 0;
            if (!CHCNetSDK.NET_DVR_PlayBackControl_V40(m_lDownHandle, CHCNetSDK.NET_DVR_PLAYSTART, IntPtr.Zero, 0, IntPtr.Zero, ref iOutValue))
            {
                iLastErr = CHCNetSDK.NET_DVR_GetLastError();
                str = "NET_DVR_PLAYSTART failed, error code= " + iLastErr; //Download controlling failed,print error code
                MessageBox.Show(str);
                return;
            }

            timerDownload.Interval = 1000;
            timerDownload.Enabled = true;
            btnStopDownload.Enabled = true;
        }

        private void btnDownloadName_Click(object sender, EventArgs e)
        {
            if (m_lDownHandle >= 0)
            {
                MessageBox.Show("Downloading, please stop firstly!");//Please stop downloading
                return;
            }

            string sVideoFileName;  //the path and file name to save      
            sVideoFileName = "Downtest_"+sPlayBackFileName+".mp4";

            //Download by file name
            m_lDownHandle = CHCNetSDK.NET_DVR_GetFileByName(m_lUserID, sPlayBackFileName, sVideoFileName);
            if (m_lDownHandle < 0)
            {
                iLastErr = CHCNetSDK.NET_DVR_GetLastError();
                str = "NET_DVR_GetFileByName failed, error code= " + iLastErr;
                MessageBox.Show(str);
                return;
            }

            uint iOutValue = 0;

            //Set format of transfer package.
            //UInt32 iInValue = 5;
            //IntPtr lpInValue = Marshal.AllocHGlobal(4);
            //Marshal.StructureToPtr(iInValue, lpInValue, false);

            //if (!CHCNetSDK.NET_DVR_PlayBackControl_V40(m_lDownHandle, CHCNetSDK.NET_DVR_SET_TRANS_TYPE, lpInValue, 4, IntPtr.Zero, ref iOutValue))
            //{
            //    iLastErr = CHCNetSDK.NET_DVR_GetLastError();
            //    str = "NET_DVR_PLAYSTART failed, error code= " + iLastErr; //Download controlling failed,print error code
            //    MessageBox.Show(str);
            //    return;
            //}

            if (!CHCNetSDK.NET_DVR_PlayBackControl_V40(m_lDownHandle, CHCNetSDK.NET_DVR_PLAYSTART, IntPtr.Zero, 0, IntPtr.Zero, ref iOutValue))
            {
                iLastErr = CHCNetSDK.NET_DVR_GetLastError();
                str = "NET_DVR_PLAYSTART failed, error code= " + iLastErr; //Download controlling failed,print error code
                MessageBox.Show(str);
                return;
            }
            timerDownload.Interval = 1000;
            timerDownload.Enabled = true;
            btnStopDownload.Enabled = true;
        }

        private void btnStopDownload_Click(object sender, EventArgs e)
        {
            if(m_lDownHandle<0)
            {
                return;            
            }

            if (!CHCNetSDK.NET_DVR_StopGetFile(m_lDownHandle))
            {
                iLastErr = CHCNetSDK.NET_DVR_GetLastError();
                str = "NET_DVR_StopGetFile failed, error code= " + iLastErr; //Download controlling failed,print error code
                MessageBox.Show(str);
                return;
            }

            timerDownload.Stop(); 

            MessageBox.Show("The downloading has been stopped succesfully!");
            m_lDownHandle = -1;
            DownloadProgressBar.Value = 0;
            btnStopDownload.Enabled = true;
        }

        private void timerProgress_Tick(object sender, EventArgs e)
        {
            DownloadProgressBar.Maximum = 100;
            DownloadProgressBar.Minimum = 0;

            int iPos = 0;

            //Get downloading process
            iPos = CHCNetSDK.NET_DVR_GetDownloadPos(m_lDownHandle);

            if ((iPos > DownloadProgressBar.Minimum) && (iPos < DownloadProgressBar.Maximum))
            {
                DownloadProgressBar.Value = iPos;            
            }

            if (iPos == 100)  //Finish downloading
            {
                DownloadProgressBar.Value = iPos;
                if (!CHCNetSDK.NET_DVR_StopGetFile(m_lDownHandle))
                {
                    iLastErr = CHCNetSDK.NET_DVR_GetLastError();
                    str = "NET_DVR_StopGetFile failed, error code= " + iLastErr; //Download controlling failed,print error code
                    MessageBox.Show(str);
                    return;
                }
                m_lDownHandle = -1;
                timerDownload.Stop(); 
            }

            if (iPos == 200) //Network abnormal,download failed
            {
                MessageBox.Show("The downloading is abnormal for the abnormal network!");
                timerDownload.Stop();
            }
        }

        private void timerPlayback_Tick(object sender, EventArgs e)
        {
            PlaybackprogressBar.Maximum = 100;
            PlaybackprogressBar.Minimum = 0;

            uint iOutValue = 0;
            int iPos = 0;

            IntPtr lpOutBuffer = Marshal.AllocHGlobal(4);

            //get playback process
            CHCNetSDK.NET_DVR_PlayBackControl_V40(m_lPlayHandle, CHCNetSDK.NET_DVR_PLAYGETPOS, IntPtr.Zero, 0, lpOutBuffer, ref iOutValue);

            iPos = (int)Marshal.PtrToStructure(lpOutBuffer, typeof(int));

            if ((iPos > PlaybackprogressBar.Minimum) && (iPos < PlaybackprogressBar.Maximum))
            {
                PlaybackprogressBar.Value = iPos;
            }

            if (iPos == 100)  //Playback finished
            {
                PlaybackprogressBar.Value = iPos;
                if (!CHCNetSDK.NET_DVR_StopPlayBack(m_lPlayHandle))
                {
                    iLastErr = CHCNetSDK.NET_DVR_GetLastError();
                    str = "NET_DVR_StopPlayBack failed, error code= " + iLastErr; //Download controlling failed,print error code
                    MessageBox.Show(str);
                    return;
                }
                m_lPlayHandle = -1;
                timerPlayback.Stop();
            }

            if (iPos == 200) //Network abnormal,playback failed
            {
                MessageBox.Show("The playback is abnormal for the abnormal network!");
                timerPlayback.Stop();
            }
            Marshal.FreeHGlobal(lpOutBuffer);
        }

        private void MainWindow_Load(object sender, EventArgs e)
        {
            //Initialize time
            dateTimeStart.Text = DateTime.Now.ToShortDateString();
            dateTimeEnd.Text = DateTime.Now.ToString();
        }

        private void btn_Exit_Click(object sender, EventArgs e)
        {
            //Stop playback
            if (m_lPlayHandle >= 0)
            {
                CHCNetSDK.NET_DVR_StopPlayBack(m_lPlayHandle);
                m_lPlayHandle = -1;
            }

            //Stop download
            if (m_lDownHandle >= 0)
            {
                CHCNetSDK.NET_DVR_StopGetFile(m_lDownHandle);
                m_lDownHandle = -1;            
            }

            //Logout the device
            if (m_lUserID >= 0)
            {
                CHCNetSDK.NET_DVR_Logout(m_lUserID);
                m_lUserID = -1;
            }

            Application.Exit();
        }

        private void btnSound_Click(object sender, EventArgs e)
        {
            uint iOutValue = 0;
            if (!m_bSound)
            {
                if (!CHCNetSDK.NET_DVR_PlayBackControl_V40(m_lPlayHandle, CHCNetSDK.NET_DVR_PLAYSTARTAUDIO, IntPtr.Zero, 0, IntPtr.Zero, ref iOutValue))
                {
                    iLastErr = CHCNetSDK.NET_DVR_GetLastError();
                    str = "NET_DVR_PLAYSTARTAUDIO failed, error code= " + iLastErr; //Playback controlling failed,print error code
                    MessageBox.Show(str);
                    return;
                }
                m_bSound = true;
                btnSound.Text = "Stop";
                labelSound.Text = "Close Audio";
            }
            else
            {
                if (!CHCNetSDK.NET_DVR_PlayBackControl_V40(m_lPlayHandle, CHCNetSDK.NET_DVR_PLAYSTOPAUDIO, IntPtr.Zero, 0, IntPtr.Zero, ref iOutValue))
                {
                    iLastErr = CHCNetSDK.NET_DVR_GetLastError();
                    str = "NET_DVR_PLAYSTOPAUDIO failed, error code= " + iLastErr; //Playback controlling failed,print error code
                    MessageBox.Show(str);
                    return;
                }
                m_bSound = false;
                btnSound.Text = "Sound";
                labelSound.Text = "Open Audio";
            }
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void groupBox4_Enter(object sender, EventArgs e)
        {

        }

        private void listViewIPChannel_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
