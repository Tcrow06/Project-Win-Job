using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace JobHub
{
    public class JobPostHistory
    {
        private JobPostHistoryDao dao = new JobPostHistoryDao();
        private JobDetail jobDetail = new JobDetail();
        private Image edit = Properties.Resources.edit;
        private Image delete = Properties.Resources.detele;
        public JobPostHistory() { }

        public void LoadFullGridView(int idCompany, DataGridView dgv)
        {

            SqlDataReader dr = dao.LoadFullGridView(idCompany);
            while (dr.Read())
            {
                JobDetail jd = jobDetail.GetInfoJobDetail(dr);
                dgv.Rows.Add(jd.PostDate.ToString("dd-MM-yyyy"), jd.NameJob, jd.Address, jd.Salary, edit, delete, jd.IdJob.ToString());
            }
        }
        public void DeleteJob(int idJob)
        {
            //MessageBox.Show(idJob.ToString());
            dao.DeleteJob(idJob);
        }
    }
}
