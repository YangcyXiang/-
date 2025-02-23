using SeeSharpTools.JY.File;
using SeeSharpTools.JY.GUI.DigitalChart;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using JY5411;
using System.Threading;
using System.IO;

namespace DAQmx
{
    public partial class DOConfigForm : Form
    {
        /// <summary>
        /// DO Task
        /// </summary>
        private JY5411DOTask doTask;
        private byte[,] writeData = null;
        /// <summary>
        /// json文件路径
        /// </summary>
        string iniPath = Environment.CurrentDirectory + "\\config" + "\\DOIni.ini";
        public DOConfigForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < 32; i++)
            {
                dataGridView_Config.Rows.Add();
                dataGridView_Config.Rows[i].HeaderCell.Value = i.ToString();
            }
            ///Call the enumeration of PowerLevel as a menu
            comboBox_setPowerLevel.Items.AddRange(Enum.GetNames(typeof(JY5411Device.PowerLevel)));
            comboBox_setPowerLevel.SelectedIndex = 3;

            LoadIni(iniPath);
        }

        private void btn_SaveConfig_Click(object sender, EventArgs e)
        {
            saveFileDialog1.Filter = "配置文件(*.ini)|*.ini";
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                saveIni(saveFileDialog1.FileName);
            }
        }

        private void saveIni(string filePath)
        {
            IniData iniData = new IniData();
            // 如果不包含当前section，则新增section
            if (!iniData.Sections.ContainsSection("参数配置"))
            {
                iniData.Sections.RemoveSection("参数配置");
                iniData.Sections.Add(new SectionData("参数配置"));
            }
            else
            {
                iniData.Sections.Add(new SectionData("参数配置"));
            }
            if (!iniData.Sections.ContainsSection("更新率"))
            {
                iniData.Sections.RemoveSection("更新率");
                iniData.Sections.Add(new SectionData("更新率"));
            }
            else
            {
                iniData.Sections.Add(new SectionData("更新率"));
            }
            for (int i = 0; i < dataGridView_Config.Rows.Count; i++)
            {
                iniData.Sections["参数配置"].AddKey(i.ToString(), (dataGridView_Config.Rows[i].Cells[0].Value != null ? dataGridView_Config.Rows[i].Cells[0].Value.ToString() : "") + "&&" + (dataGridView_Config.Rows[i].Cells[1].Value != null ? dataGridView_Config.Rows[i].Cells[1].Value.ToString() : ""));

            }
            iniData.Sections["更新率"].AddKey("更新率", numericUpDown_updateRate.Value.ToString());
            iniData.Sections["更新率"].AddKey("重复次数", numeric_RepeatNum.Value.ToString());
            iniData.Sections["更新率"].AddKey("连续", cbx_IsContinues.Checked.ToString());
            iniData.Sections["更新率"].AddKey("电平选择", comboBox_setPowerLevel.SelectedIndex.ToString());
            iniData.Sections["更新率"].AddKey("波形加载", tbx_FilePath.Text);
            IniHandler.WriteIniFile(filePath, iniData);
        }

        private void LoadIni(string LoadFilePath)
        {
            IniData iniData = IniHandler.ReadIniFile(LoadFilePath);
            if (iniData.Sections.ContainsSection("参数配置"))
            {
                int i = 0;
                foreach (KeyData keyData in iniData.Sections["参数配置"])
                {
                    //dataGridView_data.Rows.Add(sectionData.SectionName, keyData.KeyName, keyData.Value);
                    string str1 = keyData.Value.ToString().Replace("&&", "&");
                    string[] sArray = str1.Split('&');
                    if (sArray[0] == "")
                    {
                        dataGridView_Config.Rows[i].Cells[0].Value = false;
                    }
                    else
                    {
                        dataGridView_Config.Rows[i].Cells[0].Value = Convert.ToBoolean(sArray[0]);
                    }

                    dataGridView_Config.Rows[i].Cells[1].Value = sArray[1];
                    i++;
                }
            }
            if (iniData.Sections.ContainsSection("更新率"))
            {
                numericUpDown_updateRate.Value = Convert.ToDecimal(iniData.Sections["更新率"].GetKeyData("更新率").Value);
                numeric_RepeatNum.Value = Convert.ToDecimal(iniData.Sections["更新率"].GetKeyData("重复次数").Value);
                cbx_IsContinues.Checked = Convert.ToBoolean(iniData.Sections["更新率"].GetKeyData("连续").Value);
                comboBox_setPowerLevel.SelectedIndex = Convert.ToInt32(iniData.Sections["更新率"].GetKeyData("电平选择").Value);
                tbx_FilePath.Text = iniData.Sections["更新率"].GetKeyData("波形加载").Value.ToString();
            }
        }

        private void btn_LoadConfig_Click(object sender, EventArgs e)
        {
            OpenFileDialog IniPath = new OpenFileDialog();
            IniPath.Title = "选择文件";
            IniPath.Filter = "Ini文件(*.ini)|*.ini";//过滤文件类型只能为ini
            IniPath.RestoreDirectory = false;//每次打开位置与上一次相同

            if (IniPath.ShowDialog() == DialogResult.OK)
            {
                LoadIni(IniPath.FileName);

            }
        }

        private void btn_LoadDigWave_Click(object sender, EventArgs e)
        {
            double _step = 1.0 / (double)numericUpDown_updateRate.Value;
            var k = CsvHandler.Read<int>(tbx_FilePath.Text);
            writeData = new byte[k.GetLength(1), k.GetLength(0)];
            for (int i = 0; i < k.GetLength(0); i++)
            {
                for (int j = 0; j < k.GetLength(1); j++)
                {
                    writeData[j, i] = (byte)k[i, j];
                }
            }

            if (k.GetLength(0) == 1)
            {
                bool[] points = new bool[k.GetLength(1)];
                for (int i = 0; i < k.GetLength(1); i++)
                {
                    points[i] = Convert.ToBoolean(k[0, i]);
                }
            }
            if (k.GetLength(0) > 1 && k.GetLength(0) <= 8)
            {
                byte[] points = new byte[k.GetLength(1)];
                for (int i = 0; i < k.GetLength(1); i++)
                {
                    for (int j = 0; j < k.GetLength(0); j++)
                    {
                        points[i] |= (Byte)(Convert.ToByte(k[j, i]) << j);
                    }
                }
                digitalChart.Plot(points, 0, _step);
            }
            if (k.GetLength(0) > 8 && k.GetLength(0) <= 16)
            {
                short[] points = new short[k.GetLength(1)];
                for (int i = 0; i < k.GetLength(1); i++)
                {
                    for (int j = 0; j < k.GetLength(0); j++)
                    {
                        points[i] |= (short)(Convert.ToInt16(k[j, i]) << j);
                    }
                }
                digitalChart.Plot(points, 0, _step);
            }
            if (k.GetLength(0) > 16)
            {
                int[] points = new int[k.GetLength(1)];
                for (int i = 0; i < k.GetLength(1); i++)
                {
                    for (int j = 0; j < k.GetLength(0); j++)
                    {
                        points[i] |= (int)(Convert.ToInt32(k[j, i]) << j);
                    }
                }
                digitalChart.Plot(points, 0, _step);
            }

        }

        private void btn_WaveFileBrowser_Click(object sender, EventArgs e)
        {
            OpenFileDialog CsvPath = new OpenFileDialog();
            CsvPath.Title = "选择文件";
            CsvPath.Filter = "Ini文件(*.csv)|*.csv";//过滤文件类型只能为ini
            CsvPath.RestoreDirectory = false;//每次打开位置与上一次相同
            if (CsvPath.ShowDialog() == DialogResult.OK)
                tbx_FilePath.Text = CsvPath.FileName;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Random r = new Random();
            byte[,] data = new byte[9, 10000];
            for (int i = 0; i < data.GetLength(0); i++)
            {
                for (int j = 0; j < data.GetLength(1); j++)
                {
                    if (r.NextDouble() > 0.5)
                    {
                        data[i, j] = 1;
                    }
                    else
                    {
                        data[i, j] = 0;
                    }

                }
            }
            CsvHandler.WriteData(data);
        }

        private async void btn_SimuRun_Click(object sender, EventArgs e)
        {

            int cnt = 0;

            for (int i = 0; i < dataGridView_Config.Rows.Count; i++)
            {
                if (Convert.ToBoolean(dataGridView_Config.Rows[i].Cells[0].Value) == true)
                {
                    cnt++;
                }
            }

            if (cnt != writeData.GetLength(1))
            {
                MessageBox.Show("选择通道数需要和文本数组中通道数一致！");
            }



            btn_SimuRun.Enabled = false;
            try
            {
                //Create a new doTask based on the selected card slot number
                doTask = new JY5411DOTask(0);

                for (int i = 0; i < dataGridView_Config.Rows.Count; i++)
                {
                    if (Convert.ToBoolean(dataGridView_Config.Rows[i].Cells[0].Value) == true)
                    {
                        doTask.AddChannel(i);
                    }
                }

                //Basic parameter configuration
                if (cbx_IsContinues.Checked == true)
                {
                    doTask.Mode = DOMode.ContinuousWrapping;
                }
                else
                {
                    doTask.Mode = DOMode.Finite;
                }


                doTask.SampleClock.Source = DOSampleClockSource.Internal;//(DOSampleClockSource)Enum.Parse(typeof(DOSampleClockSource), comboBox_clockSource.Text, true);
                doTask.SignalExport.Add(DOSignalExportSource.DO_8, SignalExportDestination.PXI_Trig2);
                doTask.SignalExport.Add(DOSignalExportSource.DO_10, SignalExportDestination.PXI_Trig5);
                //数据
                // writeData();
                doTask.SamplesToUpdate = writeData.GetLength(0);
                doTask.Device.PFI.LogicLevel = (JY5411Device.PowerLevel)Enum.Parse(typeof(JY5411Device.PowerLevel), comboBox_setPowerLevel.Text, true);

                doTask.Device.ReferenceClock.External.Frequency = 100000000;
                doTask.Device.ReferenceClock.External.Terminal = ExternalReferenceClockTerminal.PXIe_Clk100;
                doTask.Device.ReferenceClock.Commit();

                doTask.UpdateRate = (double)numericUpDown_updateRate.Value;
                doTask.WriteData(writeData, (uint)doTask.SamplesToUpdate, -1);
                try
                {
                    //Start output
                    doTask.Start();
                }
                catch (JYDriverException ex)
                {
                    MessageBox.Show(ex.Message);
                    return;
                }
                if (cbx_IsContinues.Checked == true)
                {

                }
                else
                {
                    await Task.Factory.StartNew(() => {
                        while (!doTask.WaitUntilDone())
                        {
                            Thread.Sleep(100);
                        }

                    });
                    doTask.Stop();
                    btn_SimuRun.Enabled = true;
                }


            }
            catch (JYDriverException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btn_SimuStop_Click(object sender, EventArgs e)
        {
            if (cbx_IsContinues.Checked == true)
            {
                doTask.Stop();
                btn_SimuRun.Enabled = true;
            }
        }

        private void DOConfigForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            saveIni(iniPath);
        }

        /// <summary>
        /// 窗口关闭前将界面信息保存到Json文件中
        /// </summary>

    }
    /// <summary>
    /// 界面配置信息类
    /// </summary>
    public class DOFormParameter
    {
        public int UpdateRate;
        public int RepeatNum;
        public bool IsContinues;
        public int PowerLevelSelectIndex;
        public string WaveLoadPath;
    }
}
