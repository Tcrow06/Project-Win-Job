using Guna.UI2.WinForms;
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
    public partial class FCompanyDetails : Form
    {
        private bool saveCheck = false;
        private CompanyDetailDao cdd= new CompanyDetailDao();
        CandidateDao cd = new CandidateDao();
        Candidate can = new Candidate();
        Fmain fm = new Fmain();
        
        CompanyDetail company= new CompanyDetail();
        public FCompanyDetails()
        {
            InitializeComponent();
        }
        public FCompanyDetails(int idCompany, Fmain fm)
        {
            InitializeComponent();
            this.fm = fm;   
            company.Id = idCompany;
        }
        private void FCompanyDetails_Load(object sender, EventArgs e)
        {
            LoadCompanyDetail();
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
            Description(company.Description);
            cdd.LoadUc_JobDetail(company.Id, can.Id, flpUC_JobDetail, fm);

        }
        private int GetWidth(Guna2HtmlLabel l)
        {
            return TextRenderer.MeasureText(l.Text, l.Font).Width;
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

        private void btnFollowCompany_Click(object sender, EventArgs e)
        {
            if (saveCheck)
            {
                can.Id = 1;
                btnFollowCompany.Image = Properties.Resources.plus;
                cd.UnFollowedCompany(can.Id, company.Id);
                saveCheck = false;

            }
            else
            {
                saveCheck = true;
                can.Id = 1;
                btnFollowCompany.Image = Properties.Resources.checkmark;
                cd.FollowedCompany(can.Id, company.Id);
            }
        }
    }
}
