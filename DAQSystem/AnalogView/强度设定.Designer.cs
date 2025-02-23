namespace DAQmx.AnalogView
{
    partial class 强度设定
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
            this.numeric_min = new System.Windows.Forms.NumericUpDown();
            this.numeric_max = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btn_Confirm = new System.Windows.Forms.Button();
            this.btn_Cancel = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.cbx_Auto = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.numeric_min)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numeric_max)).BeginInit();
            this.SuspendLayout();
            // 
            // numeric_min
            // 
            this.numeric_min.Location = new System.Drawing.Point(104, 114);
            this.numeric_min.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numeric_min.Minimum = new decimal(new int[] {
            10000,
            0,
            0,
            -2147483648});
            this.numeric_min.Name = "numeric_min";
            this.numeric_min.Size = new System.Drawing.Size(152, 31);
            this.numeric_min.TabIndex = 0;
            // 
            // numeric_max
            // 
            this.numeric_max.Location = new System.Drawing.Point(355, 114);
            this.numeric_max.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numeric_max.Minimum = new decimal(new int[] {
            10000,
            0,
            0,
            -2147483648});
            this.numeric_max.Name = "numeric_max";
            this.numeric_max.Size = new System.Drawing.Size(152, 31);
            this.numeric_max.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(138, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 21);
            this.label2.TabIndex = 1;
            this.label2.Text = "Bar_Min";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(377, 80);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 21);
            this.label4.TabIndex = 1;
            this.label4.Text = "Bar_Max";
            // 
            // btn_Confirm
            // 
            this.btn_Confirm.Location = new System.Drawing.Point(122, 203);
            this.btn_Confirm.Name = "btn_Confirm";
            this.btn_Confirm.Size = new System.Drawing.Size(135, 53);
            this.btn_Confirm.TabIndex = 4;
            this.btn_Confirm.Text = "确认";
            this.btn_Confirm.UseVisualStyleBackColor = true;
            this.btn_Confirm.Click += new System.EventHandler(this.btn_Confirm_Click);
            // 
            // btn_Cancel
            // 
            this.btn_Cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn_Cancel.Location = new System.Drawing.Point(328, 203);
            this.btn_Cancel.Name = "btn_Cancel";
            this.btn_Cancel.Size = new System.Drawing.Size(135, 53);
            this.btn_Cancel.TabIndex = 5;
            this.btn_Cancel.Text = "取消";
            this.btn_Cancel.UseVisualStyleBackColor = true;
            this.btn_Cancel.Click += new System.EventHandler(this.btn_Cancel_Click);
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("隶书", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label5.Location = new System.Drawing.Point(258, 120);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(92, 38);
            this.label5.TabIndex = 3;
            this.label5.Text = "~";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cbx_Auto
            // 
            this.cbx_Auto.AutoSize = true;
            this.cbx_Auto.Location = new System.Drawing.Point(355, 25);
            this.cbx_Auto.Name = "cbx_Auto";
            this.cbx_Auto.Size = new System.Drawing.Size(141, 25);
            this.cbx_Auto.TabIndex = 6;
            this.cbx_Auto.Text = "自适应状态";
            this.cbx_Auto.UseVisualStyleBackColor = true;
            // 
            // 强度设定
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(616, 323);
            this.Controls.Add(this.cbx_Auto);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btn_Cancel);
            this.Controls.Add(this.btn_Confirm);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.numeric_max);
            this.Controls.Add(this.numeric_min);
            this.Name = "强度设定";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "强度设定";
            ((System.ComponentModel.ISupportInitialize)(this.numeric_min)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numeric_max)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.NumericUpDown numeric_min;
        private System.Windows.Forms.NumericUpDown numeric_max;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btn_Confirm;
        private System.Windows.Forms.Button btn_Cancel;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.CheckBox cbx_Auto;
    }
}