using DAQmx.Helper;
using JY9818;
using SeeSharpTools.JY.ArrayUtility;
using SeeSharpTools.JY.File;
using System;
using System.Diagnostics;
using System.IO;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using WeifenLuo.WinFormsUI.Docking;

namespace DAQmx
{
    public partial class MainForm : DockContent
    {
      
        public DAQchartView _DAQchartView;
        private DAQspectrumView _DAQspectrumView;

        private CancellationTokenSource cts;
        //定义实际最小采样率
        private JY9818AITask aitask;
        private DAQmxHelper _DAQmaxHelper = DAQmxHelper.GetInstance();


        private int ImageRows;
        private int ImageCols;
        private int totalSampleNum;
        private double[,] darkSignalData;
        /// <summary>
        /// 已经完成的重触发次数
        /// </summary>
        private ulong finishedRetrigCnt;
        /// <summary>
        /// 每次循环从缓冲区读取的触发次数
        /// </summary>
        double[,] displayValue;
        private double[,] readValue;

        private double[,] image;

        //这部分可以调试时候进行
        public MainForm()
        {
            InitializeComponent();
            Control.CheckForIllegalCrossThreadCalls = false;
            ribbonPanel_operation.Enabled = false;
            ribbonPanel_waveform.Enabled = false;
        }

        private void ribbonButton_daqConfig_Click(object sender, EventArgs e)
        {
            var formconfig = new DAQmxConfig();
            formconfig.ShowDialog();
            if (_DAQmaxHelper.IsConfigFinish)
            {
                ribbonPanel_operation.Enabled = true;
                ribbonPanel_waveform.Enabled = true;
                _DAQmaxHelper.ViewData = new double[_DAQmaxHelper.Rowsnum, _DAQmaxHelper.Colsnum];
                
            }
        }

        private void writeRaw(double[,] image)
        {
            // 获取当前日期和时间
            DateTime currentTime = DateTime.Now;

            // 分别获取年、月、日、时、分、秒
            int year = currentTime.Year;
            int month = currentTime.Month;
            int day = currentTime.Day;
            int hour = currentTime.Hour;
            int minute = currentTime.Minute;
            int second = currentTime.Second;

            // 格式化成下划线分隔的字符串
            string formattedDateTime = string.Format("{0}_{1}_{2}_{3}_{4}_{5}", year, month, day, hour, minute, second);
            FileStream fs = new FileStream(_DAQmaxHelper.saveRollingPath+"\\"+formattedDateTime+".raw", FileMode.Create);
            BinaryWriter writer = new BinaryWriter(fs);
            for (int i = 0; i < image.GetLength(0); i++)
            {
                for (int j = 0; j < image.GetLength(1); j++)
                {
                    writer.Write(Convert.ToUInt32(image[i, j]));
                }
            }
            writer.Close();
            fs.Close();
        }

        /// <summary>
        /// 符合JY板卡的多通道输出写入数组转置并转成float数据类型的二进制文件
        /// </summary>
        /// <param name = "bufin" ></ param >
        /// < param name="channelcount"></param>
        /// <param name = "bufout" ></ param >
        public void WriteConvert(double[,] bufin, ref byte[] bufout)
        {
            Buffer.BlockCopy(bufin, 0, bufout, 0, bufin.Length * sizeof(double));
        }

