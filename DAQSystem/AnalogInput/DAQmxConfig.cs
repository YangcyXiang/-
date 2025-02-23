using DAQmx.Helper;
using SeeSharpTools.JY.File;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Runtime.CompilerServices;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace DAQmx
{
    public partial class DAQmxConfig : Form
    {
        //private ReportInfo _report = ReportInfo.GetInstance();
        private DAQmxHelper _DAQmaxHelper = DAQmxHelper.GetInstance();
        string iniPath = Environment.CurrentDirectory + "\\config" + "\\DAQIni.ini";

        public DAQmxConfig()
        {
            InitializeComponent();

            _DAQmaxHelper.IsConfigFinish = false;
        }


        #region UI操作
        private void DAQmxConfig_Load(object sender, EventArgs e)
        {
            cbx_DifferentialChannels.SelectedIndex = 0;

            LoadIni(iniPath);
        }

        private void btn_Confirm_Click(object sender, EventArgs e)
        {
            _DAQmaxHelper.SampleRate = (double)numericUpDown_sampleRate.Value;
            _DAQmaxHelper.SampleToAcquire = (int)numericUpDown_sampleRate.Value;
            _DAQmaxHelper.Rowsnum = (int)numeric_Rowsnum.Value;
            _DAQmaxHelper.Colsnum = (int)numeric_Colnum.Value;
            _DAQmaxHelper.DifferetialChannels = Convert.ToInt32(cbx_DifferentialChannels.Text);
            _DAQmaxHelper.EnalbeDarkSignal = cbx_EnableDarkSignal.Checked;
            _DAQmaxHelper.DarkSignalPath = tbx_DarkSignalPath.Text;
            _DAQmaxHelper.IsConfigFinish = true;

            _DAQmaxHelper.saveRollingFlag = cbx_SaveFlag.Checked;
            _DAQmaxHelper.saveRollingPath = tbx_Path.Text;
            _DAQmaxHelper.RetriggerNum = (int)numericUpDown_RetriggerNum.Value;

            this.Close();
        }

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            _DAQmaxHelper.IsConfigFinish = false;
            this.Close();
        }


        private void saveIni(string filePath)
        {
            IniData iniData = new IniData();
            // 如果不包含当前section，则新增section
            if (!iniData.Sections.ContainsSection("采样配置"))
            {
                iniData.Sections.RemoveSection("采样配置");
                iniData.Sections.Add(new SectionData("采样配置"));
            }
            else
            {
                iniData.Sections.Add(new SectionData("采样配置"));
            }
            iniData.Sections["采样配置"].AddKey("采样率", numericUpDown_sampleRate.Value.ToString());
            iniData.Sections["采样配置"].AddKey("存储路径", tbx_Path.Text);
            iniData.Sections["采样配置"].AddKey("数据存储", cbx_SaveFlag.Checked.ToString());
            iniData.Sections["采样配置"].AddKey("差分通道数", cbx_DifferentialChannels.SelectedIndex.ToString());
            iniData.Sections["采样配置"].AddKey("运行帧数", numericUpDown_RetriggerNum.Value.ToString());



            if (!iniData.Sections.ContainsSection("图像配置"))
            {
                iniData.Sections.RemoveSection("图像配置");
                iniData.Sections.Add(new SectionData("图像配置"));
            }
            else
            {
                iniData.Sections.Add(new SectionData("图像配置"));
            }
            iniData.Sections["图像配置"].AddKey("行数值", numeric_Rowsnum.Value.ToString());
            iniData.Sections["图像配置"].AddKey("列数值", numeric_Colnum.Value.ToString());
            iniData.Sections["图像配置"].AddKey("暗背景路径", tbx_DarkSignalPath.Text);
            iniData.Sections["图像配置"].AddKey("加载暗背景", cbx_EnableDarkSignal.Checked.ToString());
            IniHandler.WriteIniFile(filePath, iniData);

        }

        private void btn_SaveMotorConfig_Click(object sender, EventArgs e)
        {
            saveFileDialog1.Filter = "配置文件(*.ini)|*.ini";
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                saveIni(saveFileDialog1.FileName);
            }

         }


        #endregion

        #region 私有方法


        private void LoadIni(string LoadFilePath)
        {
            IniData iniData = IniHandler.ReadIniFile(LoadFilePath);

            if (iniData.Sections.ContainsSection("采样配置"))
            {
                numericUpDown_sampleRate.Value = Convert.ToDecimal(iniData.Sections["采样配置"].GetKeyData("采样率").Value);
                tbx_Path.Text = iniData.Sections["采样配置"].GetKeyData("存储路径").Value;
                cbx_SaveFlag.Checked = Convert.ToBoolean(iniData.Sections["采样配置"].GetKeyData("数据存储").Value);
                cbx_DifferentialChannels.SelectedIndex = Convert.ToInt32(iniData.Sections["采样配置"].GetKeyData("差分通道数").Value);
                numericUpDown_RetriggerNum.Value = Convert.ToDecimal(iniData.Sections["采样配置"].GetKeyData("运行帧数").Value);



            }
            if (iniData.Sections.ContainsSection("图像配置"))
            {

                numeric_Rowsnum.Value = Convert.ToDecimal(iniData.Sections["图像配置"].GetKeyData("行数值").Value);
                numeric_Colnum.Value = Convert.ToDecimal(iniData.Sections["图像配置"].GetKeyData("列数值").Value);
                tbx_DarkSignalPath.Text = iniData.Sections["图像配置"].GetKeyData("暗背景路径").Value;
                cbx_EnableDarkSignal.Checked = Convert.ToBoolean(iniData.Sections["图像配置"].GetKeyData("加载暗背景").Value);
            }
        }


        #endregion

        private void btn_LoadMotorConfig_Click_1(object sender, EventArgs e)
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
        FolderBrowserDialog folderDialog;
        private void btn_Browser_Click(object sender, EventArgs e)
        {
            folderDialog = new FolderBrowserDialog();
            //folderDialog.RootFolder = Environment.SpecialFolder.DesktopDirectory ;
            // 检查用户是否点击了“确定”按钮
            if (folderDialog.ShowDialog() == DialogResult.OK)
            {
                // 用户选择的文件夹路径
                tbx_Path.Text = folderDialog.SelectedPath;
            }
        }

        private void numericUpDown_RetriggerNum_ValueChanged(object sender, EventArgs e)
        {

        }

        private void btn_DarkSignalBrowser_Click(object sender, EventArgs e)
        {
            var fileDialog = new OpenFileDialog();
            fileDialog.Filter = "CSV文件(*.csv)|*.csv";//过滤文件类型只能为csv
            fileDialog.RestoreDirectory = false;//每次打开位置与上一次相同
            // 检查用户是否点击了“确定”按钮
            if (fileDialog.ShowDialog() == DialogResult.OK)
            {
                // 用户选择的文件夹路径
                tbx_DarkSignalPath.Text = fileDialog.FileName;
            }
        }

        private void DAQmxConfig_FormClosing(object sender, FormClosingEventArgs e)
        {
            saveIni(iniPath);
        }
    }
}
