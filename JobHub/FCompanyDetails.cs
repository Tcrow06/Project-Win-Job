using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JobHub
{
    public partial class FCompanyDetails : Form
    {
        private CompanyDetailDao cdd= new CompanyDetailDao();
        CandidateDao cd = new CandidateDao();
        Fmain fm = new Fmain();
        private Account account;
        
        CompanyDetail company= new CompanyDetail();
        public FCompanyDetails()
        {
            InitializeComponent();
        }
        public FCompanyDetails(int idCompany, Fmain fm, Account account)
        {
            InitializeComponent();
            this.fm = fm;   
            company.Id = idCompany;
            this.account = account;
        }
        private void FCompanyDetails_Load(object sender, EventArgs e)
        {
            LoadCompanyDetail();
        }
        private int GetWidth(Guna2HtmlLabel l)
        {
            return TextRenderer.MeasureText(l.Text, l.Font).Width;
        }
        private void LoadCompanyDetail()
        {
            company = cdd.GetInfoCompanyDetailFromDB(company.Id); 
            lblCompanyName.Text = company.Name;
            lblSize.Text = company.Size;
            lblSize.Width = GetWidth(lblSize);
            lblEmployee.Location = new Point(lblSize.Location.X+ lblSize.Width - 5, lblSize.Location.Y);
            lblDescription.Text = company.Address;
            lblGmail.Text = company.Email;
            lblGmail.Width = GetWidth(lblGmail);
            lblPhone.Text = company.Phone;
            lblLink.Text = company.Link;
            lblLink.Width = GetWidth(lblLink);
            lblAddress.Text = company.Address;

            string projectFolderPath = Directory.GetParent(Application.StartupPath).Parent.FullName;
            string imagePath = Path.Combine(projectFolderPath ,company.Avatar);
            pbAvatar.Image = Image.FromFile(imagePath);

            pbBackground.Size = new Size(100, 100);
            pbBackground.BorderRadius = 50;
            Description(company.Description);
            FollowStatus();
            cdd.LoadUc_JobDetail(company.Id, flpUC_JobDetail, fm);

        }

        public void Description(string desc)
        {
            Label lb = new Label();
            lb = lblDescription;
            lblDescription.Dispose();
            if (desc.Length > 0)
            {
                string[] arr = desc.Split('~');
                for (int i = 0; i < arr.Length; i++)
                {
                    Label lbl = new Label();
                    lbl.Font = lb.Font;
                    lbl.Width = lb.Width;
                    lbl.Height = lb.Font.Height;
                    lbl.Text = "  *";
                    lbl.Text += arr[i];
                    lbl.AutoSize = false;

                    Size textSize = TextRenderer.MeasureText(arr[i], lbl.Font);
                    int j = textSize.Width / lbl.Width;

                    if (j >= 1)
                    {
                        lbl.Height = lbl.Font.Height* (j+1);
                    }
                    flpDescription.Controls.Add(lbl);
                }
            }
        }
        private void FollowStatus()
        {
            if(account == null)
            {
                btnFollowCompany.Image = Properties.Resources.plus;
            }
            else
            {
                if (!cd.CheckFollowStatus(company.Id, account.Id))
                {
                    btnFollowCompany.Image = Properties.Resources.plus;
                }
                else
                    btnFollowCompany.Image = Properties.Resources.checkmark;


            }
        }
        private void btnFollowCompany_Click(object sender, EventArgs e)
        {


            if (account == null)
            {
                    FLogin login = new FLogin(company.Id, fm);
                    login.Show();
            }
            else
            {
                if (cd.CheckFollowStatus(company.Id, account.Id))
                {
                    cd.UnFollowedCompany(account.Id, company.Id);
                    FollowStatus();
                }
                else
                {
                    cd.FollowedCompany(account.Id, company.Id);
                    FollowStatus();
                }
            }
        }
    }
}
