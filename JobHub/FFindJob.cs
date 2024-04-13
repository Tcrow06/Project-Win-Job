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
        private void LoadUc_NewJob()
        {
            fjd.LoadUCNewJob(fpnNewJob, fm);
            
        }
        private void LoadUc_HotJob()
        {
            fjd.LoadUCHotJob(pnHotJob, fm);
        }
        public FJob(Fmain fm)
        {
                this.fm = fm;
                InitializeComponent();

        }
        private void FJob_Load(object sender, EventArgs e)
        {
            LoadFilterUcJob();
            
        }
        private void LoadFilterUcJob()
        {
            fjd.LoadFilterUcJob(pnJob, fm, btnTechnique.Checked, btnIT.Checked, btnEconomy.Checked, cboIndustryGroup.SelectedItem.ToString(),
                                cboSalary.SelectedItem.ToString(),cboAddress.SelectedItem.ToString(),
                                cboExperience.SelectedItem.ToString(), txtSearch.Text.Trim());
            LoadUc_NewJob();
            LoadUc_HotJob();
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
        private void SelectUcFilter(object sender, EventArgs e)
        {
            LoadFilterUcJob();
        }
      
    }
} 