        private void DaqLoop()
        {
            int cnt = 0;
            int o = 0;
            aitask.Start();
            Stopwatch sp = new Stopwatch();
            sp.Restart();
            while (!cts.IsCancellationRequested)
            {
                aitask.ReadData(ref readValue, -1);
                //数据更新内容

                _DAQmaxHelper.WaveData = readValue;
                double[,] vout1 = new double[totalSampleNum, _DAQmaxHelper.DifferetialChannels];
                double[,] vout2 = new double[totalSampleNum, _DAQmaxHelper.DifferetialChannels];
                double[,] deltaImage = new double[totalSampleNum, _DAQmaxHelper.DifferetialChannels];
                for (int i = 0; i < totalSampleNum; i++)
                {
                    for (int j = 0; j < _DAQmaxHelper.DifferetialChannels; j++)
                    {
                        vout1[i, j ] = readValue[i + 1, j * 2];//i+1是舍掉了一个点进行的操作
                        vout2[i, j] = readValue[i + 1, j * 2 + 1];

                        deltaImage[i, j] = vout1[i, j]- vout2[i, j]; //vout1是vout1 vout2是vout2
                    }
                }

                if (_DAQmaxHelper.saveRollingFlag)
                {
                    CsvHandler.WriteData(_DAQmaxHelper.saveRollingPath + "\\vout1_" + (o + 1).ToString() + ".csv", imageProcess(vout1, _DAQmaxHelper.Rowsnum, _DAQmaxHelper.Colsnum), WriteMode.OverLap);
                    CsvHandler.WriteData(_DAQmaxHelper.saveRollingPath + "\\vout2_" + (o + 1).ToString() + ".csv", imageProcess(vout2, _DAQmaxHelper.Rowsnum, _DAQmaxHelper.Colsnum), WriteMode.OverLap);
                    CsvHandler.WriteData(_DAQmaxHelper.saveRollingPath + "\\delta_" + (o + 1).ToString() + ".csv", imageProcess(deltaImage, _DAQmaxHelper.Rowsnum, _DAQmaxHelper.Colsnum), WriteMode.OverLap);
                    o++;//记录时候进行+1
                }

                double[,] imageOrig = imageProcess(deltaImage, _DAQmaxHelper.Rowsnum, _DAQmaxHelper.Colsnum);

                for (int i = 0; i < imageOrig.GetLength(0); i++)
                {
                    for (int j = 0; j < imageOrig.GetLength(1); j++)
                    {
                        imageOrig[i, j] = imageOrig[i, j] - darkSignalData[i, j];
                    }
                }

                _DAQmaxHelper.ViewData = imageOrig;
                
                if (_DAQmaxHelper.RetriggerNum == -1)
                {
                    cnt = -100;//永远不可能大于等于-1
                }
                else
                {
                    cnt++;

                }
                if (cnt>= _DAQmaxHelper.RetriggerNum)
                {
                    cts.Cancel();
                }


            }

            Console.WriteLine(sp.ElapsedMilliseconds.ToString());
            sp.Stop();
        }

        //List<double[,]> tempSaveList = new List<double[,]>();

        private async void ribbonButton_start_Click(object sender, EventArgs e)
        {
            //第一步确认采样点数
            //5 + (行数) *（列数 / 通道数 + 8）
            #region 舍掉一个点操作
            if (_DAQmaxHelper.EnalbeDarkSignal == true)
            {
                darkSignalData =  CsvHandler.ReadDoubleData(_DAQmaxHelper.DarkSignalPath);
            }
            else
            {
                darkSignalData = new double[_DAQmaxHelper.Rowsnum, _DAQmaxHelper.Colsnum];
            }

            totalSampleNum = 5 + _DAQmaxHelper.Rowsnum * (_DAQmaxHelper.Colsnum / _DAQmaxHelper.DifferetialChannels + 8);
            cts = new CancellationTokenSource();
            //配置完成重触发数据
            aitask = new JY9818AITask(0);        // 主卡AI任务
            aitask.RemoveChannel(-1);

            //基本参数配置
            aitask.Mode = AIMode.Finite;
            //比要采集的数据多一个就行了
            aitask.SamplesToAcquire = (ulong)(totalSampleNum + 1);
            aitask.SampleRate = _DAQmaxHelper.SampleRate;


            switch (_DAQmaxHelper.DifferetialChannels)
            {
                case 1:
                    for (int i = 0; i < 2; i++)
                    {
                        aitask.AddChannel(i, -5, 5, AICoupling.DC, AIImpedance.ImpedanceHigh);
                    }
                    break;
                case 2:
                    for (int i = 0; i < 4; i++)
                    {
                        aitask.AddChannel(i, -5, 5, AICoupling.DC, AIImpedance.ImpedanceHigh);
                    }
                    break;
                case 4:
                    for (int i = 0; i < 8; i++)
                    {
                        aitask.AddChannel(i, -5, 5, AICoupling.DC, AIImpedance.ImpedanceHigh);
                    }
                    break;
                default:
                    for (int i = 0; i < 2; i++)
                    {
                        aitask.AddChannel(i, -5, 5, AICoupling.DC, AIImpedance.ImpedanceHigh);
                    }
                    break;
            }



            aitask.Trigger.ReTriggerCount = _DAQmaxHelper.RetriggerNum;
            aitask.Trigger.Type = AITriggerType.Digital;
            aitask.Trigger.Mode = AITriggerMode.Start;
            aitask.Trigger.Digital.Source = AIDigitalTriggerSource.PXI_Trig2;//(AIDigitalTriggerSource)Enum.Parse(typeof(AIDigitalTriggerSource), comboBox_triggerSource.Text, true);
            aitask.Trigger.Digital.Edge = AIDigitalTriggerEdge.Rising;

           // aitask.SampleClock.Source.re

            aitask.SampleClock.Source = AISampleClockSource.KClock;
            aitask.KClockSource = AIKClockSource.PXI_Trig5;

            //触发配置
            ImageRows = _DAQmaxHelper.Colsnum;
            ImageCols = _DAQmaxHelper.Rowsnum;
            // 数组初始化
            readValue = new double[aitask.SamplesToAcquire, aitask.Channels.Count];

            //
            image = new double[ImageRows, ImageCols];
            _DAQmaxHelper.ViewData = image;
            ribbonButton_start.Enabled = false;




            await Task.Factory.StartNew(() => DaqLoop());

            #endregion



            aitask.Stop();
            // 去除添加通道
            aitask.Channels.Clear();

            ribbonButton_start.Enabled = true;
            ribbonPanel_AIConfig.Enabled = true;
            ribbonButton_start.Enabled = true;
        }


