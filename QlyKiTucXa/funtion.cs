using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Data;

namespace QlyKiTucXa
{
     class funtion
    {
        protected SqlConnection GetSqlConnection()
        {
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = "Data Source=PHAMV;Initial Catalog=THLVN;Integrated Security=True;Encrypt=False";
            return conn;
        }
        public DataSet getData(string query)
        {
            SqlConnection conn = GetSqlConnection();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;
            cmd.CommandText = query;
            SqlDataAdapter adt = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            adt.Fill(ds);
            return ds;
        }
        public void setData(string  query, string msg)
        {
            SqlConnection conn = GetSqlConnection();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;
            conn.Open();
            cmd.CommandText = query;
            cmd.ExecuteNonQuery();
            conn.Close();
            MessageBox.Show(msg, "Thông tin", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
