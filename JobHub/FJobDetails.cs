using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JobHub
{
    public partial class FJobDetails : Form
    {
        private int count = 0;
        public FJobDetails()
        {
            InitializeComponent();
        }


        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FCompanyDetails fcd = new FCompanyDetails();
            this.Hide();
            fcd.ShowDialog();
            fcd = null;
            this.Show();
        }

        private void FJobDetails_Load(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            count++;
            if (count%2 == 0)
            {
                btnSave.Image = Properties.Resources.heartChuaLuu;
            }
            else
            {
                btnSave.Image = Properties.Resources.heartDaLuu;
            }
        }

        private void lblCompany_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FCompanyDetails fcd = new FCompanyDetails();
            this.Hide();
            fcd.ShowDialog();
            fcd = null;
            this.Show();
        }

        private void btnApply_Click(object sender, EventArgs e)
        {

        }
    }
}
