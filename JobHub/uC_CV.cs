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
    public partial class uC_CV : UserControl
    {
        public EventHandler loadJob;
        public uC_CV()
        {
            InitializeComponent();
        }

        private void uC_CV_Click(object sender, EventArgs e)
        {
            loadJob?.Invoke(sender, e);
        }
    }
}
