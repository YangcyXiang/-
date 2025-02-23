using DAQmx.Helper;
using Microsoft.VisualBasic;
using ScottPlot.Plottable;
using ScottPlot;
using SeeSharpTools.JY.ArrayUtility;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using WeifenLuo.WinFormsUI.Docking;

namespace DAQmx
{    
    public partial class DAQchartView : DockContent
    {
        private CancellationTokenSource cts;
        private DAQmxHelper _DAQmaxHelper = DAQmxHelper.GetInstance();
        private ManualResetEvent manual = new ManualResetEvent(true);//默认开启！！！！！
        private int sleepTime;
        public DAQchartView()
        {
            InitializeComponent();
            sleepTime = 1000;
        }
        private void DAQchartView_Load(object sender, EventArgs e)
        {
            _DAQmaxHelper.WaveData = new double[1000,2];
            cts = new CancellationTokenSource();
            Task.Factory.StartNew(() => UpdateLoop());
        }

        private void UpdateLoop()
        {
            while (!cts.IsCancellationRequested)
            {
                try
                {
                    manual.WaitOne();
                    Action act = () => { easyChartX1.Plot(_DAQmaxHelper.WaveData, majorOrder: SeeSharpTools.JY.GUI.MajorOrder.Column); };
                    easyChartX1.Invoke(act);
                    Thread.Sleep(sleepTime);
                }
                catch (Exception)
                {

                    //throw;
                }

            }

        }
        private void easyChartX1_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Copy;
        }

        private void easyChartX1_DragDrop(object sender, DragEventArgs e)
        {

        }



        private void DAQchartView_FormClosing(object sender, FormClosingEventArgs e)
        {

        }

        private void 刷新时间ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var k = Interaction.InputBox("刷新时间(ms)：", "输入数字", "1000");
            if (k != "")
            {
                sleepTime = Convert.ToInt32(k);
            }
        }


        private void 暂停刷新ToolStripMenuItemToolStripMenuItem_Click(object sender, EventArgs e)
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
    }
}