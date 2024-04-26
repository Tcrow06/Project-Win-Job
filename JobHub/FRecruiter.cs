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
    public partial class FRecruiter : Form
    {
        private Recruiter recruiter = new Recruiter();
        private Function function = new Function(); 
        private string imagePath;
        public FRecruiter()
        {
            InitializeComponent();
        }

        private void btnLoadPicture_Click(object sender, EventArgs e)
        {
            /*using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Title = "Chọn ảnh";
                openFileDialog.Filter = "Tất cả các tệp (*.*)|*.*|Ảnh (*.png;*.jpg;*.jpeg;*.gif;*.bmp)|*.png;*.jpg;*.jpeg;*.gif;*.bmp";
                openFileDialog.FilterIndex = 2;
                openFileDialog.RestoreDirectory = true;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        imagePath = openFileDialog.FileName;
                        Image im = Image.FromFile(imagePath);
                        txtBusinessLicenseLink.Text = Path.GetFileName(imagePath);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Lỗi khi mở tệp ảnh: " + ex.Message);
                    }
                }
            }*/
            imagePath = function.SelectPicture();
            if(imagePath != null)
            {
                txtBusinessLicenseLink.Text = Path.GetFileName(imagePath);
            }
        }

        private void btnCompanyyAccountRegister_Click(object sender, EventArgs e)
        {
            Company company = new Company(txtEmail.Text.Trim(),txtCompanyName.Text.Trim(),txtManagerName.Text.Trim(), txtBusinessLicenseLink.Text.Trim(),
                                        txtTaxCode.Text.Trim(), txtAddress.Text.Trim() + " " + cbCity.SelectedItem);
            Account account = new Account(txtEmail.Text.ToString(), txtPassword.Text.ToString(), company);
            recruiter.Register(company, account, this, txtConfirmPassword.Text.Trim());
            function.SaveImage(imagePath);    

                
        }

    }
}
