using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace 管理员
{
    class DB我的信息
    {
        private const String connStr = "server=localhost;database=class_1;uid=root;pwd=12345678";//连接数据库的基本信息

        public int id;//管理员ID
        public char name;//管理员姓名
        public void get_name(int id)//通过ID获取姓名
        {
            using (MySqlConnection conn = new MySqlConnection(connStr))
            {
                conn.Open();
                using (MySqlCommand cmd = new MySqlCommand())//创建查询命令
                {
                    string sql = "select * from administrator where ID=@id";//sql语句
                    cmd.Connection = conn;
                    cmd.CommandText = sql;
                    MySqlDataReader rd = cmd.ExecuteReader();//执行查询操作
                    while (rd.Read())//每次循环查询一行
                    {
                        name = rd.GetChar("adm_name");
                    }
                }
            }
        }
    }
}
