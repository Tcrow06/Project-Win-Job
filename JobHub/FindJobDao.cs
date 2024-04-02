using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JobHub
{
    public class FindJobDao
    {
        private DBConection db = new DBConection();
        ChangTheSize changTheSize = new ChangTheSize();
        private Account account;
        public FindJobDao(Account account)
        {
            this.account = account;
        }
        public void LoadUc_Job(FlowLayoutPanel flPanel, Fmain fm)
        {
            string query = $@"SELECT Job.idJob, Job.jobName, Job.jobSalary, Job.jobAddress, Company.companyName, Company.idCompany
                        FROM Job
                         INNER JOIN Company ON Job.idCompany = Company.idCompany";
            SqlDataReader dr = db.loadData(query);
            while (dr.Read())
            {
                uC_Job job = new uC_Job();
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
                    job.LoadJobDetail(sender, e, idJob, idCp, fm, account);
                };
                job.loadCompanyClick += (sender, e) =>
                {
                    job.LoadCompanyDetail(sender, e, idCp, fm,account);
                };
            }
            dr.Dispose();
        }
        public void LoadTxtSearch(FlowLayoutPanel flPanel, Fmain fm, string txtSearch)
        {
            string query = $@"SELECT Job.idJob, Company.idCompany, Job.jobName, Job.jobSalary, Job.jobAddress, Company.companyName
                        FROM Job
                         INNER JOIN Company ON Job.idCompany = Company.idCompany
                         where Job.jobName LIKE N'%{txtSearch}%'";
            SqlDataReader dr = db.loadData(query);

            while (dr.Read())
            {
                uC_Job job = new uC_Job();
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
                    job.LoadJobDetail(sender, e, idJob, idCp, fm, account);
                };
                job.loadCompanyClick += (sender, e) =>
                {
                    job.LoadCompanyDetail(sender, e, idCp, fm, account);
                };
            }
            dr.Dispose();
        }
        }
}
