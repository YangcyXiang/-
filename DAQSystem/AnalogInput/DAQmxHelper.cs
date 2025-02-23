using MathNet.Filtering.FIR;
using SeeSharpTools.JY.GUI;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Windows.Forms;

namespace DAQmx.Helper
{
    internal class DAQmxHelper
    {
        private bool isConfigFinish;
        private string savePath;
        private int saveFileTime;

        public int RetriggerNum;
        public  Barrier Rendezvous { get; set; }
        public  ManualResetEventSlim ViewDataSetEvent { get; set; }
        // 定义一个静态变量来保存类的实例
        private static DAQmxHelper uniqueInstance;

        public double SampleRate { get; set; }
        public bool IsAccumulate { get; set; }
        public int TriggerFreq { get; set; }
        public int Rowsnum { get; set; }
        public int Colsnum { get; set; }
        public bool EnalbeDarkSignal { get; set; }
        public string DarkSignalPath { get; set; }
        public int K_Num { get; set; }
        public int DifferetialChannels { get; set; }
        public int SampleToAcquire { get; set; }
        public double[,] ViewData { get; set; }
        public double[,] WaveData { get; set; }
        public bool saveRollingFlag { get; set; }
        public string saveRollingPath { get; set; }

        // 定义私有构造函数，使外界不能创建该类实例
        private DAQmxHelper()
        {
            Rendezvous = new Barrier(0);
            ViewDataSetEvent = new ManualResetEventSlim(false);
        }

        /// <summary>
        /// 定义公有方法提供一个全局访问点,提供全局访问点 同时你也可以定义公有属性来
        /// </summary>
        /// <returns></returns>
        public static DAQmxHelper GetInstance()
        {
            // 如果类的实例不存在则创建，否则直接返回
            if (uniqueInstance == null)
            {
                uniqueInstance = new DAQmxHelper();

            }
            return uniqueInstance;
        }

        public bool IsConfigFinish
        {
            get
            {
                return isConfigFinish;
            }

            set
            {
                isConfigFinish = value;
            }
        }
       
    }
}