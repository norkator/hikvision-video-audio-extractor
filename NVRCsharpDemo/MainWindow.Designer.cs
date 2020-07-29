namespace NVRCsharpDemo
{
    partial class MainWindow
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (m_lPlayHandle >= 0)
            {
                CHCNetSDK.NET_DVR_StopPlayBack(m_lPlayHandle);
            }
            if (m_lDownHandle >= 0)
            {
                CHCNetSDK.NET_DVR_StopGetFile(m_lDownHandle);

            }
            if (m_lUserID >= 0)
            {
                CHCNetSDK.NET_DVR_Logout(m_lUserID);
            }
            if (m_bInitSDK == true)
            {
                CHCNetSDK.NET_DVR_Cleanup();
            }

            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.textBoxPassword = new System.Windows.Forms.TextBox();
            this.textBoxUserName = new System.Windows.Forms.TextBox();
            this.textBoxPort = new System.Windows.Forms.TextBox();
            this.textBoxIP = new System.Windows.Forms.TextBox();
            this.btnLogin = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.VideoPlayWnd = new System.Windows.Forms.PictureBox();
            this.listViewIPChannel = new System.Windows.Forms.ListView();
            this.ColumnHeader1 = new System.Windows.Forms.ColumnHeader();
            this.ColumnHeader2 = new System.Windows.Forms.ColumnHeader();
            this.label13 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.labelSound = new System.Windows.Forms.Label();
            this.btnSound = new System.Windows.Forms.Button();
            this.btnResume = new System.Windows.Forms.Button();
            this.labelReverse = new System.Windows.Forms.Label();
            this.btnReverse = new System.Windows.Forms.Button();
            this.label23 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.labelPause = new System.Windows.Forms.Label();
            this.btnFrame = new System.Windows.Forms.Button();
            this.btnFast = new System.Windows.Forms.Button();
            this.btnSlow = new System.Windows.Forms.Button();
            this.btnPause = new System.Windows.Forms.Button();
            this.label14 = new System.Windows.Forms.Label();
            this.btnBMP = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dateTimeStart = new System.Windows.Forms.DateTimePicker();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.DownloadProgressBar = new System.Windows.Forms.ProgressBar();
            this.btnStopDownload = new System.Windows.Forms.Button();
            this.btnDownloadName = new System.Windows.Forms.Button();
            this.btnDownloadTime = new System.Windows.Forms.Button();
            this.label22 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.btnPlaybackTime = new System.Windows.Forms.Button();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.btnStopPlayback = new System.Windows.Forms.Button();
            this.btnPlaybackName = new System.Windows.Forms.Button();
            this.listViewFile = new System.Windows.Forms.ListView();
            this.columnHeader3 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader4 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader5 = new System.Windows.Forms.ColumnHeader();
            this.btnSearch = new System.Windows.Forms.Button();
            this.label17 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.dateTimeEnd = new System.Windows.Forms.DateTimePicker();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.groupBox8 = new System.Windows.Forms.GroupBox();
            this.timerDownload = new System.Windows.Forms.Timer(this.components);
            this.PlaybackprogressBar = new System.Windows.Forms.ProgressBar();
            this.timerPlayback = new System.Windows.Forms.Timer(this.components);
            this.btn_Exit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize) (this.VideoPlayWnd)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBoxPassword.Location = new System.Drawing.Point(385, 81);
            this.textBoxPassword.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.PasswordChar = '*';
            this.textBoxPassword.Size = new System.Drawing.Size(130, 23);
            this.textBoxPassword.TabIndex = 23;
            this.textBoxPassword.Text = "12345";
            // 
            // textBoxUserName
            // 
            this.textBoxUserName.Location = new System.Drawing.Point(102, 81);
            this.textBoxUserName.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.textBoxUserName.Name = "textBoxUserName";
            this.textBoxUserName.Size = new System.Drawing.Size(132, 23);
            this.textBoxUserName.TabIndex = 22;
            this.textBoxUserName.Text = "admin";
            // 
            // textBoxPort
            // 
            this.textBoxPort.Location = new System.Drawing.Point(385, 24);
            this.textBoxPort.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.textBoxPort.Name = "textBoxPort";
            this.textBoxPort.Size = new System.Drawing.Size(130, 23);
            this.textBoxPort.TabIndex = 21;
            this.textBoxPort.Text = "8000";
            // 
            // textBoxIP
            // 
            this.textBoxIP.Location = new System.Drawing.Point(102, 24);
            this.textBoxIP.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.textBoxIP.Name = "textBoxIP";
            this.textBoxIP.Size = new System.Drawing.Size(132, 23);
            this.textBoxIP.TabIndex = 20;
            this.textBoxIP.Text = "172.6.22.19";
            // 
            // btnLogin
            // 
            this.btnLogin.Location = new System.Drawing.Point(558, 31);
            this.btnLogin.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(91, 62);
            this.btnLogin.TabIndex = 19;
            this.btnLogin.Text = "Login";
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(24, 12);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 23);
            this.label1.TabIndex = 16;
            this.label1.Text = "Device IP";
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(24, 68);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 20);
            this.label2.TabIndex = 15;
            this.label2.Text = "User Name";
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(299, 66);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 20);
            this.label3.TabIndex = 18;
            this.label3.Text = "Password";
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(299, 12);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 21);
            this.label4.TabIndex = 17;
            this.label4.Text = "Device Port";
            // 
            // VideoPlayWnd
            // 
            this.VideoPlayWnd.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.VideoPlayWnd.Location = new System.Drawing.Point(215, 129);
            this.VideoPlayWnd.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.VideoPlayWnd.Name = "VideoPlayWnd";
            this.VideoPlayWnd.Size = new System.Drawing.Size(513, 457);
            this.VideoPlayWnd.TabIndex = 30;
            this.VideoPlayWnd.TabStop = false;
            // 
            // listViewIPChannel
            // 
            this.listViewIPChannel.Columns.AddRange(new System.Windows.Forms.ColumnHeader[]
                {this.ColumnHeader1, this.ColumnHeader2});
            this.listViewIPChannel.FullRowSelect = true;
            this.listViewIPChannel.GridLines = true;
            this.listViewIPChannel.Location = new System.Drawing.Point(5, 129);
            this.listViewIPChannel.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.listViewIPChannel.MultiSelect = false;
            this.listViewIPChannel.Name = "listViewIPChannel";
            this.listViewIPChannel.Size = new System.Drawing.Size(202, 469);
            this.listViewIPChannel.TabIndex = 32;
            this.listViewIPChannel.UseCompatibleStateImageBehavior = false;
            this.listViewIPChannel.View = System.Windows.Forms.View.Details;
            this.listViewIPChannel.ItemSelectionChanged +=
                new System.Windows.Forms.ListViewItemSelectionChangedEventHandler(this
                    .listViewIPChannel_ItemSelectionChanged);
            this.listViewIPChannel.SelectedIndexChanged +=
                new System.EventHandler(this.listViewIPChannel_SelectedIndexChanged);
            // 
            // ColumnHeader1
            // 
            this.ColumnHeader1.Text = "Channel";
            this.ColumnHeader1.Width = 90;
            // 
            // ColumnHeader2
            // 
            this.ColumnHeader2.Text = "Status";
            this.ColumnHeader2.Width = 90;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(9, 614);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(153, 15);
            this.label13.TabIndex = 37;
            this.label13.Text = "* DEMO just for reference！";
            // 
            // groupBox1
            // 
            this.groupBox1.Location = new System.Drawing.Point(6, 598);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox1.Size = new System.Drawing.Size(202, 150);
            this.groupBox1.TabIndex = 39;
            this.groupBox1.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.labelSound);
            this.groupBox2.Controls.Add(this.btnSound);
            this.groupBox2.Controls.Add(this.btnResume);
            this.groupBox2.Controls.Add(this.labelReverse);
            this.groupBox2.Controls.Add(this.btnReverse);
            this.groupBox2.Controls.Add(this.label23);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.labelPause);
            this.groupBox2.Controls.Add(this.btnFrame);
            this.groupBox2.Controls.Add(this.btnFast);
            this.groupBox2.Controls.Add(this.btnSlow);
            this.groupBox2.Controls.Add(this.btnPause);
            this.groupBox2.Controls.Add(this.label14);
            this.groupBox2.Controls.Add(this.btnBMP);
            this.groupBox2.Location = new System.Drawing.Point(215, 598);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox2.Size = new System.Drawing.Size(513, 150);
            this.groupBox2.TabIndex = 40;
            this.groupBox2.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(168, 61);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(82, 15);
            this.label5.TabIndex = 53;
            this.label5.Text = "Normal Speed";
            // 
            // labelSound
            // 
            this.labelSound.AutoSize = true;
            this.labelSound.Location = new System.Drawing.Point(15, 123);
            this.labelSound.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelSound.Name = "labelSound";
            this.labelSound.Size = new System.Drawing.Size(71, 15);
            this.labelSound.TabIndex = 52;
            this.labelSound.Text = "Open Audio";
            // 
            // btnSound
            // 
            this.btnSound.Location = new System.Drawing.Point(8, 89);
            this.btnSound.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnSound.Name = "btnSound";
            this.btnSound.Size = new System.Drawing.Size(88, 29);
            this.btnSound.TabIndex = 51;
            this.btnSound.Text = "Sound";
            this.btnSound.UseVisualStyleBackColor = true;
            this.btnSound.Click += new System.EventHandler(this.btnSound_Click);
            // 
            // btnResume
            // 
            this.btnResume.Location = new System.Drawing.Point(163, 23);
            this.btnResume.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnResume.Name = "btnResume";
            this.btnResume.Size = new System.Drawing.Size(99, 29);
            this.btnResume.TabIndex = 49;
            this.btnResume.Text = "Normal Speed";
            this.btnResume.UseVisualStyleBackColor = true;
            this.btnResume.Click += new System.EventHandler(this.btnResume_Click);
            // 
            // labelReverse
            // 
            this.labelReverse.AutoSize = true;
            this.labelReverse.Location = new System.Drawing.Point(355, 61);
            this.labelReverse.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelReverse.Name = "labelReverse";
            this.labelReverse.Size = new System.Drawing.Size(47, 15);
            this.labelReverse.TabIndex = 48;
            this.labelReverse.Text = "Reserve";
            // 
            // btnReverse
            // 
            this.btnReverse.Location = new System.Drawing.Point(335, 23);
            this.btnReverse.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnReverse.Name = "btnReverse";
            this.btnReverse.Size = new System.Drawing.Size(88, 29);
            this.btnReverse.TabIndex = 47;
            this.btnReverse.Text = "Reverse";
            this.btnReverse.UseVisualStyleBackColor = true;
            this.btnReverse.Click += new System.EventHandler(this.button1_Click);
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(265, 61);
            this.label23.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(68, 15);
            this.label23.TabIndex = 46;
            this.label23.Text = "Sigle Frame";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(114, 61);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(28, 15);
            this.label11.TabIndex = 45;
            this.label11.Text = "Fast";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(63, 61);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(32, 15);
            this.label9.TabIndex = 44;
            this.label9.Text = "Slow";
            // 
            // labelPause
            // 
            this.labelPause.AutoSize = true;
            this.labelPause.Location = new System.Drawing.Point(13, 61);
            this.labelPause.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelPause.Name = "labelPause";
            this.labelPause.Size = new System.Drawing.Size(38, 15);
            this.labelPause.TabIndex = 43;
            this.labelPause.Text = "Pause";
            // 
            // btnFrame
            // 
            this.btnFrame.Location = new System.Drawing.Point(270, 23);
            this.btnFrame.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnFrame.Name = "btnFrame";
            this.btnFrame.Size = new System.Drawing.Size(58, 29);
            this.btnFrame.TabIndex = 42;
            this.btnFrame.Text = "|>";
            this.btnFrame.UseVisualStyleBackColor = true;
            this.btnFrame.Click += new System.EventHandler(this.btnFrame_Click);
            // 
            // btnFast
            // 
            this.btnFast.Location = new System.Drawing.Point(108, 23);
            this.btnFast.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnFast.Name = "btnFast";
            this.btnFast.Size = new System.Drawing.Size(48, 29);
            this.btnFast.TabIndex = 41;
            this.btnFast.Text = ">>";
            this.btnFast.UseVisualStyleBackColor = true;
            this.btnFast.Click += new System.EventHandler(this.btnFast_Click);
            // 
            // btnSlow
            // 
            this.btnSlow.Location = new System.Drawing.Point(56, 23);
            this.btnSlow.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnSlow.Name = "btnSlow";
            this.btnSlow.Size = new System.Drawing.Size(48, 29);
            this.btnSlow.TabIndex = 40;
            this.btnSlow.Text = "<<";
            this.btnSlow.UseVisualStyleBackColor = true;
            this.btnSlow.Click += new System.EventHandler(this.btnSlow_Click);
            // 
            // btnPause
            // 
            this.btnPause.Location = new System.Drawing.Point(8, 23);
            this.btnPause.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnPause.Name = "btnPause";
            this.btnPause.Size = new System.Drawing.Size(43, 29);
            this.btnPause.TabIndex = 39;
            this.btnPause.Text = "||";
            this.btnPause.UseVisualStyleBackColor = true;
            this.btnPause.Click += new System.EventHandler(this.btnPause_Click);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(114, 123);
            this.label14.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(85, 15);
            this.label14.TabIndex = 38;
            this.label14.Text = "BMP SnapShot";
            // 
            // btnBMP
            // 
            this.btnBMP.Location = new System.Drawing.Point(117, 89);
            this.btnBMP.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnBMP.Name = "btnBMP";
            this.btnBMP.Size = new System.Drawing.Size(65, 29);
            this.btnBMP.TabIndex = 36;
            this.btnBMP.Text = "BMP";
            this.btnBMP.UseVisualStyleBackColor = true;
            this.btnBMP.Click += new System.EventHandler(this.btnBMP_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Location = new System.Drawing.Point(5, -1);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox3.Size = new System.Drawing.Size(723, 121);
            this.groupBox3.TabIndex = 41;
            this.groupBox3.TabStop = false;
            // 
            // dateTimeStart
            // 
            this.dateTimeStart.CustomFormat = "yyyy-MM-dd HH:mm:ss";
            this.dateTimeStart.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimeStart.Location = new System.Drawing.Point(118, 32);
            this.dateTimeStart.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.dateTimeStart.Name = "dateTimeStart";
            this.dateTimeStart.Size = new System.Drawing.Size(184, 23);
            this.dateTimeStart.TabIndex = 42;
            this.dateTimeStart.UseWaitCursor = true;
            this.dateTimeStart.Value = new System.DateTime(2014, 2, 28, 14, 43, 28, 0);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.DownloadProgressBar);
            this.groupBox4.Controls.Add(this.btnStopDownload);
            this.groupBox4.Controls.Add(this.btnDownloadName);
            this.groupBox4.Controls.Add(this.btnDownloadTime);
            this.groupBox4.Controls.Add(this.label22);
            this.groupBox4.Controls.Add(this.label19);
            this.groupBox4.Controls.Add(this.label20);
            this.groupBox4.Controls.Add(this.label21);
            this.groupBox4.Controls.Add(this.btnPlaybackTime);
            this.groupBox4.Controls.Add(this.groupBox6);
            this.groupBox4.Controls.Add(this.groupBox5);
            this.groupBox4.Controls.Add(this.btnStopPlayback);
            this.groupBox4.Controls.Add(this.btnPlaybackName);
            this.groupBox4.Controls.Add(this.listViewFile);
            this.groupBox4.Controls.Add(this.btnSearch);
            this.groupBox4.Controls.Add(this.label17);
            this.groupBox4.Controls.Add(this.label16);
            this.groupBox4.Controls.Add(this.dateTimeEnd);
            this.groupBox4.Controls.Add(this.dateTimeStart);
            this.groupBox4.Controls.Add(this.groupBox7);
            this.groupBox4.Controls.Add(this.groupBox8);
            this.groupBox4.Location = new System.Drawing.Point(735, -1);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox4.Size = new System.Drawing.Size(345, 749);
            this.groupBox4.TabIndex = 42;
            this.groupBox4.TabStop = false;
            this.groupBox4.Enter += new System.EventHandler(this.groupBox4_Enter);
            // 
            // DownloadProgressBar
            // 
            this.DownloadProgressBar.Location = new System.Drawing.Point(5, 660);
            this.DownloadProgressBar.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.DownloadProgressBar.Name = "DownloadProgressBar";
            this.DownloadProgressBar.Size = new System.Drawing.Size(330, 13);
            this.DownloadProgressBar.TabIndex = 61;
            // 
            // btnStopDownload
            // 
            this.btnStopDownload.Enabled = false;
            this.btnStopDownload.Location = new System.Drawing.Point(188, 602);
            this.btnStopDownload.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnStopDownload.Name = "btnStopDownload";
            this.btnStopDownload.Size = new System.Drawing.Size(147, 40);
            this.btnStopDownload.TabIndex = 60;
            this.btnStopDownload.Text = "Stop Download";
            this.btnStopDownload.UseVisualStyleBackColor = true;
            this.btnStopDownload.Click += new System.EventHandler(this.btnStopDownload_Click);
            // 
            // btnDownloadName
            // 
            this.btnDownloadName.Location = new System.Drawing.Point(188, 513);
            this.btnDownloadName.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnDownloadName.Name = "btnDownloadName";
            this.btnDownloadName.Size = new System.Drawing.Size(147, 40);
            this.btnDownloadName.TabIndex = 59;
            this.btnDownloadName.Text = "Download By Name";
            this.btnDownloadName.UseVisualStyleBackColor = true;
            this.btnDownloadName.Click += new System.EventHandler(this.btnDownloadName_Click);
            // 
            // btnDownloadTime
            // 
            this.btnDownloadTime.Location = new System.Drawing.Point(188, 156);
            this.btnDownloadTime.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnDownloadTime.Name = "btnDownloadTime";
            this.btnDownloadTime.Size = new System.Drawing.Size(147, 36);
            this.btnDownloadTime.TabIndex = 58;
            this.btnDownloadTime.Text = "Download By Time";
            this.btnDownloadTime.UseVisualStyleBackColor = true;
            this.btnDownloadTime.Click += new System.EventHandler(this.btnDownloadTime_Click);
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(115, 481);
            this.label22.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(181, 15);
            this.label22.TabIndex = 57;
            this.label22.Text = "Playback/Download by file name";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(126, 203);
            this.label19.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(114, 15);
            this.label19.TabIndex = 50;
            this.label19.Text = "Search for recording";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(115, 126);
            this.label20.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(156, 15);
            this.label20.TabIndex = 56;
            this.label20.Text = "Playback/Download by time";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(126, 578);
            this.label21.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(140, 15);
            this.label21.TabIndex = 54;
            this.label21.Text = "Stop Playback/Download";
            // 
            // btnPlaybackTime
            // 
            this.btnPlaybackTime.Location = new System.Drawing.Point(12, 156);
            this.btnPlaybackTime.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnPlaybackTime.Name = "btnPlaybackTime";
            this.btnPlaybackTime.Size = new System.Drawing.Size(145, 36);
            this.btnPlaybackTime.TabIndex = 55;
            this.btnPlaybackTime.Text = "PlayBack By Time";
            this.btnPlaybackTime.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnPlaybackTime.UseVisualStyleBackColor = true;
            this.btnPlaybackTime.Click += new System.EventHandler(this.btnPlaybackTime_Click);
            // 
            // groupBox6
            // 
            this.groupBox6.Location = new System.Drawing.Point(5, 200);
            this.groupBox6.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox6.Size = new System.Drawing.Size(337, 13);
            this.groupBox6.TabIndex = 45;
            this.groupBox6.TabStop = false;
            // 
            // groupBox5
            // 
            this.groupBox5.Location = new System.Drawing.Point(4, 575);
            this.groupBox5.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox5.Size = new System.Drawing.Size(337, 13);
            this.groupBox5.TabIndex = 44;
            this.groupBox5.TabStop = false;
            // 
            // btnStopPlayback
            // 
            this.btnStopPlayback.Enabled = false;
            this.btnStopPlayback.Location = new System.Drawing.Point(10, 602);
            this.btnStopPlayback.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnStopPlayback.Name = "btnStopPlayback";
            this.btnStopPlayback.Size = new System.Drawing.Size(146, 43);
            this.btnStopPlayback.TabIndex = 53;
            this.btnStopPlayback.Text = "Stop PlayBack";
            this.btnStopPlayback.UseVisualStyleBackColor = true;
            this.btnStopPlayback.Click += new System.EventHandler(this.btnStopPlayback_Click);
            // 
            // btnPlaybackName
            // 
            this.btnPlaybackName.Location = new System.Drawing.Point(10, 513);
            this.btnPlaybackName.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnPlaybackName.Name = "btnPlaybackName";
            this.btnPlaybackName.Size = new System.Drawing.Size(146, 40);
            this.btnPlaybackName.TabIndex = 51;
            this.btnPlaybackName.Text = "PlayBack By Name";
            this.btnPlaybackName.UseVisualStyleBackColor = true;
            this.btnPlaybackName.Click += new System.EventHandler(this.btnPlaybackName_Click);
            // 
            // listViewFile
            // 
            this.listViewFile.Columns.AddRange(new System.Windows.Forms.ColumnHeader[]
                {this.columnHeader3, this.columnHeader4, this.columnHeader5});
            this.listViewFile.FullRowSelect = true;
            this.listViewFile.GridLines = true;
            this.listViewFile.Location = new System.Drawing.Point(5, 231);
            this.listViewFile.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.listViewFile.Name = "listViewFile";
            this.listViewFile.Size = new System.Drawing.Size(338, 187);
            this.listViewFile.TabIndex = 49;
            this.listViewFile.UseCompatibleStateImageBehavior = false;
            this.listViewFile.View = System.Windows.Forms.View.Details;
            this.listViewFile.SelectedIndexChanged += new System.EventHandler(this.listViewFile_SelectedIndexChanged);
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "File Name";
            this.columnHeader3.Width = 93;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Starting Time";
            this.columnHeader4.Width = 109;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Ending Time";
            this.columnHeader5.Width = 113;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(10, 430);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(146, 40);
            this.btnSearch.TabIndex = 48;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(8, 74);
            this.label17.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(71, 15);
            this.label17.TabIndex = 47;
            this.label17.Text = "Ending time";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(8, 25);
            this.label16.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(88, 15);
            this.label16.TabIndex = 45;
            this.label16.Text = "Beginning time";
            // 
            // dateTimeEnd
            // 
            this.dateTimeEnd.CustomFormat = "yyyy-MM-dd HH:mm:ss";
            this.dateTimeEnd.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimeEnd.Location = new System.Drawing.Point(118, 85);
            this.dateTimeEnd.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.dateTimeEnd.Name = "dateTimeEnd";
            this.dateTimeEnd.Size = new System.Drawing.Size(181, 23);
            this.dateTimeEnd.TabIndex = 43;
            this.dateTimeEnd.Value = new System.DateTime(2014, 2, 28, 14, 40, 31, 0);
            // 
            // groupBox7
            // 
            this.groupBox7.Location = new System.Drawing.Point(5, 123);
            this.groupBox7.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox7.Size = new System.Drawing.Size(337, 13);
            this.groupBox7.TabIndex = 46;
            this.groupBox7.TabStop = false;
            // 
            // groupBox8
            // 
            this.groupBox8.Location = new System.Drawing.Point(5, 478);
            this.groupBox8.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox8.Name = "groupBox8";
            this.groupBox8.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox8.Size = new System.Drawing.Size(337, 13);
            this.groupBox8.TabIndex = 46;
            this.groupBox8.TabStop = false;
            // 
            // timerDownload
            // 
            this.timerDownload.Tick += new System.EventHandler(this.timerProgress_Tick);
            // 
            // PlaybackprogressBar
            // 
            this.PlaybackprogressBar.Location = new System.Drawing.Point(215, 588);
            this.PlaybackprogressBar.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.PlaybackprogressBar.Name = "PlaybackprogressBar";
            this.PlaybackprogressBar.Size = new System.Drawing.Size(513, 13);
            this.PlaybackprogressBar.TabIndex = 43;
            // 
            // timerPlayback
            // 
            this.timerPlayback.Tick += new System.EventHandler(this.timerPlayback_Tick);
            // 
            // btn_Exit
            // 
            this.btn_Exit.Location = new System.Drawing.Point(922, 756);
            this.btn_Exit.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btn_Exit.Name = "btn_Exit";
            this.btn_Exit.Size = new System.Drawing.Size(148, 37);
            this.btn_Exit.TabIndex = 44;
            this.btn_Exit.Text = "Exit";
            this.btn_Exit.UseVisualStyleBackColor = true;
            this.btn_Exit.Click += new System.EventHandler(this.btn_Exit_Click);
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1084, 804);
            this.Controls.Add(this.btn_Exit);
            this.Controls.Add(this.PlaybackprogressBar);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.listViewIPChannel);
            this.Controls.Add(this.VideoPlayWnd);
            this.Controls.Add(this.textBoxPassword);
            this.Controls.Add(this.textBoxUserName);
            this.Controls.Add(this.textBoxPort);
            this.Controls.Add(this.textBoxIP);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox4);
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "MainWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Main Window";
            this.Load += new System.EventHandler(this.MainWindow_Load);
            ((System.ComponentModel.ISupportInitialize) (this.VideoPlayWnd)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.TextBox textBoxPassword;
        private System.Windows.Forms.TextBox textBoxUserName;
        private System.Windows.Forms.TextBox textBoxPort;
        private System.Windows.Forms.TextBox textBoxIP;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox VideoPlayWnd;
        private System.Windows.Forms.ListView listViewIPChannel;
        private System.Windows.Forms.ColumnHeader ColumnHeader1;
        private System.Windows.Forms.ColumnHeader ColumnHeader2;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DateTimePicker dateTimeStart;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.DateTimePicker dateTimeEnd;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.ListView listViewFile;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.Button btnPlaybackName;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Button btnStopPlayback;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Button btnPlaybackTime;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Button btnBMP;
        private System.Windows.Forms.Button btnFast;
        private System.Windows.Forms.Button btnSlow;
        private System.Windows.Forms.Button btnPause;
        private System.Windows.Forms.Button btnFrame;
        private System.Windows.Forms.Label labelPause;
        private System.Windows.Forms.Button btnReverse;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnResume;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.GroupBox groupBox8;
        private System.Windows.Forms.Button btnDownloadName;
        private System.Windows.Forms.Button btnDownloadTime;
        private System.Windows.Forms.Button btnStopDownload;
        private System.Windows.Forms.ProgressBar DownloadProgressBar;
        private System.Windows.Forms.Timer timerDownload;
        private System.Windows.Forms.ProgressBar PlaybackprogressBar;
        private System.Windows.Forms.Timer timerPlayback;
        private System.Windows.Forms.Button btn_Exit;
        private System.Windows.Forms.Label labelSound;
        private System.Windows.Forms.Button btnSound;
        private System.Windows.Forms.Label labelReverse;
        private System.Windows.Forms.Label label5;
    }
}

