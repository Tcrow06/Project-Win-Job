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
    public partial class FCompanyDetails2 : Form
    {
        private CompanyDetail companyDetail = new CompanyDetail();
        private Candidate cd = new Candidate();
        Fmain fm = new Fmain();
          
        private Company company = new Company();
        private Function function = new Function();
        private string imagePath;

        private List<string> listCompanyImage = new List<string>();
        int indexImage = 0;
        public FCompanyDetails2()
        {
            InitializeComponent();
        }

        public FCompanyDetails2(Fmain fm)
        {
            InitializeComponent();
            this.fm = fm;
            company.Id = fm.Account.Id;
        }

        private int GetWidth(Guna2HtmlLabel l)
        {
            return TextRenderer.MeasureText(l.Text, l.Font).Width;
        }

        public void LoadCompanyDetail()
        {
            company = companyDetail.GetInfoCompanyDetail(company.Id);
            lblCompanyName.Text = company.Name;
            lblSize.Text = company.Size;
            lblSize.Width = GetWidth(lblSize);
            lblEmployee.Location = new Point(lblSize.Location.X + lblSize.Width - 5, lblSize.Location.Y);
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
                        lbl.Height = lbl.Font.Height * (j + 1);
                    }
                    flpDescription.Controls.Add(lbl);
                }
            }
        }

        private void LoadImageIntoPictureBox(Guna2PictureBox pictureBox, int indexImage)
        {
            lblImage.Text = (indexImage + 1).ToString() + "/" + listCompanyImage.Count.ToString();
            string image = listCompanyImage[indexImage].Trim();
            if (image.Length > 0)
            {
                function.InsertImage(image, pictureBox);
            }
        }

        private void LoadPanelImage()
        {

            if (listCompanyImage != null )
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
        }

        private void LoadPanelEdit()
        {
            panelEditCompany.Location = pnDetail.Location;
        }


        private void btnCompanyyAccountRegister_Click(object sender, EventArgs e)
        {
            btnDeletePic.Visible = false;
            pnImage.Visible = false;
            panelEditCompany.Visible = true;
            pnDetail.Visible = false;
            panelEditCompany.BringToFront();
        }

        private void FCompanyDetails2_Load(object sender, EventArgs e)
        {
            LoadCompanyDetail();
            pnDetail.BringToFront();
            LoadPanelImage();
            LoadPanelEdit();
            lblImage.Visible = false;
            pbNext.Visible = false;
            pbBack.Visible = false;
            pnImage.Visible = false;
            btnDeletePic.Visible = false;
        }

        private void btnImageAdd_Click(object sender, EventArgs e)
        {

            try
            {
                EditCompany fec = new EditCompany();
                imagePath = function.SelectImage();
                Image im = Image.FromFile(imagePath);
                string nameImage = function.SaveImage(imagePath);
                fec.ListCompanyImage = nameImage;
                fec.ID = company.Id;

                if (listCompanyImage == null)
                {
                    fec.AddImagePath();
                }
                else if (listCompanyImage.Count != 0)
                {
                    fec.AddOtherImagePath();
                }
                company = companyDetail.GetInfoCompanyDetail(company.Id);

                listCompanyImage = company.ListCompanyImage;
                LoadPanelImage();
            }
            catch
            {
                MessageBox.Show("Lỗi không thể chọn ảnh này");
            }
        }

        private void btnDetail_Click(object sender, EventArgs e)
        {
            btnDeletePic.Visible = false;
            pnImage.Visible = false;
            panelEditCompany.Visible = false;
            pnDetail.Visible = true;
            pnDetail.BringToFront();
        }

        private void btnImage_Click(object sender, EventArgs e)
        {
            btnDeletePic.Visible = true;
            pnDetail.Visible = false;
            panelEditCompany.Visible = false;
            pnImage.Visible = true;
            lblImage.Visible = true;
            pbNext.Visible = true;
            pbBack.Visible = true;
            pnImage.Visible = true;
            pnImage.BringToFront();
        }

        private void pbBack_Click(object sender, EventArgs e)
        {
            indexImage -= 1;
            if (indexImage < 0)
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

        private void btnDeletePic_Click(object sender, EventArgs e)
        {
            try
            {
                EditCompany fec = new EditCompany();
                fec.ID = company.Id;
                fec.ListCompanyImage = listCompanyImage[indexImage].Trim();
                if (listCompanyImage.Count == 1)
                {
                    fec.DeleteOnlyImage();
                    listCompanyImage = null;
                    LoadPanelImage();
                }
                else if (indexImage == 0)
                {
                    fec.DeleteImage();
                    company = companyDetail.GetInfoCompanyDetail(company.Id);
                    listCompanyImage = company.ListCompanyImage;
                    LoadPanelImage();
                }
                else if (indexImage != 0)
                {
                    fec.DeleteOtherImage();
                    company = companyDetail.GetInfoCompanyDetail(company.Id);
                    listCompanyImage = company.ListCompanyImage;
                    LoadPanelImage();
                }

                btnDeletePic.Visible = true;

            }
            catch
            {
                MessageBox.Show("Lỗi không thể xóa ảnh này");
            }
        }

        private void btnLoadPicture_Click(object sender, EventArgs e)
        {
            try
            {
                EditCompany fec = new EditCompany();
                imagePath = function.SelectImage();
                Image im = Image.FromFile(imagePath);
                string nameImage = function.SaveImage(imagePath);
                fec.Avatar = nameImage;
                fec.ID = company.Id;
                fec.AddAvatar();
                FCompanyDetails2_Load(sender, e);
            }
            catch
            {
                MessageBox.Show("Lỗi không thể chọn ảnh này");
            }
        }

        private void btnEditCompany_Click(object sender, EventArgs e)
        {
            btnDeletePic.Visible = false;
            pnImage.Visible = false;
            panelEditCompany.Visible = true;
            pnDetail.Visible = false;
            panelEditCompany.BringToFront();
        }

        private void btnXacNhan_Click(object sender, EventArgs e)
        {
            EditCompany ec = new EditCompany(company.Id, txtPhone.Text, txtWeb.Text, txtCompanySize.Text, txtDescription.Text);
            try
            {
                ec.AddCompany();
            }
            catch
            {
                MessageBox.Show("Gặp lỗi bất ngờ");
            }
            finally
            {
                MessageBox.Show("Update thông tin thành công", "Thành công");

            }
            FCompanyDetails2_Load(sender,e);
        }
    }
}
