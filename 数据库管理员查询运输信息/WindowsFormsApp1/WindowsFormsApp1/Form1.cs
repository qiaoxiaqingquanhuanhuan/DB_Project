using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_avgmoney_Click(object sender, EventArgs e)
        {
            //if (查询数据库比较存在该日期)
            //    则执行以下部分在结果框显示结果
            MessageBox.Show("平均运费为:");//查询结果加入到该语句中
            //else //否则就在提示显示查询日期不存在
            //MessageBox.Show("The date you type in isn't existed!");
        }

        private void btn_transmoney_Click(object sender, EventArgs e)
        {
            Form_TransMoneyResult FormResult = new Form_TransMoneyResult();
            //if (查询数据库比较存在该日期)
            //    则执行以下部分在结果框显示结果
            //    把查询主窗体的日期信息传给查询的显示结果窗体
            FormResult.year = dtp_transmoney.Value.Year.ToString();
            FormResult.month = dtp_transmoney.Value.Month.ToString();
            FormResult.day = dtp_transmoney.Value.Day.ToString();
            FormResult.ShowDialog(this);//用formmain唤醒formresult
            //else //否则就在提示显示查询日期不存在
            //MessageBox.Show("The date you type in isn't existed!");
        }
    }
}
