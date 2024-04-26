using System;
using System.Collections.Generic;
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
                        job.ptbSave.Image = Properties.Resources.heartChuaLuu;
                    }
                    else
                    {
                        if (!candidate.CheckSaveStatus(idJob, fm.Account.Id))
                        {
                            job.ptbSave.Image = Properties.Resources.heartChuaLuu;
                        }
                        else
                        {
                            job.ptbSave.Image = Properties.Resources.heartDaLuu;
                        }
                    }
                    pn.Controls.Add(job);
                }
                dr.Dispose();
            }
        }
    }
}
