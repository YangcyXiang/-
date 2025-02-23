using SeeSharpTools.JY.ArrayUtility;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using WeifenLuo.WinFormsUI.Docking;
using SeeSharpTools.JY.DSP.Fundamental;
using DAQmx.Helper;
using ScottPlot;
using ScottPlot.Drawing;
using DAQmx.AnalogView;
using ScottPlot.Plottable;
using Microsoft.VisualBasic;
using System.Security.Cryptography.X509Certificates;
using System.IO;
using SeeSharpTools.JY.File;

namespace DAQmx
{
    public partial class DAQspectrumView : DockContent
    {
        private bool isGray;
        private bool IsZoomFlag;
        private DAQmxHelper _DAQmaxHelper = DAQmxHelper.GetInstance();
        private double[,] zoomImage;
        private CancellationTokenSource cts;
        private ManualResetEvent manual = new ManualResetEvent(true);//默认开启！！！！！
        private int sleepTime;
        private ScottPlot.Plot plt;
        int startX0;//显示X坐标，OffSet使用
        int startY0;//显示Y坐标，OffSet使用
        int startX; // 子数组的起始X坐标
        int startY; // 子数组的起始Y坐标
        int width;  // 子数组的宽度
        int height; // 子数组的高度

        public DAQspectrumView()
        {
            InitializeComponent();
            plt = formsPlot1.Plot;
            plt.Margins(0, 0);
            plt.Clear();

            // 禁用右键拖动缩放
            formsPlot1.Configuration.Zoom = false;
            // 确保纵坐标刻度为整数
            //formsPlot1.Plot.YAxis.TickLabelFormat((value) => ((int)value).ToString());
            //formsPlot1.Plot.XAxis.TickLabelFormat((value) => ((int)value).ToString());
            //formsPlot1.Plot.YAxis.TickLabelFormat("1", true);
            //formsPlot1.Plot.XAxis.TickLabelFormat("1", true);
            // 禁用滚轮缩放
            formsPlot1.Configuration.ScrollWheelZoom = false;
            Control.CheckForIllegalCrossThreadCalls = false;
            IsZoomFlag = false;
            isGray = false;
            sleepTime = 1000;
        }

        private void DAQspectrumView_Load(object sender, EventArgs e)
        {
            cts = new CancellationTokenSource();
            Task.Factory.StartNew(()=>UpdateLoop());
        }


        private void UpdateLoop()
        {
            Heatmap hm;
            while (!cts.IsCancellationRequested)
            {
                manual.WaitOne();
                try
                {
                    if (IsZoomFlag)
                    {
                        for (int y = 0; y < width; y++)
                        {
                            for (int x = 0; x < height; x++)
                            {
                                zoomImage[x, y] = _DAQmaxHelper.ViewData[startX + x, startY + y];
                            }
                        }
                        plt.Clear();
                        if (isGray)
                        {

                            hm = plt.AddHeatmap(zoomImage, Colormap.Grayscale, lockScales: false);
                            hm.OffsetX = startX0;
                            hm.OffsetY = startY0;
                        }
                        else
                        {
                            hm = plt.AddHeatmap(zoomImage, Colormap.Turbo, lockScales: false);
                            hm.OffsetX = startX0;
                            hm.OffsetY = startY0;
                        }
                        if (强度BarToolStripMenuItem.Checked == true)
                        {
                            plt.AddColorbar(hm);
                        }
                        plt.Margins(0, 0);
                        formsPlot1.Render();
                    }
                    else
                    {
                        plt.Clear();
                        if (isGray)
                        {

                                hm = plt.AddHeatmap(_DAQmaxHelper.ViewData, Colormap.Grayscale, lockScales: false);
                            

                        }
                        else
                        {

                                hm = plt.AddHeatmap(_DAQmaxHelper.ViewData, Colormap.Turbo,lockScales:false);


                               
                        }
                        if (强度BarToolStripMenuItem.Checked == true)
                        {
                            plt.AddColorbar(hm);
                        }
                        plt.Margins(0, 0);
                        formsPlot1.Render();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }



                Thread.Sleep(sleepTime);
            }

        }

        private void DAQspectrumView_FormClosing(object sender, FormClosingEventArgs e)
        {
            cts.Cancel();
        }

        private void 暂停刷新ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (暂停刷新ToolStripMenuItem.Text == "暂停刷新")
            {
                manual.Reset();
                暂停刷新ToolStripMenuItem.Text = "继续刷新";
            }
            else
            {
                manual.Set();
                暂停刷新ToolStripMenuItem.Text = "暂停刷新";
            }
        }

