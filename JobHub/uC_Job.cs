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
        public void LoadJobDetail(object sender, EventArgs e, int idjob, int idcp)
        {
            fjobdetails_load(idjob, idcp);
        }
        private void fjobdetails_load(int idjob, int idcp)
        {
            FJobDetails job = new FJobDetails(idjob, idcp);
            job.ShowDialog();
        }

        private void uC_Job_Click(object sender, EventArgs e)
        {
            loadJobClick.Invoke(this, e);
        }

    }
}
