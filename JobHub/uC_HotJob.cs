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
        private int idJob;
        private int idCompany;

        public int IdJob { get => idJob; set => idJob = value; }
        public int IdCompany { get => idCompany; set => idCompany = value; }

        private void ucSlideJob_Click(object sender, EventArgs e)
        {
            OnJobDetailClick(e);
            
        }
        public void click(object sender, EventArgs e)
        {
            MessageBox.Show(this.pbAvatar.Width.ToString() + " " + this.Width.ToString());
        }

        private void pnContain_Click(object sender, EventArgs e)
        {
            OnJobDetailClick(e);
        }
    }
}
