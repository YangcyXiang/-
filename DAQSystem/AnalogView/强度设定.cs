
using DAQmx.Helper;
using System;
using System.Windows.Forms;

namespace DAQmx.AnalogView
{
    public partial class 强度设定 : Form
    {
        private DAQmxHelper _DAQmaxHelper = DAQmxHelper.GetInstance();
        public 强度设定()
        {
            InitializeComponent();
            numeric_max.Value = (decimal)_DAQmaxHelper.barMax;
            numeric_min.Value = (decimal)_DAQmaxHelper.barMin;
        }

        private void btn_Confirm_Click(object sender, EventArgs e)
        {
            if (cbx_Auto.Checked)
            {
                _DAQmaxHelper.barSetFlag = false;
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                if (numeric_max.Value > numeric_min.Value)
                {
                    _DAQmaxHelper.barMax = Convert.ToDouble(numeric_max.Value);
                    _DAQmaxHelper.barMin = Convert.ToDouble(numeric_min.Value);
                    _DAQmaxHelper.barSetFlag = true;
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
                else
                {

                    MessageBox.Show("范围超过数组边界!");
                }
            }



        }

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
