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
    public partial class 我的信息 : Form
    {
        public 我的信息()
        {
            InitializeComponent();
        }
        //加载“我的信息”窗体
        private void 我的信息_Load(object sender, EventArgs e)
        {  
            this.Owner.Hide();//隐藏所有者窗体，即“管理员”窗体
            
            //查询我的信息
            DB我的信息 db = new DB我的信息();
            label_ID_data.Text = db.id.ToString();//显示ID
            label_adm_name_data.Text = db.name.ToString();//显示姓名
        }
        //关闭“我的信息”窗体后
        private void 我的信息_FormClosed(object sender, FormClosedEventArgs e)
        {  
            this.Owner.Show();//显示所有者窗体，即“管理员”窗体
        }
        //返回所有者窗体，即“管理员”窗体
        private void button_return_Click(object sender, EventArgs e)
        {
            this.Close();//关闭当前窗体
        }
    }
}
