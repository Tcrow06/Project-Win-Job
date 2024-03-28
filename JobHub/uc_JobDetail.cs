using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JobHub
{
    public partial class uc_JobDetail : UserControl
    {
        //private bool saveCheck= false;
        CandidateDao cd = new CandidateDao();
        public event EventHandler loadJobClick;
        public event EventHandler JobSavedClick;
        public uc_JobDetail()
        {
            InitializeComponent();
        }

        private void ptbSave_Click(object sender, EventArgs e, int idJob, int idCp, Fmain fm)
        {
            //JobSavedClick?.Invoke(this, e);
            //if()
            /* if (saveCheck)
             {   
                 ptbSave.Image = Properties.Resources.heartChuaLuu;
                 cd.SavedJob(can.Id, company.Id);
                 saveCheck = false;
             }
             else
             {
                 ptbSave.Image = Properties.Resources.heartDaLuu;

             }*/
        }

        private void uc_JobDetail_Click(object sender, EventArgs e)
        {
            loadJobClick?.Invoke(this, e);
        }
        public void LoadJobDetail(object sender, EventArgs e, int idJob, int idCp, Fmain fm)
        {
            FJobDetails_Load(idJob, idCp, fm);
        }
        private void FJobDetails_Load(int idJob, int idCp, Fmain fm)
        {

            FJobDetails job = new FJobDetails(idJob, idCp, fm);
            fm.resize(job.Width + 160, job.Height + 50);
            job.MdiParent = fm;
            job.Dock = DockStyle.Fill;
            job.Show();
            job.BringToFront();
        }

        private void ptbSave_Click(object sender, EventArgs e)
        {
            JobSavedClick?.Invoke(this, e);
        }
        public void SaveJob(object sender, EventArgs e, int idJob, int idCan)
        {
            if (cd.CheckSaveStatus(idJob, idCan))
            {
                ptbSave.Image = Properties.Resources.heartChuaLuu;
                cd.UnSavedJob(idJob, idCan);
            }
            else
            {
                cd.SavedJob(idJob, idCan);
                ptbSave.Image = Properties.Resources.heartDaLuu;
            }
        }
    }
}
