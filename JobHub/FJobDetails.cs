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
        

        private int count = 0;
        private int idJob;
        private int idCp;
        private Fmain fm;
        public FJobDetails()
        {
            InitializeComponent();
        }
        public FJobDetails(int idJob,int IdCp, Fmain fm)
        {
            can.Id = 1;
            this.fm = fm;
            this.idJob = idJob;
            this.idCp = IdCp;
            InitializeComponent();
        }
        private void FJobDetails_Load(object sender, EventArgs e)
        {
            LoadJobDetails(idJob);
            LoadCompanyDetails(idCp);
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
            DateTime date = jd.RegisterDead;
            string day = date.ToString("dd/MM/yyyy");
            lblRegisterDead.Text = day;
            
            
            SaveStatus();
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
                int x = lblInfo.Location.X;
                int y = lblInfo.Location.Y - lblInfo.Height;
                pnInfo.Height = lblName.Height  + 10;

                Label lblBefore = new Label();
                lblBefore = lblInfo;
                lblInfo.Dispose();
                for (int i = 0; i < arr.Length; i++)
                {
                    Label lblCur = new Label();
                    lblCur.Font = lblInfo.Font;
                    if (arr[i][0] != '-')
                        lblCur.Text = "+";

                    lblCur.Text += arr[i];
                    lblCur.AutoSize = false;
                    lblCur.Size = new Size(lblInfo.Width, lblInfo.Height);
                    Size textSize = TextRenderer.MeasureText(arr[i], lblCur.Font);
                    int j = textSize.Width / lblCur.Width;
                    if (j >= 1)
                    {
                        lblCur.Height = lblInfo.Height * (j);
                    }
                    y += lblBefore.Height;
                    lblBefore = lblCur; 
                    pnInfo.Height += lblCur.Height;
                    pnInfo.Controls.Add(lblCur);
                    lblCur.Location = new Point(x, y);
                }
            }
        }
        private void SaveStatus()
        {
            if (!cd.CheckSaveStatus(idJob, can.Id))
            {
                btnSave.Image = Properties.Resources.heartChuaLuu;
            }
            else
            {
                btnSave.Image = Properties.Resources.heartDaLuu;
            }
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (cd.CheckSaveStatus(idJob, can.Id))
            {
                btnSave.Image = Properties.Resources.heartChuaLuu;
                cd.UnSavedJob(idJob, can.Id);
            }
            else
            {
                cd.SavedJob(idJob, can.Id);
                btnSave.Image = Properties.Resources.heartDaLuu;
            }
        }

        private void lblCompany_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FCompanyDetails fcd = new FCompanyDetails(idCp, fm);
            fm.resize(fcd.Width + 200, fcd.Height +50);
            fcd.MdiParent = fm;
            fcd.Dock = DockStyle.Fill;
            fcd.Show();
            fcd.BringToFront();
            
        }


        private void btnApply_Click(object sender, EventArgs e)
        {
            can.Id = 2;
            int IdCv = 2;
            cd.Apply(idJob,can.Id,IdCv);
        }
    }
}
