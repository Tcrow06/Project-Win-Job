using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
                jb.NameJob = dr["nameJob"].ToString();
                jb.Salary = dr["salary"].ToString();
                jb.Address= dr["position"].ToString();
                jb.Experience = dr["experience"].ToString();
                jb.Description = dr["describe"].ToString();
                jb.Requirement = dr["requirement"].ToString();
                jb.Benefit = dr["benefit"].ToString();

            }
            return jb;
        }
    }
}
