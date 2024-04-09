using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Web.Configuration;
using System.Windows.Forms;

namespace JobHub
{
    public class FindJobDao
    {
        DBConection db = new DBConection();
        public FindJobDao()
        {
        }
        public SqlDataReader LoadUc_SlideJob()
        {
            string query = $@"SELECT Job.idJob, Job.jobName,Job.jobMinSalary,Job.jobMaxSalary, 
                            Job.jobAddress, Company.companyName, Company.idCompany, Company.companyAvatar
                            FROM Job
                            INNER JOIN Company ON Job.idCompany = Company.idCompany and Job.jobRegisterDead >= '{DateTime.Now.Date}'
                            where Job.jobNumberOf = (select max(Job.jobNumberOfViews) from Job)";
            return db.loadData(query);
        }
        public SqlDataReader LoadFilterUcJob(string txt)
        {
            string query = $@"SELECT Job.idJob, Company.idCompany, Job.jobName,Job.jobMinSalary,Job.jobMaxSalary, Job.jobAddress, Company.companyName ,Company.companyAvatar
                    FROM Job
                    INNER JOIN Company ON Job.idCompany = Company.idCompany and Job.jobRegisterDead >= '{DateTime.Now.Date}'
                    {txt}";
            return db.loadData(query);
        }
       
    }
}
