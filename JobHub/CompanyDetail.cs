using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JobHub
{
    public class CompanyDetail


    {
        private CompanyDetailDAO companyDetailDao = new CompanyDetailDAO(); 
        private CandidateDAO candidate = new CandidateDAO();  
        private JobDetail jobDetail = new JobDetail();
        private Function function = new Function();

        public Company GetInfoCompanyDetail(int idCompany)
        {
            
            SqlDataReader dr = companyDetailDao.GetInfoCompanyDetailFromDB(idCompany);
            if (dr.HasRows)
            {
                dr.Read();
                return GetInfoCompanyDetail(dr);
            }
            return null;

        }
        public Company GetInfoCompanyDetail(SqlDataReader dr)
        {
            Company company = new Company();
            company.Id = int.Parse(dr["idCompany"].ToString());
            company.Name = dr["companyName"].ToString();
            company.Avatar = dr["companyAvatar"].ToString();
            company.Address = dr["companyAddress"].ToString();
            company.Phone = dr["companyPhone"].ToString();
            company.Description = dr["companyDescription"].ToString();
            company.Email = dr["companyEmail"].ToString();
            company.Link = dr["companyLink"].ToString();
            company.Size = dr["companySize"].ToString();
            company.ListCompanyImage = dr["companyImagePath"] != DBNull.Value? dr["companyImagePath"].ToString().Split('+').ToList(): null;
            company.BusinessLicense = dr["companyBusinessLicense"].ToString();
            return company;

        }
        
        public void LoadUc_JobDetail(int idCompany, FlowLayoutPanel pn, Fmain fm)
        {
            SqlDataReader dr = companyDetailDao.LoadAllCompanyJobInformation(idCompany);
            LoadUC_JobIntoPanel(dr, pn, fm);
        }
        public void LoadUC_JobIntoPanel(SqlDataReader dr, FlowLayoutPanel pn, Fmain fm)
        {
            pn.Controls.Clear();    
            if (dr != null)
            {
                while (dr.Read())
                {
                    uc_JobDetail job = jobDetail.InsertInfoAndEventIntoUcJobDetail(dr, fm);
                    int idJob = int.Parse(dr["idJob"].ToString());
                    if (fm.Account == null)
                    {
                        job.ptbSave.Image = Properties.Resources.heartNotSaved;
                    }
                    else
                    {
                        if (!candidate.CheckSaveStatus(idJob, fm.Account.Id))
                        {
                            job.ptbSave.Image = Properties.Resources.heartNotSaved;
                        }
                        else
                        {
                            job.ptbSave.Image = Properties.Resources.heartSave;
                        }
                    }
                    pn.Controls.Add(job);
                }
                dr.Dispose();
            }
        }
        public SqlDataReader LoadUc_JobEvaluate(int idJob)
        {
            return companyDetailDao.LoadUc_JobEvaluate(idJob);
        }
        public SqlDataReader LoadInfoEvaluate(int idJob)
        {
            return companyDetailDao.LoadInfoEvaluate(idJob);
        }
        public bool CheckEvaluated(int idCandidate, int idCompany)
        {
            DataTable dt = companyDetailDao.CheckEvaluated(idCandidate, idCompany);
            if(dt.Rows.Count > 0)
            {
                return true;
            }
            return false;
        }

        public uC_Company InsertInfoAndEventIntoUcCompany(SqlDataReader dr, Fmain fm)
        {
            uC_Company company = new uC_Company();
            int idCompany = int.Parse(dr["idCompany"].ToString());
            company.IdCompany = idCompany;
            company.lblCompanyName.Text= dr["companyName"].ToString();
            function.InsertImage(dr["companyAvatar"].ToString(), company.pbCompanyAvatar);
            company.lblNumofE.Text= dr["companySize"].ToString();
            company.lblCompanyAddress.Text= dr["companyAddress"].ToString();
            return company;
/*
            company.lbl = dr["jobName"].ToString();

            job.lblCompanyName.Text = dr["companyName"].ToString();
            job.lblSalary.Text = job.HandleSalary(dr["jobMinSalary"].ToString(), dr["jobMaxSalary"].ToString());


            function.InsertImage(dr["companyAvatar"].ToString(), job.pbAvatar);

            job.lblJobAddress.Text = dr["jobAddress"].ToString();
            job.IdCompany = int.Parse(dr["idCompany"].ToString());

            job.loadJobClick += (sender, e) =>
            {
                job.LoadJobDetail(sender, e, job.IdJob, job.IdCompany, fm);
            };
            job.loadCompanyClick += (sender, e) =>
            {
                job.LoadCompanyDetail(sender, e, job.IdCompany, fm);
            };
            changTheSize.setSize(130, 25, job.lblJobName);
            return job;*/
        }


    }
}
