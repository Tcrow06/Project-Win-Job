using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace JobHub
{
    public partial class FCompanyJob : Form
    {
        SqlConnection sqlConnection = new SqlConnection(Properties.Settings.Default.conn);
        DBConection conection = new DBConection();
        private Fmain fm;
        public FCompanyJob()
        {
            InitializeComponent();
        }

        private void btnIT_Click(object sender, EventArgs e)
        {

        }

        public FCompanyJob(Fmain fm)
        {
            this.fm = fm;
            InitializeComponent();
        }

        private void loadCompany()
        {
            sqlConnection.Open();
            SqlDataReader myreader = null;
            SqlCommand query = new SqlCommand("SELECT * FROM Company WHERE idCompany=3", sqlConnection);
            myreader = query.ExecuteReader();
            while (myreader.Read())
            {
                lblCompanyName.Text = myreader[1].ToString();
                lblCompanyEmail.Text = myreader[6].ToString();
                lblCompanyAddress.Text = myreader[3].ToString();
                lblCompanyPhone.Text = myreader[4].ToString();
            }
            sqlConnection.Close();
        }

        private void loadJobInPanel()
        {
            //string query = @"SELECT Job.idJob, Job.nameJob, Job.salary, Job.position, Company.nameCompany, Company.idCompany
            string query = $@"SELECT Job.idJob, Job.jobName, Job.jobSalary, Job.jobAddress, Company.companyName, Company.idCompany
                        FROM Job
                         INNER JOIN Company ON Job.idCompany = Company.idCompany
                            WHERE Job.idCompany=3";
            //Chưa có chức năng đăng nhập bằng cty nên để tạm idcompany=3 làm ví dụ
            SqlDataReader reader = conection.loadData(query);
            pnJob.Controls.Clear();
            //conection.changeforCompany(reader, pnJob, fm);

        }

        private void FCompanyJob_Load(object sender, EventArgs e)
        {
            loadCompany();
            loadJobInPanel();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {

        }

        private void guna2PictureBox9_Click(object sender, EventArgs e)
        {

        }

        private void lblAddress_Click(object sender, EventArgs e)
        {

        }
    }
}
