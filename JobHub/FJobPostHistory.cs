using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI.WebControls;
using System.Windows.Forms;

namespace JobHub
{
    public partial class FJobPostHistory : Form
    {
        SqlConnection conn = new SqlConnection(Properties.Settings.Default.conn);
        public FJobPostHistory()
        {
            InitializeComponent();
            //dgJobPostHistory.ColumnHeadersDefaultCellStyle.BackColor = Color.Red; // Màu nền
        }

        private void FJobPostHistory_Load(object sender, EventArgs e)
        {
            /*dgJobPostHistory.Rows.Add("12/23/2023",
                "Nhân Viên Kinh Doanh Có Lương Cứng + Hoa Hồng Cao, Thu Nhập Trên 20 Triệu",
                1, 1, 1);*/
            int idCompany = 5;
            try
            {
                if (conn.State != ConnectionState.Open)
                {
                    conn.Open();

                    string query = string.Format($"select* from Job where Job.idCompany = {idCompany}");
                    SqlCommand cmd = new SqlCommand(query, conn);
                    SqlDataReader dr = cmd.ExecuteReader();
                    JobDetail jd = new JobDetail();
                    while (dr.Read())
                    {
                        jd.NameJob = dr["jobName"].ToString();
                        jd.Salary = dr["jobSalary"].ToString();
                        jd.Address = dr["jobAddress"].ToString();
                        jd.Experience = dr["jobExperience"].ToString();
                        jd.Description = dr["jobDescription"].ToString();
                        jd.Requirement = dr["jobRequirement"].ToString();
                        jd.Benefit = dr["jobBenefit"].ToString();
                        jd.RegisterDead = Convert.ToDateTime(dr["jobRegisterDead"]);
                        jd.PostDate = Convert.ToDateTime(dr["jobPostDate"]);
                        dgJobPostHistory.Rows.Add(jd.PostDate, jd.NameJob, jd.Address, jd.Salary);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
