using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Collections;
using Guna.UI2.WinForms;
using System.Reflection;
using System.Diagnostics.Eventing.Reader;

namespace JobHub
{
    public partial class FJob : Form
    {
        private FindJob fjd=new FindJob();
        private Fmain fm;
        private void LoadUc_SlideJob()
        {
            fjd.LoadUc_SlideJob(pnHotFob, fm);
        }
        public FJob(Fmain fm,Account account)
        {
                this.fm = fm;
                InitializeComponent();

        }
        private void FJob_Load(object sender, EventArgs e)
        {
            LoadFilterUcJob();

        }
        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            LoadFilterUcJob();
        }
        private void LoadFilterUcJob()
        {
            fjd.LoadFilterUcJob(pnJob, fm, btnTechnique.Checked, btnIT.Checked, btnEconomy.Checked, cboIndustryGroup.SelectedItem.ToString(),
                                cboSalary.SelectedItem.ToString(),cboAddress.SelectedItem.ToString(),
                                cboExperience.SelectedItem.ToString(), txtSearch.Text.Trim());
        }

        private void btnFilter_Click(object sender, EventArgs e)
        {
            LoadFilterUcJob();
        }

        private void cboIndustryGroup_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboIndustryGroup.SelectedIndex == 3)
            {
                    btnEconomy.Checked = true;
            }
            else if (cboIndustryGroup.SelectedIndex == 4)
            {
                    btnIT.Checked = true;
            }
            else if (cboIndustryGroup.SelectedIndex == 5)
            {
                    btnTechnique.Checked = true;
            }
            LoadFilterUcJob();
        }
        private void cboFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadFilterUcJob();

        }
        private void cboFilterAndSearch(object sender, EventArgs e)
        {
            LoadFilterUcJob();

        }

    }
} 

