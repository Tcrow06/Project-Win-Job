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
    public partial class uc_JobMain : UserControl
    {
        public event EventHandler loadJobClick;
        public uc_JobMain()
        {
            InitializeComponent();
        }
        protected virtual void OnJobDetailClick(EventArgs e)
        {
            loadJobClick?.Invoke(this, e);
        }
        public void LoadJobDetail(object sender, EventArgs e, int idJob, int idCompany, Fmain fm, Account account)
        {
            FJobDetails_Load(idJob, idCompany, fm, account);
        }
        private void FJobDetails_Load(int idJob, int idCp, Fmain fm, Account account)
        {

            FJobDetails job = new FJobDetails(idJob, idCp, fm, account);
            fm.HideChildForm();
            FormAndInfoCandidate fai = new FormAndInfoCandidate(job, idJob, idCp);
            fm.Forms.Push(fai);
            fm.resize(job.Width + 160, job.Height + 50);
            job.MdiParent = fm;
            job.Dock = DockStyle.Fill;
            job.Show();
            job.BringToFront();
        }
    }
}
