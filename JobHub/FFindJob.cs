using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace JobHub
{
    public partial class FJob : Form
    {
        SqlConnection sqlConnection = new SqlConnection(DBConection.str);
        public FJob()
        {
            InitializeComponent();

        }

        private void setSize(int width, int height, Label label)
        {
            label.Width = width;
            label.Height = height;
        }
        private void loadJobInPanel()
        {
            try
            {
                if (sqlConnection.State != ConnectionState.Open)
                {
                    sqlConnection.Open();
                }

                string query = @"SELECT Job.nameJob, Job.salary, Job.position, Company.nameCompany
                         FROM Job
                         INNER JOIN Company ON Job.idCompany = Company.idCompany";

                SqlCommand cmd = new SqlCommand(query, sqlConnection);
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    uC_Job job = new uC_Job();
                    job.lblNameJob.Text = dr["nameJob"].ToString();
                    setSize(130, 25, job.lblNameJob);
                    job.lblNameCompany.Text = dr["nameCompany"].ToString();
                    job.lblSalary.Text = dr["salary"].ToString();
                    job.lblPositon.Text = dr["position"].ToString();
                    
                    pnJob.Controls.Add(job);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Đã xảy ra lỗi: " + ex.Message);
            }

        }

        private void FJob_Load(object sender, EventArgs e)
        {
            this.MinimumSize = new System.Drawing.Size(925, 550);
            loadJobInPanel();
        }

        private void guna2Button5_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void loadDetailJob(object sender, EventArgs e)
        {
            FJobDetails jobDetails = new FJobDetails();
            jobDetails.ShowDialog();
        }

    }
}
