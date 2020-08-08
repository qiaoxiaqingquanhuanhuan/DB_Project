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
    public partial class Formmain : Form
    {
        public Formmain()
        {
            InitializeComponent();
        }

        private void btn_sale_Click(object sender, EventArgs e)
        {
            //
            Form_SaleResult FormResult = new Form_SaleResult();
            //if (查询数据库比较存在该日期)
            //    则执行以下部分在结果框显示结果
            //    把查询主窗体的日期信息传给查询的显示结果窗体
            FormResult.year = dtp_sale.Value.Year.ToString();
            FormResult.month = dtp_sale.Value.Month.ToString();
            FormResult.day = dtp_sale.Value.Day.ToString();
            FormResult.ShowDialog(this);//用formmain唤醒formresult
            //else //否则就在提示显示查询日期不存在
            //MessageBox.Show("The date you type in isn't existed!");
        }

        private void btn_salemoney_Click(object sender, EventArgs e)
        {
            //
            Form_SaleMoneyResult FormResult = new Form_SaleMoneyResult();
            //if (查询数据库比较存在该日期)
            //    则执行以下部分在结果框显示结果
            //    把查询主窗体的日期信息传给查询的显示结果窗体
            FormResult.year = dtp_salemoney.Value.Year.ToString();
            FormResult.month = dtp_salemoney.Value.Month.ToString();
            FormResult.day = dtp_salemoney.Value.Day.ToString();
            FormResult.ShowDialog(this);//用formmain唤醒formresult
            //else //否则就在提示显示查询日期不存在
            //MessageBox.Show("The date you type in isn't existed!");
        }

        private void btn_monthsale_Click(object sender, EventArgs e)
        {
            //
            Form_MonthSaleResult FormResult = new Form_MonthSaleResult();
            //if (查询数据库比较存在该日期)
            //    则执行以下部分在结果框显示结果
            //    把查询主窗体的日期信息传给查询的显示结果窗体
            FormResult.year = dtp_monthsale.Value.Year.ToString();
            FormResult.ShowDialog(this);//用formmain唤醒formresult
            //else //否则就在提示显示查询日期不存在
            //MessageBox.Show("The date you type in isn't existed!");
        }

        private void btn_monthsalemoney_Click(object sender, EventArgs e)
        {
            //
            Form_MonthSaleMoneyResult FormResult = new Form_MonthSaleMoneyResult();
            //if (查询数据库比较存在该日期)
            //    则执行以下部分在结果框显示结果
            //    把查询主窗体的日期信息传给查询的显示结果窗体
            FormResult.year = dtp_monthsalemoney.Value.Year.ToString();
            FormResult.ShowDialog(this);//用formmain唤醒formresult
            //else //否则就在提示显示查询日期不存在
            //MessageBox.Show("The date you type in isn't existed!");
        }
    }
}
