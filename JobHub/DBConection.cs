using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Management;
using System.Security.Cryptography;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace JobHub
{
    class DBConection
    {
        SqlConnection sqlConnection = new SqlConnection(Properties.Settings.Default.conn);
        
        public void ThucThi(string sqlStr)
        {
            try
            {
                // Ket noi
                if(sqlConnection.State != ConnectionState.Open)
                {
                    sqlConnection.Open();
                }
                SqlCommand cmd = new SqlCommand(sqlStr, sqlConnection);
                if (cmd.ExecuteNonQuery() > 0)
                {
                    MessageBox.Show("Thành công");
                }
                    

            }
            catch (Exception ex)
            {
                MessageBox.Show("Thất bại" + ex);
            }
        }
        public void ExcuteNoMess(string sqlStr)
        {
            try
            {
                // Ket noi
                if (sqlConnection.State != ConnectionState.Open)
                {
                    sqlConnection.Open();
                }
                SqlCommand cmd = new SqlCommand(sqlStr, sqlConnection);
                cmd.ExecuteNonQuery();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Thất bại" + ex);
            }
        }

        public SqlDataReader loadData(string sql)
        {
            SqlDataReader dr = null;
            try
            {
                if (sqlConnection.State != ConnectionState.Open)
                {
                    sqlConnection.Open();
                }
                SqlCommand cmd = new SqlCommand(sql, sqlConnection);
                dr = cmd.ExecuteReader();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return dr;
        }
        public bool CheckNull (string sql)
        {
            SqlDataAdapter adapter = new SqlDataAdapter(sql, sqlConnection);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            if (dt.Rows.Count > 0)
                return true;  
            return false;

        }
        public DataTable CheckExists(string sql)
        {
            try
            {
                if (sqlConnection.State != ConnectionState.Open)
                {
                    sqlConnection.Open();
                }
                SqlDataAdapter adapter = new SqlDataAdapter(sql, sqlConnection);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                return dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return null;

        }
        public DataRow GetHotUcJob(string sql)
        {
            SqlDataAdapter adapter = new SqlDataAdapter(sql, sqlConnection);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            Random random = new Random();

            int randomNumber = random.Next(0, dt.Rows.Count);
            return dt.Rows[randomNumber];

        }

        public void ExcutionInsertData(string cmd)
        {
            using (SqlConnection connection = new SqlConnection((Properties.Settings.Default.conn)))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand(cmd, connection))
                {
                    command.ExecuteNonQuery();
                }
            }
        }
             

        public DataTable ExcutionReadData(string cmd)
        {
            DataTable dt = new DataTable();
            /*MessageBox.Show(cmd);*/
            using (SqlConnection connection = new SqlConnection((Properties.Settings.Default.conn)))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand(cmd, connection))
                {
                    using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                    {
                        adapter.Fill(dt);
                    }
                }
            }
            return dt;
        }


        public void ExcutionUpdateDate(string cmd)
        {
            try
            {
                using (SqlConnection conection = new SqlConnection(Properties.Settings.Default.conn))
                {
                    conection.Open();
                    using (SqlCommand ex = new SqlCommand(cmd, conection))
                    {
                        ex.ExecuteNonQuery();
                    }
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }  
}
