using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.SqlServer.Server;

namespace JobHub
{
    public class JobDetailDao
    {
        DBConection dbc = new DBConection();

        public JobDetailDao() { }
        public SqlDataReader GetJobData(int idJob)
        {
            string query = $"SELECT*from Job where Job.idJob = {idJob}";
            return dbc.loadData(query);
        }
        public SqlDataReader IncreaseView(int idJob)
        {
            string query = $"update Job set jobNumberOfViews = jobNumberOfViews + 1 where idJob = {idJob}";
            return dbc.loadData(query);
        }
        public SqlDataReader CountCandiDate(int idJob)
        {
            string sql = $@"select count(idJob) as CandidateNumbers from AppliedCV where idJob = {idJob}";
            return dbc.loadData(sql);
        }
        public void AddJob(JobDetail A)
        {
            string sqlStr = string.Format("INSERT INTO Job(idJob,idCompany,jobName,jobAddress,jobExperience,jobDescription,jobRequirement,jobBenefit,jobPostDate,JobRegisterDead,jobMinSalary,jobMaxSalary) VALUES (N'{0}','{1}',N'{2}',N'{3}',N'{4}',N'{5}',N'{6}',N'{7}',N'{8}',N'{9}',N'{10}')",A.IdJob, A.IdCompany, A.NameJob, A.Salary, A.Address, A.Experience, A.Description, A.Requirement, A.Benefit, A.PostDate, A.RegisterDead);
            dbc.ThucThi(sqlStr);

        }
        public void Them(JobDetail A)
        {
            string sqlStr = string.Format("INSERT INTO Job(idJob,idCompany,jobName,jobAddress,jobExperience,jobDescription,jobRequirement,jobBenefit,jobPostDate,JobRegisterDead,jobField,jobMinSalary,jobMaxSalary) VALUES (N'{0}','{1}',N'{2}',N'{3}',N'{4}',N'{5}',N'{6}',N'{7}',N'{8}',N'{9}',N'{10}',N'{11}',N'{12}')", A.IdJob, A.IdCompany, A.NameJob, A.Address, A.Experience, A.Description, A.Requirement, A.Benefit, A.PostDate, A.RegisterDead,A.Category,A.MinSalary,A.MaxSalary);
            dbc.ThucThi(sqlStr);

        }

    }
}
