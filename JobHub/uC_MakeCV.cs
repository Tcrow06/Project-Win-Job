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
    public partial class uC_MakeCV : UserControl
    {

        public uC_MakeCV()
        {
            InitializeComponent();
        }

        private void uC_MakeCV_Load(object sender, EventArgs e)
        {
            guna2VScrollBar1.BindingContainer = fpnContain;
        }

        private void picLink_Click(object sender, EventArgs e)
        {

        }
    }
}
