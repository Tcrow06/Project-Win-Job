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
        public FJobPostHistory()
        {
            InitializeComponent();
            //dgJobPostHistory.ColumnHeadersDefaultCellStyle.BackColor = Color.Red; // Màu nền
        }

        private void FJobPostHistory_Load(object sender, EventArgs e)
        {
            /*dgJobPostHistory.Rows.Add("12/23/2023",
                "Nhân Viên Kinh Doanh Có Lương Cứng + Hoa Hồng Cao, Thu Nhập Trên 20 Triệu",
                1, 1, 1);*/
            LoadFullGridView();
            
        }
        private void LoadFullGridView()
        {
            int idCompany = 3;
            try
            {
                if (conn.State != ConnectionState.Open)
                {
                    conn.Open();

                    string query = string.Format($"select* from Job where Job.idCompany = {idCompany}");
                    SqlCommand cmd = new SqlCommand(query, conn);
                    SqlDataReader dr = cmd.ExecuteReader();
                    JobDetail jd = new JobDetail();
                    while (dr.Read())
                    {
                        jd.NameJob = dr["jobName"].ToString();
                        jd.Salary = dr["jobSalary"].ToString();
                        jd.Address = dr["jobAddress"].ToString();
                        jd.Experience = dr["jobExperience"].ToString();
                        jd.Description = dr["jobDescription"].ToString();
                        jd.Requirement = dr["jobRequirement"].ToString();
                        jd.Benefit = dr["jobBenefit"].ToString();
                        jd.RegisterDead = Convert.ToDateTime(dr["jobRegisterDead"]);
                        jd.PostDate = Convert.ToDateTime(dr["jobPostDate"]);

                        DateTime date = Convert.ToDateTime(jd.PostDate);
                        string datePost = date.ToString("dd-MM-yyyy");
                        dgv.Rows.Add(datePost, jd.NameJob, jd.Address, jd.Salary, edit, delete);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        
        private void dgv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int x = e.ColumnIndex, y = e.RowIndex;
            if (y >= 0)
            {
                // If click Update button 
                if (x == 4)
                {
                    /*if (taiKhoan.CapDoQuyen == 1)
                    {
                        CTMessageBox.Show("Bạn không có quyền thực hiện thao tác này.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }*/
                    FPostJob fpj = new FPostJob();
                    try
                    {
                        int idJob = int.Parse(dgv.Rows[y].Cells[1].Value.ToString());
                        fpj.ShowDialog();
                    }
                    catch (Exception)
                    {
                        //CustomMessageBox.Show("Lỗi không thể sửa");
                    }
                    finally
                    {
                        LoadFullGridView();
                        
                    }
                }
                if (x == 5)
                {


                    //CustomMessageBox.Show("Bạn có muốn xóa");
                    
                }

                }
            }

        private void dgv_CellMouseMove(object sender, DataGridViewCellMouseEventArgs e)
        {
            int y = e.RowIndex, x = e.ColumnIndex;

            if (y >= 0 && x == 4 || y >= 0 && x == 5 || y == -1)
                dgv.Cursor = Cursors.Hand;
            else
                dgv.Cursor = Cursors.Default;
        }
    }


 
}
