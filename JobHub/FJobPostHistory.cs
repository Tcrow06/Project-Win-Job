using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Text;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//using System.Web.UI.WebControls;
using System.Windows.Forms;

namespace JobHub
{
    public partial class FJobPostHistory : Form
    {
        SqlConnection conn = new SqlConnection(Properties.Settings.Default.conn);
        private Image edit = Properties.Resources.edit;
        private Image delete = Properties.Resources.detele;
        private Fmain fm;
        JobDetail jobDetail = new JobDetail();
        JobPostHistory jobPostHistory = new JobPostHistory();   
        public FJobPostHistory(Fmain fm)
        {
            this.fm = fm;
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

        private void FJobPostHistory_Load(object sender, EventArgs e)
        {
            LoadFullGridView();
        }
        private void LoadFullGridView()
        {
            dgv.Rows.Clear();
            jobPostHistory.LoadFullGridView(fm.Account.Id, dgv);
            SetSizeDGV();
        }
        
        private void dgv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int x = e.ColumnIndex, y = e.RowIndex;
            if (y >= 0)
            {
                CustomMessageBox cmb = new CustomMessageBox();
                if (x == 4)
                {
                    FPostJob fpj = new FPostJob();
                    try
                    {
                        int idJob = int.Parse(dgv.Rows[y].Cells[6].Value.ToString());

                        //Hiện form chỉnh sửa tại đây
                        fpj.ShowDialog();
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
                if (x == 5)
                {
                    try
                    {
                        DialogResult result = MessageBox.Show("Xác nhận xóa", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                        if(result == DialogResult.Yes)
                        {
                            DeleteJob(int.Parse(dgv.Rows[y].Cells[6].Value.ToString()));
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
        private void DeleteJob(int idJob)
        {
            jobPostHistory.DeleteJob(idJob);
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
