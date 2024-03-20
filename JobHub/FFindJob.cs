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
using Guna.UI2.WinForms;

namespace JobHub
{
    public partial class FJob : Form
    {
        SqlConnection sqlConnection = new SqlConnection(DBConection.str);
        DBConection conection = new DBConection();
        public FJob()
        {
            InitializeComponent();

        }
   
        private void loadJobInPanel()
        {
            string query = @"SELECT Job.nameJob, Job.salary, Job.position, Company.nameCompany
                         FROM Job
                         INNER JOIN Company ON Job.idCompany = Company.idCompany";
            SqlDataReader reader = conection.loadData(query);
            pnJob.Controls.Clear(); 
            conection.change(reader, pnJob);
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

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            string query = $@"SELECT Job.nameJob, Job.salary, Job.position, Company.nameCompany
                         FROM Job
                         INNER JOIN Company ON Job.idCompany = Company.idCompany
                         where Job.nameJob LIKE N'{txtSearch.Text}%'";
            SqlDataReader dr = conection.loadData(query);
            pnJob.Controls.Clear();
            conection.change(dr, pnJob);
        }

        private void loadJob(Guna2Button button)
        {
            string query = $@"SELECT Job.nameJob, Job.salary, Job.position, Company.nameCompany
                    FROM Job
                    INNER JOIN Company ON Job.idCompany = Company.idCompany
                    where Job.category LIKE N'{button.Text}%'";
            SqlDataReader dr = conection.loadData(query);
            conection.change(dr, pnJob);
        }
        private void checkStateButton(Guna2Button button)
        {               
            pnJob.Controls.Clear();
            if(btnEconomy.Checked )
            {
                loadJob(btnEconomy);
            }           
            if(btnIT.Checked )
            {
                loadJob(btnIT);
            }
            if(btnTechnique.Checked )
            {
                loadJob(btnTechnique);
            }
            if(!btnTechnique.Checked && !btnIT.Checked && !btnEconomy.Checked)
            {
                loadJobInPanel();
            }
        }

        private void btnIT_Click(object sender, EventArgs e)
        {
            checkStateButton(btnIT);
        }

        private void btnEconomy_Click(object sender, EventArgs e)
        {
            checkStateButton(btnEconomy);
        }

        private void btnTechnique_Click(object sender, EventArgs e)
        {
            checkStateButton(btnTechnique);
        }

        private void cboIndustryGroup_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cboIndustryGroup.SelectedIndex == 2)
            {
                btnEconomy.Checked = true;
                checkStateButton(btnIT);
            }
            if(cboIndustryGroup.SelectedIndex == 3)
            {
                btnIT.Checked = true;
                checkStateButton(btnIT);
            }
            if(cboIndustryGroup.SelectedIndex == 4)
            {
                btnTechnique.Checked = true;
                checkStateButton(btnTechnique);
            }
        }

        private void cboWage_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void cboWage_SelectedValueChanged(object sender, EventArgs e)
        {
          
          
        }

        private void cboExperience_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (sqlConnection.State != ConnectionState.Open)
            {
                sqlConnection.Open();
            }

            string query = $@"SELECT Job.nameJob, Job.salary, Job.position, Company.nameCompany
                    FROM Job
                    INNER JOIN Company ON Job.idCompany = Company.idCompany
                    where Job.salary LIKE N'{cboExperience.SelectedItem.ToString()}%'";
            SqlDataReader dr = conection.loadData(query);
            pnJob.Controls.Clear();
            conection.change(dr, pnJob); 
        }
    }
}
