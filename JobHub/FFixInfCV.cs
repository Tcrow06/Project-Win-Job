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
            //DataTable dt = fixCVDAO.ReadData(this.idCandidate, this.idCV);
            //fixCVDAO.ShowData(this.idCV, this.idCandidate, uC_MakeCV2.txtAddress, uC_MakeCV2.txtEducation, uC_MakeCV2.txtEmail, uC_MakeCV2.txtFirstName, uC_MakeCV2.txtLastName, uC_MakeCV2.txtNameJob, uC_MakeCV2.txtPhoneNumber, uC_MakeCV2.txtSkill, dt, uC_MakeCV2.fpnContain, uC_MakeCV2.rdoBoy, uC_MakeCV2.rdoGirl, uC_MakeCV2.dtpYob);
        }
        public FFixInfCV(int idCV, int idCandidate)
        {
            InitializeComponent();
            this.idCV = idCV;
            this.idCandidate = idCandidate;
        }

        private void FFixInfCV_Load(object sender, EventArgs e)
        {
            handler.setSizeForm(755, 710, this);
            readData();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
/*            try
            {
                string experience = "";
                foreach (Control control in uC_MakeCV2.fpnContain.Controls)
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
                Candidate candidate = new Candidate(idCandidate, uC_MakeCV2.txtFirstName.Text.Trim(), uC_MakeCV2.txtLastName.Text.Trim(), uC_MakeCV2.txtPhoneNumber.Text.Trim(), uC_MakeCV2.txtEmail.Text.Trim(),
                uC_MakeCV2.rdoBoy.Checked, uC_MakeCV2.dtpYob.Value, uC_MakeCV2.txtAddress.Text.Trim());
                DetailCV detail = new DetailCV(idCV, idCandidate, uC_MakeCV2.txtNameJob.Text.Trim(), uC_MakeCV2.txtSkill.Text.Trim(), experience, uC_MakeCV2.txtEducation.Text.Trim());
                fix.UpdateData(detail);
                fix.UpdateData(candidate);
                CustomMessageBox custom = new CustomMessageBox();
                custom.Show("Sửa thành công");
                FFixInfCV_Load(sender, e);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }*/

        }
    }
}
