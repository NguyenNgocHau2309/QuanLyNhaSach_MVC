using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyNhaSach
{
    public class DataProvider
    {
        private string connecString = @"Data Source=LAPTOP-HAU03\SQL2022;Initial Catalog=QuanLyNhaSach;Integrated Security=True";

        public DataTable execQuery(string query, object[] paramater = null)
        {
            DataTable data = new DataTable();
            using (SqlConnection conn = new SqlConnection(connecString))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(query, conn);
                if (paramater != null)
                {
                    string[] lisrPara = query.Split(' ');
                    int i = 0;
                    foreach (string item in lisrPara)
                    {
                        if (item.Contains('@'))
                        {
                            cmd.Parameters.AddWithValue(item, paramater[i]);
                            i++;
                        }
                    }
                }
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                adapter.Fill(data);
                conn.Close();
            }
            return data;
        }
        public int execNonQuery(string query, object[] paramater = null)
        {
            int data = 0;

            using (SqlConnection conn = new SqlConnection(connecString))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(query, conn);
                if (paramater != null)
                {
                    string[] lisrPara = query.Split(' ');
                    int i = 0;
                    foreach (string item in lisrPara)
                    {
                        if (item.Contains('@'))
                        {
                            cmd.Parameters.AddWithValue(item, paramater[i]);
                            i++;
                        }
                    }
                }
                data = cmd.ExecuteNonQuery();
                conn.Close();
            }
            return data;
        }
        public object execScalar(string query, object[] paramater = null)
        {
            object data = 0;

            using (SqlConnection conn = new SqlConnection(connecString))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(query, conn);
                if (paramater != null)
                {
                    string[] lisrPara = query.Split(' ');
                    int i = 0;
                    foreach (string item in lisrPara)
                    {
                        if (item.Contains('@'))
                        {
                            cmd.Parameters.AddWithValue(item, paramater[i]);
                            i++;
                        }
                    }
                }
                data = cmd.ExecuteScalar();
                conn.Close();
            }
            return data;
        }
    }
}
