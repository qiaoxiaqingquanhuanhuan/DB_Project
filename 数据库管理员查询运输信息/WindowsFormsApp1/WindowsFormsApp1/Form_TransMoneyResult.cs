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
    public partial class Form_TransMoneyResult : Form
    {
        public Form_TransMoneyResult()
        {
            InitializeComponent();
        }

        public string year, month, day;

        private void Form_AvgMoneyResult_Load(object sender, EventArgs e)
        {
            lbl_date.Text = lbl_date.Text.ToString() + year + "年" + month + "月" + day + "日";
        }
    }
}
