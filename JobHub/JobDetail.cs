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
    public class JobDetail
    {
        private JobDetailDAO jdd = new JobDetailDAO();
        private ChangTheSize changTheSize = new ChangTheSize();
        private Function function= new Function();
        private Candidate candidate = new Candidate();  

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
        public void IncreaseView(int idJob)
        {
            jdd.IncreaseView(idJob);
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
            jd.MinSalary = (float)Convert.ToDouble(dr["jobMinSalary"]);
            jd.MaxSalary = (float)Convert.ToDouble(dr["jobMaxSalary"]);
            jd.Category = dr["jobField"].ToString();
            return jd;
        }
        public uc_JobDetail InsertInfoAndEventIntoUcJobDetail(SqlDataReader dr, Fmain fm)
        {
            uc_JobDetail job = new uc_JobDetail();
            job.lblJobName.Text = dr["jobName"].ToString();
            job.lblCompanyName.Text = dr["companyName"].ToString();
            job.lblSalary.Text = job.HandleSalary(dr["jobMinSalary"].ToString(), dr["jobMaxSalary"].ToString());
            job.lblJobAddress.Text = dr["jobAddress"].ToString();
            
            function.InsertImage(dr["companyAvatar"].ToString(), job.pbAvatar);
            job.IdJob = int.Parse(dr["idJob"].ToString());
            job.IdCompany = int.Parse(dr["idCompany"].ToString());

            job.JobField = dr["jobField"].ToString();

            job.loadJobClick += (sender, e) =>
            {
                job.LoadJobDetail(sender, e,job.IdJob, job.IdCompany, fm);
            };
            job.JobSavedClick += (sender, e) =>
            {
                job.SaveJob(sender, e, job.IdJob, fm);
            };

            if (fm.Account != null)
            {
                if (candidate.CheckApplyStatus(job.IdJob, fm.Account.Id))
                {
                    job.btnApply.Text = "Hủy ứng tuyển";
                    job.btnApply.Width += 30;
                    job.btnApply.Location = new Point(job.btnApply.Location.X - 30, job.btnApply.Location.Y);
                }
                
            }
            
            return job;
        }
        public uC_Job InsertInfoAndEventIntoUcJob(SqlDataReader dr, Fmain fm)
        {
            uC_Job job = new uC_Job();
            int idJob = int.Parse(dr["idJob"].ToString());
            job.IdJob = idJob;

            string field = dr["jobField"].ToString();
            job.JobField = field;

            job.lblJobName.Text = dr["jobName"].ToString();

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
            return job;
        }
        public uC_NewJob InsertInfoAndEventIntoUcNewJob(SqlDataReader dr, Fmain fm)
        {
            uC_NewJob job = new uC_NewJob();
            job.IdJob = int.Parse(dr["idJob"].ToString());
            job.JobField = dr["jobField"].ToString();
            job.IdCompany = int.Parse(dr["idCompany"].ToString());
            job.lblJobName.Text = dr["jobName"].ToString();
            string field = dr["jobField"].ToString() ;
            job.lblCompanyName.Text = dr["companyName"].ToString();

            function.InsertImage(dr["companyAvatar"].ToString(), job.pbAvatar);

            job.loadJobClick += (sender, e) =>
            {
                job.LoadJobDetail(sender, e, job.IdJob, job.IdCompany, fm);
            };
            return job;
        }
        public uC_HotJob InsertInfoAndEventIntoUcHotJob(SqlDataReader dr, Fmain fm)
        {
            uC_HotJob job = new uC_HotJob();
            job.IdJob = int.Parse(dr["idJob"].ToString());
            job.JobField = dr["jobField"].ToString();
            job.lblJobName.Text = dr["jobName"].ToString();

            function.InsertImage(dr["companyAvatar"].ToString(), job.pbAvatar);

            job.pbAvatar.Height = job.pbAvatar.Width;
            job.lblField.Text = dr["jobField"].ToString();
            job.lblNumberOfViews.Text = function.HandleNumbers(int.Parse(dr["jobNumberOfViews"]?.ToString()));

            job.lblSalary.Text = job.HandleSalary(dr["jobMinSalary"].ToString(), dr["jobMaxSalary"].ToString());
            job.IdCompany = int.Parse(dr["idCompany"].ToString()); 
            job.loadJobClick += (sender, e) =>
            {
                job.LoadJobDetail(sender, e, job.IdJob, job.IdCompany, fm);
            };
            SqlDataReader drCount = jdd.CountCandiDate(job.IdJob);
            int candidateNumber = 0;
            if (dr!=null)
            {
                
                drCount.Read();
                candidateNumber = int.Parse(drCount["CandidateNumbers"].ToString());
            }
            job.lblNumberOfCandidates.Text = function.HandleNumbers(candidateNumber);

            return job;
        }
        public void AddJob(JobDetail a)
        {
            jdd.AddJob(a);
        }

        public void LoadRelatedJobs(int idJob, FlowLayoutPanel flpn, Fmain fm)
        {
            SqlDataReader dr = jdd.LoadRelatedJobs(idJob);
          CompanyDetail companyDetail = new CompanyDetail();
          companyDetail.LoadUC_JobIntoPanel(dr,flpn,fm);



        }
        public SqlDataReader LoadUc_JobEvaluate(int idJob)
        {
            return jdd.LoadUc_JobEvaluate(idJob);
        }
        public SqlDataReader LoadInfoEvaluate(int idJob)
        {
            return jdd.LoadInfoEvaluate(idJob);
        }
        public bool CheckEvaluated(int idCandidate, int idJob)
        {
            DataTable dt = jdd.CheckEvaluated(idCandidate, idJob);
            if (dt.Rows.Count > 0)
            {
                return true;
            }
            return false;
        }
    }
}
