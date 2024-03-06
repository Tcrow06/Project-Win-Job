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
    public partial class FJobDetails : Form
    {
        public FJobDetails()
        {
            InitializeComponent();
        }
        private void SetSize()
        {
            this.Width = 750;
            guna2Panel2.Width = this.Width;
            guna2Panel1.Size = new Size(450, 134 + 38);
            guna2HtmlLabel1.Width = 420;
            guna2HtmlLabel1.Height = 69;
            guna2HtmlLabel3.Width = 177;
            guna2HtmlLabel2.Width = 177;
            guna2HtmlLabel8.Width = 177;
            guna2HtmlLabel9.Width = 118;
            guna2HtmlLabel9.Height = 30;
            guna2HtmlLabel10.Width = 177;
            guna2HtmlLabel7.Width = 177;
            guna2Panel3.Size = new System.Drawing.Size(244, 150);
            guna2Panel3.Location = new System.Drawing.Point(475, 12);
            guna2HtmlLabel5.Size = new System.Drawing.Size(93, 21);
            guna2HtmlLabel6.Size = new System.Drawing.Size(55, 19);
            guna2Panel4.Width = 715;
            guna2HtmlLabel12.Size = new System.Drawing.Size(148, 29);
            guna2HtmlLabel13.Size = new System.Drawing.Size(148, 29);
            guna2HtmlLabel14.Size = new System.Drawing.Size(148, 29);
            guna2HtmlLabel15.Size = new System.Drawing.Size(33, 22);
            guna2HtmlLabel16.Size = new System.Drawing.Size(77, 22);
            guna2HtmlLabel17.Size = new System.Drawing.Size(135, 50);
            guna2HtmlLabel18.Size = new System.Drawing.Size(57, 25);
            guna2HtmlLabel19.Size = new System.Drawing.Size(59, 25);
        }
        private void guna2Panel2_Paint(object sender, PaintEventArgs e)
        {
            SetSize();

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FCompanyDetails fcd = new FCompanyDetails();
            this.Hide();
            fcd.ShowDialog();
            fcd = null;
            this.Show();
        }
    }
}
