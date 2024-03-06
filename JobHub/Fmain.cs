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
    public partial class Fmain : Form
    {
        public Fmain()
        {
            InitializeComponent();

        }

        private void Fmain_Load(object sender, EventArgs e)
        {
            FViews views = new FViews();
            views.MdiParent = this;
            views.Dock = DockStyle.Fill;
            views.Show();
            if (pnMenu.Width > 50)
            {
                btnHide.Visible = true;
                btnShow.Visible = false;
            }
            else
            {
                btnHide.Visible = false;
                btnShow.Visible = true;
            }
        }
        private void Show(Panel contain)
        {
            contain.Height = 94;
            guna2Transition1.ShowSync(contain);
        }
        private void Hide(Panel contain)
        {
            contain.Height = 38;
            guna2Transition1.ShowSync(contain);
        }

        private void guna2PictureBox1_Click(object sender, EventArgs e)
        {

        }
        //private int imageNumber = 1;
        //private void timer1_Tick(object sender, EventArgs e)
        //{
        //    if (imageNumber == 4)
        //    {
        //        imageNumber = 1;
        //    }
        //    bannerPictureBox.ImageLocation = string.Format(@"Images\{0}.jpg", imageNumber);
        //    imageNumber++;
        //}

        private void findJobBtn_Click(object sender, EventArgs e)
        {
            FJob ffj = new FJob();
            this.Hide();
            ffj.Show();

        }

        private void writeCvBtn_Click(object sender, EventArgs e)
        {
            FCV fcv = new FCV();
            this.Hide();
            fcv.Show();
        }

        private void btnHide_Click(object sender, EventArgs e)
        {
            btnHide.Visible = false;
            btnShow.Visible = true;
            pnMenu.Visible = false;
            pnMenu.Width = 45;
            guna2Transition1.ShowSync(pnMenu);
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            btnHide.Visible = true;
            btnShow.Visible = false;
            pnMenu.Visible = false;
            pnMenu.Width = 160;
            guna2Transition1.ShowSync(pnMenu);
        }

        private void guna2Button5_Click(object sender, EventArgs e)
        {
            FLogin login = new FLogin();
            this.Hide();
            login.ShowDialog();
            this.Show();
        }

        private void btnJob_Click(object sender, EventArgs e)
        {
            if(pnSubMenu1.Height > 55)
            {
                Hide(pnSubMenu1);
            }
            else
            {
                if(pnMenu.Width > 70)
                {
                    Show(pnSubMenu1);
                }  
            }
        }

        private void btnCompany_Click(object sender, EventArgs e)
        {
            if (pnSubMenu3.Height > 55)
            {

                Hide(pnSubMenu3);
            }
            else
            {
                if (pnMenu.Width > 70)
                {
                    Show(pnSubMenu3);
                }
            }
        }

        private void btnCV_Click(object sender, EventArgs e)
        {
            if (pnSubMenu2.Height > 55)
            {
                Hide(pnSubMenu2);
            }
            else
            {
                if (pnMenu.Width > 70)
                {
                    Show(pnSubMenu2);
                }
            }
        }

        private void btnFindJob_Click_1(object sender, EventArgs e)
        {
            FJob find = new FJob();
            this.Hide();
            find.ShowDialog();
            this.Show();
        }

        private void pnContainContent_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnSignJob_Click(object sender, EventArgs e)
        {
            FPostJob fpj = new FPostJob();
            this.Hide();
            fpj.ShowDialog();
            this.Show();
        }

        private void btnListCompany_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button4_Click(object sender, EventArgs e)
        {

        }

        private void btnMakeFile_Click(object sender, EventArgs e)
        {
            FCV fcv = new FCV();
            this.Hide();
            fcv.ShowDialog();
            this.Show();
        }

        private void btnInstructCV_Click(object sender, EventArgs e)
        {
            FCVGuide fcvg = new FCVGuide();
            this.Hide();
            fcvg.ShowDialog();
            this.Show();
        }
    }
}
