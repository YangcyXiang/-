namespace DAQmx
{
    partial class DOConfigForm
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.numericUpDown_updateRate = new System.Windows.Forms.NumericUpDown();
            this.btn_LoadDigWave = new System.Windows.Forms.Button();
            this.btn_SimuRun = new System.Windows.Forms.Button();
            this.dataGridView_Config = new System.Windows.Forms.DataGridView();
            this.选择 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.名称 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_LoadConfig = new System.Windows.Forms.Button();
            this.btn_SaveConfig = new System.Windows.Forms.Button();
            this.numeric_RepeatNum = new System.Windows.Forms.NumericUpDown();
            this.cbx_IsContinues = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.tbx_FilePath = new System.Windows.Forms.TextBox();
            this.btn_WaveFileBrowser = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.digitalChart = new SeeSharpTools.JY.GUI.DigitalChart.DigitalChart();
            this.btn_SimuStop = new System.Windows.Forms.Button();
            this.comboBox_setPowerLevel = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_updateRate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Config)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numeric_RepeatNum)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(610, 32);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(154, 24);
            this.label1.TabIndex = 11;
            this.label1.Text = "更新率（Hz）";
            // 
            // numericUpDown_updateRate
            // 
            this.numericUpDown_updateRate.Location = new System.Drawing.Point(614, 80);
            this.numericUpDown_updateRate.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.numericUpDown_updateRate.Maximum = new decimal(new int[] {
            50000000,
            0,
            0,
            0});
            this.numericUpDown_updateRate.Name = "numericUpDown_updateRate";
            this.numericUpDown_updateRate.Size = new System.Drawing.Size(240, 35);
            this.numericUpDown_updateRate.TabIndex = 10;
            this.numericUpDown_updateRate.Value = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            // 
            // btn_LoadDigWave
            // 
            this.btn_LoadDigWave.Location = new System.Drawing.Point(620, 1194);
            this.btn_LoadDigWave.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_LoadDigWave.Name = "btn_LoadDigWave";
            this.btn_LoadDigWave.Size = new System.Drawing.Size(240, 96);
            this.btn_LoadDigWave.TabIndex = 9;
            this.btn_LoadDigWave.Text = "加载数字波形";
            this.btn_LoadDigWave.UseVisualStyleBackColor = true;
            this.btn_LoadDigWave.Click += new System.EventHandler(this.btn_LoadDigWave_Click);
            // 
            // btn_SimuRun
            // 
            this.btn_SimuRun.Location = new System.Drawing.Point(614, 632);
            this.btn_SimuRun.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_SimuRun.Name = "btn_SimuRun";
            this.btn_SimuRun.Size = new System.Drawing.Size(240, 96);
            this.btn_SimuRun.TabIndex = 8;
            this.btn_SimuRun.Text = "执行输出";
            this.btn_SimuRun.UseVisualStyleBackColor = true;
            this.btn_SimuRun.Click += new System.EventHandler(this.btn_SimuRun_Click);
            // 
            // dataGridView_Config
            // 
            this.dataGridView_Config.AllowUserToAddRows = false;
            this.dataGridView_Config.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_Config.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.选择,
            this.名称});
            this.dataGridView_Config.Location = new System.Drawing.Point(24, 32);
            this.dataGridView_Config.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dataGridView_Config.Name = "dataGridView_Config";
            this.dataGridView_Config.RowHeadersWidth = 82;
            this.dataGridView_Config.RowTemplate.Height = 37;
            this.dataGridView_Config.Size = new System.Drawing.Size(458, 1168);
            this.dataGridView_Config.TabIndex = 12;
            // 
            // 选择
            // 
            this.选择.HeaderText = "选择";
            this.选择.MinimumWidth = 10;
            this.选择.Name = "选择";
            this.选择.Width = 60;
            // 
            // 名称
            // 
            this.名称.HeaderText = "名称";
            this.名称.MinimumWidth = 10;
            this.名称.Name = "名称";
            this.名称.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.名称.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.名称.Width = 80;
            // 
            // btn_LoadConfig
            // 
            this.btn_LoadConfig.Location = new System.Drawing.Point(614, 485);
            this.btn_LoadConfig.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_LoadConfig.Name = "btn_LoadConfig";
            this.btn_LoadConfig.Size = new System.Drawing.Size(240, 96);
            this.btn_LoadConfig.TabIndex = 9;
            this.btn_LoadConfig.Text = "加载配置";
            this.btn_LoadConfig.UseVisualStyleBackColor = true;
            this.btn_LoadConfig.Click += new System.EventHandler(this.btn_LoadConfig_Click);
            // 
            // btn_SaveConfig
            // 
            this.btn_SaveConfig.Location = new System.Drawing.Point(614, 336);
            this.btn_SaveConfig.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_SaveConfig.Name = "btn_SaveConfig";
            this.btn_SaveConfig.Size = new System.Drawing.Size(240, 96);
            this.btn_SaveConfig.TabIndex = 9;
            this.btn_SaveConfig.Text = "保存配置";
            this.btn_SaveConfig.UseVisualStyleBackColor = true;
            this.btn_SaveConfig.Click += new System.EventHandler(this.btn_SaveConfig_Click);
            // 
            // numeric_RepeatNum
            // 
            this.numeric_RepeatNum.Location = new System.Drawing.Point(614, 181);
            this.numeric_RepeatNum.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.numeric_RepeatNum.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numeric_RepeatNum.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numeric_RepeatNum.Name = "numeric_RepeatNum";
            this.numeric_RepeatNum.Size = new System.Drawing.Size(151, 35);
            this.numeric_RepeatNum.TabIndex = 10;
            this.numeric_RepeatNum.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // cbx_IsContinues
            // 
            this.cbx_IsContinues.AutoSize = true;
            this.cbx_IsContinues.Location = new System.Drawing.Point(818, 187);
            this.cbx_IsContinues.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cbx_IsContinues.Name = "cbx_IsContinues";
            this.cbx_IsContinues.Size = new System.Drawing.Size(90, 28);
            this.cbx_IsContinues.TabIndex = 15;
            this.cbx_IsContinues.Text = "连续";
            this.cbx_IsContinues.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(610, 138);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 24);
            this.label2.TabIndex = 11;
            this.label2.Text = "重复次数";
            // 
            // tbx_FilePath
            // 
            this.tbx_FilePath.Font = new System.Drawing.Font("宋体", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tbx_FilePath.Location = new System.Drawing.Point(13, 1253);
            this.tbx_FilePath.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbx_FilePath.Name = "tbx_FilePath";
            this.tbx_FilePath.Size = new System.Drawing.Size(510, 32);
            this.tbx_FilePath.TabIndex = 16;
            // 
            // btn_WaveFileBrowser
            // 
            this.btn_WaveFileBrowser.Location = new System.Drawing.Point(536, 1240);
            this.btn_WaveFileBrowser.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_WaveFileBrowser.Name = "btn_WaveFileBrowser";
            this.btn_WaveFileBrowser.Size = new System.Drawing.Size(76, 50);
            this.btn_WaveFileBrowser.TabIndex = 17;
            this.btn_WaveFileBrowser.Text = "...";
            this.btn_WaveFileBrowser.UseVisualStyleBackColor = true;
            this.btn_WaveFileBrowser.Click += new System.EventHandler(this.btn_WaveFileBrowser_Click);
            // 
            // digitalChart
            // 
            this.digitalChart.Location = new System.Drawing.Point(1078, 32);
            this.digitalChart.Margin = new System.Windows.Forms.Padding(12, 11, 12, 11);
            this.digitalChart.Name = "digitalChart";
            this.digitalChart.Size = new System.Drawing.Size(1742, 1258);
            this.digitalChart.TabIndex = 19;
            // 
            // btn_SimuStop
            // 
            this.btn_SimuStop.Location = new System.Drawing.Point(614, 779);
            this.btn_SimuStop.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_SimuStop.Name = "btn_SimuStop";
            this.btn_SimuStop.Size = new System.Drawing.Size(240, 96);
            this.btn_SimuStop.TabIndex = 8;
            this.btn_SimuStop.Text = "停止输出";
            this.btn_SimuStop.UseVisualStyleBackColor = true;
            this.btn_SimuStop.Click += new System.EventHandler(this.btn_SimuStop_Click);
            // 
            // comboBox_setPowerLevel
            // 
            this.comboBox_setPowerLevel.FormattingEnabled = true;
            this.comboBox_setPowerLevel.Location = new System.Drawing.Point(620, 272);
            this.comboBox_setPowerLevel.Name = "comboBox_setPowerLevel";
            this.comboBox_setPowerLevel.Size = new System.Drawing.Size(185, 32);
            this.comboBox_setPowerLevel.TabIndex = 20;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(616, 235);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 24);
            this.label3.TabIndex = 11;
            this.label3.Text = "电平选择";
            // 
            // DOConfigForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(2524, 1339);
            this.Controls.Add(this.comboBox_setPowerLevel);
            this.Controls.Add(this.digitalChart);
            this.Controls.Add(this.btn_WaveFileBrowser);
            this.Controls.Add(this.tbx_FilePath);
            this.Controls.Add(this.cbx_IsContinues);
            this.Controls.Add(this.dataGridView_Config);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.numeric_RepeatNum);
            this.Controls.Add(this.numericUpDown_updateRate);
            this.Controls.Add(this.btn_SaveConfig);
            this.Controls.Add(this.btn_LoadConfig);
            this.Controls.Add(this.btn_LoadDigWave);
            this.Controls.Add(this.btn_SimuStop);
            this.Controls.Add(this.btn_SimuRun);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "DOConfigForm";
            this.Text = "控制信号";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.DOConfigForm_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_updateRate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Config)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numeric_RepeatNum)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown numericUpDown_updateRate;
        private System.Windows.Forms.Button btn_LoadDigWave;
        private System.Windows.Forms.Button btn_SimuRun;
        private System.Windows.Forms.DataGridView dataGridView_Config;
        private System.Windows.Forms.Button btn_LoadConfig;
        private System.Windows.Forms.Button btn_SaveConfig;
        private System.Windows.Forms.DataGridViewCheckBoxColumn 选择;
        private System.Windows.Forms.DataGridViewTextBoxColumn 名称;
        private System.Windows.Forms.NumericUpDown numeric_RepeatNum;
        private System.Windows.Forms.CheckBox cbx_IsContinues;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.TextBox tbx_FilePath;
        private System.Windows.Forms.Button btn_WaveFileBrowser;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private SeeSharpTools.JY.GUI.DigitalChart.DigitalChart digitalChart;
        private System.Windows.Forms.Button btn_SimuStop;
        private System.Windows.Forms.ComboBox comboBox_setPowerLevel;
        private System.Windows.Forms.Label label3;
    }
}

