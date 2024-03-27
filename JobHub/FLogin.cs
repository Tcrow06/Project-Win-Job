using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JobHub
{
    public partial class FLogin : Form
    {
        DBConection con = new DBConection();
        private Candidate candidate;

        public Candidate Candidate { get => candidate; set => candidate = value; }

        public FLogin()
        {
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
            string sql = $@"select * from Account
                            where account like '{txtAcc.Text.Trim()}%' AND accountPass like '{txtPass.Text.Trim()}%'";
            SqlDataReader reader = con.loadData(sql);
            if(reader.HasRows)
            {
                if (Int32.Parse(reader["accountType"].ToString()) == 1)
                {
                    Candidate = new Candidate(Int32.Parse(reader["accountType"].ToString()));
                }
                CustomMessageBox.Show("Đăng nhập thành công");
            }
            else
            {
                CustomMessageBox.Show("Sai tài khoản hoặc mật khẩu");
            }
            Candidate = null;
            reader.Close();
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
