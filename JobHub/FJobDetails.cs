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
        private Candidate cd = new Candidate();
        private CompanyDetail cdd = new CompanyDetail();
        private JobDetail jdd = new JobDetail(); 

        private int idJob;
        private int idCp;
        private Fmain fm;
        public FJobDetails()
        {
            InitializeComponent();
        }
        public FJobDetails(int idJob,int IdCp, Fmain fm)
        {
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

            CompanyDetail cd = cdd.GetInfoCompanyDetail(idCompany);
            lblCompanyName.Text = cd.Name;
            lblCompanyAddress.Text = cd.Address;
            lblNumofE.Text = cd.Size;
            Size textSize = TextRenderer.MeasureText(lblNumofE.Text, lblNumofE.Font);

            lblEmployee.Location = new System.Drawing.Point(lblNumofE.Location.X + textSize.Width, lblNumofE.Location.Y);
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
            if (fm.Account == null)
            {
                btnSave.Image = Properties.Resources.heartChuaLuu;
                /*                fm.Login();
                                *//*FLogin login = new FLogin();
                                login.Show();*/
            }
            else
            {
                if (!cd.CheckSaveStatus(idJob, fm.Account.Id))
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
            if(fm.Account == null)
            {
                fm.Login();
            }
            else
            {
                if (cd.CheckSaveStatus(idJob, fm.Account.Id))
                {
                    cd.UnSavedJob(idJob, fm.Account.Id);
                    SaveStatus();
                }
                else
                {
                    cd.SavedJob(idJob, fm.Account.Id);
                    SaveStatus();
                }
            }
        }

        private void lblCompany_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            uC_Job job = new uC_Job();
            job.FCompanyDetails_Load(idCp, fm);
        }
        private void ApplyStatus()
        {
            if(fm.Account  == null)
            {
                btnApply.Text = "Ứng tuyển";
            }
            else
            {
                if (!cd.CheckApplyStatus(idJob, fm.Account.Id))
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
            if (fm.Account == null)
            {
                fm.Login();   
            }
            else
            {
                ///Chưa hoàn hành nộp cv 
                ///



                /////
                if (cd.CheckApplyStatus(idJob, fm.Account.Id))
                {
                    cd.UnApplyJob(idJob, fm.Account.Id, fm.Account.Id);
                    ApplyStatus();
                }
                else
                {
                    FApplyWithCV fApplyWithCV = new FApplyWithCV(idJob,fm.Account);
                    fApplyWithCV.ShowDialog();
                    //cd.ApplyJob(idJob, fm.Account.Id,  fm.Account.Id);
                    //ApplyStatus();
                }
            }
                
  
        }

    }
}
