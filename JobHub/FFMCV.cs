using JobHub;
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
    public partial class FFMCV : Form
    {
        FormHandler handler = new FormHandler();
        FixCVDAO fixCVDAO = new FixCVDAO();
        uC_MakeCV_1 uc_make;
        private int idCV;
        private int idCandidate;
        
        public FFMCV()
        {
            InitializeComponent();
        }

        public FFMCV(uC_MakeCV_1 uc)
        {
            InitializeComponent();
        }
        public FFMCV(int idCV, int idCandidate)
        {
            InitializeComponent();
            this.idCV = idCV;
            this.idCandidate = idCandidate;
        }
        

        private DataTable readData()
        {
            DataTable dt = fixCVDAO.readData(this.idCandidate, this.idCV);
            return dt;
        }

        private void WriteData(DataTable dt)
        {
            //Candidate candidate = new Candidate(this.idCandidate, uc_make.txtFirstName.Text.Trim(), uc_make.txtLastName.Text.Trim(), uc_make.txtPhoneNumber.Text.Trim(),
            //                                    uc_make.txtEmail.Text.Trim(), uc_make.rdoBoy.Checked, uc_make.txtLink.Text.Trim(), uc_make.dtpYob.Value, uc_make.txtLinkAVT.Text.Trim(), uc_make.txtAddress.Text.Trim());
            fixCVDAO.writeData(dt, this);
        }
        private void FFMCV_Load(object sender, EventArgs e)
        {

            DataTable dt = readData();
            
            WriteData(dt);
        }
    }
}
