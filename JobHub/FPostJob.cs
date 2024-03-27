using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JobHub
{
    public partial class FPostJob : Form
    {
        public FPostJob()
        {
            InitializeComponent();
        }

        private void txtWorkExperience_TextChanged(object sender, EventArgs e)
        {

        }

        private void guna2ShadowPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txtGmail_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtExDescribe_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtAcStart_TextChanged(object sender, EventArgs e)
        {

        }

        private void guna2PictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void txtExPosition_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtExEnd_TextChanged(object sender, EventArgs e)
        {

        }

        private void guna2TextBox23_TextChanged(object sender, EventArgs e)
        {

        }

        private void guna2TextBox14_TextChanged(object sender, EventArgs e)
        {

        }

        private void guna2TextBox10_TextChanged(object sender, EventArgs e)
        {

        }

        private void guna2PictureBox7_Click(object sender, EventArgs e)
        {

        }

        private void txtEducation_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtDescribeEdu_TextChanged(object sender, EventArgs e)
        {

        }

        private void guna2CirclePictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void guna2PictureBox10_Click(object sender, EventArgs e)
        {

        }

        private void txtActivity_TextChanged(object sender, EventArgs e)
        {

        }

        private void guna2TextBox20_TextChanged(object sender, EventArgs e)
        {

        }

        private void guna2TextBox31_TextChanged(object sender, EventArgs e)
        {

        }

        private void guna2PictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void txtAcPosition_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtOrganizationName_TextChanged(object sender, EventArgs e)
        {

        }

        private void guna2Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2ShadowPanel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2ShadowPanel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txtExCompany_TextChanged(object sender, EventArgs e)
        {

        }

        private void dateEndedu_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dateAcEnd_ValueChanged(object sender, EventArgs e)
        {

        }

        private void guna2PictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void txtNumbersPhone_TextChanged(object sender, EventArgs e)
        {

        }

        private void guna2CirclePictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void txtAcEnd_TextChanged(object sender, EventArgs e)
        {

        }

        private void guna2CirclePictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void txtMajors_TextChanged(object sender, EventArgs e)
        {

        }

        private void guna2TextBox28_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtGender_TextChanged(object sender, EventArgs e)
        {

        }

        private void dateExStart_ValueChanged(object sender, EventArgs e)
        {

        }

        private void txtPosition_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtAcDescribe_TextChanged(object sender, EventArgs e)
        {

        }

        private void uC_Job1_Load(object sender, EventArgs e)
        {

        }

        private void guna2PictureBox5_Click(object sender, EventArgs e)
        {

        }

        private void txtDateOfBirth_TextChanged(object sender, EventArgs e)
        {

        }

        private void dateAcStart_ValueChanged(object sender, EventArgs e)
        {

        }

        private void dateExEnd_ValueChanged(object sender, EventArgs e)
        {

        }

        private void txtLink_TextChanged(object sender, EventArgs e)
        {

        }

        private void dateEduStart_ValueChanged(object sender, EventArgs e)
        {

        }

        private void dateEduEnd_ValueChanged(object sender, EventArgs e)
        {

        }

        private void txtEduEnd_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtEduStart_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtLocation_TextChanged(object sender, EventArgs e)
        {

        }

        private void saveBtn_Click(object sender, EventArgs e)
        {

        }

        private void guna2PictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtSchoolName_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtExStart_TextChanged(object sender, EventArgs e)
        {

        }

        private void guna2TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtLocation_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void guna2CirclePictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void saveBtn_Click_1(object sender, EventArgs e)
        {/*
            try
            {
                if(sqlConnection.State != ConnectionState.Open)
                {
                    sqlConnection.Open();
                }

                string sqlStr = string.Format("INSERT INTO Job(nameJob,idCompany,salary,position,dentail,requirement,benefit,category) VALUES (N'{0}','{1}',N'{2}',N'{3}',N'{4}',N'{5}',N'{6}',N'{7}')", txtNameJob.Text, 1, txtSalary.Text, txtPosition.Text, txtJobDes.Text, txtJobRequirement.Text, txtBenefit.Text, cbCategory.SelectedItem.ToString());
                SqlCommand cmd = new SqlCommand(sqlStr, sqlConnection);
                if (cmd.ExecuteNonQuery() > 0)
                {
                    MessageBox.Show("Đăng việc thành công");
                    this.Close();
                    Fmain fm = new Fmain();
                    fm.Show();
                }

            }
            catch(Exception ex)
            {
                MessageBox.Show("Đăng công việc thất bại" + ex);
            }
            finally
            {
                sqlConnection.Close();
            }*/

          

        }
    }
}
