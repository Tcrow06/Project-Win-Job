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
    public partial class uC_HotJob : uc_JobMain
    {
        public uC_HotJob()
        {
            InitializeComponent();
        }

        public event EventHandler loadCompanyClick;

        private void pnContain_Click(object sender, EventArgs e)
        {
            OnJobDetailClick(e);
        }
    }
}
