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

namespace JobHub
{
    public partial class FJob : Form
    {
        private FindJob fjd=new FindJob();
        private Fmain fm;
        public FJob(Fmain fm,Account account)
        {
                this.fm = fm;
                InitializeComponent();

        }
        private void FJob_Load(object sender, EventArgs e)
        {
            LoadUcJobFilter();
        }
        private void LoadUcJobFilter()
        {
            fjd.LoadUcJobFilter(pnJob, fm, btnTechnique.Checked, btnIT.Checked ,btnEconomy.Checked,
                cboIndustryGroup.SelectedItem.ToString(),
                cboSalary.SelectedItem.ToString(),
                cboAddress.SelectedItem.ToString(),
                cboExperience.SelectedItem.ToString(),
                txtSearch.Text.Trim());

        }
        private void SelectUcFilter(object sender, EventArgs e)
        {
            LoadUcJobFilter();
        }
      
    }
} 

