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
    public partial class FCompanyList : Form
    {

        private CompanyList cl = new CompanyList();
        private Fmain fm;
        public FCompanyList(Fmain fm)
        {
            this.fm = fm;
            InitializeComponent();
        }

        private void LoadFilterUcCompany()
        {
            cl.LoadFilterUcCompany(pnCompany, fm, txtSearch.Text.Trim());
        }

        private void FCompanyList_Load(object sender, EventArgs e)
        {
            LoadFilterUcCompany();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            LoadFilterUcCompany();
        }
    }
}
