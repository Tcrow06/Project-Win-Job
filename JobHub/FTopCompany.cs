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
    public partial class FTopCompany : Form
    {
        TopCompanyDAO TopCompanyDAO = new TopCompanyDAO();
        Charts charts = new Charts();
        public FTopCompany()
        {
            InitializeComponent();
        }

        private void FTopCompany_Load(object sender, EventArgs e)
        {
            charts.InitializeGunaChart(gunaChart1, "CV", "Tháng");
            charts.InitializeGunaChart(gunaChart2, "Doanh Thu", "Tháng");
            charts.InitializeGunaChart(gunaChart3, "Đánh Giá", "Tháng");
            DataTable dt = TopCompanyDAO.ReadData();
            TopCompanyDAO.WriteData(dt, dgvCompany);
        }
    }
}
