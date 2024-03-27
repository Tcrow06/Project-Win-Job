using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JobHub
{
    public partial class FJobDetails : Form
    {
        Candidate can = new Candidate();
        CandidateDao cd = new CandidateDao();
        CompanyDetailDao cdd = new CompanyDetailDao();
        JobDetailDao jdd= new JobDetailDao(); 
        int i = 2;

        private int count = 0;
        private int IdJob;
        private int IdCp;
        private Fmain fm;
        public FJobDetails()
        {
            InitializeComponent();
        }
        public FJobDetails(int idJob,int IdCp, Fmain fm)
        {
            this.fm = fm;
            this.IdJob = idJob;
            this.IdCp = IdCp;
            InitializeComponent();
        }
        private void FJobDetails_Load(object sender, EventArgs e)
        {
            LoadJobDetails(IdJob);
            LoadCompanyDetails(IdCp);
        }
        private void LoadCompanyDetails(int idCompany)
        {
            
            CompanyDetail cd = cdd.GetInfoCompanyDetailFromDB(idCompany);
            lblCompanyName.Text = cd.Name;
            lblCompanyAddress.Text = cd.Address; 
            lblNumofE.Text = cd.Size;
        }
        private void LoadJobDetails(int idJob)
        {
            JobDetail jd = jdd.GetInfoJobDetailFromDB(idJob);
            lblJobName.Text = jd.NameJob;
            lblSalary.Text = jd.Salary;
            lblAddress.Text = jd.Address;
            lblExperience.Text = jd.Experience;
            DescribeJob(jd.Description);
            RequirementJob(jd.Requirement);
            BenefitJob(jd.Benefit);
        }
        public void DescribeJob(string desc)
        {
            InfoJob(pnJobDescription, desc, lblDesc, lblDescInfo);
            pnJobDescription.Height += 10;
        }
        private void RequirementJob(string desc)
        {
            InfoJob(pnRequirement, desc, lblRe, lblReInfo);
            pnRequirement.Height += 10;
        }
        private void BenefitJob(string desc)
        {
            InfoJob(pnBenefit, desc, lblBe, lblBeInfo);
        }
        public void InfoJob(Panel pnInfo, string desc, Label lblName, Label lblInfo)
        {
            if(desc.Length > 0) { 
            string[] arr = desc.Split('~');
            if (arr[0][0]=='-')
                    lblInfo.Text =" ";
            else 
                lblInfo.Text = "+ " + arr[0];
            int x = lblInfo.Location.X;
            int y = lblInfo.Location.Y;
            pnInfo.Height = lblName.Height + lblInfo.Height + 10;
            Label lblBefore = new Label();
                lblBefore = lblInfo;
            for (int i = 1; i < arr.Length; i++)
            {
                Label lblCur = new Label();
                lblCur.Font = lblInfo.Font;
                lblCur.Text = " ";
                if (arr[i][1] != '-')
                    lblCur.Text = "+";

                lblCur.Text += arr[i];
                lblCur.AutoSize = false;
                lblCur.Size = new Size(lblInfo.Width, lblInfo.Height);
                Size textSize = TextRenderer.MeasureText(arr[i], lblCur.Font);
                int j = textSize.Width / lblCur.Width;
                if (j >= 1)
                {
                    lblCur.Height = lblInfo.Height * j;
                }
                y += lblBefore.Height;
                lblBefore = lblCur; 
                pnInfo.Height += lblCur.Height;
                pnInfo.Controls.Add(lblCur);
                lblCur.Location = new Point(x, y);
            }
            }
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            count++;
            if (count%2 == 0)
            {
                btnSave.Image = Properties.Resources.heartChuaLuu;
               
            }
            else
            {
                btnSave.Image = Properties.Resources.heartDaLuu;
                string query = String.Format($"insert into SavedJob(");
            }
        }

        private void lblCompany_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FCompanyDetails fcd = new FCompanyDetails(IdCp);
            fm.Forms.Push(fcd);
            fcd.MdiParent = fm;
            fcd.Dock = DockStyle.Fill;
            fcd.Show();
            fcd.BringToFront();
            fm.resize(fcd.Width + 150, fcd.Height + 130);
        }


        private void btnApply_Click(object sender, EventArgs e)
        {
            can.Id = i++;
            int IdCv = i++;
            cd.Apply(IdJob,can.Id,IdCv);
        }
    }
}
