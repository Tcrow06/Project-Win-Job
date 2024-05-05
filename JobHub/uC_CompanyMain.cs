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
    public partial class uC_CompanyMain : UserControl
    {
        public event EventHandler loadJobClick;
        private int idCompany;

        public int IdCompany { get => idCompany; set => idCompany = value; }

        public uC_CompanyMain()
        {
            InitializeComponent();
        }
    }
}
