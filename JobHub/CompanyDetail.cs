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
        private CompanyDetailDao companyDetailDao = new CompanyDetailDao(); 
        private CandidateDao candidate = new CandidateDao();  
        private JobDetail jobDetail = new JobDetail();
        
        
        private int id;
        private string name;
        private string avatar;
        private string address;
        private string phone;
        private string description;
        private string email;
        private string link;
        private string size;
        private List<string> listCompanyImage;
         
        public CompanyDetail()
        {
        }

        public CompanyDetail(int id, string nsame, string avatar, string address
            , string phone, string description, string email, string link, string size, List<string> listCompanyImage)
        {
            this.Id = id;
            this.Name = name;
            this.Avatar = avatar;
            this.Address = address;
            this.Phone = phone;
            this.Description = description;
            this.email = email;
            this.Link = link;
            this.Size = size;
            this.ListCompanyImage = listCompanyImage;
        }

        public int Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
        public string Avatar { get => avatar; set => avatar = value; }
        public string Address { get => address; set => address = value; }
        public string Phone { get => phone; set => phone = value; }
        public string Description { get => description; set => description = value; }
        public string Email { get => email; set => email = value; }
        public string Link { get => link; set => link = value; }
        public string Size { get => size; set => size = value; }
        public List<string> ListCompanyImage { get => listCompanyImage; set => listCompanyImage = value; }

        public CompanyDetail GetInfoCompanyDetail(int idCompany)
        {
            
            SqlDataReader dr = companyDetailDao.GetInfoCompanyDetailFromDB(idCompany);
            if (dr.HasRows)
            {
                dr.Read();
                return GetInfoCompanyDetail(dr);
            }
            return null;

        }
        public CompanyDetail GetInfoCompanyDetail(SqlDataReader dr)
        {
            CompanyDetail companyDetail = new CompanyDetail();
            companyDetail.Id = int.Parse(dr["idCompany"].ToString());
            companyDetail.Name = dr["companyName"].ToString();
            companyDetail.Avatar = dr["companyAvatar"].ToString();
            companyDetail.Address = dr["companyAddress"].ToString();
            companyDetail.Phone = dr["companyPhone"].ToString();
            companyDetail.Description = dr["companyDescription"].ToString();
            companyDetail.Email = dr["companyEmail"].ToString();
            companyDetail.Link = dr["companyLink"].ToString();
            companyDetail.Size = dr["companySize"].ToString();
            companyDetail.listCompanyImage = dr["companyImagePath"].ToString().Split('+').ToList();
            return companyDetail;

        }
        
        public void LoadUc_JobDetail(int idCompany, FlowLayoutPanel pn, Fmain fm)
        {
           
            SqlDataReader dr = companyDetailDao.LoadAllCompanyJobInformation(idCompany);
            LoadUC_JobIntoPanel(dr, pn, fm);
/*            if (dr != null)
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
            }*/
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
