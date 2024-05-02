using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JobHub
{
    public partial class FAppliedCV : Form
    {
        private AppliedCV appliedCV = new AppliedCV();
        JobDetail jobDetail = new JobDetail();
        private Candidate candidate = new Candidate();
        private Fmain fm;
        public FAppliedCV()
        {
            InitializeComponent();
        }
        public FAppliedCV(Fmain fm)
        {
            InitializeComponent();
            this.fm = fm;
        }

        private void FAppliedJob_Load(object sender, EventArgs e)
        {
            LoadAppliedJob();
        }
        private void LoadAppliedJob()
        {
            flpnAppliedCV.Controls.Clear();
            SqlDataReader dr = appliedCV.LoadAppliedCV(fm.Account.Id);
            int i = 0;
            if (dr != null)
            {
                while (dr.Read())
                {
                    i++;
                    uc_JobDetail job = jobDetail.InsertInfoAndEventIntoUcJobDetail(dr, fm);
                    if (candidate.CheckSaveStatus(job.IdJob, fm.Account.Id))
                    {
                        job.ptbSave.Image = Properties.Resources.heartDaLuu;
                    }
                    else
                    {
                        job.ptbSave.Image = Properties.Resources.heartChuaLuu;
                    }
                    job.btnApplyClick += (sender, e) =>
                    {
                        DialogResult dialog = MessageBox.Show("Bạn có chắc chắn hủy ứng tuyển ?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                        if (dialog == DialogResult.OK)
                        {
                            candidate.UnApplyJob(job.IdJob, fm.Account.Id);
                            job.Dispose();  
                        }
                    };
                    flpnAppliedCV.Controls.Add(job);
                }
                dr.Dispose();
            }
            lblNumberOfAppliedCV.Text = i.ToString();
        }
    }
}
