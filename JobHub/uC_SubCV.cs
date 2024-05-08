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
    public partial class uC_SubCV : UserControl
    {
        public EventHandler uc_click;
        public uC_SubCV()
        {
            InitializeComponent();
        }

        private void pnContainCV_Click(object sender, EventArgs e)
        {
            uc_click?.Invoke(this, e);
        }
    }
}
