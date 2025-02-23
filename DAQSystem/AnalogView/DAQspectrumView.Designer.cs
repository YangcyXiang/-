namespace DAQmx
{
    partial class DAQspectrumView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DAQspectrumView));
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripDropDownButton1 = new System.Windows.Forms.ToolStripDropDownButton();
            this.彩色图画ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.暂停刷新ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.刷新时间ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ZoomMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.保存RAWToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.保存CSVToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.强度BarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.formsPlot1 = new ScottPlot.FormsPlot();
            this.强度设定ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripDropDownButton1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 838);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Padding = new System.Windows.Forms.Padding(0, 0, 14, 0);
            this.statusStrip1.Size = new System.Drawing.Size(1438, 40);
            this.statusStrip1.TabIndex = 0;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripDropDownButton1
            // 
            this.toolStripDropDownButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripDropDownButton1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.彩色图画ToolStripMenuItem,
            this.暂停刷新ToolStripMenuItem,
            this.刷新时间ToolStripMenuItem,
            this.ZoomMenuItem,
            this.toolStripMenuItem1,
            this.保存RAWToolStripMenuItem,
            this.保存CSVToolStripMenuItem,
            this.强度BarToolStripMenuItem,
            this.强度设定ToolStripMenuItem});
            this.toolStripDropDownButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripDropDownButton1.Image")));
            this.toolStripDropDownButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripDropDownButton1.Name = "toolStripDropDownButton1";
            this.toolStripDropDownButton1.Size = new System.Drawing.Size(54, 36);
            this.toolStripDropDownButton1.Text = "toolStripDropDownButton1";
            // 
            // 彩色图画ToolStripMenuItem
            // 
            this.彩色图画ToolStripMenuItem.Name = "彩色图画ToolStripMenuItem";
            this.彩色图画ToolStripMenuItem.Size = new System.Drawing.Size(359, 44);
            this.彩色图画ToolStripMenuItem.Text = "彩色图画";
            this.彩色图画ToolStripMenuItem.Click += new System.EventHandler(this.彩色图画ToolStripMenuItem_Click);
            // 
            // 暂停刷新ToolStripMenuItem
            // 
            this.暂停刷新ToolStripMenuItem.Name = "暂停刷新ToolStripMenuItem";
            this.暂停刷新ToolStripMenuItem.Size = new System.Drawing.Size(359, 44);
            this.暂停刷新ToolStripMenuItem.Text = "暂停刷新";
            this.暂停刷新ToolStripMenuItem.Click += new System.EventHandler(this.暂停刷新ToolStripMenuItem_Click);
            // 
            // 刷新时间ToolStripMenuItem
            // 
            this.刷新时间ToolStripMenuItem.Name = "刷新时间ToolStripMenuItem";
            this.刷新时间ToolStripMenuItem.Size = new System.Drawing.Size(359, 44);
            this.刷新时间ToolStripMenuItem.Text = "刷新时间";
            this.刷新时间ToolStripMenuItem.Click += new System.EventHandler(this.刷新时间ToolStripMenuItem_Click);
            // 
            // ZoomMenuItem
            // 
            this.ZoomMenuItem.Name = "ZoomMenuItem";
            this.ZoomMenuItem.Size = new System.Drawing.Size(359, 44);
            this.ZoomMenuItem.Text = "缩放操作";
            this.ZoomMenuItem.Click += new System.EventHandler(this.ZoomMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(359, 44);
            this.toolStripMenuItem1.Text = "缩放恢复";
            this.toolStripMenuItem1.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
            // 
            // 保存RAWToolStripMenuItem
            // 
            this.保存RAWToolStripMenuItem.Name = "保存RAWToolStripMenuItem";
            this.保存RAWToolStripMenuItem.Size = new System.Drawing.Size(359, 44);
            this.保存RAWToolStripMenuItem.Text = "保存RAW";
            this.保存RAWToolStripMenuItem.Click += new System.EventHandler(this.保存RAWToolStripMenuItem_Click);
            // 
            // 保存CSVToolStripMenuItem
            // 
            this.保存CSVToolStripMenuItem.Name = "保存CSVToolStripMenuItem";
            this.保存CSVToolStripMenuItem.Size = new System.Drawing.Size(359, 44);
            this.保存CSVToolStripMenuItem.Text = "保存CSV";
            this.保存CSVToolStripMenuItem.Click += new System.EventHandler(this.保存CSVToolStripMenuItem_Click);
            // 
            // 强度BarToolStripMenuItem
            // 
            this.强度BarToolStripMenuItem.Name = "强度BarToolStripMenuItem";
            this.强度BarToolStripMenuItem.Size = new System.Drawing.Size(359, 44);
            this.强度BarToolStripMenuItem.Text = "强度Bar";
            this.强度BarToolStripMenuItem.Click += new System.EventHandler(this.强度BarToolStripMenuItem_Click);
            // 
            // formsPlot1
            // 
            this.formsPlot1.Location = new System.Drawing.Point(0, 0);
            this.formsPlot1.Margin = new System.Windows.Forms.Padding(7, 5, 7, 5);
            this.formsPlot1.Name = "formsPlot1";
            this.formsPlot1.Size = new System.Drawing.Size(1224, 743);
            this.formsPlot1.TabIndex = 1;
            // 
            // 强度设定ToolStripMenuItem
            // 
            this.强度设定ToolStripMenuItem.Name = "强度设定ToolStripMenuItem";
            this.强度设定ToolStripMenuItem.Size = new System.Drawing.Size(359, 44);
            this.强度设定ToolStripMenuItem.Text = "强度设定";
            this.强度设定ToolStripMenuItem.Click += new System.EventHandler(this.强度设定ToolStripMenuItem_Click);
            // 
            // DAQspectrumView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1438, 878);
            this.Controls.Add(this.formsPlot1);
            this.Controls.Add(this.statusStrip1);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "DAQspectrumView";
            this.TabText = "图像显示";
            this.Text = "图像显示";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.DAQspectrumView_FormClosing);
            this.Load += new System.EventHandler(this.DAQspectrumView_Load);
            this.SizeChanged += new System.EventHandler(this.DAQspectrumView_SizeChanged);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButton1;
        private System.Windows.Forms.ToolStripMenuItem 暂停刷新ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 刷新时间ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ZoomMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem 彩色图画ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 保存RAWToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 保存CSVToolStripMenuItem;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private ScottPlot.FormsPlot formsPlot1;
        private System.Windows.Forms.ToolStripMenuItem 强度BarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 强度设定ToolStripMenuItem;
    }
}