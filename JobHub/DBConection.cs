using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
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
        ChangTheSize changTheSize = new ChangTheSize();
        
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


        public void change(SqlDataReader dr, FlowLayoutPanel flPanel, Fmain fm)
        {
            //int i = 1;
            while (dr.Read())
            {
                uC_Job job = new uC_Job();
                job.lblJobName.Text = dr["jobName"].ToString();
                changTheSize.setSize(130, 25, job.lblJobName);
                job.lblCompanyName.Text = dr["companyName"].ToString();
                job.lblSalary.Text = dr["jobSalary"].ToString();
                job.lblJobAddress.Text = dr["jobAddress"].ToString();
                flPanel.Controls.Add(job);
                int idJob = int.Parse(dr["idJob"].ToString());
                int idCp = int.Parse(dr["idCompany"].ToString());
                job.loadJobClick += (sender, e) =>
                {
                    job.LoadJobDetail(sender, e, idJob, idCp, fm);
                };
                job.loadCompanyClick += (sender, e) =>
                {
                    job.LoadCompanyDetail(sender, e, idCp, fm);
                };
            }
            if (sqlConnection.State == ConnectionState.Open)
            {
                sqlConnection.Close();
            }
            dr.Dispose();
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
        public DataTable CheckAcount(string sql)
        {
            SqlDataAdapter adapter = new SqlDataAdapter(sql, sqlConnection);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            return dt;

        }

        /*public void changeforCompany(SqlDataReader dr, FlowLayoutPanel flPanel, Fmain fm)
        {
            //int i = 1;
            while (dr.Read())
            {
                uC_Job2 job = new uC_Job2();
                job.lblNameJob.Text = dr["jobName"].ToString();
                changTheSize.setSize(130, 25, job.lblNameJob);
                job.lblNameCompany.Text = dr["companyName"].ToString();
                job.lblSalary.Text = dr["jobSalary"].ToString();
                job.lblPositon.Text = dr["jobAddress"].ToString();
                flPanel.Controls.Add(job);
                int idJob = int.Parse(dr["idJob"].ToString());
                int idCp = int.Parse(dr["idCompany"].ToString());
                job.loadJobClick += (sender, e) =>
                {
                    job.LoadJobDetail(sender, e, idJob, idCp, fm);
                };
            }
            if (sqlConnection.State == ConnectionState.Open)
            {
                sqlConnection.Close();
            }
        }*/


    }
    
}
