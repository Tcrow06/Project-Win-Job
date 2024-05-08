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
using System.Windows.Forms.DataVisualization.Charting;

namespace JobHub
{
    public partial class FApplyWithCV : Form
    {
        private Function function = new Function();
        private MyCV myCV = new MyCV(); 
        ApplyWithCV awc = new ApplyWithCV();
        int idJob;
        Fmain fm = new Fmain();
        bool checkSelectCVInLibrary = false;
        bool checkSelectUpFileCV = false;
        int idCV = -1;
        private int heightPanel1;
        Uc_ChoiceCV uc;
        private string pathImage;
        private int CVTypeApply = 0;


        public int HeightPanel1 { get => heightPanel1; set => heightPanel1 = value; }

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
            pn1.Cursor = Cursors.Default;
            pn2.Cursor = Cursors.Hand;
            btnChange.Visible = false;
            pn1.BorderColor = Color.FromArgb(0, 139, 0);
            btnSelectCVImage.FillColor = pnCV2.BorderColor;
            rb1.Checked = true;
            pn2.Height = height2;
            pn1.Height = height1;
        }
        private void pnCV1_Click(object sender, EventArgs e)
        {
            if (!checkSelectCVInLibrary)
            {
                pnCVClick(rbChoiceCV1, pnCV1, rbChoiceCV2, pnCV2, heightPanel1,105);
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
            btnSelectCVImage.FillColor = Color.FromArgb(0, 139, 0);
        }

        private void pnCV2_MouseLeave(object sender, EventArgs e)
        {
            if (!rbChoiceCV2.Checked)
            {
                pnCV2.BorderColor = Color.Silver;
                btnSelectCVImage.FillColor = Color.Silver;
            }
        }

        private void pnCV2_Click(object sender, EventArgs e)
        {
            if (!checkSelectUpFileCV)
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


        private void pbDelete_Click(object sender, EventArgs e)
        {
            lblCVName.Visible= false;
            lblCVName.Text = "";
            pbDelete.Visible= false;
            checkSelectUpFileCV = true;
        }

        private void FApplyWithCV_Load(object sender, EventArgs e)
        {
            pnCVClick(rbChoiceCV1, pnCV1, rbChoiceCV2, pnCV2, 200, 105);
            awc.LoadJobNameOfForm(lblJobName, idJob);
            awc.LoadUC_CV(this,pnCV1, lblCVOn, lblCVLoad, fm.Account);
        }
        public void LoadFormChoiceCVOn(Uc_ChoiceCV uc1, int idCV, int CVType)
        {
            checkSelectCVInLibrary = true;
            uc = new Uc_ChoiceCV();
            uc = uc1;
            this.idCV = idCV;
            pnCV1.Height = 70;
            uc.Visible = true;
            uc.pnChoiceCV.BorderColor = Color.White;
            uc.pnChoiceCV.BorderThickness = 0;
            uc.Size = new Size(200, 20);
            lblSelectName.Visible = true;
            if(CVType == 1)
            {
                lblSelectName.Text = "CV đã tải lên: ";
                CVTypeApply = 1;
            }
            else
            {
                lblSelectName.Text = "CV online: ";
                CVTypeApply= 0;
            }
            uc.lblCVName.Font = new Font("Segoe UI", 9, FontStyle.Bold);
            Size textSize = TextRenderer.MeasureText(lblSelectName.Text, lblSelectName.Font);
            lblSelectName.Size = textSize;
            uc.Location = new Point(lblSelectName.Location.X + lblSelectName.Width -15, lblSelectName.Location.Y - 7);
            lblCVOn.Visible = false;
            btnChange.Visible = true;

        }
        private void btnApply_Click(object sender, EventArgs e)
        {
           if(rbChoiceCV1.Checked == true && idCV != -1)
           {
                awc.Apply(idJob, idCV, fm, CVTypeApply);
                this.Dispose();
                    
           }
           else if(rbChoiceCV2.Checked == true&&lblCVName.Text.Trim().Length>0)
           {

                int idCVSelect = myCV.GetIdBeforeSaveNew();
                string nameImage = function.SaveImage(pathImage);
                
                if (lblCVName.Text.Length>0)
                {
                    Guna2PictureBox pb = new Guna2PictureBox();

                    function.InsertImage(nameImage, pb);
                    if (pb.Image != null)
                    {
                        myCV.AddImageCVIntoDB(nameImage, fm.Account.Id, idCVSelect, nameImage);
                        awc.Apply(idJob, idCVSelect, fm, 1);
                    }
                    else
                    {
                        MessageBox.Show("Hình ảnh không hợp lệ! Vui lòng scan lại ảnh khác");
                    }
                        
                }

                this.Dispose();
            }
            else
            {
                MessageBox.Show("Vui lòng chọn CV để ứng tuyển", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        private void btnChange_Click(object sender, EventArgs e)
        {
            lblSelectName.Visible = false;
            uc.Dispose();
            foreach (Control control in pnCV1.Controls)
             {
                if (control.Name == "Uc_ChoiceCV")
                {
                    control.Dispose();  
                }
            }
            checkSelectCVInLibrary = false;
            idCV = -1;
            awc.LoadUC_CV(this, pnCV1, lblCVOn, lblCVLoad, fm.Account);
            pnCVClick(rbChoiceCV1, pnCV1, rbChoiceCV2, pnCV2, heightPanel1, 105);
            
        }

        private void btnSelectCVImage_Click(object sender, EventArgs e)
        {
            pnCVClick(rbChoiceCV2, pnCV2, rbChoiceCV1, pnCV1, 200, 35);
            pathImage = function.SelectImage();
            if(pathImage != null)
            {
                lblCVName.Visible = true;
                pbDelete.Visible = true;
                lblCVName.Text = Path.GetFileName(pathImage);
            }
        }
    }
}
