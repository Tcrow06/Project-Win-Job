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
        private Fmain fm;
        public Fmain()
        {
            fm = this;
            InitializeComponent();

        }

        private void Fmain_Load(object sender, EventArgs e)
        {
            this.Height = 550;
            FViews view = new FViews();
            view = new FViews();
            view.MdiParent = this;
            view.Dock = DockStyle.Fill;
            resize(view.Width + 200, view.Height + 50);
            view.Show();
        }
        public void Reset_Load(FJobDetails view)
        {
            this.Height = 550;
            view.MdiParent = this;
            view.Dock = DockStyle.Fill;
            resize(view.Width + 200, view.Height + 50);
            view.Show();
        }

        private void ShowSubNav(Panel nav)
        {
            
            resize(this.Width + 150, this.Height);
            pnNav.Visible = false;
            pnNav.Width = 175;
            guna2Transition1.ShowSync(pnNav);
        }

        private void HideSubNav(Panel nav)
        {
            Hide(pnSubNav1);
            Hide(pnSubNav2);
            Hide(pnSubNav3);
            resize(this.Width - 150, this.Height);
            
            pnNav.Visible = false;
            pnNav.Width = 45;
            guna2Transition1.ShowSync(pnNav);
        }
        private void guna2PictureBox1_Click(object sender, EventArgs e)
        {
            if(pnNav.Width > 52)
            {
                HideSubNav(pnNav);
            }
            else
            {
                ShowSubNav(pnNav);
            }
        }

        private void Show(Panel contain)
        {
            if(pnNav.Width < 52)
            {
                ShowSubNav(pnNav);
            }
            contain.Height = 102;
            guna2Transition1.ShowSync(contain);
        }

        private void Hide(Panel contain)
        {
            contain.Height = 33;
            guna2Transition1.ShowSync(contain);
        }

        public void resize(int width, int height)
        {
            this.Width = width;
            this.Height = height;
        }

        private void checkHeight(Panel SubNav)
        {
            if (SubNav.Height > 35)
            {
                Hide(SubNav);
            }
            else
            {
                Show(SubNav);
            }
        }
        private void btnCV_Click(object sender, EventArgs e)
        {
            checkHeight(pnSubNav3);
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            FLogin login = new FLogin();
            this.Hide();
            login.ShowDialog();
            this.Show();
        }

        private void btnJob_Click(object sender, EventArgs e)
        {
            checkHeight(pnSubNav1);
        }

        private void btnCompany_Click(object sender, EventArgs e)
        {
            checkHeight(pnSubNav2);
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            FJob job = new FJob(fm);
            job.MdiParent = fm;
            job.Dock = DockStyle.Fill;
            job.Show();
            job.BringToFront();
            job.Location= new Point(0,0);
            resize(job.Width + 200, job.Height + 50);
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            FPostJob job = new FPostJob();
            job.MdiParent = this;
            job.Dock = DockStyle.Fill;
            job.Show();
            job.BringToFront();
            resize(job.Width + 200, job.Height + 50);
        }

        private void btnWriteCV_Click(object sender, EventArgs e)
        {
            FCV job = new FCV();
            job.MdiParent = this;
            job.Dock = DockStyle.Fill;
            job.Show();
            job.BringToFront();
            resize(job.Width + 200, job.Height + 50);
        }

        private void btnCvGuide_Click(object sender, EventArgs e)
        {
            FCVGuide job = new FCVGuide();
            job.MdiParent = this;
            job.Dock = DockStyle.Fill;
            job.Show();
            job.BringToFront();
            resize(job.Width + 200, job.Height + 50);
        }
    }
}
