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
        public FConfirmCompanyAccount()
        {
            InitializeComponent();
        }

        private void SetSizeDGV()
        {
            if (dgv.DisplayedRowCount(false) < dgv.RowCount)
            {
                dgv.Width = 814;
            }
            else
            {
                dgv.Width = 796;
            }
        }
        private void ConfirmCreationOfCompanyAccount_Load(object sender, EventArgs e)
        {
            for(int i=0; i< 20; i++)
            {
                dgv.Rows.Add(company, "Text2", file, true, delete, true);
            }


            SetSizeDGV();

        }
        private void LoadFullGridView()
        {
            //dgv.Rows.Clear();
            //jobPostHistory.LoadFullGridView(fm.Account.Id, dgv);
            SetSizeDGV();
        }

        private void dgv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int x = e.ColumnIndex, y = e.RowIndex;
            if (y >= 0)
            {
                CustomMessageBox cmb = new CustomMessageBox();
                if (x == 2)
                {
                    //FPostJob fpj = new FPostJob(fm);
                    try
                    {
                        int idJob = int.Parse(dgv.Rows[y].Cells[5].Value.ToString());

                        //Hiện form chỉnh sửa tại đây
                        //fpj.ShowDialog();
                        LoadFullGridView();
                    }
                    catch (Exception)
                    {
                        cmb.Show("Lỗi không thể sửa");
                    }
                    finally
                    {

                    }
                }
                if (x == 4)
                {
                    try
                    {
                        DialogResult result = MessageBox.Show("Xác nhận xóa", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                        if (result == DialogResult.Yes)
                        {
                            //DeleteJob(int.Parse(dgv.Rows[y].Cells[6].Value.ToString()));
                            LoadFullGridView();
                        }

                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Đã xảy ra lỗi! Vui lòng thử lại.");
                    }
                    finally
                    {
                    }
                }

            }
        }

        private void dgv_CellMouseMove(object sender, DataGridViewCellMouseEventArgs e)
        {
            int y = e.RowIndex, x = e.ColumnIndex;
            int[] arrX = { 0, 1, 2, 3, };
            bool isExists = false;
            if (Array.IndexOf(arrX, x) != -1)
                isExists = true;
            if (y >= 0 && (x == 4 || x == 5) || (y == -1 && isExists))
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
