using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hs.console.utility
{
    public class AdoNetUtility
    {
        private static string connectionString = "server=(local);database=northwind;user id=sa;pwd=111111";

        private static string itsmTest = "server=192.168.54.28;database=hsyunitsm;user id=yunrong;pwd=yunrong@1qsc";

        private static string itsmOfficial = "server=192.168.72.235;database=hswlitsm;user id=yunrong;pwd=yunrong@1qsc";

        public static void Query()
        {
            SqlConnection conn = new SqlConnection(itsmTest);
            conn.Open();
            //SELECT top 100 *  FROM [dbo].[事件视图_云融]
            SqlCommand cmd = new SqlCommand("SELECT top 100 *  FROM [dbo].[事件视图_云融]", conn);
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                Console.WriteLine(reader[0]);
                Console.WriteLine(reader["event_no"]);
            }
        }

        public static void Query2DataSet()
        {
            SqlConnection conn = new SqlConnection(itsmOfficial);
            conn.Open();
            //SELECT top 100 *  FROM [dbo].[事件视图_云融]
            SqlCommand cmd = new SqlCommand("SELECT top 100 *  FROM [dbo].[事件视图_云融] where event_id=@event_id", conn);
            SqlParameter param = new SqlParameter("event_id", 170959);
            cmd.Parameters.Add(param);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataSet data = new DataSet();
            adapter.Fill(data, "CustomerEvent");
            DataRowCollection rows = data.Tables["CustomerEvent"].Rows;
            int index = rows.Count;
            for (int i = 0; i < index; i++)
            {
                Console.WriteLine(rows[i]["topic"]);
            }
        }
    }
}