        //这个位置写成静态类
        private void updateImage(double[,] result, ref double[,] image)
        {
            // 创建随机数生成器
            Random random = new Random();

            // 进行100次循环
            for (int i = 0; i < 100; i++)
            {
                // 随机选择行和列
                int row = random.Next(0, image.GetLength(0));
                int col = random.Next(0, image.GetLength(1));

                // 选定的元素加1
                image[row, col]++;
            }
        }

        /// <summary>
        /// 图像处理函数, 5+（M+8）*（N）个数据的数组，将前5个数据进行删除，然后帮我组成一个N行，M+8列的数组，然后把每行后8个数据去掉，最终得到N行，M列的数组。
        /// </summary>
        /// <param name="rawData"></param>
        /// <param name="Rows"></param>
        /// <param name="Cols"></param>
        /// <returns></returns>
        public  double[,] imageProcess(double[,] rawData, int Rows, int Cols)
        {
            //分裂列数
            int splitColsNum = rawData.GetLength(1);
            //创建最终返回数组
            double[,] finalArray = new double[Rows, Cols];
            // 创建[][,]数组
            double[][,] tempArray = new double[splitColsNum][,];
            //数值是否匹配
            if (rawData.GetLength(0) == 5 + (Cols / splitColsNum + 8) * Rows)
            {
                for (int i = 0; i < splitColsNum; i++)
                {
                    tempArray[i] = new double[Rows, Cols / splitColsNum];
                    //提起第一行进行处理
                    double[] tempRawDataCols = new double[rawData.GetLength(0)];
                    ArrayManipulation.GetArraySubset(rawData, i, ref tempRawDataCols, ArrayManipulation.IndexType.column);
                    // 删除前5个元素
                    double[] modifiedArray = new double[tempRawDataCols.Length - 1];
                    Array.Copy(tempRawDataCols, 5, modifiedArray, 0, tempRawDataCols.Length - 5);
                    // 创建N行，M+8列的数组
                    double[,] reshapedArray = new double[Rows, Cols/splitColsNum + 8];
                    for (int n = 0; n < Rows; n++)
                    {
                        for (int m = 0; m < Cols/splitColsNum + 8; m++)
                        {
                            reshapedArray[n, m] = modifiedArray[n * (Cols / splitColsNum + 8) + m];
                        }
                    }
                    //整体修改成r c也行
                    for (int n = 0; n < Rows; n++)
                    {
                        for (int m = 0; m < Cols/splitColsNum; m++)
                        {
                            tempArray[i][n, m] = reshapedArray[n, m];
                        }
                    }
                }

                // 创建最终的N行，M列的数组
                // 使用列交织的方式填充新数组
                for (int row = 0; row < Rows; row++)
                {
                    for (int col = 0; col < Cols; col++)
                    {
                        int arrayIndex = (col % splitColsNum); // 确定当前列来自哪个数组
                        int arrayCol = (col / splitColsNum); // 确定来自该数组的哪一列
                        finalArray[row, col] = tempArray[arrayIndex][row, arrayCol];
                    }
                }


            }






            return finalArray;
        }

        private void ribbonButton_channels_Click(object sender, EventArgs e)
        {
            //显示节点管理面板窗口，并设置其显示比例


            Application.DoEvents();
        }

        private void ribbonButton_waveform_Click(object sender, EventArgs e)
        {
            _DAQchartView = new DAQchartView();
            _DAQchartView.AutoScroll = true;
            _DAQchartView.Show(dockPanel1);
        }

        private void ribbonButton_stop_Click(object sender, EventArgs e)
        {
            //IsDaqRunning = false;
            cts.Cancel();
        }


        private void ribbonButton_SpectrumWave_Click(object sender, EventArgs e)
        {
            _DAQspectrumView = new DAQspectrumView();
            _DAQspectrumView.AutoScroll = true;
            _DAQspectrumView.Show(dockPanel1);
        }




        private void ribbonButton_DOConfig_Click(object sender, EventArgs e)
        {
            var frm = new DOConfigForm();
            frm.Show();
        }

        private void dockPanel1_ActiveContentChanged(object sender, EventArgs e)
        {

        }
    }
}
