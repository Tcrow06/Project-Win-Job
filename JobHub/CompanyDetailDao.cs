using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Common;
using System.Security.Cryptography;
using System.Windows.Forms;
using System.IO;
using System.Drawing;

namespace JobHub
{
    public class CompanyDetailDao
    {
        DBConection dbc = new DBConection();
        CandidateDao cd = new CandidateDao();
        public CompanyDetailDao() { }

        public CompanyDetail GetInfoCompanyDetailFromDB(int idCompany)
        {
            CompanyDetail cd = new CompanyDetail();
            string query = $"select * from Company where  Company.idCompany = {idCompany}";
            SqlDataReader dr = dbc.loadData(query);
            if (dr.HasRows)
            {
                dr.Read();
                cd.Id = idCompany;
                cd.Name = dr["companyName"].ToString();
                cd.Avatar = dr["companyAvatar"].ToString() ;
                cd.Address = dr["companyAddress"].ToString();
                cd.Phone = dr["companyPhone"].ToString();
                cd.Description = dr["companyDescription"].ToString();
                cd.Email = dr["companyEmail"].ToString();
                cd.Link = dr["companyLink"].ToString();
                cd.Size = dr["companySize"].ToString();
                
            }
            return cd;
        
        }
        public void LoadUc_JobDetail(int idCompany,FlowLayoutPanel pn, Fmain fm)
        {
            string query = $"select * from Job inner join Company on Company.idCompany = Job.idCompany where job.idCompany = {idCompany}";

            SqlDataReader dr = dbc.loadData(query);
            if(dr !=null)
            {
                while (dr.Read())
                {
                    uc_JobDetail job = new uc_JobDetail();
                    job.lblJobName.Text = dr["jobName"].ToString();
                    job.lblCompanyName.Text = dr["companyName"].ToString();
                    job.lblSalary.Text = dr["jobSalary"].ToString();
                    job.lblJobAddress.Text = dr["jobAddress"].ToString();
                    string projectFolderPath = Directory.GetParent(Application.StartupPath).Parent.FullName;

                    // Kết hợp với đường dẫn tương đối của tập tin ảnh
                    string imagePath = Path.Combine(projectFolderPath, dr["companyAvatar"].ToString());

                    // Nạp hình ảnh vào PictureBox
                    
                    job.pbAvatar.Image = Image.FromFile(imagePath);
 
                    pn.Controls.Add(job);
                    
                    int idJob = int.Parse(dr["idJob"].ToString());
                    int idCp = int.Parse(dr["idCompany"].ToString());
                    if(fm.Account == null)
                    {
                        job.ptbSave.Image = Properties.Resources.heartChuaLuu;
                        FLogin login = new FLogin();
                        login.Show();
                    }
                    else
                    {
                        if (!cd.CheckSaveStatus(idJob, fm.Account.Id))
                        {
                            job.ptbSave.Image = Properties.Resources.heartChuaLuu;
                        }
                        else
                        {
                            job.ptbSave.Image = Properties.Resources.heartDaLuu;
                        }
                    }
                    job.loadJobClick += (sender, e) =>
                    {
                        job.LoadJobDetail(sender, e, idJob, idCp, fm, fm.Account);
                    };
                    job.JobSavedClick += (sender, e) =>
                    {
                        job.SaveJob(sender, e, idJob, idCp, fm.Account);
                    };
                }
                dr.Dispose();
            }
            


        } 
    }
}
