using Guna.UI2.WinForms;
using Guna.UI2.WinForms.Enums;
using Guna.UI2.WinForms.Suite;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
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
        private CompanyDetail companyDetail= new CompanyDetail();
        private Candidate cd = new Candidate();
        Fmain fm = new Fmain();
        
        private Company company= new Company();
        private Function function = new Function(); 

        private List<string> listCompanyImage = new List<string>();
        int indexImage = 0;

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
            pnDetail.BringToFront();
            LoadPanelImage();
            LoadEvaluate();
        }
        private int GetWidth(Guna2HtmlLabel l)
        {
            return TextRenderer.MeasureText(l.Text, l.Font).Width;
        }
        private void LoadCompanyDetail()
        {
            company = companyDetail.GetInfoCompanyDetail(company.Id); 
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
            listCompanyImage = company.ListCompanyImage;

            function.InsertImage(company.Avatar, pbAvatar);

            pbBackground.Size = new Size(100, 100);
            pbBackground.BorderRadius = 50;
            Description(company.Description);
            FollowStatus();
            companyDetail.LoadUc_JobDetail(company.Id, flpUC_JobDetail, fm);

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
            if(fm.Account == null)
            {
                btnFollowCompany.Image = Properties.Resources.plus;
                
            }
            else
            {
                if (!cd.CheckFollowStatus(company.Id, fm.Account.Id))
                {
                    btnFollowCompany.Image = Properties.Resources.plus;
                }
                else
                    btnFollowCompany.Image = Properties.Resources.checkmark;
            }
        }
        private void btnFollowCompany_Click(object sender, EventArgs e)
        {
            if (fm.Account == null)
            {
                fm.Login();
            }
            else
            {
                if (cd.CheckFollowStatus(company.Id, fm.Account.Id))
                {
                    cd.UnFollowedCompany(fm.Account.Id, company.Id);
                    FollowStatus();
                }
                else
                {
                    cd.FollowedCompany(fm.Account.Id, company.Id);
                    FollowStatus();
                }
            }
        }        
        private void btnDetail_Click(object sender, EventArgs e)
        {   
            pnImage.Visible = false;
            pnDetail.Visible = true;
            flpnEvaluate.Visible = false;
            pnDetail.BringToFront();
        }
        private void LoadImageIntoPictureBox(Guna2PictureBox pictureBox, int indexImage)
        {
            lblImage.Text = (indexImage + 1).ToString() + "/" + listCompanyImage.Count.ToString();
            string image = listCompanyImage[indexImage].Trim();
            if(image.Length > 0)
            {
                function.InsertImage(image, pictureBox);
            }
        }
        private void LoadPanelImage()
        {
             
            if (listCompanyImage!=null)
            {
                LoadImageIntoPictureBox(pbCompanyInfo, 0);
                pnImage.Location = pnDetail.Location;
                lblImage.Visible = true;
                pbNext.Visible = true;
                pbBack.Visible = true;
            }
            else
            {
                lblImage.Visible = false;
                pbNext.Visible = false;
                pbBack.Visible = false; 
                pnImage.Visible = false;
            }
            pnImage.Visible = false;
        }
        private void btnImage_Click(object sender, EventArgs e)
        {
            pnDetail.Visible = false;
            pnImage.Visible = true;
            flpnEvaluate.Visible = false;
            pnImage.BringToFront();
        }
        private void pbBack_Click(object sender, EventArgs e)
        {
            indexImage -= 1;
            if(indexImage < 0)
                indexImage = listCompanyImage.Count - 1;
            LoadImageIntoPictureBox(pbCompanyInfo, indexImage);
        }
        private void pbNext_Click(object sender, EventArgs e)
        {
            indexImage += 1;
            if (indexImage >= listCompanyImage.Count)
                indexImage = 0;
            LoadImageIntoPictureBox(pbCompanyInfo, indexImage);
        }

        private void btnEvaluate_Click(object sender, EventArgs e)
        {
            pnDetail.Visible = false;
            pnImage.Visible = false;
            flpnEvaluate.Visible = true;
            flpnEvaluate.BringToFront();
        }
        private void LoadInfoEvaluate()
        {
            SqlDataReader dr = companyDetail.LoadInfoEvaluate(company.Id);
            function.LoadInfoEvaluate(dr, uC_EvaluateInfo);
            uC_EvaluateInfo.clickBtn += (sender, e) =>
            {
                if (fm.Account!=null)
                {
                    if (companyDetail.CheckEvaluated(fm.Account.Id))
                    {
                        MessageBox.Show("Bạn đã đánh giá nên không thể đánh giá thêm.","Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        //mở form
                        LoadEvaluate();
                    }
                }
                else
                {
                    MessageBox.Show("Vui lòng đăng nhập", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            };
        }
        private void LoadUc_JobEvaluate()
        {
            SqlDataReader dr = companyDetail.LoadUc_JobEvaluate(company.Id);
            function.LoadUc_JobEvaluate(dr, flpnUC);

        }
        private void LoadEvaluate()
        {
            LoadInfoEvaluate();
            LoadUc_JobEvaluate();
            flpnEvaluate.Location = new Point(pnDetail.Location.X + 20, pnDetail.Location.Y);
        }
    }
}
