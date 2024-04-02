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
using System.Collections;
using Guna.UI2.WinForms;

namespace JobHub
{
    public partial class FJob : Form
    {
        SqlConnection sqlConnection = new SqlConnection(Properties.Settings.Default.conn);
        DBConection conection = new DBConection();
        private FindJobDao fjd;
        private Fmain fm;
        private Account account = new Account();
        public Account Account { get => account; set => account = value; }

/*        public FJob(Account account)
        {
            this.Account = account;
            fjd = new FindJobDao(account);
            InitializeComponent();
        }*/

        private void loadJobInPanel()
        {
            fjd.LoadUc_Job(pnJob, fm);


        }
        public FJob(Fmain fm,Account account)
        {
                this.fm = fm;
                this.Account = account;
                fjd = new FindJobDao(account);
                InitializeComponent();

        }

/*        private void FJobDetails_Load(int idJob, int idCp, Fmain fm, Account account)
        {
            FJobDetails job = new FJobDetails(idJob, idCp, fm, account);
            job.MdiParent = fm;
            job.Dock = DockStyle.Fill;
            fm.Close();
            job.Show();
            job.BringToFront();
            //fm.resize(job.Width, job.Height);
        }
        private void UCJob_Click(object sender, EventArgs e, int idJob, int idCp, Fmain fm, Account account)
        {
            FJobDetails_Load(idJob, idCp, fm, account);
        }*/
        private void FJob_Load(object sender, EventArgs e)
            {
                //this.MinimumSize = new System.Drawing.Size(925, 550);
                loadJobInPanel();
            }

            private void guna2Button5_Click(object sender, EventArgs e)
            {
                this.Close();
            }
            private void txtSearch_TextChanged(object sender, EventArgs e)
            {
                //string query = $@"SELECT Job.idJob, Company.idCompany, Job.nameJob, Job.salary, Job.position, Company.nameCompany
/*                  string query = $@"SELECT Job.idJob, Company.idCompany, Job.jobName, Job.jobSalary, Job.jobAddress, Company.companyName
                        FROM Job
                         INNER JOIN Company ON Job.idCompany = Company.idCompany
                         where Job.jobName LIKE N'%{txtSearch.Text}%'";
                SqlDataReader dr = conection.loadData(query);
                pnJob.Controls.Clear();
                conection.change(dr, pnJob, fm);*/
                fjd.LoadTxtSearch(pnJob, fm, txtSearch.Text);  

                
            }

        private void loadJob(Guna2Button button)
        {
            //string query = $@"SELECT Job.idJob, Company.idCompany, Job.nameJob, Job.salary, Job.position, Company.nameCompany
/*            string query = $@"SELECT Job.idJob, Company.idCompany, Job.jobName, Job.jobSalary, Job.jobAddress, Company.companyName 
                    FROM Job
                    INNER JOIN Company ON Job.idCompany = Company.idCompany
                    where Job.jobField LIKE N'{button.Text}%'";
            SqlDataReader dr = conection.loadData(query);
            conection.change(dr, pnJob, fm);*/

            fjd.LoadTxtSearch(pnJob, fm, button.Text);

        }
        private void checkStateButton(Guna2Button button)
            {
                pnJob.Controls.Clear();
                if (btnEconomy.Checked)
                {
                    loadJob(btnEconomy);
                }
                if (btnIT.Checked)
                {
                    loadJob(btnIT);
                }
                if (btnTechnique.Checked)
                {
                    loadJob(btnTechnique);
                }
                if (!btnTechnique.Checked && !btnIT.Checked && !btnEconomy.Checked)
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
                if (cboIndustryGroup.SelectedIndex == 2)
                {
                    btnEconomy.Checked = true;
                    checkStateButton(btnIT);
                }
                if (cboIndustryGroup.SelectedIndex == 3)
                {
                    btnIT.Checked = true;
                    checkStateButton(btnIT);
                }
                if (cboIndustryGroup.SelectedIndex == 4)
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
            ///Chưa chỉnh sửa 
            ///

                /*if (sqlConnection.State != ConnectionState.Open)
                {
                    sqlConnection.Open();
                }

                string query = $@"SELECT Job.idJob, Company.idCompany, Job.jobName, Job.jobSalary, Job.jobAddress, Company.companyName
                    FROM Job
                    INNER JOIN Company ON Job.idCompany = Company.idCompany
                    where Job.jobSalary LIKE N'{cboExperience.SelectedItem.ToString()}%'";
                SqlDataReader dr = conection.loadData(query);
                pnJob.Controls.Clear();
                conection.change(dr, pnJob,fm);*/
            }
        }
    } 

