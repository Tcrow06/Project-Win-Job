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
    public partial class FMainCompany : Form
    {
        Charts charts = new Charts();
        public FMainCompany()
        {
            InitializeComponent();
        }

        private void AddValues()
        {
            dgvComapny.Rows.Add("FPT", "75%");
            dgvComapny.Rows.Add("Hòa Phát", "70%");
            dgvComapny.Rows.Add("NextTech", "65%");
            dgvComapny.Rows.Add("Đại Nam", "50%");
            dgvComapny.Rows.Add("VinGroup", "90%");

        }
        private void FMainCompany_Load(object sender, EventArgs e)
        {
            AddValues();
            charts.InitializeGunaChart(gunaChart1, "Duong");
            charts.InitializeGunaChart(gunaChart2, "Cot");
            charts.InitializeGunaChart(gunaChart3, "Tron");
            charts.GenerateDataAndLabels();
        }
    }
}
