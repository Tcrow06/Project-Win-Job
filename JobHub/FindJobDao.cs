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
        public SqlDataReader LoadUc_Job()
        {
            string query = $@"SELECT Job.idJob, Job.jobName,Job.jobMinSalary,Job.jobMaxSalary, 
                            Job.jobAddress, Company.companyName, Company.idCompany, Company.companyAvatar
                            FROM Job
                            INNER JOIN Company ON Job.idCompany = Company.idCompany and Job.jobRegisterDead >= '{DateTime.Now.Date}'";
            return db.loadData(query);
        }
        public SqlDataReader LoadButton(string txtButton)
        {
            string query = $@"SELECT Job.idJob, Company.idCompany, Job.jobName,Job.jobMinSalary,Job.jobMaxSalary, Job.jobAddress, Company.companyName ,Company.companyAvatar
                    FROM Job
                    INNER JOIN Company ON Job.idCompany = Company.idCompany
                    where Job.jobField LIKE N'{txtButton}%'";
            return db.loadData(query);
        }
        public SqlDataReader LoadTxtSearch(string txtSearch)
        {
            string query = $@"SELECT Job.idJob, Company.idCompany, Job.jobName,Job.jobMinSalary,
                            Job.jobMaxSalary, Job.jobAddress, Company.companyName, Company.companyAvatar
                             FROM Job
                             INNER JOIN Company ON Job.idCompany = Company.idCompany
                             where Job.jobName LIKE N'%{txtSearch}%'";
            return db.loadData(query);
        }
        public SqlDataReader LoadTxtExperience(string txtEx)
        {
            string query = $@"SELECT Job.idJob, Company.idCompany, Job.jobName,Job.jobMinSalary,
                            Job.jobMaxSalary, Job.jobAddress, Company.companyName, Company.companyAvatar
                            FROM Job
                            INNER JOIN Company ON Job.idCompany = Company.idCompany
                            where Job.jobExperience LIKE N'{txtEx.Trim()}%'";
            return db.loadData(query);
        }
        public SqlDataReader LoadTxtAddress(string txtAddress)
        {
            string query = $@"SELECT Job.idJob, Company.idCompany, Job.jobName,Job.jobMinSalary,
                            Job.jobMaxSalary, Job.jobAddress, Company.companyName, Company.companyAvatar
                            FROM Job
                            INNER JOIN Company ON Job.idCompany = Company.idCompany
                            where Job.jobAddress LIKE N'{txtAddress.Trim()}%'";
            return db.loadData(query);
        }
        public SqlDataReader LoadTxtIndustry(string txtIndustry)
        {
            string query = $@"SELECT Job.idJob, Company.idCompany, Job.jobName,Job.jobMinSalary,
                            Job.jobMaxSalary, Job.jobAddress, Company.companyName, Company.companyAvatar
                            FROM Job
                            INNER JOIN Company ON Job.idCompany = Company.idCompany
                            where Job.jobField LIKE N'{txtIndustry.Trim()}%'";
            return db.loadData(query);
        }
        public SqlDataReader LoadTxtSalary(string txtEx)
        {
            float minSalary;
            float maxSalary;
            string[] txt = txtEx.Trim().Split();
            if (txtEx == "Thỏa thuận")
            {
                minSalary = 0; maxSalary = 0;
            }
            else if (txt[1] == "-")
            {
                minSalary = float.Parse(txt[0]);
                maxSalary = float.Parse(txt[2]);
            }
            else
            {
                minSalary=0; maxSalary = float.Parse(txt[1]);
            }

            string query = $@"SELECT Job.idJob, Company.idCompany, Job.jobName,Job.jobMinSalary,
                            Job.jobMaxSalary, Job.jobAddress, Company.companyName, Company.companyAvatar
                            FROM Job
                            INNER JOIN Company ON Job.idCompany = Company.idCompany
                            where ";
            if (minSalary == 0 && maxSalary == 0)
            {
                query += $"Job.jobMinSalary = 0 and Job.jobMaxSalary = 0";
            }
            else if (minSalary == 0 && maxSalary != 0)
                query += $"Job.jobMaxSalary >= {maxSalary}";
            else
                query += $@"((Job.jobMinSalary <= {minSalary} and Job.jobMaxSalary >=  {minSalary}) 
                            or (Job.jobMinSalary <= {maxSalary} and jobMaxSalary >= {maxSalary} )) 
                            and Job.jobMinSalary != 0";
            return db.loadData(query);
        }
    }
}
