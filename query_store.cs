﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;


namespace Windows_Cshape
{
    class query_store    //店铺查询
    {

        static public string Date(int year, int month, int day)//日期处理
        {
            string Year, Month, Day;
            string dateTime = "%";
            if (year == -1)
            {
                return dateTime;
            }
            else
            {
                Year = year.ToString();
            }

            if (month == -1)
            {
                dateTime = Year + dateTime;
                return dateTime;
            }
            else if (month > 0 && month < 10)
            {
                Month = "0" + month.ToString();
            }
            else
            {
                Month = month.ToString();
            }

            if (day == -1)
            {
                dateTime = Year + "-" + Month + dateTime;
                return dateTime;
            }
            else if (day > 0 && day < 10)
            {
                Day = "0" + day.ToString();
            }
            else
            {
                Day = day.ToString();
            }
            dateTime = Year + "-" + Month + "-" + Day + dateTime;
            return dateTime;
        }



        static public void store_assess(int year, int month, int day)     //店铺评价查询
        {
            string date = Date(year, month, day);

            string connString = "server=localhost;database=db_mall;uid=root;pwd=1234";

            using (MySqlConnection conn = new MySqlConnection(connString))
            {
                conn.Open();
                using (MySqlCommand cmd = new MySqlCommand())//创建查询命令
                {
                    string sql = "select store_id,avg(assessment) from sell natural join assess natural join `order` where date like @date group by store_id";
                    cmd.Connection = conn;
                    cmd.CommandText = sql;
                    cmd.Parameters.Add(new MySqlParameter("@date", date));
                    cmd.ExecuteNonQuery();//用来执行sql语句

                    MySqlDataReader reader = cmd.ExecuteReader();//创建一个执行命令的对象,但是还没有执行命令
                    while (reader.Read())//按行执行查询，每次循环查询一行
                    {
                        //此时reader会获取一行的内容，返回一个类似字典的结构，key为列名，value为值
                        //对于不同的数据库字段类型，我们需要用不同的方法获取
                        int store_id = reader.GetInt32("store_id");
                        int assessment = reader.GetInt32("assessment");
                        
                    }
                }

            }
            
        }




        static public void store_sales_quantity(int year, int month, int day)//////店铺销量查询
        {
             
             string date = Date(year, month, day);

            string connString = "server=localhost;database=db_mall;uid=root;pwd=1234";

            using (MySqlConnection conn = new MySqlConnection(connString))
            {
                conn.Open();
                using (MySqlCommand cmd = new MySqlCommand())//创建查询命令
                {
                    string sql = "select store_id ,sum(order_id) from goods natural join goods_order natural join `order` natural join sell where date like @date group by store_id ";
                    cmd.Connection = conn;
                    cmd.CommandText = sql;
                    cmd.Parameters.Add(new MySqlParameter("@date", date));
                    cmd.ExecuteNonQuery();//用来执行sql语句

                    MySqlDataReader reader = cmd.ExecuteReader();//创建一个执行命令的对象,但是还没有执行命令
                    while (reader.Read())//按行执行查询，每次循环查询一行
                    {
                        //此时reader会获取一行的内容，返回一个类似字典的结构，key为列名，value为值
                        //对于不同的数据库字段类型，我们需要用不同的方法获取
                        int store_id = reader.GetInt32(0);
                        int quantity = reader.GetInt32(1);

                    }
                }

            }
        }


        static public void store_sales_month_quantity(int year)//////店铺月度销量（年报表）

        {
            
            string date = Date(year, -1, -1);

            string connString = "server=localhost;database=db_mall;uid=root;pwd=1234";

            using (MySqlConnection conn = new MySqlConnection(connString))
            {
                conn.Open();
                using (MySqlCommand cmd = new MySqlCommand())//创建查询命令
                {
                    string sql = "select store_id ,sum(order_id) from goods natural join goods_order natural join `order` natural join sell where date like @date group by store_id ";
                    cmd.Connection = conn;
                    cmd.CommandText = sql;
                    cmd.Parameters.Add(new MySqlParameter("@date", date));
                    cmd.ExecuteNonQuery();//用来执行sql语句

                    MySqlDataReader reader = cmd.ExecuteReader();//创建一个执行命令的对象,但是还没有执行命令
                    while (reader.Read())//按行执行查询，每次循环查询一行
                    {
                        //此时reader会获取一行的内容，返回一个类似字典的结构，key为列名，value为值
                        //对于不同的数据库字段类型，我们需要用不同的方法获取
                        int store_id = reader.GetInt32(0);
                        int quantity = reader.GetInt32(1);

                    }
                }

            }
        }


        
        static public void store_sales_money(int year,int month,int day)////////店铺销售额查询

