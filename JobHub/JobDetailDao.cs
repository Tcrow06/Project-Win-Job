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
        SqlConnection sqlConnection = new SqlConnection(Properties.Settings.Default.conn);

        public JobDetailDao() { }

        public JobDetail GetInfoJobDetailFromDB(int idJob)
        {
            JobDetail jd = new JobDetail();

            string query = $"SELECT*from Job where Job.idJob = {idJob}";
            SqlDataReader dr = dbc.loadData(query);
            if (dr.HasRows)
            {
                dr.Read();
                jd.NameJob = dr["jobName"].ToString();
                jd.Salary = dr["jobSalary"].ToString();
                jd.Address= dr["jobAddress"].ToString();
                jd.Experience = dr["jobExperience"].ToString();
                jd.Description = dr["jobDescription"].ToString();
                jd.Requirement = dr["jobRequirement"].ToString();
                jd.Benefit = dr["jobBenefit"].ToString();
                jd.RegisterDead = Convert.ToDateTime(dr["jobRegisterDead"]);
                jd.PostDate = Convert.ToDateTime(dr["jobPostDate"]);

            }
            return jd;
        }
    }
}
