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
            JobDetail jb = new JobDetail();

            string query = $"SELECT*from Job where Job.idJob = {idJob}";
            SqlDataReader dr = dbc.loadData(query);
            if (dr.HasRows)
            {
                dr.Read();
                jb.NameJob = dr["jobName"].ToString();
                jb.Salary = dr["jobSalary"].ToString();
                jb.Address= dr["jobAddress"].ToString();
                jb.Experience = dr["jobExperience"].ToString();
                jb.Description = dr["jobDescription"].ToString();
                jb.Requirement = dr["jobRequirement"].ToString();
                jb.Benefit = dr["jobBenefit"].ToString();
                jb.RegisterDead = Convert.ToDateTime(dr["jobRegisterDead"]);
        
            }
            return jb;
        }
    }
}
