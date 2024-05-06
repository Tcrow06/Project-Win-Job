using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JobHub
{
    internal class AppliedCVDAO
    {
        DBConection db = new DBConection();
        public AppliedCVDAO() { }  
        public SqlDataReader LoadAppliedCV(int idCandidate)
        {
            string query = $@"select Job.idJob, Job.State, Job.idCompany, Job.idCandidate, Job.jobField ,Job.jobName,Company.companyName,Company.companyAvatar, job.jobMinSalary , job.jobMaxSalary, Job.jobAddress
                from Company join (select  Job.idJob,Job.jobField, Job.idCompany, AppliedCV.idCandidate, AppliedCV.State, Job.jobName, job.jobMinSalary , job.jobMaxSalary, Job.jobAddress 
                from AppliedCV join Job on Job.idJob = AppliedCV.idJob) as Job on Job.idCompany = Company.idCompany where Job.idCandidate = {idCandidate} ";

            return db.loadData(query);
        }
    }
}
