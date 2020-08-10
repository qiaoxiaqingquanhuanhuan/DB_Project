using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 管理员
{
    public partial class 店铺评价 : Form
    {
        public 店铺评价()
        {
            InitializeComponent();
        }
        //加载“店铺评价”窗体
        private void 店铺评价_Load(object sender, EventArgs e)
        {
            this.Owner.Hide();//隐藏所有者窗体，即“店铺统计”窗体
        }
        //关闭“店铺评价”窗体后
        private void 店铺评价_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Owner.Show();//显示所有者窗体，即“店铺统计”窗体
        }
        //返回所有者窗体，即“店铺统计”窗体
        private void button_return_Click(object sender, EventArgs e)
        {
            this.Close();//关闭当前窗体
        }
        //确认所选择的日期类型
        private void button_confirm_date_Click(object sender, EventArgs e)
        {
            if (comboBox_date.SelectedIndex == 0)//选择了“年-月-日”
            {
                dateTimePicker_date.CustomFormat = "yyyy - MM - dd";//更改日期格式
                dateTimePicker_date.Visible = true;//显示日历
                dateTimePicker_date.Enabled = true;//启用日历
            }
            else if (comboBox_date.SelectedIndex == 1)//选择了“年-月”
            {
                dateTimePicker_date.CustomFormat = "yyyy - MM";//更改日期格式
                dateTimePicker_date.Visible = true;//显示日历
                dateTimePicker_date.Enabled = true;//启用日历
            }
            else if (comboBox_date.SelectedIndex == 2)//选择了“年”
            {
                dateTimePicker_date.CustomFormat = "yyyy";//更改日期格式
                dateTimePicker_date.Visible = true;//显示日历
                dateTimePicker_date.Enabled = true;//启用日历
            }
            else if (comboBox_date.SelectedIndex == 3)//选择了“历史累计”
            {
                dateTimePicker_date.Visible = false;//不显示日历
            }
            else//未进行选择
            {
                MessageBox.Show("请选择日期类型！");
            }
        }
    }
}
