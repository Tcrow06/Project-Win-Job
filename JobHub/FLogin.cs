using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI.WebControls;
using System.Windows.Forms;

namespace JobHub
{
    public partial class FLogin : Form
    {
        DBConection con = new DBConection();
        LoginDao ld = new LoginDao();
        private Candidate candidate;
        ReLoadFormCandidate rlf = new ReLoadFormCandidate();
        private Fmain fm = new Fmain();
        private int idJob;
        private int idCp;
        private Account account;

        public Account Account { get => account; set => account = value; }

        public FLogin()
        {
            InitializeComponent();
        }
        public FLogin(Fmain fm)
        {
            this.fm = fm;
            InitializeComponent();
        }
        public FLogin(int idJob, int IdCp, Fmain fm)
        {
            this.fm = fm;   
            this.idJob = idJob;
            this.idCp = IdCp;
            InitializeComponent();
        }
        public FLogin( int IdCp, Fmain fm)
        {
            this.fm = fm;
            this.idCp = IdCp;
            InitializeComponent();
        }
        public FLogin(int idJob, int IdCp, Fmain fm, Account account)
        {
            this.fm = fm;
            this.idJob = idJob;
            this.idCp = IdCp;
            this.Account = account;
            InitializeComponent();
        }
        private void FLogin_Load(object sender, EventArgs e)
        {

        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FAns fAns = new FAns();
            this.Hide();
            fAns.ShowDialog();
            fAns.Close();
        }

        private void lblToLogin_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            pnLogin.BringToFront();
            pnLogin.Visible = true;
            pnResetPass.Visible = false;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            CustomMessageBox cmb = new CustomMessageBox();
            this.Account = ld.CheckAccount(txtAcc.Text.Trim(), txtPass.Text.Trim());
            if(Account != null)
            {
                if (Account.Type == 0)
                {
                    if (fm.Forms.Count > 0)
                    {
                        fm.Account = Account;
                        FormAndInfoCandidate form = rlf.ReLoadLogin(fm);
                        this.Close();
                        fm.loadFormReload(form.Form);
                        this.Close();
                    }
                    else
                    {
                        FViews fv = new FViews();
                        fm.Account = Account;
                        fm.Forms.Clear();
                        fm.loadForm(fv);
                    }
                }
                else
                {

                }

            }
            else
            {
                cmb.Show("Sai tài khoản hoặc mật khẩu");
            }

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            pnLogin.Visible = false;
            pnResetPass.Visible = true;
            pnResetPass.BringToFront();
        }

        private void btnOke_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Lấy lại mật khẩu thành công");
            pnResetPass.Visible = false;
            pnLogin.Visible = true;
            pnLogin.BringToFront();
        }

        private void picBackGround_Click(object sender, EventArgs e)
        {

        }

        private void guna2ControlBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
