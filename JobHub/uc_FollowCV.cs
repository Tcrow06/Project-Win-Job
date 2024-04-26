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
    public partial class uc_FollowCV : UserControl
    {
        public event EventHandler Sumbit_Click;
        public event EventHandler Remove_Click;
        public uc_FollowCV()
        {
            InitializeComponent();
        }

        private void btnSumbit_Click(object sender, EventArgs e)
        {
            Sumbit_Click?.Invoke(sender, EventArgs.Empty);
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            Remove_Click?.Invoke(sender, EventArgs.Empty);
        }
    }
}
