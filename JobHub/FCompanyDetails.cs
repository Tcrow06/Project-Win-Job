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
    public partial class FCompanyDetails : Form
    {
        public FCompanyDetails()
        {
            InitializeComponent();
        }

        private void FCompanyDetails_Load(object sender, EventArgs e)
        {
            this.Width = 745;
            guna2PictureBox1.Size   = new Size(700,150);
            guna2CirclePictureBox1.Size = new Size(80, 80);
            guna2HtmlLabel5.Size = new Size(400, 50);
            guna2HtmlLabel4.Size = new Size(400, 20);
            guna2HtmlLabel17.Size = new Size(200, 60);

        }


    }
}
