namespace DAQmx.AnalogView
{
    partial class SubArrayExtractorForm
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
            this.numeric_Ystart = new System.Windows.Forms.NumericUpDown();
            this.numeric_Xstart = new System.Windows.Forms.NumericUpDown();
            this.numeric_Yend = new System.Windows.Forms.NumericUpDown();
            this.numeric_Xend = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btn_Confirm = new System.Windows.Forms.Button();
            this.btn_Cancel = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numeric_Ystart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numeric_Xstart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numeric_Yend)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numeric_Xend)).BeginInit();
            this.SuspendLayout();
            // 
            // numeric_Ystart
            // 
            this.numeric_Ystart.Location = new System.Drawing.Point(96, 174);
            this.numeric_Ystart.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numeric_Ystart.Name = "numeric_Ystart";
            this.numeric_Ystart.Size = new System.Drawing.Size(166, 35);
            this.numeric_Ystart.TabIndex = 2;
            // 
            // numeric_Xstart
            // 
            this.numeric_Xstart.Location = new System.Drawing.Point(96, 84);
            this.numeric_Xstart.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numeric_Xstart.Name = "numeric_Xstart";
            this.numeric_Xstart.Size = new System.Drawing.Size(166, 35);
            this.numeric_Xstart.TabIndex = 0;
            // 
            // numeric_Yend
            // 
            this.numeric_Yend.Location = new System.Drawing.Point(369, 174);
            this.numeric_Yend.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numeric_Yend.Name = "numeric_Yend";
            this.numeric_Yend.Size = new System.Drawing.Size(166, 35);
            this.numeric_Yend.TabIndex = 3;
            // 
            // numeric_Xend
            // 
            this.numeric_Xend.Location = new System.Drawing.Point(369, 84);
            this.numeric_Xend.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numeric_Xend.Name = "numeric_Xend";
            this.numeric_Xend.Size = new System.Drawing.Size(166, 35);
            this.numeric_Xend.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(132, 137);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "Y-Start";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(132, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "X-start";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(417, 136);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 24);
            this.label3.TabIndex = 1;
            this.label3.Text = "Y-End";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(417, 45);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 24);
            this.label4.TabIndex = 1;
            this.label4.Text = "X-End";
            // 
            // btn_Confirm
            // 
            this.btn_Confirm.Location = new System.Drawing.Point(133, 265);
            this.btn_Confirm.Name = "btn_Confirm";
            this.btn_Confirm.Size = new System.Drawing.Size(147, 61);
            this.btn_Confirm.TabIndex = 4;
            this.btn_Confirm.Text = "确认";
            this.btn_Confirm.UseVisualStyleBackColor = true;
            this.btn_Confirm.Click += new System.EventHandler(this.btn_Confirm_Click);
            // 
            // btn_Cancel
            // 
            this.btn_Cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn_Cancel.Location = new System.Drawing.Point(352, 265);
            this.btn_Cancel.Name = "btn_Cancel";
            this.btn_Cancel.Size = new System.Drawing.Size(147, 61);
            this.btn_Cancel.TabIndex = 5;
            this.btn_Cancel.Text = "取消";
            this.btn_Cancel.UseVisualStyleBackColor = true;
            this.btn_Cancel.Click += new System.EventHandler(this.btn_Cancel_Click);
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("隶书", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label5.Location = new System.Drawing.Point(263, 91);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 44);
            this.label5.TabIndex = 3;
            this.label5.Text = "~";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("隶书", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label6.Location = new System.Drawing.Point(263, 183);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(100, 44);
            this.label6.TabIndex = 3;
            this.label6.Text = "~";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // SubArrayExtractorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(672, 369);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btn_Cancel);
            this.Controls.Add(this.btn_Confirm);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.numeric_Xend);
            this.Controls.Add(this.numeric_Xstart);
            this.Controls.Add(this.numeric_Yend);
            this.Controls.Add(this.numeric_Ystart);
            this.Name = "SubArrayExtractorForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "缩放提取";
            ((System.ComponentModel.ISupportInitialize)(this.numeric_Ystart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numeric_Xstart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numeric_Yend)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numeric_Xend)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown numeric_Ystart;
        private System.Windows.Forms.NumericUpDown numeric_Xstart;
        private System.Windows.Forms.NumericUpDown numeric_Yend;
        private System.Windows.Forms.NumericUpDown numeric_Xend;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btn_Confirm;
        private System.Windows.Forms.Button btn_Cancel;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
    }
}