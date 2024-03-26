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
    public partial class uC_Job : UserControl
    {
        public event EventHandler loadJobClick;
        public uC_Job()
        {
            InitializeComponent();
            //ucJob.Click += Even;
        }


        private void guna2Panel1_DoubleClick(object sender, EventArgs e)
        {

            //loadJobClick?.Invoke(this, e);
        }

        private void ucJob_Click(object sender, EventArgs e)
        {
            loadJobClick?.Invoke(this, e);
        }
        //Nháp 
 /*       private void Even(object sender, EventArgs e)
        {
            FJobDetails f = new FJobDetails();
            f.Show();
        }*/
        public void LoadJobDetail(object sender, EventArgs e, int idJob, int idCp, Fmain fm)
        {
            FJobDetails_Load(idJob, idCp, fm);
        }
        private void FJobDetails_Load(int idJob, int idCp, Fmain fm)
        {
            FJobDetails job = new FJobDetails(idJob, idCp, fm);
            job.MdiParent = fm;
            job.Dock = DockStyle.Fill;
            job.Show();
            job.BringToFront();
            fm.resize(job.Width, job.Height);
        }
    }
}
