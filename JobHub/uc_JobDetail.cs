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
        private ReLoadFormCandidate reLoadForm = new ReLoadFormCandidate();

        private int idJob;
        private int idCompany;

        public int IdJob { get => idJob; set => idJob = value; }
        public int IdCompany { get => idCompany; set => idCompany = value; }
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
        private void Login(Fmain fm)
        {
            FLogin login = new FLogin(fm);
            login.ShowDialog();
            login = null;
            if (fm.Account != null)
            {
                FormAndInfoCandidate form = reLoadForm.ReLoadLogin(fm);
                fm.loadFormReload(form.Form);
            }
        }
        public void SaveJob(object sender, EventArgs e, int idJob, Fmain fm)
        {
            if (fm.Account == null)
            {
                Login(fm);
            }
            else
            {
                if (cd.CheckSaveStatus(idJob, fm.Account.Id))
                {
                    ptbSave.Image = Properties.Resources.heartChuaLuu;
                    cd.UnSavedJob(idJob, fm.Account.Id);
                }
                else
                {
                    cd.SavedJob(idJob, fm.Account.Id);
                    ptbSave.Image = Properties.Resources.heartDaLuu;
                }
            }
        }
        public void UnSaveJob(object sender, EventArgs e, int idJob, FlowLayoutPanel pn,Fmain fm, FFavouriteJob ffj)
        {
            ptbSave.Image = Properties.Resources.heartChuaLuu;
            cd.UnSavedJob(idJob, fm.Account.Id);
            pn.Controls.Clear();
            ffj.LoadUcDetail();
        }
        /*public void UnSaveJob(object sender, EventArgs e, int idJob, int idCan, Fmain fm)
        {
            if (fm.Account == null)
            {
                Login(fm);
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
        }*/
    }
}
