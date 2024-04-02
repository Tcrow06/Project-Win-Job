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
    public partial class uC_Job : uc_JobMain
    {
        public event EventHandler loadCompanyClick;
        public uC_Job()
        {
            InitializeComponent();
        }

        private void ucJob_Click(object sender, EventArgs e)
        {
            OnJobDetailClick(e);
        }

        private void lblNameCompany_Click(object sender, EventArgs e)
        {
            loadCompanyClick?.Invoke(sender,e);
        }
        public void LoadCompanyDetail(object sender, EventArgs e, int idCp, Fmain fm, Account account)
        {
            FCompanyDetails_Load(idCp, fm, account);
        }
        private void FCompanyDetails_Load( int idCp, Fmain fm, Account account)
        {

            FCompanyDetails job = new FCompanyDetails(idCp, fm, account);
            FormAndInfoCandidate fai = new FormAndInfoCandidate(job,-1, idCp);
            fm.HideChildForm();
            fm.Forms.Push(fai);
            fm.resize(job.Width + 170, job.Height + 50);
            job.MdiParent = fm;
            job.Dock = DockStyle.Fill;
            job.Show();
            job.BringToFront();
        }

    }
}
