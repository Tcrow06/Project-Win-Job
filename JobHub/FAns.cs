using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JobHub
{
    public partial class FAns : Form
    {
        FLogin fl = new FLogin();
        public FAns()
        {
            InitializeComponent();
        }
        public FAns(FLogin fl)
        {
            this.fl = fl;
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
            fl.pnRegister.Visible = true;
            fl.pnLogin.Visible = false;
            fl.pnRegister.BringToFront();
            this.Close();

        }
    }
}
