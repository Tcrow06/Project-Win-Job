﻿using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Management;

namespace JobHub
{
    public  class JobPostHistoryDao
    {
        DBConection db = new DBConection();
        public JobPostHistoryDao() { }
        public SqlDataReader LoadFullGridView(int idCompany)
        {
               string query = string.Format($"select* from Job where Job.idCompany = {idCompany}");
               return db.loadData( query );
        }
        public void DeleteJob(int idJob)
        {
            MessageBox.Show("co");
            string query = string.Format($"delete Job where Job.idJob = {idJob}");
            db.ThucThi(query );
        }
    }
}