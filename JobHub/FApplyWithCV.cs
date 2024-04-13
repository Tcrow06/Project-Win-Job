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
using System.Web.UI.WebControls;
using System.Windows.Forms;

namespace JobHub
{
    public partial class FApplyWithCV : Form
    {
        ApplyWithCV awc = new ApplyWithCV();
        int idJob;
        Fmain fm = new Fmain();
        bool checkSelectCVInLibrary = true;
        bool checkSelectUpFileCV = true;
        int idCV = 0;
        Uc_ChoiceCV uc;
        
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

        private void pnCVClick(Guna2RadioButton rb1,Guna2Panel pn1, Guna2RadioButton rb2, Guna2Panel pn2 , int height1, int height2)
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
            pn2.Height = height2;
            pn1.Height = height1;
        }
        private void pnCV1_Click(object sender, EventArgs e)
        {
            if (checkSelectCVInLibrary)
            {

                pnCVClick(rbChoiceCV1, pnCV1, rbChoiceCV2, pnCV2, 200,105);
            }
            else
            {
                pnCVClick(rbChoiceCV1, pnCV1, rbChoiceCV2, pnCV2, 70,105);
                btnChange.Visible = true;   
            }
               
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
            if (checkSelectUpFileCV)
            {
                lblCVName.Visible = false;
                pbDelete.Visible = false;
                pnCVClick(rbChoiceCV2, pnCV2, rbChoiceCV1, pnCV1, 200, 35);
            }
            else
            {
                pnCVClick(rbChoiceCV2, pnCV2, rbChoiceCV1, pnCV1, 200, 35);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnChoice_Click(object sender, EventArgs e)
        {
            checkSelectUpFileCV = false;
            pnCVClick(rbChoiceCV2, pnCV2, rbChoiceCV1, pnCV1,200, 35);
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Tệp PDF|*.pdf|Tệp DOCX|*.docx"; // Chỉ cho phép tải lên tệp PDF hoặc DOCX

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                lblCVName.Visible = true;
                pbDelete.Visible = true;

                string filePath = openFileDialog.FileName;
                lblCVName.Text = Path.GetFileName(filePath);

                // Tạo một thư mục mới nếu nó không tồn tại
                string folderPath = Path.Combine(Application.StartupPath, "image");
                if (!Directory.Exists(folderPath))
                {
                    Directory.CreateDirectory(folderPath);
                }

                string fileName = Path.GetFileName(filePath);
                string destinationPath = GetUniqueFileName(folderPath, fileName);
                File.Copy(filePath, destinationPath);
                //byte[] fileData = File.ReadAllBytes(filePath);
            }
        }
        private string GetUniqueFileName(string folderPath, string fileName)
        {
            int count = 1;
            string newFileName = fileName;
            string extension = Path.GetExtension(fileName);
            string fileNameOnly = Path.GetFileNameWithoutExtension(fileName);

            while (File.Exists(Path.Combine(folderPath, newFileName)))
            {
                newFileName = $"{fileNameOnly} ({count++}){extension}";
            }

            return Path.Combine(folderPath, newFileName);
        }

        private void pbDelete_Click(object sender, EventArgs e)
        {
            lblCVName.Visible= false;
            lblCVName.Text = "";
            pbDelete.Visible= false;    
        }

        private void FApplyWithCV_Load(object sender, EventArgs e)
        {
            pnCVClick(rbChoiceCV1, pnCV1, rbChoiceCV2, pnCV2, 200, 105);
            awc.LoadJobNameOfForm(lblJobName, idJob);
            awc.LoadForm(this,pnCV1, lblCVOn, lblCVLoad, fm.Account);
        }
        public void LoadFormChoiceCVOn(Uc_ChoiceCV uc1, int idCV)
        {

            checkSelectCVInLibrary = false;
            uc = new Uc_ChoiceCV();
            uc = uc1;
            this.idCV = idCV;
            pnCV1.Height = 70;
            uc.Visible = true;
            uc.pnChoiceCV.BorderColor = Color.White;
            uc.pnChoiceCV.BorderThickness = 0;
            uc.Size = new Size(200, 20);
            uc.lblCVName.Text = ": " + uc.lblCVName.Text;
            uc.lblCVName.Font = new Font("Segoe UI", 9, FontStyle.Bold);
            uc.Location = new Point(lblCVOn.Location.X + lblCVOn.Width - 17, lblCVOn.Location.Y - 7);
            btnChange.Visible = true;

        }
        private void btnApply_Click(object sender, EventArgs e)
        {
           if(rbChoiceCV1.Checked == true)
           {
                awc.Apply(idJob, idCV, fm);
                this.Dispose(); 
           }
           else
           {
               
           }
            
        }

        private void btnChange_Click(object sender, EventArgs e)
        {
            uc.Dispose();
            foreach (Control control in pnCV1.Controls)
            {
                if (control.Name == "Uc_ChoiceCV")
                {
                    control.Dispose();  
                }
            }
            checkSelectCVInLibrary = true;
            awc.LoadForm(this, pnCV1, lblCVOn, lblCVLoad, fm.Account);
            pnCVClick(rbChoiceCV1, pnCV1, rbChoiceCV2, pnCV2, 200, 105);
            
        }
    }
}