        {

            string date = Date(year, month, day);

            string connString = "server=localhost;database=db_mall;uid=root;pwd=1234";

            using (MySqlConnection conn = new MySqlConnection(connString))
            {
                conn.Open();
                using (MySqlCommand cmd = new MySqlCommand())//创建查询命令
                {
                    string sql = "select store_id ,sum(price*sum(order_id)) from goods natural join goods_order natural join `order` natural join sell where date like @date group by store_id ";
                    cmd.Connection = conn;
                    cmd.CommandText = sql;
                    cmd.Parameters.Add(new MySqlParameter("@date", date));
                    cmd.ExecuteNonQuery();//用来执行sql语句

                    MySqlDataReader reader = cmd.ExecuteReader();//创建一个执行命令的对象,但是还没有执行命令
                    while (reader.Read())//按行执行查询，每次循环查询一行
                    {
                        //此时reader会获取一行的内容，返回一个类似字典的结构，key为列名，value为值
                        //对于不同的数据库字段类型，我们需要用不同的方法获取
                        int store_id = reader.GetInt32(0);
                        int money = reader.GetInt32(1);

                    }
                }

            }
        }


        static public void store_sales_month_money(int year)////////店铺月度销售额（年报表）

        {

            string date = Date(year,-1, -1);

            string connString = "server=localhost;database=db_mall;uid=root;pwd=1234";

            using (MySqlConnection conn = new MySqlConnection(connString))
            {
                conn.Open();
                using (MySqlCommand cmd = new MySqlCommand())//创建查询命令
                {
                    string sql = "select store_id ,sum(price*sum(order_id)) from goods natural join goods_order natural join `order` natural join sell where date like @date group by store_id ";
                    cmd.Connection = conn;
                    cmd.CommandText = sql;
                    cmd.Parameters.Add(new MySqlParameter("@date", date));
                    cmd.ExecuteNonQuery();//用来执行sql语句

                    MySqlDataReader reader = cmd.ExecuteReader();//创建一个执行命令的对象,但是还没有执行命令
                    while (reader.Read())//按行执行查询，每次循环查询一行
                    {
                        //此时reader会获取一行的内容，返回一个类似字典的结构，key为列名，value为值
                        //对于不同的数据库字段类型，我们需要用不同的方法获取
                        int store_id = reader.GetInt32(0);
                        int money = reader.GetInt32(1);

                    }
                }

            }
        }


        static public void staff_info( )         ///////////店铺员工信息
        {

            string connString = "server=localhost;database=db_mall;uid=root;pwd=1234";

            using (MySqlConnection conn = new MySqlConnection(connString))
            {
                conn.Open();
                using (MySqlCommand cmd = new MySqlCommand())//创建查询命令
                {
                    string sql = "select store_id ,staff_id,staff_name,staff_phone_num from staff natural join store_staff  ";
                    cmd.Connection = conn;
                    cmd.CommandText = sql;
                    

                    MySqlDataReader reader = cmd.ExecuteReader();//创建一个执行命令的对象,但是还没有执行命令
                    while (reader.Read())//按行执行查询，每次循环查询一行
                    {
                        //此时reader会获取一行的内容，返回一个类似字典的结构，key为列名，value为值
                        //对于不同的数据库字段类型，我们需要用不同的方法获取
                        int store_id = reader.GetInt32(0);
                        int staff_id = reader.GetInt32(1);
                        string staff_name = reader.GetString(2);
                        int staff_phone_num = reader.GetInt32(3);
                    }
                }

            }
        }



