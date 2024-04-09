﻿using System;
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
    public class FavoriteJob
    {
        private FavoriteJobDao favoriteJobDao = new FavoriteJobDao();
        JobDetail jobDetail = new JobDetail();
        public FavoriteJob() { }

        public void LoadUc_JobDetail(FlowLayoutPanel pn, Fmain fm, Label x, FFavouriteJob ffb)
        {
            SqlDataReader dr = favoriteJobDao.LoadUc_JobDetail(pn, fm, x);  
            int i = 0;
            if (dr != null)
            {
                while (dr.Read())
                {
                    i++;
                    uc_JobDetail job = jobDetail.InsertInfoAndEventIntoUcJobDetail(dr, fm);
                    job.ptbSave.Image = Properties.Resources.heartDaLuu;
                    job.JobSavedClick += (sender, e) =>
                    {
                        job.UnSaveJob(sender, e, job.IdJob, pn, fm, ffb);
                    };
                    pn.Controls.Add(job);
                }
                dr.Dispose();
            }
            x.Text = i.ToString();
        }
    }
}