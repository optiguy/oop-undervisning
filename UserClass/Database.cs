using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace KurvClass
{
    public static class Database
    {
        private static SqlConnection Conn = new SqlConnection(ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString);

        public static DataTable Query(string sql)
        {
            DataTable dt = new DataTable();
            SqlDataAdapter ad = new SqlDataAdapter(sql, Conn);
            ad.Fill(dt);
            return dt;
        }

        public static int InsertAndGetId(string sql)
        {
            using (Conn) {
                sql += "; SELECT scope_identity();"; //Edit sql to select id from inserted statement
                SqlCommand insert = new SqlCommand(sql, Conn);
                Conn.Open();
                int orderId = (int)insert.ExecuteScalar();
                Conn.Close();
                return orderId;
            }
        }

    }
}