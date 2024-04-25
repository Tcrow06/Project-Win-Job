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
using static System.Net.Mime.MediaTypeNames;

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
                            Job.jobAddress, Company.companyName, Company.idCompany, Company.companyAvatar, Job.jobField
                            FROM Job
                            INNER JOIN Company ON Job.idCompany = Company.idCompany 
                            where Job.jobNumberOf = (select max(Job.jobNumberOfViews) from Job) and Job.jobRegisterDead >= '{DateTime.Now.Date}'";
            return db.loadData(query);
        }
        public SqlDataReader LoadFilterUcJob(string txt)
        {
            string query = $@"SELECT Job.idJob, Company.idCompany, Job.jobName,Job.jobMinSalary,Job.jobMaxSalary, Job.jobAddress, 
                            Company.companyName ,Company.companyAvatar, Job.jobField
                    FROM Job
                    INNER JOIN Company ON Job.idCompany = Company.idCompany  
                    {txt} Job.jobRegisterDead >= '{DateTime.Now.Date}'";
            return db.loadData(query);
        }
        public SqlDataReader LoadUCHotJob()
        {
            SqlDataReader dr = null;
                string sql = $@"SELECT Job.idJob, Company.idCompany, Job.jobName, Company.companyName ,Company.companyAvatar, 
                            Job.jobNumberOfViews, Job.jobField ,Job.jobMinSalary,Job.jobMaxSalary
                    FROM Job
                    INNER JOIN Company ON Job.idCompany = Company.idCompany
                    where Job.jobRegisterDead >= '{DateTime.Now.Date}' and Job.jobNumberOfViews = (
                                                                                        select max(jobNumberOfViews) 
                                                                                        from Job
                                                                                        where Job.jobRegisterDead >= '{DateTime.Now.Date}'
                                                                                        )";
                dr = db.loadData(sql);
            return dr;
        }

        public SqlDataReader LoadUCNewJob()
        {
            SqlDataReader dr = null;
                string sql = $@"SELECT top 5 
                                        Job.idJob, Company.idCompany, Job.jobName, Company.companyName ,Company.companyAvatar, Job.jobField
                                FROM Job
                                INNER JOIN Company ON Job.idCompany = Company.idCompany
                                where Job.jobRegisterDead >= '{DateTime.Now.Date}'
                                order by Job.jobPostDate desc";
                dr = db.loadData(sql);
            return dr;
        }
       


    }
}
