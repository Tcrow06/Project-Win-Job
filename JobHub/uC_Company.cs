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
    public partial class uC_Company : uC_CompanyMain
    {
        public event EventHandler loadCompanyClick;
        public uC_Company()
        {
            InitializeComponent();
        }

        private void lblCompanyName_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            loadCompanyClick?.Invoke(sender, e);
        }

        public void LoadCompanyDetail(object sender, EventArgs e, int idCp, Fmain fm)
        {
            FCompanyDetails_Load(idCp, fm);
        }

        public void FCompanyDetails_Load(int idCp, Fmain fm)
        {

            FCompanyDetails job = new FCompanyDetails(idCp, fm);
            FormAndInfoCandidate fai = new FormAndInfoCandidate(job, -1, idCp);
            fm.HideChildForm();
            fm.Forms.Push(fai);
            fm.resize(955, 640);
            job.MdiParent = fm;
            job.Dock = DockStyle.Fill;
            job.Show();
            job.BringToFront();
        }


    }
}
