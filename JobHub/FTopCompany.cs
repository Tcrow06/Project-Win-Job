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
        private Fmain fm;
        public FTopCompany()
        {
            InitializeComponent();
        }
        public FTopCompany(Fmain fm)
        {
            InitializeComponent();
            this.fm = fm;
        }

        private void FTopCompany_Load(object sender, EventArgs e)
        {
            charts.InitializeGunaChart(gunaChart1, "CV", "Tháng");
            charts.InitializeGunaChart(gunaChart2, "Doanh Thu", "Tháng");
            charts.InitializeGunaChart(gunaChart3, "Đánh Giá", "Tháng");
            DataTable dt = TopCompanyDAO.ReadData();
            TopCompanyDAO.WriteData(dt, dgvCompany);
        }

        private void dgvCompany_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int x = e.ColumnIndex, y = e.RowIndex;
            if (y >= 0)
            {
                CustomMessageBox cmb = new CustomMessageBox();
                if (x == 4)
                {
                    FCompanyDetails fcd = new FCompanyDetails(int.Parse(dgvCompany.Rows[y].Cells[0].Value.ToString()), fm);
                    try
                    {
                        fcd.btnDeleteForm.Visible = true;
                        fcd.ShowDialog();
                        
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Lỗi không xem");
                    }
                    finally
                    {

                    }
                }
            }
        }
    }
}
