namespace DAQmx
{
    partial class MainForm
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
            System.Windows.Forms.Ribbon ribbon1;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.ribbonTab_AI = new System.Windows.Forms.RibbonTab();
            this.ribbonPanel_AIConfig = new System.Windows.Forms.RibbonPanel();
            this.ribbonButton_daqConfig = new System.Windows.Forms.RibbonButton();
            this.ribbonButton_DOConfig = new System.Windows.Forms.RibbonButton();
            this.ribbonPanel_operation = new System.Windows.Forms.RibbonPanel();
            this.ribbonButton_start = new System.Windows.Forms.RibbonButton();
            this.ribbonButton_stop = new System.Windows.Forms.RibbonButton();
            this.ribbonPanel_waveform = new System.Windows.Forms.RibbonPanel();
            this.ribbonButton_waveform = new System.Windows.Forms.RibbonButton();
            this.ribbonButton_SpectrumWave = new System.Windows.Forms.RibbonButton();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.folerBrower_savePath = new System.Windows.Forms.FolderBrowserDialog();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dockPanel1 = new WeifenLuo.WinFormsUI.Docking.DockPanel();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.ribbonButton_channelList = new System.Windows.Forms.RibbonButton();
            ribbon1 = new System.Windows.Forms.Ribbon();
            this.panel1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ribbon1
            // 
            ribbon1.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F);
            ribbon1.ForeColor = System.Drawing.Color.Crimson;
            ribbon1.Location = new System.Drawing.Point(0, 0);
            ribbon1.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            ribbon1.Minimized = false;
            ribbon1.Name = "ribbon1";
            // 
            // 
            // 
            ribbon1.OrbDropDown.BorderRoundness = 8;
            ribbon1.OrbDropDown.Location = new System.Drawing.Point(0, 0);
            ribbon1.OrbDropDown.Name = "";
            ribbon1.OrbDropDown.Size = new System.Drawing.Size(527, 447);
            ribbon1.OrbDropDown.TabIndex = 0;
            ribbon1.OrbStyle = System.Windows.Forms.RibbonOrbStyle.Office_2013;
            ribbon1.OrbText = "";
            ribbon1.OrbVisible = false;
            ribbon1.RibbonTabFont = new System.Drawing.Font("Trebuchet MS", 9F);
            ribbon1.Size = new System.Drawing.Size(2073, 149);
            ribbon1.TabIndex = 0;
            ribbon1.Tabs.Add(this.ribbonTab_AI);
            ribbon1.TabsMargin = new System.Windows.Forms.Padding(5, 26, 20, 0);
            ribbon1.TabSpacing = 4;
            ribbon1.Text = "PXIe-6301精度测试";
            ribbon1.ThemeColor = System.Windows.Forms.RibbonTheme.Black;
            // 
            // ribbonTab_AI
            // 
            this.ribbonTab_AI.Name = "ribbonTab_AI";
            this.ribbonTab_AI.Panels.Add(this.ribbonPanel_AIConfig);
            this.ribbonTab_AI.Panels.Add(this.ribbonPanel_operation);
            this.ribbonTab_AI.Panels.Add(this.ribbonPanel_waveform);
            this.ribbonTab_AI.Text = "Analog Input";
            // 
            // ribbonPanel_AIConfig
            // 
            this.ribbonPanel_AIConfig.Items.Add(this.ribbonButton_daqConfig);
            this.ribbonPanel_AIConfig.Items.Add(this.ribbonButton_DOConfig);
            this.ribbonPanel_AIConfig.Name = "ribbonPanel_AIConfig";
            this.ribbonPanel_AIConfig.Text = "AI Setting";
            // 
            // ribbonButton_daqConfig
            // 
            this.ribbonButton_daqConfig.Image = ((System.Drawing.Image)(resources.GetObject("ribbonButton_daqConfig.Image")));
            this.ribbonButton_daqConfig.LargeImage = ((System.Drawing.Image)(resources.GetObject("ribbonButton_daqConfig.LargeImage")));
            this.ribbonButton_daqConfig.Name = "ribbonButton_daqConfig";
            this.ribbonButton_daqConfig.SmallImage = ((System.Drawing.Image)(resources.GetObject("ribbonButton_daqConfig.SmallImage")));
            this.ribbonButton_daqConfig.Text = "采集设置";
            this.ribbonButton_daqConfig.Click += new System.EventHandler(this.ribbonButton_daqConfig_Click);
            // 
            // ribbonButton_DOConfig
            // 
            this.ribbonButton_DOConfig.Image = ((System.Drawing.Image)(resources.GetObject("ribbonButton_DOConfig.Image")));
            this.ribbonButton_DOConfig.LargeImage = ((System.Drawing.Image)(resources.GetObject("ribbonButton_DOConfig.LargeImage")));
            this.ribbonButton_DOConfig.Name = "ribbonButton_DOConfig";
            this.ribbonButton_DOConfig.SmallImage = ((System.Drawing.Image)(resources.GetObject("ribbonButton_DOConfig.SmallImage")));
            this.ribbonButton_DOConfig.Text = "控制信号";
            this.ribbonButton_DOConfig.Click += new System.EventHandler(this.ribbonButton_DOConfig_Click);
            // 
            // ribbonPanel_operation
            // 
            this.ribbonPanel_operation.Items.Add(this.ribbonButton_start);
            this.ribbonPanel_operation.Items.Add(this.ribbonButton_stop);
            this.ribbonPanel_operation.Name = "ribbonPanel_operation";
            this.ribbonPanel_operation.Text = "Acquisition Operation";
            // 
            // ribbonButton_start
            // 
            this.ribbonButton_start.Image = ((System.Drawing.Image)(resources.GetObject("ribbonButton_start.Image")));
            this.ribbonButton_start.LargeImage = ((System.Drawing.Image)(resources.GetObject("ribbonButton_start.LargeImage")));
            this.ribbonButton_start.Name = "ribbonButton_start";
            this.ribbonButton_start.SmallImage = ((System.Drawing.Image)(resources.GetObject("ribbonButton_start.SmallImage")));
            this.ribbonButton_start.Text = "开始采集";
            this.ribbonButton_start.Click += new System.EventHandler(this.ribbonButton_start_Click);
            // 
            // ribbonButton_stop
            // 
            this.ribbonButton_stop.Image = ((System.Drawing.Image)(resources.GetObject("ribbonButton_stop.Image")));
            this.ribbonButton_stop.LargeImage = ((System.Drawing.Image)(resources.GetObject("ribbonButton_stop.LargeImage")));
            this.ribbonButton_stop.Name = "ribbonButton_stop";
            this.ribbonButton_stop.SmallImage = ((System.Drawing.Image)(resources.GetObject("ribbonButton_stop.SmallImage")));
            this.ribbonButton_stop.Text = "停止采集";
            this.ribbonButton_stop.Click += new System.EventHandler(this.ribbonButton_stop_Click);
            // 
            // ribbonPanel_waveform
            // 
            this.ribbonPanel_waveform.Items.Add(this.ribbonButton_waveform);
            this.ribbonPanel_waveform.Items.Add(this.ribbonButton_SpectrumWave);
            this.ribbonPanel_waveform.Name = "ribbonPanel_waveform";
            this.ribbonPanel_waveform.Text = "Waveform View";
            // 
            // ribbonButton_waveform
            // 
            this.ribbonButton_waveform.Image = ((System.Drawing.Image)(resources.GetObject("ribbonButton_waveform.Image")));
            this.ribbonButton_waveform.LargeImage = ((System.Drawing.Image)(resources.GetObject("ribbonButton_waveform.LargeImage")));
            this.ribbonButton_waveform.Name = "ribbonButton_waveform";
            this.ribbonButton_waveform.SmallImage = ((System.Drawing.Image)(resources.GetObject("ribbonButton_waveform.SmallImage")));
            this.ribbonButton_waveform.Text = "波形参数";
            this.ribbonButton_waveform.Click += new System.EventHandler(this.ribbonButton_waveform_Click);
            // 
            // ribbonButton_SpectrumWave
            // 
            this.ribbonButton_SpectrumWave.Image = ((System.Drawing.Image)(resources.GetObject("ribbonButton_SpectrumWave.Image")));
            this.ribbonButton_SpectrumWave.LargeImage = ((System.Drawing.Image)(resources.GetObject("ribbonButton_SpectrumWave.LargeImage")));
            this.ribbonButton_SpectrumWave.Name = "ribbonButton_SpectrumWave";
            this.ribbonButton_SpectrumWave.SmallImage = ((System.Drawing.Image)(resources.GetObject("ribbonButton_SpectrumWave.SmallImage")));
            this.ribbonButton_SpectrumWave.Text = "图像显示";
            this.ribbonButton_SpectrumWave.Click += new System.EventHandler(this.ribbonButton_SpectrumWave_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 50;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dockPanel1);
            this.panel1.Controls.Add(this.statusStrip1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 149);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(2073, 1231);
            this.panel1.TabIndex = 2;
            // 
            // dockPanel1
            // 
            this.dockPanel1.ActiveAutoHideContent = null;
            this.dockPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dockPanel1.DocumentStyle = WeifenLuo.WinFormsUI.Docking.DocumentStyle.DockingWindow;
            this.dockPanel1.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.dockPanel1.Location = new System.Drawing.Point(0, 0);
            this.dockPanel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dockPanel1.Name = "dockPanel1";
            this.dockPanel1.Size = new System.Drawing.Size(2073, 1190);
            this.dockPanel1.TabIndex = 2;
            this.dockPanel1.ActiveContentChanged += new System.EventHandler(this.dockPanel1_ActiveContentChanged);
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel});
            this.statusStrip1.Location = new System.Drawing.Point(0, 1190);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(2073, 41);
            this.statusStrip1.TabIndex = 0;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel
            // 
            this.toolStripStatusLabel.Name = "toolStripStatusLabel";
            this.toolStripStatusLabel.Size = new System.Drawing.Size(110, 31);
            this.toolStripStatusLabel.Text = "状态显示";
            // 
            // ribbonButton_channelList
            // 
            this.ribbonButton_channelList.Image = ((System.Drawing.Image)(resources.GetObject("ribbonButton_channelList.Image")));
            this.ribbonButton_channelList.LargeImage = ((System.Drawing.Image)(resources.GetObject("ribbonButton_channelList.LargeImage")));
            this.ribbonButton_channelList.Name = "ribbonButton_channelList";
            this.ribbonButton_channelList.SmallImage = ((System.Drawing.Image)(resources.GetObject("ribbonButton_channelList.SmallImage")));
            this.ribbonButton_channelList.Text = "ChannelList";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2073, 1380);
            this.Controls.Add(this.panel1);
            this.Controls.Add(ribbon1);
            this.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.TabText = "irfpa_test_system";
            this.Text = "irfpa_test_system-V1.2";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RibbonTab ribbonTab_AI;
        private System.Windows.Forms.RibbonPanel ribbonPanel_AIConfig;
        private System.Windows.Forms.RibbonButton ribbonButton_daqConfig;
        private System.Windows.Forms.RibbonPanel ribbonPanel_operation;
        private System.Windows.Forms.RibbonButton ribbonButton_start;
        private System.Windows.Forms.RibbonButton ribbonButton_stop;
        private System.Windows.Forms.RibbonPanel ribbonPanel_waveform;
        private System.Windows.Forms.RibbonButton ribbonButton_waveform;
        private System.Windows.Forms.RibbonButton ribbonButton_channelList;
        private System.Windows.Forms.RibbonPanel ribbonPanel_configuration;
        private System.Windows.Forms.RibbonPanel ribbonPanel_playbackOpen;
        private System.Windows.Forms.RibbonPanel ribbonPanel_waveformView;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.RibbonButton ribbonButton_SpectrumWave;
        private System.Windows.Forms.RibbonPanel ribbonPanel_Playback;
        private System.Windows.Forms.FolderBrowserDialog folerBrower_savePath;
        private System.Windows.Forms.Panel panel1;
        private WeifenLuo.WinFormsUI.Docking.DockPanel dockPanel1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel;
        private System.Windows.Forms.RibbonButton ribbonButton_DOConfig;
    }
}