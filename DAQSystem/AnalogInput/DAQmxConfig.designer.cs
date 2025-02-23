namespace DAQmx
{
    partial class DAQmxConfig
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
            this.btn_Confirm = new System.Windows.Forms.Button();
            this.btn_Cancel = new System.Windows.Forms.Button();
            this.btn_SaveMotorConfig = new System.Windows.Forms.Button();
            this.btn_LoadMotorConfig = new System.Windows.Forms.Button();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.label19 = new System.Windows.Forms.Label();
            this.numeric_Rowsnum = new System.Windows.Forms.NumericUpDown();
            this.label_SampleRate = new System.Windows.Forms.Label();
            this.numericUpDown_sampleRate = new System.Windows.Forms.NumericUpDown();
            this.label26 = new System.Windows.Forms.Label();
            this.numeric_Colnum = new System.Windows.Forms.NumericUpDown();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbx_DifferentialChannels = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.numericUpDown_RetriggerNum = new System.Windows.Forms.NumericUpDown();
            this.cbx_SaveFlag = new System.Windows.Forms.CheckBox();
            this.btn_Browser = new System.Windows.Forms.Button();
            this.tbx_Path = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.cbx_EnableDarkSignal = new System.Windows.Forms.CheckBox();
            this.btn_DarkSignalBrowser = new System.Windows.Forms.Button();
            this.tbx_DarkSignalPath = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.numeric_Rowsnum)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_sampleRate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numeric_Colnum)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_RetriggerNum)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_Confirm
            // 
            this.btn_Confirm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Confirm.Font = new System.Drawing.Font("隶书", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_Confirm.Location = new System.Drawing.Point(152, 747);
            this.btn_Confirm.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_Confirm.Name = "btn_Confirm";
            this.btn_Confirm.Size = new System.Drawing.Size(164, 78);
            this.btn_Confirm.TabIndex = 10;
            this.btn_Confirm.Text = "确认";
            this.btn_Confirm.UseVisualStyleBackColor = true;
            this.btn_Confirm.Click += new System.EventHandler(this.btn_Confirm_Click);
            // 
            // btn_Cancel
            // 
            this.btn_Cancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Cancel.Font = new System.Drawing.Font("隶书", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_Cancel.Location = new System.Drawing.Point(479, 747);
            this.btn_Cancel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_Cancel.Name = "btn_Cancel";
            this.btn_Cancel.Size = new System.Drawing.Size(164, 78);
            this.btn_Cancel.TabIndex = 10;
            this.btn_Cancel.Text = "取消";
            this.btn_Cancel.UseVisualStyleBackColor = true;
            this.btn_Cancel.Click += new System.EventHandler(this.btn_Cancel_Click);
            // 
            // btn_SaveMotorConfig
            // 
            this.btn_SaveMotorConfig.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_SaveMotorConfig.Font = new System.Drawing.Font("隶书", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_SaveMotorConfig.Location = new System.Drawing.Point(812, 747);
            this.btn_SaveMotorConfig.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_SaveMotorConfig.Name = "btn_SaveMotorConfig";
            this.btn_SaveMotorConfig.Size = new System.Drawing.Size(164, 78);
            this.btn_SaveMotorConfig.TabIndex = 17;
            this.btn_SaveMotorConfig.Text = "保存配置";
            this.btn_SaveMotorConfig.UseVisualStyleBackColor = true;
            this.btn_SaveMotorConfig.Click += new System.EventHandler(this.btn_SaveMotorConfig_Click);
            // 
            // btn_LoadMotorConfig
            // 
            this.btn_LoadMotorConfig.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_LoadMotorConfig.Font = new System.Drawing.Font("隶书", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_LoadMotorConfig.Location = new System.Drawing.Point(1141, 747);
            this.btn_LoadMotorConfig.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_LoadMotorConfig.Name = "btn_LoadMotorConfig";
            this.btn_LoadMotorConfig.Size = new System.Drawing.Size(164, 78);
            this.btn_LoadMotorConfig.TabIndex = 17;
            this.btn_LoadMotorConfig.Text = "读取配置";
            this.btn_LoadMotorConfig.UseVisualStyleBackColor = true;
            this.btn_LoadMotorConfig.Click += new System.EventHandler(this.btn_LoadMotorConfig_Click_1);
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label19.Location = new System.Drawing.Point(112, 74);
            this.label19.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(58, 24);
            this.label19.TabIndex = 68;
            this.label19.Text = "行数";
            // 
            // numeric_Rowsnum
            // 
            this.numeric_Rowsnum.Location = new System.Drawing.Point(211, 72);
            this.numeric_Rowsnum.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.numeric_Rowsnum.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.numeric_Rowsnum.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numeric_Rowsnum.Name = "numeric_Rowsnum";
            this.numeric_Rowsnum.Size = new System.Drawing.Size(204, 35);
            this.numeric_Rowsnum.TabIndex = 69;
            this.numeric_Rowsnum.Tag = "ParaConfig";
            this.numeric_Rowsnum.ThousandsSeparator = true;
            this.numeric_Rowsnum.Value = new decimal(new int[] {
            32,
            0,
            0,
            0});
            // 
            // label_SampleRate
            // 
            this.label_SampleRate.AutoSize = true;
            this.label_SampleRate.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label_SampleRate.Location = new System.Drawing.Point(70, 88);
            this.label_SampleRate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_SampleRate.Name = "label_SampleRate";
            this.label_SampleRate.Size = new System.Drawing.Size(154, 24);
            this.label_SampleRate.TabIndex = 1;
            this.label_SampleRate.Text = "采样率(S/s) ";
            // 
            // numericUpDown_sampleRate
            // 
            this.numericUpDown_sampleRate.Location = new System.Drawing.Point(259, 85);
            this.numericUpDown_sampleRate.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.numericUpDown_sampleRate.Maximum = new decimal(new int[] {
            1250000000,
            0,
            0,
            0});
            this.numericUpDown_sampleRate.Name = "numericUpDown_sampleRate";
            this.numericUpDown_sampleRate.Size = new System.Drawing.Size(204, 35);
            this.numericUpDown_sampleRate.TabIndex = 5;
            this.numericUpDown_sampleRate.Tag = "ParaConfig";
            this.numericUpDown_sampleRate.ThousandsSeparator = true;
            this.numericUpDown_sampleRate.Value = new decimal(new int[] {
            125000000,
            0,
            0,
            0});
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Font = new System.Drawing.Font("宋体", 9F);
            this.label26.Location = new System.Drawing.Point(112, 151);
            this.label26.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(58, 24);
            this.label26.TabIndex = 86;
            this.label26.Text = "列数";
            // 
            // numeric_Colnum
            // 
            this.numeric_Colnum.Location = new System.Drawing.Point(211, 149);
            this.numeric_Colnum.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.numeric_Colnum.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.numeric_Colnum.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numeric_Colnum.Name = "numeric_Colnum";
            this.numeric_Colnum.Size = new System.Drawing.Size(204, 35);
            this.numeric_Colnum.TabIndex = 92;
            this.numeric_Colnum.Tag = "ParaConfig";
            this.numeric_Colnum.ThousandsSeparator = true;
            this.numeric_Colnum.Value = new decimal(new int[] {
            32,
            0,
            0,
            0});
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbx_DifferentialChannels);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.numericUpDown_RetriggerNum);
            this.groupBox1.Controls.Add(this.cbx_SaveFlag);
            this.groupBox1.Controls.Add(this.btn_Browser);
            this.groupBox1.Controls.Add(this.tbx_Path);
            this.groupBox1.Controls.Add(this.numericUpDown_sampleRate);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label_SampleRate);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox1.Location = new System.Drawing.Point(121, 122);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(544, 541);
            this.groupBox1.TabIndex = 114;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "采样配置";
            // 
            // cbx_DifferentialChannels
            // 
            this.cbx_DifferentialChannels.FormattingEnabled = true;
            this.cbx_DifferentialChannels.Items.AddRange(new object[] {
            "1",
            "2",
            "4"});
            this.cbx_DifferentialChannels.Location = new System.Drawing.Point(259, 187);
            this.cbx_DifferentialChannels.Name = "cbx_DifferentialChannels";
            this.cbx_DifferentialChannels.Size = new System.Drawing.Size(204, 32);
            this.cbx_DifferentialChannels.TabIndex = 112;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(73, 292);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 24);
            this.label1.TabIndex = 111;
            this.label1.Text = "运行帧数";
            // 
            // numericUpDown_RetriggerNum
            // 
            this.numericUpDown_RetriggerNum.Location = new System.Drawing.Point(262, 290);
            this.numericUpDown_RetriggerNum.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numericUpDown_RetriggerNum.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            -2147483648});
            this.numericUpDown_RetriggerNum.Name = "numericUpDown_RetriggerNum";
            this.numericUpDown_RetriggerNum.Size = new System.Drawing.Size(131, 35);
            this.numericUpDown_RetriggerNum.TabIndex = 110;
            this.numericUpDown_RetriggerNum.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown_RetriggerNum.ValueChanged += new System.EventHandler(this.numericUpDown_RetriggerNum_ValueChanged);
            // 
            // cbx_SaveFlag
            // 
            this.cbx_SaveFlag.AutoSize = true;
            this.cbx_SaveFlag.Location = new System.Drawing.Point(355, 498);
            this.cbx_SaveFlag.Name = "cbx_SaveFlag";
            this.cbx_SaveFlag.Size = new System.Drawing.Size(138, 28);
            this.cbx_SaveFlag.TabIndex = 109;
            this.cbx_SaveFlag.Text = "数据保存";
            this.cbx_SaveFlag.UseVisualStyleBackColor = true;
            // 
            // btn_Browser
            // 
            this.btn_Browser.Location = new System.Drawing.Point(418, 427);
            this.btn_Browser.Name = "btn_Browser";
            this.btn_Browser.Size = new System.Drawing.Size(75, 48);
            this.btn_Browser.TabIndex = 108;
            this.btn_Browser.Text = "...";
            this.btn_Browser.UseVisualStyleBackColor = true;
            this.btn_Browser.Click += new System.EventHandler(this.btn_Browser_Click);
            // 
            // tbx_Path
            // 
            this.tbx_Path.Font = new System.Drawing.Font("宋体", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tbx_Path.Location = new System.Drawing.Point(6, 427);
            this.tbx_Path.Name = "tbx_Path";
            this.tbx_Path.Size = new System.Drawing.Size(406, 32);
            this.tbx_Path.TabIndex = 107;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(70, 191);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(130, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "差分通道数";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.numeric_Rowsnum);
            this.groupBox3.Controls.Add(this.label19);
            this.groupBox3.Controls.Add(this.numeric_Colnum);
            this.groupBox3.Controls.Add(this.cbx_EnableDarkSignal);
            this.groupBox3.Controls.Add(this.label26);
            this.groupBox3.Controls.Add(this.btn_DarkSignalBrowser);
            this.groupBox3.Controls.Add(this.tbx_DarkSignalPath);
            this.groupBox3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox3.Location = new System.Drawing.Point(774, 122);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(584, 541);
            this.groupBox3.TabIndex = 116;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "图像配置";
            // 
            // cbx_EnableDarkSignal
            // 
            this.cbx_EnableDarkSignal.AutoSize = true;
            this.cbx_EnableDarkSignal.Location = new System.Drawing.Point(321, 447);
            this.cbx_EnableDarkSignal.Name = "cbx_EnableDarkSignal";
            this.cbx_EnableDarkSignal.Size = new System.Drawing.Size(210, 28);
            this.cbx_EnableDarkSignal.TabIndex = 109;
            this.cbx_EnableDarkSignal.Text = "是否加载暗背景";
            this.cbx_EnableDarkSignal.UseVisualStyleBackColor = true;
            // 
            // btn_DarkSignalBrowser
            // 
            this.btn_DarkSignalBrowser.Location = new System.Drawing.Point(493, 292);
            this.btn_DarkSignalBrowser.Name = "btn_DarkSignalBrowser";
            this.btn_DarkSignalBrowser.Size = new System.Drawing.Size(75, 48);
            this.btn_DarkSignalBrowser.TabIndex = 108;
            this.btn_DarkSignalBrowser.Text = "...";
            this.btn_DarkSignalBrowser.UseVisualStyleBackColor = true;
            this.btn_DarkSignalBrowser.Click += new System.EventHandler(this.btn_DarkSignalBrowser_Click);
            // 
            // tbx_DarkSignalPath
            // 
            this.tbx_DarkSignalPath.Font = new System.Drawing.Font("宋体", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tbx_DarkSignalPath.Location = new System.Drawing.Point(15, 290);
            this.tbx_DarkSignalPath.Name = "tbx_DarkSignalPath";
            this.tbx_DarkSignalPath.Size = new System.Drawing.Size(472, 32);
            this.tbx_DarkSignalPath.TabIndex = 107;
            // 
            // DAQmxConfig
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1551, 962);
            this.ControlBox = false;
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btn_LoadMotorConfig);
            this.Controls.Add(this.btn_SaveMotorConfig);
            this.Controls.Add(this.btn_Cancel);
            this.Controls.Add(this.btn_Confirm);
            this.HelpButton = true;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.Name = "DAQmxConfig";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "系统采集配置";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.DAQmxConfig_FormClosing);
            this.Load += new System.EventHandler(this.DAQmxConfig_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numeric_Rowsnum)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_sampleRate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numeric_Colnum)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_RetriggerNum)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btn_Confirm;
        private System.Windows.Forms.Button btn_Cancel;
        private System.Windows.Forms.Button btn_SaveMotorConfig;
        private System.Windows.Forms.Button btn_LoadMotorConfig;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.NumericUpDown numeric_Rowsnum;
        private System.Windows.Forms.Label label_SampleRate;
        private System.Windows.Forms.NumericUpDown numericUpDown_sampleRate;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.NumericUpDown numeric_Colnum;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btn_Browser;
        private System.Windows.Forms.TextBox tbx_Path;
        private System.Windows.Forms.CheckBox cbx_SaveFlag;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown numericUpDown_RetriggerNum;
        private System.Windows.Forms.ComboBox cbx_DifferentialChannels;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox cbx_EnableDarkSignal;
        private System.Windows.Forms.Button btn_DarkSignalBrowser;
        private System.Windows.Forms.TextBox tbx_DarkSignalPath;
    }
}