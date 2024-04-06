using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JobHub
{
    public partial class Fmain : Form
    {
        private Stack<FormAndInfoCandidate> forms = new Stack<FormAndInfoCandidate>();
        private Account account;
        private ReLoadFormCandidate reLoadForm = new ReLoadFormCandidate();
        private Candidate cd = new Candidate();
        public Stack<FormAndInfoCandidate> Forms { get => forms; set => forms = value; }
        public Account Account { get => account; set => account = value; }

        public Fmain()
        {
            InitializeComponent();

        }
        public Fmain(Account account)
        {
            this.Account = account;
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
            FormAndInfoCandidate fai = new FormAndInfoCandidate(view);
            this.Forms.Push(fai);
            view.MdiParent = this;
            view.Dock = DockStyle.Fill;
            resize(view.Width + 200, view.Height + 50);
            view.Show();
            picUp.BringToFront();
            LoadTaskBar();
        }
        private void FirstLoadLoginByCompany()
        {
            DeleteChildForm();
            this.Height = 550;
            FJobPostHistory view = new FJobPostHistory(this);
            view.MdiParent = this;
            view.Dock = DockStyle.Fill;
            resize(view.Width + 200, view.Height + 50);
            view.Show();
            picUp.BringToFront();
        }
        private void FirstLoadLoginOrLoginOut()
        {
            DeleteChildForm();
            this.Height = 550;
            FViews view = new FViews();
            view.MdiParent = this;
            view.Dock = DockStyle.Fill;
            resize(Math.Min(view.Width + 200,900), Math.Min(view.Height + 50,500));
            view.Show();
            picUp.BringToFront();
        }
        public void LoadTaskBar()
        {
            if(this.Account == null) {

                pnNav.Controls.Clear();
                pnNav.Controls.Add(pnSubNav10);
                pnNav.Controls.Add(pnSubNav20);
                pnNav.Controls.Add(pnSubNav3);
                pnNav.Controls.Add(btnLogin);
                pnNav.Controls.Add(btnBack);
                pnAcount.Visible = false;
                pnContainMenu.Visible = false;
                btnLogin.Text = "Đăng nhập";
                return;


            }
            else if (this.Account.Type == 0)
            {
                    pnNav.Controls.Clear();
                    pnNav.Controls.Add(pnSubNav1);
                    pnNav.Controls.Add(pnSubNav2);
                    pnNav.Controls.Add(pnSubNav3);
                    pnNav.Controls.Add(btnLogin);
                    pnNav.Controls.Add(btnBack);
                    pnSubNav1.Visible = true;
                    pnSubNav2.Visible = true;
                    pnSubNav3.Visible = true;
                    setLocation(crtMini.Location.X - pnAcount.Width - 10, crtMini.Location.Y, pnAcount);
                    setLocation(pnAcount.Location.X, pnAcount.Location.Y + pnAcount.Height, pnContainMenu);
                    pnAcount.Visible = true;
                    lblAccName.Text = cd.GetInfoCandidate(this.Account).Name;
                    btnLogin.Text = "Đăng xuất";
                    

            }
            else
            {
                    pnNav.Controls.Clear();
                    pnNav.Controls.Add(pnSubNav11);
                    pnNav.Controls.Add(pnSubNav21);
                    pnNav.Controls.Add(pnSubNav31);
                    pnNav.Controls.Add(btnLogin);
                    pnNav.Controls.Add(btnBack);
                    pnSubNav31.Visible = true;
                    pnSubNav21.Visible = true;
                    pnSubNav11.Visible = true;
                    btnLogin.Text = "Đăng xuất";

            }

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
            Hide(pnSubNav3);
            Hide(pnSubNav2);
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
            if(checkHeight(pnSubNav2, 35))
            {
                Show(pnSubNav2, 102);
            }
            else
            {
                Hide(pnSubNav2);
            }
        }
        private void btnCV1_Click(object sender, EventArgs e)
        {
            if (checkHeight(pnSubNav20, 35))
            {
                Show(pnSubNav20, 70);
            }
            else
            {
                Hide(pnSubNav20);
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if(btnLogin.Text =="Đăng nhập")
            {
                FLogin login = new FLogin(this);
                this.Hide();
                login.ShowDialog();
                login = null;
                this.Show();
                if (this.Account != null)
                {
                    if (this.Account.Type == 0)
                    {
                        if (this.Forms.Count > 0)
                        {
                            FormAndInfoCandidate form = reLoadForm.ReLoadLogin(this);
                            this.loadFormReload(form.Form);
                        }
                        else
                        {
                            FirstLoadLoginOrLoginOut();
                        }
                    }
                    else
                    {
                        FirstLoadLoginByCompany();
                    }
                    LoadTaskBar();
                }
            }
            else
            {
                FirstLoadLoginOrLoginOut();
                this.account = null;
                LoadTaskBar();

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
        private void btnJob1_Click(object sender, EventArgs e)
        {
            if (checkHeight(pnSubNav10, 35))
            {
                Show(pnSubNav10, 70);
            }
            else
            {
                Hide(pnSubNav10);
            }
        }

        private void btnCompany_Click(object sender, EventArgs e)
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


        private void btnSaveJob_Click(object sender, EventArgs e)
        {
            foreach (Form formdelete in this.MdiChildren)
            {
                formdelete.Close();
            }
            FFavouriteJob job = new FFavouriteJob(this);
            FormAndInfoCandidate fai = new FormAndInfoCandidate(job);
            this.Forms.Push(fai);
            resize(job.Width + 200, job.Height + 50);
            job.MdiParent = this;
            job.Dock = DockStyle.Fill;
            job.Show();
            job.BringToFront();

        }

        private void btnWriteCV_Click(object sender, EventArgs e)
        {
            this.Hide();
            FCVDetail cv = new FCVDetail();
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
            if (checkHeight(pnSubNav21, 35))
            {
                Show(pnSubNav21, 102);
            }
            else
            {
                Hide(pnSubNav21);
            }
        }

        private void guna2Button5_Click(object sender, EventArgs e)
        {
            if (checkHeight(pnSubNav31, 35))
            {
                Show(pnSubNav31, 102);
            }
            else
            {
                Hide(pnSubNav31);
            }
        }

        private void guna2Button6_Click(object sender, EventArgs e)
        {
            foreach (Form formdelete in this.MdiChildren)
            {
                formdelete.Close();
            }
            FMyCV fMyCV = new FMyCV();
            fMyCV.MdiParent = this;
            resize(fMyCV.Width + 200, fMyCV.Height + 50);
            fMyCV.Dock = DockStyle.Fill;
            fMyCV.Show();
        }

        public void loadForm(Form form)
        {
            this.HideChildForm();
            form.MdiParent = this;
            if (form.Name == "FJobDetails")
            {
                resize(form.Width + 100, form.Height - 50);
            }
            else if (form.Name == "FJob")
                resize(form.Width + 178, form.Height + 35);
            form.Dock = DockStyle.Fill;
            form.Show();
            form.BringToFront();
        }
        public void loadFormReload(Form form)
        {
            this.HideChildForm();
            form.MdiParent = this;
            if (form.Name == "FJobDetails")
            {
                resize(form.Width + 200, form.Height + 70);
            }
            else if (form.Name == "FJob")
                resize(form.Width + 178, form.Height + 35);
            else if(form.Name == "FViews")
            {
                resize(900, 500);
            }
            else if (form.Name == "FCompanyDetails")
            {
                resize(955, 640);
            }
            else if (form.Name == "FJobPostHistory")
            {
                resize(form.Width, form.Height);
            }
            form.Dock = DockStyle.Fill;
            form.Show();
            form.BringToFront();
        }
        private void btnBack_Click(object sender, EventArgs e)
        {
            if(Forms.Count > 1)
            {
                /*if (Forms.Peek().Form.Name == "FJobDetails")
                {
                    while (Forms.Peek().Form.Name != "FJob")
                    {
                        Forms.Pop();
                    }
                        
                    FormAndInfoCandidate tmp = new FormAndInfoCandidate();
                    Forms.Push(tmp);
                }*/

                Forms.Pop();
                
                FormAndInfoCandidate form = reLoadForm.ReLoadBack(this);
                this.loadFormReload(form.Form);

            }
            else
            {
                    FViews fv = new FViews();
                    Forms.Clear();
                    this.loadFormReload(fv);
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

        private void btnListJob_Click(object sender, EventArgs e)
        {
            this.DeleteChildForm();
            FJobPostHistory jsh = new FJobPostHistory(this);
            jsh.MdiParent = this;
            resize(jsh.Width + 200, jsh.Height + 50);
            jsh.Dock = DockStyle.Fill;
            jsh.Show();
            jsh.BringToFront();
        }
        public void HideChildForm()
        {
            foreach (Form formdelete in this.MdiChildren)
            {
                formdelete.Hide();
            }
        }
        public void DeleteChildForm()
        {
            foreach (Form formdelete in this.MdiChildren)
            {
                formdelete.Close();
            }
        }

        private void btnPostJob_Click(object sender, EventArgs e)
        {
            this.DeleteChildForm();   
            FPostJob jsh = new FPostJob();
            jsh.MdiParent = this;
            resize(jsh.Width + 200, jsh.Height + 50);
            jsh.Dock = DockStyle.Fill;
            jsh.Show();
            jsh.BringToFront();
        }

        private void FindJob_Click(object sender, EventArgs e)
        {
            foreach (Form formdelete in this.MdiChildren)
            {
                formdelete.Close();

            }
            FJob job = new FJob(this,Account);
            FormAndInfoCandidate fai = new FormAndInfoCandidate(job);
            forms.Push(fai);
            job.MdiParent = this;
            resize(job.Width + 200, job.Height + 70);
            job.Dock = DockStyle.Fill;
            job.Show();
            job.BringToFront();
        }

        private void btnFavouriteCV_Click(object sender, EventArgs e)
        {
            foreach (Form formdelete in this.MdiChildren)
            {
                formdelete.Close();

            }
            FFollowCV fcv = new FFollowCV(this);
            FormAndInfoCandidate fai = new FormAndInfoCandidate(fcv);
            forms.Push(fai);
            fcv.MdiParent = this;
            resize(fcv.Width + 200, fcv.Height + 70);
            fcv.Dock = DockStyle.Fill;
            fcv.Show();
            fcv.BringToFront();
        }

        private void btnOut_Click(object sender, EventArgs e)
        {
            Forms.Clear();
            this.Account = null;
            this.loadFormReload(new FViews());
            btnLogin.Text = "Đăng nhập";
            LoadTaskBar();  
        }
        public void Login()
        {
            FLogin login = new FLogin(this);
            login.ShowDialog();
            login = null;
            if (this.Account != null)
            {
                if (this.Account.Type == 0) 
                {
                    FormAndInfoCandidate form = reLoadForm.ReLoadLogin(this);
                    this.loadFormReload(form.Form);
                }
                else
                {
                    DialogResult result = MessageBox.Show("Đây là tài khoản công ty. Bạn có muốn chuyển sang giao diện công ty không ?","Thông báo "
                                                            , MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if(result == DialogResult.Yes)
                    {
                        FirstLoadLoginByCompany();
                    }
                    else this.account = null;

                }
                
            }
        }

        
    }
}
