using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JobHub
{
    public class CompanyList
    {
        private CompanyListDao companylistdao = new CompanyListDao();
        ChangTheSize changTheSize = new ChangTheSize();
        CompanyDetail companydetail = new CompanyDetail();


        public void LoadFilterUcCompany(FlowLayoutPanel flPanel,Fmain fm, string search)
        {
            string sql = "";
            if (search.Length > 0)
            {
                sql += " where ";
                sql += $"Company.companyName LIKE N'%{search}%'";
            }
            SqlDataReader dr = companylistdao.LoadFilterUcCompany(sql);
            LoadUcIntoPanel(dr, flPanel, fm);
        }

        public void LoadUcIntoPanel(SqlDataReader dr, FlowLayoutPanel flPanel, Fmain fm)
        {
            flPanel.Controls.Clear();
            if (dr != null)
            {
                while (dr.Read())
                {
                    uC_Company company = companydetail.InsertInfoAndEventIntoUcCompany(dr, fm);
                    //changTheSize.setSize(130, 25, job.lblJobName);
                    flPanel.Controls.Add(company);
                }
                dr.Close();
            }
        }



    }
}
