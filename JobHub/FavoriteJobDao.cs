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
    public class FavoriteJobDao
    {
        DBConection dbc = new DBConection();

        public SqlDataReader LoadUc_JobDetail(FlowLayoutPanel pn, Fmain fm, Label x)
        {
            string query = $@"select Job.idJob, Job.idCompany, Job.idCandidate, Job.jobName,Company.companyName,Company.companyAvatar, job.jobMinSalary , job.jobMaxSalary, Job.jobAddress
                from Company join (select  Job.idJob, Job.idCompany, SavedJob.idCandidate, Job.jobName, job.jobMinSalary , job.jobMaxSalary, Job.jobAddress 
                from SavedJob join Job on Job.idJob = SavedJob.idJob) as Job on Job.idCompany = Company.idCompany where Job.idCandidate = {fm.Account.Id} ";

            return dbc.loadData(query);
        }
    }
}
