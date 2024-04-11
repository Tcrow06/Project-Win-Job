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
    public partial class FApplyWithCV : Form
    {
        ApplyWithCV awc = new ApplyWithCV();
        int idJob;
        Fmain fm;
        int idCV ;
        string name = null;
        
        public FApplyWithCV()
        {
            InitializeComponent();
        }
        public FApplyWithCV(int idJob, Fmain fm)
        {
            this.idJob = idJob;
            InitializeComponent();
            this.fm = fm;
        }

        private void pnCV1_MouseHover(object sender, EventArgs e)
        {
                pnCV1.BorderColor =  Color.FromArgb(0,139,0);
        }

        private void pnCV1_MouseLeave(object sender, EventArgs e)
        {
            if (!rbChoiceCV1.Checked)
            {
                pnCV1.BorderColor = Color.Silver;
            }
        }

        private void pnCVClick(Guna2RadioButton rb1,Guna2Panel pn1, Guna2RadioButton rb2, Guna2Panel pn2 , int height)
        {
            if (rb2.Checked)
            {
                rb2.Checked = false;
                pn2.BorderColor = Color.Silver;
            }
            btnChange.Visible = false;
            pn1.BorderColor = Color.FromArgb(0, 139, 0);
            btnChoice.FillColor = pnCV2.BorderColor;
            rb1.Checked = true;
            pn2.Height = height;
            pn1.Height = 200;
        }
        private void pnCV1_Click(object sender, EventArgs e)
        {
            pnCVClick(rbChoiceCV1, pnCV1, rbChoiceCV2, pnCV2,105);
        }

        private void pnCV2_MouseHover(object sender, EventArgs e)
        {
            pnCV2.BorderColor = Color.FromArgb(0, 139, 0);
            btnChoice.FillColor = Color.FromArgb(0, 139, 0);
        }

        private void pnCV2_MouseLeave(object sender, EventArgs e)
        {
            if (!rbChoiceCV2.Checked)
            {
                pnCV2.BorderColor = Color.Silver;
                btnChoice.FillColor = Color.Silver;
            }
        }

        private void pnCV2_Click(object sender, EventArgs e)
        {
            lblCVName.Visible = false;
            pbDelete.Visible = false;
            pnCVClick(rbChoiceCV2, pnCV2, rbChoiceCV1, pnCV1,35);
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnChoice_Click(object sender, EventArgs e)
        {
            
            pnCVClick(rbChoiceCV2, pnCV2, rbChoiceCV1, pnCV1, 35);
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Tệp PDF|*.pdf|Tệp DOCX|*.docx"; // Chỉ cho phép tải lên tệp PDF hoặc DOCX

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                lblCVName.Visible = true;
                pbDelete.Visible = true;

                string filePath = openFileDialog.FileName;
                lblCVName.Text = Path.GetFileName(filePath);

                // Đọc dữ liệu từ tệp
                byte[] fileData = File.ReadAllBytes(filePath);

                // Lưu dữ liệu vào cơ sở dữ liệu
                // Đây là nơi bạn cần triển khai mã để lưu dữ liệu vào cơ sở dữ liệu của bạn
                // Ví dụ: DatabaseHelper.SaveFileToDatabase(fileData);
            }
        }

        private void pbDelete_Click(object sender, EventArgs e)
        {
            lblCVName.Visible= false;
            pbDelete.Visible= false;    
        }

        private void FApplyWithCV_Load(object sender, EventArgs e)
        {
            pnCVClick(rbChoiceCV1, pnCV1, rbChoiceCV2, pnCV2, 105);
            awc.LoadForm(this,pnCV1, lblCVOn, lblCVLoad, fm.Account, idJob, idCV);
        }
        public void LoadFormChoiceCVOn(Uc_ChoiceCV uc1)
        {
            Uc_ChoiceCV uc = uc1;
            pnCV1.Height = 100;
            uc.pnChoiceCV.BorderColor = Color.Transparent;
            uc.Size = new Size(20, 50);
            //lblName.Text = ": " + name;
            uc.Location = new Point(lblCVOn.Location.X + lblCVOn.Width + 5, lblCVOn.Location.Y);
            btnChange.Visible = true;

        }
        private void btnApply_Click(object sender, EventArgs e)
        {

        }
    }
}
