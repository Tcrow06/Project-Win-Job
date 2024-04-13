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

        public void readData()
        {
            DataTable dt = fixCVDAO.readData(this.idCandidate, this.idCV);
            fixCVDAO.ShowData(this.idCV, this.idCandidate, uC_MakeCV1.txtAddress, uC_MakeCV1.txtEducation, uC_MakeCV1.txtEmail, uC_MakeCV1.txtFirstName, uC_MakeCV1.txtLastName, uC_MakeCV1.txtLink, uC_MakeCV1.txtNameJob, uC_MakeCV1.txtPhoneNumber, uC_MakeCV1.txtSkill, dt, uC_MakeCV1.fpnContain, uC_MakeCV1.rdoBoy, uC_MakeCV1.rdoGirl, uC_MakeCV1.dtpYob);
        }
        public FFixInfCV(int idCV, int idCandidate)
        {
            InitializeComponent();
            this.idCV = idCV;
            this.idCandidate = idCandidate;
        }

        private void FFixInfCV_Load(object sender, EventArgs e)
        {
            handler.setSizeForm(755, 670, this);
            readData();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            try
            {
                string experience = "";
                foreach (Control control in uC_MakeCV1.fpnContain.Controls)
                {
                    if (control is uC_LoadIfJob)
                    {
                        uC_LoadIfJob uc = (uC_LoadIfJob)control;
                        if(uc.txtReviewJob.Text.Trim().Length > 0 && uc.txtTime.Text.Trim().Length > 0 && uc.txtReviewJob.Text.Trim().Length > 0)
                        {
                            experience += "+" + uc.txtWhatJob.Text.Trim();
                            experience += "-" + uc.txtTime.Text.Trim();
                            experience += ">" + uc.txtReviewJob.Text.Trim();
                        }
                    }
                }
                FixCVDAO fix = new FixCVDAO(idCV, idCandidate);
                experience += "<" + uC_MakeCV1.txtEducation.Text;
                Candidate candidate = new Candidate(idCandidate, uC_MakeCV1.txtFirstName.Text.Trim(), uC_MakeCV1.txtLastName.Text.Trim(), uC_MakeCV1.txtPhoneNumber.Text.Trim(), uC_MakeCV1.txtEmail.Text.Trim(),
                uC_MakeCV1.rdoBoy.Checked, uC_MakeCV1.dtpYob.Value, uC_MakeCV1.txtAddress.Text.Trim());
                DetailCV detail = new DetailCV(idCV, idCandidate, uC_MakeCV1.txtNameJob.Text.Trim(), uC_MakeCV1.txtLink.Text.Trim(), uC_MakeCV1.txtSkill.Text.Trim(), experience);
                fix.UpdateData(detail);
                fix.UpdateData(candidate);
                CustomMessageBox custom = new CustomMessageBox();
                custom.Show("Sửa thành công");
                FFixInfCV_Load(sender, e);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
