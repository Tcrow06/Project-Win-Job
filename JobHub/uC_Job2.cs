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
    public partial class uC_Job2: UserControl
    {
        public event EventHandler loadJobClick;
        public uC_Job2()
        {
            InitializeComponent();
        }

        private void uC_Job2_Click(object sender, EventArgs e)
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
            fm.Forms.Push(job);
            fm.resize(job.Width + 160, job.Height + 50);
            job.MdiParent = fm;
            job.Dock = DockStyle.Fill;
            job.Show();
            job.BringToFront();
        }

        private void ucJob_Paint(object sender, PaintEventArgs e)
        {

        }

        private void lblNameCompany_Click(object sender, EventArgs e)
        {

        }
    }
}
