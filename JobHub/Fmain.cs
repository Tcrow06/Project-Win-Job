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
            this.Height = 550;
        }

        private void guna2PictureBox1_Click(object sender, EventArgs e)
        {
            if(pnNav.Width > 52)
            {
                pnNav.Visible = false;
                pnNav.Width = 45;
                guna2Transition1.ShowSync(pnNav);
            }
            else
            {
                pnNav.Visible = false;
                pnNav.Width = 175;
                guna2Transition1.ShowSync(pnNav);
            }
        }

        private void Show(Panel contain)
        {
            
            contain.Height = 102;
            guna2Transition1.ShowSync(contain);
        }

        private void Hide(Panel contain)
        {
            contain.Height = 33;
            guna2Transition1.ShowSync(contain);
        }
        private void btnCV_Click(object sender, EventArgs e)
        {
            if(pnSubNav3.Height > 35)
            {
                Hide(pnSubNav3);
            }
            else 
            {
                Show(pnSubNav3);
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            FLogin login = new FLogin();
            this.Hide();
            login.ShowDialog();
            this.Show();
        }
    }
}
