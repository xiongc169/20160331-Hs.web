using MySql.Data.MySqlClient;
using System;
using System.Data;

namespace hs.console.utility.mysql
{
    /// <summary>
    /// 
    /// http://www.cnblogs.com/mingforyou/archive/2012/12/17/2821631.html
    /// </summary>
    public class MySQLHelper
    {
        public static void GetConnection()
        {
            Console.WriteLine("--------");

            string myconn = "Database='test';Data Source=localhost;User ID=root;Password=123456;CharSet=utf8;";
            //需要执行的SQL语句
            string mysql = "SELECT * from users";
            //创建数据库连接
            MySqlConnection myconnection = new MySqlConnection(myconn);

            myconnection.Open();
            //创建MySqlCommand对象
            MySqlCommand mycommand = new MySqlCommand(mysql, myconnection);
            //通过MySqlCommand的ExecuteReader()方法构造DataReader对象
            MySqlDataReader myreader = mycommand.ExecuteReader();
            int effectRows = mycommand.ExecuteNonQuery();
            object obj = mycommand.ExecuteScalar();
            while (myreader.Read())
            {
                string name = myreader["name"].ToString();
                Console.WriteLine(myreader.GetInt32(0) + "," + myreader.GetString(1) + "," + myreader.GetString(2));
            }
            myreader.Close();

            myconnection.Close();

            //实现分页
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            DataSet dataset = new DataSet();
            adapter.Fill(dataset, 0, 10, "");
        }
    }
}
