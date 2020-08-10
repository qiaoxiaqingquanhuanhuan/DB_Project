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
    public partial class 查询结果 : Form
    {
        public 查询结果()
        {
            InitializeComponent();
        }
        //加载“查询结果”窗体
        private void 查询结果_Load(object sender, EventArgs e)
        {
            this.Owner.Hide();//隐藏所有者窗体
        }
        //关闭“查询结果”窗体后
        private void 查询结果_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Owner.Show();//显示所有者窗体
        }
        //返回所有者窗体
        private void button_return_Click(object sender, EventArgs e)
        {
            this.Close();//关闭当前窗体
        }
    }
}
