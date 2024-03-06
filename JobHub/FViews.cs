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
    public partial class FViews : Form
    {
        public FViews()
        {
            InitializeComponent();
        }

        private void FViews_Load(object sender, EventArgs e)
        {

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            FCV fcv = new FCV();
            
            fcv.Show();
           
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            FCVGuide fcvg = new FCVGuide();
            fcvg.Show();
        }
    }
}
