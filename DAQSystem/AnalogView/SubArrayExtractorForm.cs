
using DAQmx.Helper;
using System;
using System.Windows.Forms;

namespace DAQmx.AnalogView
{
    public partial class SubArrayExtractorForm : Form
    {
        int startY0 ; // 子数组的起始X坐标
        int startX0; // 子数组的起始Y坐标
        int width;  // 子数组的宽度
        int height; // 子数组的高度
        int[] _Nums;
        private DAQmxHelper _DAQmaxHelper = DAQmxHelper.GetInstance();
        public SubArrayExtractorForm(ref int[] Nums)
        {
            InitializeComponent();
            _Nums = Nums;
        }

        private void btn_Confirm_Click(object sender, EventArgs e)
        {
            startY0 = Convert.ToInt32(numeric_Ystart.Value);
            startX0 = Convert.ToInt32(numeric_Xstart.Value);
            height = Convert.ToInt32(numeric_Yend.Value) - startY0;
            width = Convert.ToInt32(numeric_Xend.Value) - startX0;
            _Nums[0] = _DAQmaxHelper.Rowsnum - startY0 - height;
            _Nums[1] = startX0;
            _Nums[2] = width;
            _Nums[3] = height;
            _Nums[4] = startX0;
            _Nums[5] = startY0;
            if (startY0 >= 0 && startX0 >= 0 && startY0 + height <= _DAQmaxHelper.Rowsnum && startX0 + width <= _DAQmaxHelper.Colsnum)
            {
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {

                MessageBox.Show("范围超过数组边界!");
            }
        }

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
