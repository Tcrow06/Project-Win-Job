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
    public partial class FAns : Form
    {
        public FAns()
        {
            InitializeComponent();
        }

        private void btnEmploys_Click(object sender, EventArgs e)
        {
            FRecruiter fRecruiter = new FRecruiter();
            this.Close();
            fRecruiter.ShowDialog();
        }

        private void btnCandidate_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
