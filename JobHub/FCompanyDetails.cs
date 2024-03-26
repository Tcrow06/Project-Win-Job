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
    public partial class FCompanyDetails : Form
    {
        private int count = 0;
        private int idCompany;
        public FCompanyDetails()
        {
            InitializeComponent();
        }
        public FCompanyDetails(int idCompany)
        {
            InitializeComponent();
            this.idCompany = idCompany;
        }

        private void FCompanyDetails_Load(object sender, EventArgs e)
        {

        }

        private void btnFollowCompany_Click(object sender, EventArgs e)
        {
            count++;
            if (count % 2 == 0)
            {
                btnFollowCompany.Image = Properties.Resources.plus;
            }
            else
            {
                btnFollowCompany.Image = Properties.Resources.checkmark;
            }
        }
    }
}
