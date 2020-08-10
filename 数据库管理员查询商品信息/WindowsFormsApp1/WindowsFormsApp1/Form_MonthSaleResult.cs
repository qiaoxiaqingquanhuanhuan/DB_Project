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
    public partial class Form_MonthSaleResult : Form
    {
        public Form_MonthSaleResult()
        {
            InitializeComponent();
        }

        public string year;

        private void Form_MonthSaleResult_Load(object sender, EventArgs e)
        {
            lbl_date.Text = lbl_date.Text.ToString() + year + "年";
            //添加项
        }
    }
}
