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
    public partial class uC_LoadIfJob : UserControl
    {
        public EventHandler AddPanel;
        public EventHandler RemovePanel;
        public uC_LoadIfJob()
        {
            InitializeComponent();
        }

        private void guna2PictureBox2_Click(object sender, EventArgs e)
        {
            AddPanel?.Invoke(this, EventArgs.Empty);
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            RemovePanel?.Invoke(this, EventArgs.Empty);
        }
    }
}
