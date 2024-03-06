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
    public partial class FJob : Form
    {
        public FJob()
        {
            InitializeComponent();

        }

        private void FJob_Load(object sender, EventArgs e)
        {
            this.MinimumSize = new System.Drawing.Size(1015, 550);
            guna2VScrollBar1.BindingContainer = flowLayoutPanel1;
        }

        private void guna2Button5_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void uC_Job1_Load(object sender, EventArgs e)
        {
            
        }

        private void uC_Job1_MouseClick(object sender, MouseEventArgs e)
        {

        }
    }
}
