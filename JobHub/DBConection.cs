using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
            while (dr.Read())
            {
                uC_Job job = new uC_Job();
                job.lblNameJob.Text = dr["nameJob"].ToString();
                changTheSize.setSize(130, 25, job.lblNameJob);
                job.lblNameCompany.Text = dr["nameCompany"].ToString();
                job.lblSalary.Text = dr["salary"].ToString();
                job.lblPositon.Text = dr["position"].ToString();
                flPanel.Controls.Add(job);
                int idJob = int.Parse(dr["idJob"].ToString());
                int idCp = int.Parse(dr["idCompany"].ToString());
                job.loadJobClick += (sender, e) =>
                {
                    job.LoadJobDetail(sender, e, idJob, idCp);
                };
            }
            if(sqlConnection.State == ConnectionState.Open)
            {
                sqlConnection.Close();
            }
        }

    }
    
}
