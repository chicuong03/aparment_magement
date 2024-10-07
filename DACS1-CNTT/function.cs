using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data;

namespace DACS1_CNTT
{
    internal class function
    {
        protected SqlConnection GetConnection()
        {
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = "Data source =DESKTOP-2SS9F1P\\CHICUONG; database=managerhotel;Integrated Security = true";
            return conn;
        }

        public DataSet getData(string query)
        {
            SqlConnection con = GetConnection();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = query;
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataSet data = new DataSet();
            adapter.Fill(data);
            return data;
        }
        public void setData (string quyery, string msg)  // cập nhật thông tin có thông báo messebox
        {
            SqlConnection con = GetConnection();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            con.Open(); ;
            cmd.CommandText = quyery;
            cmd.ExecuteNonQuery();
            con.Close(); 
            MessageBox.Show(msg,"thong tin ",MessageBoxButtons.OK,MessageBoxIcon.Information);
        }

        public void setDataNO(string quyery) // cập nhật thông tin không thông báo
        {
            SqlConnection con = GetConnection();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            con.Open(); ;
            cmd.CommandText = quyery;
            cmd.ExecuteNonQuery();
            con.Close();
        }
    }
}
