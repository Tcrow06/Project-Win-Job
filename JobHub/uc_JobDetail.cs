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
        CandidateDAO cd = new CandidateDAO();
        public event EventHandler JobSavedClick;
        public event EventHandler btnApplyClick;

        /*        private int idJob;
                private int idCompany;

                public int IdJob { get => idJob; set => idJob = value; }
                public int IdCompany { get => idCompany; set => idCompany = value; }*/
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
        public void SaveJob(object sender, EventArgs e, int idJob, Fmain fm)
        {
            if (fm.Account == null)
            {
                fm.Login();
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
        public void UnSaveJob(object sender, EventArgs e, int idJob, FlowLayoutPanel pn, Fmain fm, FFavouriteJob ffj)
        {
            ptbSave.Image = Properties.Resources.heartChuaLuu;
            cd.UnSavedJob(idJob, fm.Account.Id);
            pn.Controls.Clear();
            ffj.LoadUcDetail();
        }

        private void btnApply_Click(object sender, EventArgs e)
        {
            if(btnApply.Text =="Ứng tuyển")
            {
                OnJobDetailClick(e);
            }
            else
            {
                btnApplyClick?.Invoke(sender, e);  
            }
        }
    }
}
