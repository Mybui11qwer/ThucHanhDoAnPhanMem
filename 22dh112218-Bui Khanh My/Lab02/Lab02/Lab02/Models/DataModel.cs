using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Collections; // Sử dụng Lớp ArrayList để lưu kết quả
using System.Data.SqlClient;// Sử dụng các lớp tương tác CSDL
namespace Lab02.Models
{
    public class DataModel
    {
        public static string connectionString = "workstation id=demodoanpmlab02.mssql.somee.com;packet size=4096;user id=oblivion2504_SQLLogin_3;pwd=58spdpquvw;data source=demodoanpmlab02.mssql.somee.com;persist security info=False;initial catalog=demodoanpmlab02;TrustServerCertificate=True";
        public ArrayList get(String sql)
        {
            ArrayList datalist = new ArrayList();
            SqlConnection connection = new SqlConnection(connectionString);
            SqlCommand command = new SqlCommand(sql, connection);

            connection.Open();

            using (SqlDataReader r = command.ExecuteReader())
            {
                while (r.Read())
                {
                    ArrayList row = new ArrayList();
                    for (int i = 0; i < r.FieldCount; i++)
                    {
                        row.Add(r.GetValue(i).ToString());
                    }
                    datalist.Add(row);
                }
            }
            connection.Close();
            return datalist;
        }
    }
}