        private void 刷新时间ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var k = Interaction.InputBox("刷新时间(ms)：", "输入数字", "1000");
            if (k != "")
            {
                sleepTime = Convert.ToInt32(k);
            }
        }

        private void ZoomMenuItem_Click(object sender, EventArgs e)
        {
            int[] nums = new int[6];
            var tempForm = new SubArrayExtractorForm(ref nums);
            if (DialogResult.OK == tempForm.ShowDialog())
            {
                startX = nums[0];
                startY = nums[1];
                width = nums[2];
                height = nums[3];
                startX0 = nums[4];
                startY0 = nums[5];
                zoomImage = new double[height, width];
                IsZoomFlag = true;
            }
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            IsZoomFlag = false;
        }

        private void 彩色图画ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (彩色图画ToolStripMenuItem.Text == "彩色图画")
            {
                isGray = true;
                彩色图画ToolStripMenuItem.Text = "灰度图画";
            }
            else
            {
                isGray = false;
                彩色图画ToolStripMenuItem.Text = "彩色图画";
            }
        }

        private void 保存RAWToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveFileDialog1.Filter = ".raw文档|*.raw";
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                FileStream fs = new FileStream(saveFileDialog1.FileName.ToString(), FileMode.Create);
                BinaryWriter writer = new BinaryWriter(fs);
                if (IsZoomFlag)
                {
                    for (int x = 0; x < width; x++)
                    {
                        for (int y = 0; y < height; y++)
                        {
                            zoomImage[x, y] = _DAQmaxHelper.ViewData[startX + x, startY + y];
                        }
                    }
                    for (int i = 0; i < zoomImage.GetLength(0); i++)
                    {
                        for (int j = 0; j < zoomImage.GetLength(1); j++)
                        {
                            writer.Write(Convert.ToUInt32(zoomImage[i, j]));
                        }
                    }
                }
                else
                {
                    for (int i = 0; i < _DAQmaxHelper.ViewData.GetLength(0); i++)
                    {
                        for (int j = 0; j < _DAQmaxHelper.ViewData.GetLength(1); j++)
                        {
                            writer.Write(Convert.ToUInt32(_DAQmaxHelper.ViewData[i, j]));
                        }
                    }
                }
                writer.Close();
                fs.Close();
            }
        }

        private void 保存CSVToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveFileDialog1.Filter = ".CSV文档|*.csv";
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                if (IsZoomFlag)
                {
                    for (int x = 0; x < width; x++)
                    {
                        for (int y = 0; y < height; y++)
                        {
                            zoomImage[x, y] = _DAQmaxHelper.ViewData[startX + x, startY + y];
                        }
                    }
                    CsvHandler.WriteData(saveFileDialog1.FileName.ToString(), zoomImage);

                }
                else
                {
                    CsvHandler.WriteData(saveFileDialog1.FileName.ToString(), _DAQmaxHelper.ViewData);
                }
            }
        }

        private void dBmVToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void DAQspectrumView_SizeChanged(object sender, EventArgs e)
        {
            Console.WriteLine($"Size: {this.Size.Width} x {this.Size.Height}");

            int formWidth = this.ClientSize.Width;
            int formHeight = this.ClientSize.Height - 40;//减去40是下面状态栏的位置空出来

            double cossizeX = 3 *_DAQmaxHelper.Colsnum;
            double cossizeY = 3*_DAQmaxHelper.Rowsnum;

            // 尽量占据整个窗体并保持4:3比例,4:3刚好是正方形
            int newWidth, newHeight;

            if (formWidth * cossizeY <= formHeight * cossizeX)
            {
                newWidth = formWidth;
                newHeight = (int)(formWidth * cossizeY / cossizeX);
            }
            else
            {
                newHeight = formHeight;
                newWidth = (int)(formHeight * cossizeX / cossizeY);
            }

            formsPlot1.Size = new Size(newWidth, newHeight);
        }

        private void 强度BarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            强度BarToolStripMenuItem.Checked = !强度BarToolStripMenuItem.Checked;
            if (强度BarToolStripMenuItem.Checked == false)
            {
                DAQspectrumView_SizeChanged(null,null);
            }
        }
    }
}