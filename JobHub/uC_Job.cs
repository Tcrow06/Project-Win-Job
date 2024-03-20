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
    public partial class uC_Job : UserControl
    {
        public event EventHandler loadJobClick;
        public uC_Job()
        {
            InitializeComponent();
        }


        private void guna2Panel1_DoubleClick(object sender, EventArgs e)
        {

            //loadJobClick?.Invoke(this, e);
        }

        private void ucJob_Click(object sender, EventArgs e)
        {
            loadJobClick?.Invoke(this, e);
        }

        private void ucJob_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