        //////店铺商品按销量降序排列（按年月日查询，可为空）

        static public  void goods_quantity(int year, int month, int day)
        {
            string date = Date(year, month, day);

            string connString = "server=localhost;database=db_mall;uid=root;pwd=1234";

            using (MySqlConnection conn = new MySqlConnection(connString))
            {
                conn.Open();
                using (MySqlCommand cmd = new MySqlCommand())//创建查询命令
                {
                    string sql = "select goods_id ,sum(order_id) from goods natural join goods_order natural join `order` natural join sell where date like @date group by goods_id order by sum(order_id) desc";
                    cmd.Connection = conn;
                    cmd.CommandText = sql;
                    cmd.Parameters.Add(new MySqlParameter("@date", date));
                    cmd.ExecuteNonQuery();//用来执行sql语句

                    MySqlDataReader reader = cmd.ExecuteReader();//创建一个执行命令的对象,但是还没有执行命令
                    while (reader.Read())//按行执行查询，每次循环查询一行
                    {
                        //此时reader会获取一行的内容，返回一个类似字典的结构，key为列名，value为值
                        //对于不同的数据库字段类型，我们需要用不同的方法获取
                        int goods_id = reader.GetInt32(0);
                        int goods_quantity = reader.GetInt32(1);

                    }
                }

            }
        }





        //////店铺商品按销售额降序排列（按年月日查询，可为空）

        static public void goods_sales_money(int year, int month, int day)////////店铺销售额查询

        {

            string date = Date(year, month, day);

            string connString = "server=localhost;database=db_mall;uid=root;pwd=1234";

            using (MySqlConnection conn = new MySqlConnection(connString))
            {
                conn.Open();
                using (MySqlCommand cmd = new MySqlCommand())//创建查询命令
                {
                    string sql = "select goods_id ,sum(price*sum(order_id)) from goods natural join goods_order natural join `order` natural join sell where date like @date group by goods_id order by sum(price*sum(order_id))";
                    cmd.Connection = conn;
                    cmd.CommandText = sql;
                    cmd.Parameters.Add(new MySqlParameter("@date", date));
                    cmd.ExecuteNonQuery();//用来执行sql语句

                    MySqlDataReader reader = cmd.ExecuteReader();//创建一个执行命令的对象,但是还没有执行命令
                    while (reader.Read())//按行执行查询，每次循环查询一行
                    {
                        //此时reader会获取一行的内容，返回一个类似字典的结构，key为列名，value为值
                        //对于不同的数据库字段类型，我们需要用不同的方法获取
                        int goods_id = reader.GetInt32(0);
                        int goods_money = reader.GetInt32(1);

                    }
                }

            }
        }







        //////店铺商品按评价降序排列（按年月日查询，可为空）
        static public void goods_assess(int year, int month, int day)     //店铺评价查询
        {
            string date = Date(year, month, day);

            string connString = "server=localhost;database=db_mall;uid=root;pwd=1234";

            using (MySqlConnection conn = new MySqlConnection(connString))
            {
                conn.Open();
                using (MySqlCommand cmd = new MySqlCommand())//创建查询命令
                {
                    string sql = "select goods_id,avg(assessment) from sell natural join assess natural join `order` where date like @date group by goods_id order by avg(assessment)";
                    cmd.Connection = conn;
                    cmd.CommandText = sql;
                    cmd.Parameters.Add(new MySqlParameter("@date", date));
                    cmd.ExecuteNonQuery();//用来执行sql语句

                    MySqlDataReader reader = cmd.ExecuteReader();//创建一个执行命令的对象,但是还没有执行命令
                    while (reader.Read())//按行执行查询，每次循环查询一行
                    {
                        //此时reader会获取一行的内容，返回一个类似字典的结构，key为列名，value为值
                        //对于不同的数据库字段类型，我们需要用不同的方法获取
                        int goods_id = reader.GetInt32("store_id");
                        int goods_assessment = reader.GetInt32("assessment");

                    }
                }

            }

        }








    }
}




                  //order by排序查询，desc降序
                  //order by *** desc