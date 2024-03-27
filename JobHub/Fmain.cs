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
        private Stack<Form> forms = new Stack<Form>();

        public Stack<Form> Forms { get => forms; set => forms = value; }

        public Fmain()
        {
            InitializeComponent();

        }
        private void setLocation(int x, int y, Control ctrl)
        {
            ctrl.Location = new Point(x, y);
        }
        private void Fmain_Load(object sender, EventArgs e)
        {
            this.Height = 550;
            FViews view = new FViews();
            view.MdiParent = this;
            view.Dock = DockStyle.Fill;
            resize(view.Width + 200, view.Height + 50);
            setLocation(crtMini.Location.X - pnAcount.Width - 10, crtMini.Location.Y, pnAcount);
            setLocation(pnAcount.Location.X, pnAcount.Location.Y + pnAcount.Height, pnContainMenu);
            view.Show();
            picUp.BringToFront();
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

        private void Show(Panel contain, int height)
        {
            if(pnNav.Width < 52)
            {
                ShowSubNav(pnNav);
            }
            contain.Height = height;
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

        private bool checkHeight(Panel SubNav, int height)
        {
            if (SubNav.Height > height)
            {
                return false;
            }
            return true;
        }
        private void btnCV_Click(object sender, EventArgs e)
        {
            if(checkHeight(pnSubNav3, 35))
            {
                Show(pnSubNav3, 102);
            }
            else
            {
                Hide(pnSubNav3);
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            FLogin login = new FLogin();
            this.Hide();
            login.ShowDialog();
            this.Show();
            if(login.Candidate == null)
            {
                pnNav.Controls.Clear();
                pnNav.Controls.Add(pnSubNav11);
                pnNav.Controls.Add(pnSubNav13);
                pnNav.Controls.Add(pnSubNav12);
                pnNav.Controls.Add(btnBack);
                pnNav.Controls.Add(btnLogin);
                pnSubNav13.Visible = true;
                pnSubNav12.Visible = true;
                pnSubNav11.Visible = true;
            }
        }

        private void btnJob_Click(object sender, EventArgs e)
        {
            if(checkHeight(pnSubNav1, 35))
            {
                Show(pnSubNav1, 132);
            }
            else
            {
                Hide(pnSubNav1);
            }
        }

        private void btnCompany_Click(object sender, EventArgs e)
        {
            if(checkHeight(pnSubNav2, 35))
            {
                Show(pnSubNav2, 102);
            }
            else
            {
                Hide(pnSubNav2);
            }
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            foreach (Form formdelete in this.MdiChildren)
            {
                formdelete.Close();

            }
            FJob job = new FJob(this);
            job.MdiParent = this;
            resize(job.Width + 300, job.Height + 50);
            job.Dock = DockStyle.Fill;
            job.Show();
            job.BringToFront();
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            foreach (Form formdelete in this.MdiChildren)
            {
                formdelete.Close();
            }
            FPostJob job = new FPostJob();
            resize(job.Width + 200, job.Height + 50);
            job.MdiParent = this;
            job.Dock = DockStyle.Fill;
            job.Show();
            job.BringToFront();
            
        }

        private void btnWriteCV_Click(object sender, EventArgs e)
        {
            this.Hide();
            FCv cv = new FCv();
            cv.ShowDialog();
            this.Show();
        }

        private void btnCvGuide_Click(object sender, EventArgs e)
        {
            
            foreach(Form formdelete in this.MdiChildren)
            {
                formdelete.Close();
            }
            FCVGuide job = new FCVGuide();
            resize(job.Width + 200, job.Height + 50);
            job.MdiParent = this;
            job.Dock = DockStyle.Fill;
            job.Show();
            job.BringToFront();
            
        }

        private void btnJobCompany_Click(object sender, EventArgs e)
        {
            if (checkHeight(pnSubNav11, 35))
            {
                Show(pnSubNav11, 102);
            }
            else
            {
                Hide(pnSubNav11);
            }
        }

        private void guna2Button2_Click_1(object sender, EventArgs e)
        {
            if (checkHeight(pnSubNav12, 35))
            {
                Show(pnSubNav12, 102);
            }
            else
            {
                Hide(pnSubNav12);
            }
        }

        private void guna2Button5_Click(object sender, EventArgs e)
        {
            if (checkHeight(pnSubNav13, 35))
            {
                Show(pnSubNav13, 102);
            }
            else
            {
                Hide(pnSubNav13);
            }
        }

        private void guna2Button6_Click(object sender, EventArgs e)
        {

        }

        private void loadForm(Form form)
        {
            foreach (Form formdelete in this.MdiChildren)
            {
                formdelete.Close();
            }
            form.MdiParent = this;
            resize(form.Width + 200, form.Height + 50);
            form.Dock = DockStyle.Fill;
            form.Show();
            form.BringToFront();
        }
        private void btnBack_Click(object sender, EventArgs e)
        {
            MessageBox.Show(Forms.Count.ToString());
            if(Forms.Count >= 1)
            {
                Forms.Pop();
                loadForm(Forms.Pop());
            }

        }

        private void guna2PictureBox2_Click(object sender, EventArgs e)
        {
            pnContainMenu.Visible = true;
            picUp.SendToBack();
            picDown.BringToFront();
        }

        private void picDown_Click(object sender, EventArgs e)
        {
            pnContainMenu.Visible = false;
            picDown.SendToBack();
            picUp.BringToFront();
        }

        private void Fmain_SizeChanged(object sender, EventArgs e)
        {
            setLocation(crtMini.Location.X - pnAcount.Width - 10, crtMini.Location.Y, pnAcount);
            setLocation(pnAcount.Location.X, pnAcount.Location.Y + pnAcount.Height, pnContainMenu);
        }
    }
}
