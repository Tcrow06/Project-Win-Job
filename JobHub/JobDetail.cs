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
    public class JobDetail
    {
        private JobDetailDao jdd = new JobDetailDao();
        private ChangTheSize changTheSize = new ChangTheSize();
        private int idJob;
        private string nameJob;
        private int idCompany;
        private string salary;
        private string address;
        private string description;
        private string experience;
        private string requirement;
        private string benefit;
        private string category;
        private DateTime postDate;
        private DateTime registerDead;
        private float minSalary;
        private float maxSalary;
        public JobDetail()
        {

        }

        public JobDetail(int idJob, string nameJob, int idCompany, string salary,
            string address, string description, string experience, string requirement, string benefit, string category, DateTime postDate, DateTime registerDead, float minSalary,float maxSalary)
        {
            this.idJob = idJob;
            this.nameJob = nameJob;
            this.idCompany = idCompany;
            this.salary = salary;
            this.address = address;
            this.description = description;
            this.experience = experience;
            this.requirement = requirement;
            this.benefit = benefit;
            this.category = category;
            this.PostDate = postDate;
            this.RegisterDead = registerDead;
            this.minSalary = minSalary;
            this.maxSalary = maxSalary;

        }

        public int IdJob { get => idJob; set => idJob = value; }
        public string NameJob { get => nameJob; set => nameJob = value; }
        public int IdCompany { get => idCompany; set => idCompany = value; }
        public string Salary { get => salary; set => salary = value; }
        public string Address { get => address; set => address = value; }
        public string Description { get => description; set => description = value; }
        public string Requirement { get => requirement; set => requirement = value; }
        public string Benefit { get => benefit; set => benefit = value; }
        public string Category { get => category; set => category = value; }
        public string Experience { get => experience; set => experience = value; }
        public DateTime PostDate { get => postDate; set => postDate = value; }
        public DateTime RegisterDead { get => registerDead; set => registerDead = value; }

        public float MinSalary { get => minSalary; set => minSalary = value; }
        public float MaxSalary { get => maxSalary; set => maxSalary = value; }

        public string HandleSalary(string x, string y)
        {
            if (x == "0" && y == "0") return "Thoả thuận";

            if (x == "0") return "Trên " + y + " triệu";

            return x + " - " + y + " triệu";

        }
        public JobDetail GetInfoJobDetailFromDB(int idJob)
        {
            SqlDataReader dr = jdd.GetJobData(idJob);
            if (dr.HasRows)
            {
                dr.Read();
                return GetInfoJobDetail(dr);
            }
            return null;
        }
        public JobDetail GetInfoJobDetail(SqlDataReader dr)
        {
            JobDetail jd = new JobDetail();
            jd.idJob = int.Parse(dr["idJob"].ToString());
            jd.NameJob = dr["jobName"].ToString();
            jd.Salary = HandleSalary(dr["jobMinSalary"].ToString(), dr["jobMaxSalary"].ToString());
            jd.Address = dr["jobAddress"].ToString();
            jd.Experience = dr["jobExperience"].ToString();
            jd.Description = dr["jobDescription"].ToString();
            jd.Requirement = dr["jobRequirement"].ToString();
            jd.Benefit = dr["jobBenefit"].ToString();
            jd.RegisterDead = Convert.ToDateTime(dr["jobRegisterDead"]).Date;
            jd.PostDate = Convert.ToDateTime(dr["jobPostDate"]).Date;
            return jd;
        }
        public uc_JobDetail InsertInfoAndEventIntoUcJobDetail(SqlDataReader dr, Fmain fm)
        {
            uc_JobDetail job = new uc_JobDetail();
            job.lblJobName.Text = dr["jobName"].ToString();
            job.lblCompanyName.Text = dr["companyName"].ToString();
            job.lblSalary.Text = job.HandleSalary(dr["jobMinSalary"].ToString(), dr["jobMaxSalary"].ToString());
            job.lblJobAddress.Text = dr["jobAddress"].ToString();
            string projectFolderPath = Directory.GetParent(Application.StartupPath).Parent.FullName;
            string imagePath = Path.Combine(projectFolderPath, dr["companyAvatar"].ToString());
            job.pbAvatar.Image = Image.FromFile(imagePath);
            job.IdJob = int.Parse(dr["idJob"].ToString());
            job.IdCompany = int.Parse(dr["idCompany"].ToString());

            job.loadJobClick += (sender, e) =>
            {
                job.LoadJobDetail(sender, e, job.IdJob, job.IdCompany, fm);
            };
            job.JobSavedClick += (sender, e) =>
            {
                job.SaveJob(sender, e, job.IdJob, fm);
            };
            return job;
        }
        public uC_Job InsertInfoAndEventIntoUcJob(SqlDataReader dr, Fmain fm)
        {
            uC_Job job = new uC_Job();
            job.lblJobName.Text = dr["jobName"].ToString();

            job.lblCompanyName.Text = dr["companyName"].ToString();
            job.lblSalary.Text = job.HandleSalary(dr["jobMinSalary"].ToString(), dr["jobMaxSalary"].ToString());

            string projectFolderPath = Directory.GetParent(Application.StartupPath).Parent.FullName;
            string imagePath = Path.Combine(projectFolderPath, dr["companyAvatar"].ToString());
            job.pbAvatar.Image = Image.FromFile(imagePath);

            job.lblJobAddress.Text = dr["jobAddress"].ToString();
            job.IdJob = int.Parse(dr["idJob"].ToString());
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
            return job;
        }
        public uC_NewJob InsertInfoAndEventIntoUcNewJob(SqlDataReader dr, Fmain fm)
        {
            uC_NewJob job = new uC_NewJob();
            job.lblJobName.Text = dr["jobName"].ToString();

            job.lblCompanyName.Text = dr["companyName"].ToString();
            string projectFolderPath = Directory.GetParent(Application.StartupPath).Parent.FullName;
            string imagePath = Path.Combine(projectFolderPath, dr["companyAvatar"].ToString());
            job.pbAvatar.Image = Image.FromFile(imagePath);

            
            int idJob = int.Parse(dr["idJob"].ToString());
            int idCompany = int.Parse(dr["idCompany"].ToString());
            job.loadJobClick += (sender, e) =>
            {
                job.LoadJobDetail(sender, e, idJob, idCompany, fm);
            };
            return job;
        }
        public uC_HotJob InsertInfoAndEventIntoUcHotJob(SqlDataReader dr, Fmain fm)
        {
            uC_HotJob job = new uC_HotJob();
            job.lblJobName.Text = dr["jobName"].ToString();

            string projectFolderPath = Directory.GetParent(Application.StartupPath).Parent.FullName;
            string imagePath = Path.Combine(projectFolderPath, dr["companyAvatar"].ToString());
            job.pbAvatar.Image = Image.FromFile(imagePath);
            job.pbAvatar.Height = job.pbAvatar.Width;
            job.btnField.Text = dr["jobField"].ToString();
            job.lblNumberOfViews.Text = dr["jobNumberOfViews"]?.ToString() ?? "0";
            job.lblNumberOfCandidates.Text = dr["jobNumberOfCandidates"].ToString();

            job.lblSalary.Text = job.HandleSalary(dr["jobMinSalary"].ToString(), dr["jobMaxSalary"].ToString());

            int idJob = int.Parse(dr["idJob"].ToString());
            int idCompany = int.Parse(dr["idCompany"].ToString());
            job.loadJobClick += (sender, e) =>
            {
                job.LoadJobDetail(sender, e, idJob, idCompany, fm);
            };
            /*            changTheSize.setSize(130, 25, job.lblJobName);*/
            return job;
        }
        public void AddJob(JobDetail a)
        {
            jdd.AddJob(a);
        }
    }
}
