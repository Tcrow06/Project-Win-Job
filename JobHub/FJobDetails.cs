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
        SqlConnection sqlConnection = new SqlConnection(Properties.Settings.Default.conn);
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
            this.IdJob = idJob;
            this.IdCp = IdCp;
            this.fm = fm;
            InitializeComponent();
        }
        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FCompanyDetails fcd = new FCompanyDetails(IdCp);
            fcd.MdiParent = fm;
            fcd.Dock = DockStyle.Fill;
            fcd.Show();
            fcd.BringToFront();
            fm.resize(fcd.Width, fcd.Height);
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
            int numberOfE = cd.Size;
            lblNumofE.Text = (numberOfE - 2).ToString() + "-" + (numberOfE + 2).ToString();
        }
        private void LoadJobDetails(int idJob)
        {
            JobDetail jd = jdd.GetInfoJobDetailFromDB(idJob);
            lblJobName.Text = jd.NameJob;
            lblSalary.Text = jd.Salary;
            lblAddress.Text = jd.Address;
            lblExperience.Text = jd.Experience;
            //MessageBox.Show(jd.Description);
            DescribeJob(jd.Description);
            RequirementJob(jd.Requirement);
            BenefitJob(jd.Benefit);
        }
        private void NhapLoadJobDetails(int idJob, int idCp)
        {
            try
            {
                if (sqlConnection.State != ConnectionState.Open)
                {
                    sqlConnection.Open();
                }

                string query = $"SELECT*from Job where Job.idJob = {idJob}";
                SqlCommand cmd = new SqlCommand(query, sqlConnection);
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.HasRows)
                {
                    dr.Read();
                    lblJobName.Text = dr["nameJob"].ToString();
                    lblSalary.Text = dr["salary"].ToString();
                    lblAddress.Text = dr["position"].ToString();
                    lblExperience.Text = dr["experience"].ToString();
                    string desc = dr["describe"].ToString();
                    DescribeJob(desc);
                    desc = dr["requirement"].ToString() ;
                    RequirementJob(desc);
                    desc = dr["benefit"].ToString();
                    BenefitJob(desc);

                }

            }

            catch (Exception ex)
            {
                Console.WriteLine("Đã xảy ra lỗi: " + ex.Message);
            }
            sqlConnection.Close();

            try
            {
                if (sqlConnection.State != ConnectionState.Open)
                {
                    sqlConnection.Open();
                }
                string query = $"select * from Company where  Company.idCompany = {idCp}";

                SqlCommand cmd = new SqlCommand(query, sqlConnection);
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.HasRows)
                {
                    dr.Read();
                    lblCompanyName.Text = dr["nameCompany"].ToString();
                    lblCompanyAddress.Text = dr["addressCompany"].ToString();
                    int numberOfE = int.Parse(dr["size"].ToString());
                    lblNumofE.Text = (numberOfE-2).ToString() + "-" + (numberOfE + 2).ToString();
                    
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine("Đã xảy ra lỗi: " + ex.Message);
            }
            sqlConnection.Close();
        }
        public void DescribeJob(string desc)
        {

            InfoJob(pnJobDescription, desc, lblDesc, lblDescInfo);
        }
        private void RequirementJob(string desc)
        {
            InfoJob(pnRequirement, desc, lblRe, lblReInfo);
            pnRequirement.Height -= 20;
        }
        private void BenefitJob(string desc)
        {
            InfoJob(pnBenefit, desc, lblBe, lblBeInfo);
            pnBenefit.Height -= 20;
        }
        public void InfoJob(Panel pnInfo, string desc, Label lblName, Label lblInfo)
        {
            //MessageBox.Show(desc);
            if(desc.Length > 0) { 
            string[] arr = desc.Split('+');
            lblInfo.Text = "+ " + arr[0];
            int x = lblInfo.Location.X;
            int y = lblInfo.Location.Y;
            pnInfo.Height = lblName.Height + lblInfo.Height + 10;
            for (int i = 1; i < arr.Length; i++)
            {
                Label lbl = new Label();
                if (arr[i][1] != '-')
                    lbl.Text = "+";
                lbl.Text += arr[i];
                lbl.AutoSize = false;
                lbl.Size = new Size(690, 23);
                Size textSize = TextRenderer.MeasureText(arr[i], lbl.Font);
                int j = textSize.Width / lbl.Width;
                if (j >= 1)
                {
                    lbl.Height += 23 * j;
                }
                lbl.Font = lblInfo.Font;
                y += 20;
                pnInfo.Height += lbl.Height;
                pnInfo.Controls.Add(lbl);
                lbl.Location = new Point(x, y);
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
            /*            FCompanyDetails fcd = new FCompanyDetails();
                        this.Hide();
                        fcd.ShowDialog();
                        fcd = null;
                        this.Show();*/
            FCompanyDetails fcd = new FCompanyDetails(IdCp);
            fcd.MdiParent = fm;
            fcd.Dock = DockStyle.Fill;
            fcd.Show();
            fcd.BringToFront();
            fm.resize(fcd.Width+150, fcd.Height+130);
        }


        private void btnApply_Click(object sender, EventArgs e)
        {
            can.Id = i++;
            int IdCv = i++;
            cd.Apply(IdJob,can.Id,IdCv);


        }
    }
}
