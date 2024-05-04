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
    public partial class FCreatCV : Form
    {
        int idCandidate;
        MakeCVDAO makeCVDAO;

        public FCreatCV(int idCandidate)
        {
            InitializeComponent();
            this.idCandidate = idCandidate;
            makeCVDAO = new MakeCVDAO(this.idCandidate);
        }
        private DataTable readData()
        {
            string cmd = $"select Candidate.* from Candidate where Candidate.idCandidate = {this.idCandidate}";
            DataTable dt = makeCVDAO.ReadData(cmd);
            return dt;
        }

        private void WriteData(DataTable dt)
        {
            //Candidate candidate = new Candidate(this.idCandidate, uc_make.txtFirstName.Text.Trim(), uc_make.txtLastName.Text.Trim(), uc_make.txtPhoneNumber.Text.Trim(),
            //                                    uc_make.txtEmail.Text.Trim(), uc_make.rdoBoy.Checked, uc_make.txtLink.Text.Trim(), uc_make.dtpYob.Value, uc_make.txtLinkAVT.Text.Trim(), uc_make.txtAddress.Text.Trim());
            makeCVDAO.WriteData(dt, this, idCandidate);
        }

        private void FCreatCV_Load(object sender, EventArgs e)
        {
            DataTable dt = readData();
            WriteData(dt);
        }
    }
}
