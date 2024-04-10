using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JobHub
{
    public class FindJob
    {
        private FindJobDao findJobDao = new FindJobDao();
        ChangTheSize changTheSize = new ChangTheSize();
        JobDetail jobDetail = new JobDetail();
        public FindJob() { }

        public void LoadUcJobFilter(FlowLayoutPanel flPanel, Fmain fm, bool tech, bool it, bool eco, string industry, string  salary,
            string address, string ex, string search)
        {
            string sql = "where (";
            bool check = false;
            if (tech)
            {
                sql += " Job.jobField LIKE N'Kỹ thuật%'";
                check = true;
            }
            if (it) //Kinh tế
            {
                if (check)
                    sql += " or ";
                check = true;
                sql += "Job.jobField LIKE N'Công nghệ%'";
            }
            if (eco)
            {
                if (check)
                    sql += " or ";
                check = true;
                sql += "Job.jobField LIKE N'Kinh tế%'";
            }
            if(industry!= "Tất cả các ngành")
            {
                if (check)
                    sql += " or ";
                check = true;
                sql += $"Job.jobField LIKE N'{industry}%'";
            }
            sql += ")";
            if (!check)
            {
                sql = "where ";
            }


            if (salary != "Tất cả mức lương")
            {
                float minSalary;
                float maxSalary;
                string[] txt = salary.Trim().Split();
                if (salary == "Thỏa thuận")
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
                    minSalary = 0; maxSalary = float.Parse(txt[1]);
                }
                if (check)
                    sql += " and ";
                check = true;
                if (minSalary == 0 && maxSalary == 0)
                {
                    sql += $"Job.jobMinSalary = 0 and Job.jobMaxSalary = 0";
                }
                else if (minSalary == 0 && maxSalary != 0)
                    sql += $"Job.jobMaxSalary >= {maxSalary}";
                else
                    sql += $@"((Job.jobMinSalary <= {minSalary} and Job.jobMaxSalary >=  {minSalary}) 
                            or (Job.jobMinSalary <= {maxSalary} and jobMaxSalary >= {maxSalary} )) 
                            and Job.jobMinSalary != 0";
            }
            if(ex != "Tất cả kinh nghiệm")
            {
                if (check)
                    sql += " and ";
                check = true;
                sql += $"Job.jobExperience LIKE N'{ex}%'";
            }
            if(address!= "Tất cả tỉnh/thành phố")
            {
                if (check)
                    sql += " and ";
                check = true;
                sql += $"Job.jobAddress LIKE N'{address}%'";
            }
                
            if(search.Length > 0)
            {
                if (check)
                    sql += " and ";
                check = true;
                sql += $"Job.jobName LIKE N'{search}%'";
            }
                
            if (!check)
            {
                sql = "";
            }

            SqlDataReader dr = findJobDao.LoadUcJobFilter(sql);
            LoadUcIntoPanel(dr, flPanel, fm);
        }
        public void LoadUcIntoPanel(SqlDataReader dr, FlowLayoutPanel flPanel, Fmain fm)
        {
            flPanel.Controls.Clear();
            if (dr != null)
            {
                while (dr.Read())
                {
                    uC_Job job = jobDetail.InsertInfoAndEventIntoUcJob(dr, fm);
                    changTheSize.setSize(130, 25, job.lblJobName);
                    flPanel.Controls.Add(job);
                }
                dr.Close();
            }
        }
        
    }
}
