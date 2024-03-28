using Guna.UI2.WinForms;
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
    public partial class FJobPostHistory : Form
    {
        public FJobPostHistory()
        {
            InitializeComponent();
            //dgJobPostHistory.ColumnHeadersDefaultCellStyle.BackColor = Color.Red; // Màu nền
        }

        private void FJobPostHistory_Load(object sender, EventArgs e)
        {
            dgJobPostHistory.Rows.Add("12/23/2023", 
                "Nhân Viên Kinh Doanh Có Lương Cứng + Hoa Hồng Cao, Thu Nhập Trên 20 Triệu",
                1,1,1);
        }
    }
}
