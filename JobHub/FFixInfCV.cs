using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.LinkLabel;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace JobHub
{
    public partial class FFixInfCV : Form
    {
        FormHandler handler = new FormHandler();
        FixCVDAO fixCVDAO = new FixCVDAO();
        private int idCV;
        private int idCandidate;
        public FFixInfCV()
        {
            InitializeComponent();

        }

        public FFixInfCV(int idCV, int idCandidate)
        {
            InitializeComponent();
            this.idCV = idCV;
            this.idCandidate = idCandidate;
            DataTable dt = fixCVDAO.readData(idCandidate, idCV);
            fixCVDAO.ShowData(txtAddress, txtEducation, txtEmail, txtFirstName, txtLastName, txtLink, txtNameJob, txtPhoneNumber, txtSkill, dt, fpnContain, rdoBoy, rdoGirl, dtpYob);
        }

        private void FFixInfCV_Load(object sender, EventArgs e)
        {
            handler.setSizeForm(740, 680, this);
            //string experience = "";
            //DetailCV detailCV = new DetailCV(id, txtNameJob.Text.Trim(), txtFirstName.Text.Trim(), txtLastName.Text.Trim(), txtLink.Text.Trim(), txtPhoneNumber.Text.Trim(), txtEmail.Text.Trim(), txtAddress.Text.Trim(), txtEducation.Text.Trim(), txtSkill.Text.Trim(), experience);
            
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            string experience = "";
            foreach(Control control in fpnContain.Controls)
            {
                if(control is uC_LoadIfJob)
                {
                    uC_LoadIfJob uc = (uC_LoadIfJob)control;
                    experience += "+" + uc.txtWhatJob.Text.Trim();
                    experience += "-" + uc.txtTime.Text.Trim();
                    experience += ">" + uc.txtReviewJob.Text.Trim();
                }
            }
            Candidate candidate = new Candidate(idCandidate, txtFirstName.Text.Trim() + txtLastName.Text.Trim(), txtPhoneNumber.Text.Trim(),  txtEmail.Text.Trim(),
             rdoBoy.Checked.ToString(),  txtLink.Text.Trim(), dtpYob.Value,  txtLink.Text.Trim(),  txtAddress.Text.Trim());
            DetailCV detail = new DetailCV(idCV,  txtNameJob.Text.Trim(), txtFirstName.Text.Trim(), txtLastName.Text.Trim(), txtLink.Text.Trim(),  txtPhoneNumber.Text.Trim(), 
                txtEmail.Text.Trim(), txtAddress.Text.Trim(), txtEducation.Text.Trim(), txtSkill.Text.Trim(),  experience);
            fixCVDAO.UpdateData(detail);
            fixCVDAO.UpdateData(candidate);
        }
    }
}
