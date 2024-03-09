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
    public partial class uc_CVInfor : UserControl
    {
        public event EventHandler selectUc;
        public uc_CVInfor()
        {
            InitializeComponent();
        }

        private void guna2ShadowPanel4_DoubleClick(object sender, EventArgs e)
        {
            
        }
        private void guna2ShadowPanel4_Click(object sender, EventArgs e)
        {
            selectUc?.Invoke(this, e);
        }
        private void uc_CVInfor_Click(object sender, EventArgs e)
        {
            selectUc?.Invoke(this, e);
        }
        public void SetBackgroundColor(Color color)
        {
            this.BackColor = color;
        }

    }
}
