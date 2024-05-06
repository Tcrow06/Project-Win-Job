using Guna.UI2.WinForms;
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
        private Fmain fm;
        SqlConnection sqlConnection = new SqlConnection(Properties.Settings.Default.conn);
        int idJob = -1;
        JobDetail jobdetail = new JobDetail();

        public FPostJob(Fmain fm)
        {
            this.fm = fm;
            InitializeComponent();
        }

        public FPostJob(Fmain fm, int idJob)
        {
            this.fm = fm;
            this.idJob = idJob;
            InitializeComponent();
        }

        private void AddPlusAtLineStart(Guna2TextBox textBox1)
        {
            string[] lines = textBox1.Lines;
            for (int i = 1; i < lines.Length; i++)
            {
                if (!lines[i].StartsWith("~") && !string.IsNullOrWhiteSpace(lines[i]))
                {
                    lines[i] = "~" + lines[i];
                }
            }
            textBox1.Lines = lines;
        }

        private void guna2Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void FPostJob_Load(object sender, EventArgs e)
        {
            if (idJob != -1)
            {
                LoadJobDetails();
            }
            CheckSalary();
        }

        private void btnPostJob_Click(object sender, EventArgs e)
        {
            string sql = "SELECT MAX(idJob) FROM Job";
            SqlCommand sqlCmd;
            int storeMaxId = 0;
            sqlConnection.Open();

            sqlCmd = new SqlCommand(sql, sqlConnection);
            storeMaxId = Convert.ToInt32(sqlCmd.ExecuteScalar());

            JobDetailDAO jd = new JobDetailDAO();


            storeMaxId += 1;
            float minSalary = 0;
            float maxSalary = 0;

            if (cboSalary.SelectedItem.ToString() == "Thỏa thuận khi gặp")
            {
                minSalary = 0;
                maxSalary = 0;
            }
            else if (cboSalary.SelectedItem.ToString() == "Quy định tối thiểu tối đa")
            {
                minSalary = (float)Convert.ToDouble(txtMinSalary.Text);
                maxSalary = (float)Convert.ToDouble(txtMaxSalary.Text);
            }
            else if (cboSalary.SelectedItem.ToString() == "Mức lương trên 1 khoảng nhất định")
            {
                minSalary = 0;
                maxSalary = (float)Convert.ToDouble(txtMaxSalary.Text);
            }


            AddPlusAtLineStart(txtDescription);
            AddPlusAtLineStart(txtRequire);
            AddPlusAtLineStart(txtBenefit);


            if (idJob != -1)
            {

                JobDetail A = new JobDetail(idJob, txtName.Text, fm.Account.Id, cboSalary.SelectedItem.ToString(), cboAddress.SelectedItem.ToString(), txtDescription.Text, txtExp.Text, txtRequire.Text, txtBenefit.Text, cboCatogory.Text, DateTime.Today, dtpDateDead.Value, minSalary, maxSalary);
                jd.UpdateJob(A);
                this.Close();
            }
            else
            {

                JobDetail A = new JobDetail(storeMaxId, txtName.Text, fm.Account.Id, cboSalary.SelectedItem.ToString(), cboAddress.SelectedItem.ToString(), txtDescription.Text, txtExp.Text, txtRequire.Text, txtBenefit.Text, cboCatogory.Text, DateTime.Today, dtpDateDead.Value, minSalary, maxSalary);
                jd.Them(A);
            }
        }


        private void txtMinSalary_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((!char.IsNumber(e.KeyChar)) && (!char.IsControl(e.KeyChar)))
            {
                e.Handled = true;
            }
        }

        private void txtMaxSalary_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((!char.IsNumber(e.KeyChar)) && (!char.IsControl(e.KeyChar)))
            {
                e.Handled = true;
            }
        }

        private void CheckSalary()
        {
            if (cboSalary.SelectedItem.ToString() == "Thỏa thuận khi gặp")
            {
                txtMaxSalary.ReadOnly = true;
                txtMinSalary.ReadOnly = true;
            }
            else if (cboSalary.SelectedItem.ToString() == "Quy định tối thiểu tối đa")
            {
                txtMaxSalary.ReadOnly = false ;
                txtMinSalary.ReadOnly = false ;
            }
            else if (cboSalary.SelectedItem.ToString() == "Mức lương trên 1 khoảng nhất định")
            {
                txtMaxSalary.ReadOnly = false ;
                txtMinSalary.ReadOnly = true;
            }
        }

        private void LoadJobDetails()
        {
            jobdetail = jobdetail.GetInfoJobDetailFromDB(idJob);
            txtName.Text = jobdetail.NameJob;
            cboAddress.SelectedItem = jobdetail.Address;
            cboCatogory.SelectedItem = jobdetail.Category;
            dtpDateDead.Value = jobdetail.RegisterDead;
            txtDescription.Text = jobdetail.Description;
            txtExp.Text = jobdetail.Experience;
            txtRequire.Text = jobdetail.Requirement;
            txtBenefit.Text = jobdetail.Benefit;
            if (jobdetail.MaxSalary == 0 && jobdetail.MinSalary == 0)
            {
                cboSalary.SelectedItem = "Thỏa thuận khi gặp";

            }
            else if (jobdetail.MaxSalary != 0 && jobdetail.MinSalary == 0)
            {
                cboSalary.SelectedItem = "Mức lương trên 1 khoảng nhất định";
                txtMaxSalary.Text = jobdetail.MaxSalary.ToString();
            }
            else
            {
                cboSalary.SelectedItem = "Quy định tối thiểu tối đa";
                txtMaxSalary.Text = jobdetail.MaxSalary.ToString();
                txtMinSalary.Text = jobdetail.MinSalary.ToString();
            }



        }

        private void cboSalary_SelectedIndexChanged(object sender, EventArgs e)
        {
            CheckSalary();
        }
    }
}
