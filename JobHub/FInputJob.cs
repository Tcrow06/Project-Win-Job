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
    public partial class FInputJob : Form
    {
        Fmain fm;
        DBConection con = new DBConection();
        Candidate can = new Candidate();
        public FInputJob()
        {
            InitializeComponent();
        }
        public FInputJob(Fmain fm)
        {
            InitializeComponent();
            this.fm = fm;
            GetInfo(fm.Account.Id);
        }

        private void btnApply_Click(object sender, EventArgs e)
        {

        }
        private void GetInfo(int idCandidate)
        {
            Candidate candidate= can.GetInfoCandidate(idCandidate);
            if(candidate != null) {
                txtName.Text = candidate.FullName;
                txtAddress.Text = candidate.Address;
                txtEmail.Text = candidate.Email;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string sql = $@"insert into InputJob(idCandidate, des, salaryOffer, jobName) values ({fm.Account.Id},N'{txtDes.Text}',N'{txtSalary.Text}',N'{txtNameJob.Text}')";
            con.ExcuteNoMess(sql);
            MessageBox.Show("Lưu thành công");
        }
    }
}
