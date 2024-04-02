using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
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
        CandidateDao cd = new CandidateDao();
        CompanyDetailDao cdd = new CompanyDetailDao();
        JobDetailDao jdd= new JobDetailDao();
        private Account account;

        private int idJob;
        private int idCp;
        private Fmain fm;

        public int IdJob { get => idJob; set => idJob = value; }
        public int IdCp { get => idCp; set => idCp = value; }
        public Account Account { get => account; set => account = value; }

        public FJobDetails()
        {
            InitializeComponent();
        }
        public FJobDetails(int idJob,int IdCp, Fmain fm, Account account)
        {
            this.fm = fm;
            this.IdJob = idJob;
            this.IdCp = IdCp;
            this.Account = account;
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
            lblEmployee.Location = new System.Drawing.Point(lblNumofE.Location.Y + lblNumofE.Width + 2, lblNumofE.Location.Y);
            string projectFolderPath = Directory.GetParent(Application.StartupPath).Parent.FullName;
            string imagePath = Path.Combine(projectFolderPath, cd.Avatar);
            pbCompanyAvatar.Image = Image.FromFile(imagePath);
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
            
            ApplyStatus();
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
            if(desc != null)
            {
                if (desc.Length > 0)
                {
                    string[] arr = desc.Split('~');
                    int x = lblInfo.Location.X;
                    int y = lblInfo.Location.Y - lblInfo.Height;
                    pnInfo.Height = lblName.Height + 10;

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
        }
        
        private void SaveStatus()
        {
            if (Account == null)
            {
                //CustomMessageBox.Show("Bạn chưa đăng nhập");
                FLogin login = new FLogin();
                login.Show();
            }
            else
            {
                if (!cd.CheckSaveStatus(IdJob, Account.Id))
                {
                    btnSave.Image = Properties.Resources.heartChuaLuu;
                }
                else
                {
                    btnSave.Image = Properties.Resources.heartDaLuu;
                }
            }
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            if(Account == null)
            {
                //CustomMessageBox.Show("Bạn chưa đăng nhập");
                FLogin login = new FLogin(IdJob, IdCp, fm);
                login.Show();
            }
            else
            {
                if (cd.CheckSaveStatus(IdJob, Account.Id))
                {
                    cd.UnSavedJob(IdJob, Account.Id);
                    SaveStatus();
                }
                else
                {
                    cd.SavedJob(IdJob, Account.Id);
                    SaveStatus();
                }
            }
        }

        private void lblCompany_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FCompanyDetails fcd = new FCompanyDetails(IdCp, fm, Account);
            FormAndInfoCandidate fai = new FormAndInfoCandidate(fcd, -1, IdCp);
            fm.Forms.Push(fai);
            fm.resize(fcd.Width + 200, fcd.Height +50);
            fcd.MdiParent = fm;
            fcd.Dock = DockStyle.Fill;
            fcd.Show();
            fcd.BringToFront();
            
        }
        private void ApplyStatus()
        {
            if(Account  == null)
            {
                btnApply.Text = "Ứng tuyển";
            }
            else
            {
                if (!cd.CheckApplyStatus(IdJob, Account.Id))
                {
                    btnApply.Text = "Ứng tuyển";
                }
                else
                {
                    btnApply.Text = "Hủy ứng tuyển";
                }
            }
        }

        private void btnApply_Click(object sender, EventArgs e)
        {
            if (Account == null)
            {
                FLogin login = new FLogin(IdJob, IdCp, fm);
                login.Show();
            }
            else
            {
                if (cd.CheckApplyStatus(IdJob, Account.Id))
                {

                    cd.UnApplyJob(IdJob, Account.Id, Account.Id);
                    ApplyStatus();
                }
                else
                {

                    cd.ApplyJob(IdJob, Account.Id, Account.Id);
                    ApplyStatus();
                }
            }
                
  
        }

/*        public override void LoadForm(Account account)
        {
            throw new NotImplementedException();
        }*/
    }
}
