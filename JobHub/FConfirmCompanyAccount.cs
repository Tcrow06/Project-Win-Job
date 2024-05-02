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
    public partial class FConfirmCompanyAccount : Form
    {
        Image company = Properties.Resources.enterprise;
        Image file = Properties.Resources.checklist__1_;
        Image delete = Properties.Resources.detele;
        Image accpet = Properties.Resources.accept;
        ConfirmCompanyAccount confirm = new ConfirmCompanyAccount();
        public FConfirmCompanyAccount()
        {
            InitializeComponent();
        }

        private void SetSizeDGV()
        {
            if (dgv.DisplayedRowCount(false) < dgv.RowCount)
            {
                dgv.Width = 825;
            }
            else
            {
                dgv.Width = 809;
            }
        }
        private void ConfirmCreationOfCompanyAccount_Load(object sender, EventArgs e)
        {
            confirm.LoadAllList(dgv);
            SetSizeDGV();

        }
        private void LoadFullGridView()
        {
            confirm.LoadAllList(dgv);
            SetSizeDGV();
        }

        private void dgv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int x = e.ColumnIndex, y = e.RowIndex;
            if (y >= 0)
            {
                try
                {
                    int idCompany = int.Parse(dgv.Rows[y].Cells[5].Value.ToString());
                    if (x == 2)
                    {
                        confirm.ShowBusinessLicense(idCompany);
                        
                    }else if (x == 3)
                    {
                        DialogResult result = MessageBox.Show("Bạn có chắc chắn xác nhận ?", "Question",
                                        MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                        if (result == DialogResult.OK)
                        {

                            confirm.Accept(idCompany);
                            LoadFullGridView();
                        }

                    }
                    else if (x== 4){
                        DialogResult result = MessageBox.Show("Xác nhận không chấp nhận tài khoản.", "Thông báo",
                                        MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                        if (result == DialogResult.OK)
                        {

                            confirm.NoAccept(idCompany);
                            LoadFullGridView();
                        }
                    }

                }catch(Exception) {
                    MessageBox.Show("Đã xảy ra lỗi! Vui lòng thử lại.");
                }
               

            }
        }

        private void dgv_CellMouseMove(object sender, DataGridViewCellMouseEventArgs e)
        {
            int y = e.RowIndex, x = e.ColumnIndex;
            //Cột hàng trên
            int[] arrX = { 1};
            bool isExists = false;
            if (Array.IndexOf(arrX, x) != -1)
                isExists = true;
            if (y >= 0 && (x == 2||x== 3 || x == 4) || (y == -1 && isExists))
                dgv.Cursor = Cursors.Hand;
            else
            {
                dgv.Cursor = Cursors.Default;
            }
        }

        private void dgv_MouseMove(object sender, MouseEventArgs e)
        {
            DataGridView.HitTestInfo hit = dgv.HitTest(e.X, e.Y);
            if (hit.Type == DataGridViewHitTestType.None && e.X >= 0 && e.X <= dgv.Width && e.Y >= 0 && e.Y <= dgv.Height)
            {
                dgv.Cursor = Cursors.Default;
            }
        }
    }
}
