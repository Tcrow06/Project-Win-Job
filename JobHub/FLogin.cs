using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI.WebControls;
using System.Windows.Forms;

namespace JobHub
{
    public partial class FLogin : Form
    {
        //private LoginDao ld = new LoginDao();
        private Login login = new Login();
        private Fmain fm = new Fmain();

        public FLogin()
        {
            InitializeComponent();
        }
        public FLogin(Fmain fm)
        {
            this.fm = fm;
            InitializeComponent();
        }
        private void FLogin_Load(object sender, EventArgs e)
        {
            pnRegister.Visible = false;
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FAns fAns = new FAns(this);
            this.Hide();
            fAns.ShowDialog();
            this.Show();
        }

        private void lblToLogin_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            pnRegister.Visible = false;
            pnLogin.Visible = true;
            pnLogin.BringToFront();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {

            if(login.CheckAccount(txtLoginEmail.Text.Trim(), txtLoginPassword.Text.Trim(), fm))
            {
                this.Close();
                fm.LoadTaskBar();
            }
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            Candidate can = new Candidate(txtFirstName.Text, txtLastName.Text, txtRegisterEmail.Text.ToString());
            Account account = new Account(txtRegisterEmail.Text.ToString(), txtRegisterPassword.Text.ToString(), can);
            login.Register(can, account, this, txtConfirmPassword.Text.Trim());
        }
    }
}
