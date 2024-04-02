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
    public partial class uc_JobDetail : uc_JobMain
    {
        CandidateDao cd = new CandidateDao();
        public event EventHandler JobSavedClick;
        public uc_JobDetail()
        {
            InitializeComponent();
        }


        private void uc_JobDetail_Click(object sender, EventArgs e)
        {
            OnJobDetailClick(e);
        }

        private void ptbSave_Click(object sender, EventArgs e)
        {
            JobSavedClick?.Invoke(this, e);
        }
        public void SaveJob(object sender, EventArgs e, int idJob, int idCan, Account account)
        {
            if (account == null)
            {
                FLogin login = new FLogin();    
                login.ShowDialog(); 
            }
            else
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
}
