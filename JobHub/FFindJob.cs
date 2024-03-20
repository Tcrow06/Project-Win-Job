﻿using System;
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
        SqlConnection sqlConnection = new SqlConnection(DBConection.str);
        private Fmain fm;
        public FJob()
        {
            InitializeComponent();

        }
        public FJob(Fmain fm)
        {
            this.fm = fm;
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

                string query = @"SELECT Job.idJob,Job.nameJob, Job.salary, Job.position, Company.nameCompany, Company.idCompany
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
                    int idJob = int.Parse(dr["idJob"].ToString());
                    int idCp = int.Parse(dr["idCompany"].ToString());
                    pnJob.Controls.Add(job);
                    job.loadJobClick += (sender, e) =>
                    {
                        UCJob_Click(sender, e, idJob, idCp, fm);
                    };
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Đã xảy ra lỗi: " + ex.Message);
            }
            finally
            {
                sqlConnection.Close();
            }
        }
        private void FJobDetails_Load(int idJob, int idCp, Fmain fm)
        {
            FJobDetails job = new FJobDetails(idJob, idCp, fm);
            job.MdiParent = fm;
            job.Dock = DockStyle.Fill;
            this.Close();
            job.Show();   
            job.BringToFront();
            fm.resize(job.Width,job.Height);
        }
        private void UCJob_Click(object sender, EventArgs e, int idJob,int idCp, Fmain fm)
        {
            FJobDetails_Load(idJob, idCp,fm);
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
            try
            {
                if (sqlConnection.State != ConnectionState.Open)
                {
                    sqlConnection.Open();
                }

                string query = @"SELECT Job.nameJob, Job.salary, Job.position, Company.nameCompany
                         FROM Job
                         INNER JOIN Company ON Job.idCompany = Company.idCompany
                         where Job.nameJob LIKE @SearchTerm";

                SqlCommand cmd = new SqlCommand(query, sqlConnection);
                cmd.Parameters.AddWithValue("@SearchTerm", txtSearch.Text.Trim() + "%");
                SqlDataReader dr = cmd.ExecuteReader();
                pnJob.Controls.Clear();
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
            finally
            {
                sqlConnection.Close();
            }
        }

        private void loadJob(Guna2Button button)
        {
            try
            {
                if (sqlConnection.State != ConnectionState.Open)
                {
                    sqlConnection.Open();
                }

                string query = @"SELECT Job.nameJob, Job.salary, Job.position, Company.nameCompany
                        FROM Job
                        INNER JOIN Company ON Job.idCompany = Company.idCompany
                        where Job.category = @SearchTerm";

                SqlCommand cmd = new SqlCommand(query, sqlConnection);
                cmd.Parameters.AddWithValue("@SearchTerm", button.Text.Trim());
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
            finally
            {
                sqlConnection.Close();
            }
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
            try
            {
                if (sqlConnection.State != ConnectionState.Open)
                {
                    sqlConnection.Open();
                }

                string query = @"SELECT Job.nameJob, Job.salary, Job.position, Company.nameCompany
                        FROM Job
                        INNER JOIN Company ON Job.idCompany = Company.idCompany
                        where Job.salary = @salary";
                SqlCommand cmd = new SqlCommand(query, sqlConnection);
                cmd.Parameters.AddWithValue("@salary", cboExperience.SelectedItem.ToString());
                SqlDataReader dr = cmd.ExecuteReader();
                pnJob.Controls.Clear();
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
            finally
            {
                sqlConnection.Close();
            }
            if (cboExperience.SelectedItem.ToString() == "Tất cả mức lương")
            {
                loadJobInPanel();
            }
        }
    }
}
