using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Tab;

namespace JobHub
{
    public partial class FMakeCV : Form
    {
        private int idCandidate;
        private int idCV;        
        MakeCVDAO makeCVDAO;
        FormHandler handler = new FormHandler();
        Stack<uC_LoadIfJob> containUC = new Stack<uC_LoadIfJob> ();
        public FMakeCV()
        {
            InitializeComponent();
        }

        public FMakeCV(int idCandidate)
        {
            InitializeComponent();
            this.idCandidate = idCandidate;
        }


        private void guna2Button1_Click(object sender, EventArgs e)
        {

            makeCVDAO = new MakeCVDAO(this.idCandidate);
            string cmd = "select max(CV.idCV) as max from CV";
            string experience = "";
            foreach (Control control in uC_MakeCV1.fpnContain.Controls)
            {
                if (control is uC_LoadIfJob)
                {
                    uC_LoadIfJob uc = (uC_LoadIfJob)control;
                    if (uc.txtReviewJob.Text.Trim().Length > 0 && uc.txtTime.Text.Trim().Length > 0 && uc.txtReviewJob.Text.Trim().Length > 0)
                    {
                        experience += "+" + uc.txtWhatJob.Text.Trim();
                        experience += "-" + uc.txtTime.Text.Trim();
                        experience += ">" + uc.txtReviewJob.Text.Trim();
                    }
                }
            }
            DataTable dt = makeCVDAO.ReadData(cmd);
            this.idCV = Int32.Parse(dt.Rows[0]["max"].ToString()) + 1;
            DetailCV detailCV = new DetailCV(idCV, idCandidate, uC_MakeCV1.txtNameJob.Text.Trim(),
            uC_MakeCV1.txtSkill.Text.Trim(), experience, uC_MakeCV1.txtEducation.Text.Trim());        
            makeCVDAO.Insert(detailCV);
            MessageBox.Show("Lưu thành công");
            this.Close();
        }

        public void makeViewJob()
        {
            uC_LoadIfJob load = new uC_LoadIfJob();
            containUC.Push(load);
            ControlManager controlManager = new ControlManager(idCV, idCandidate);
            load.AddPanel += (sender, e) =>
            {
                controlManager.AddPenal(uC_MakeCV1.fpnContain, load, containUC);
            };
            load.RemovePanel += (sender, e) =>
            {
                controlManager.RemoveControl(uC_MakeCV1.fpnContain, load, containUC);
            };
            load.btnAddPanel.Visible = true;
            uC_MakeCV1.fpnContain.Controls.Add(load);
        }
        private void FMakeCV_Load(object sender, EventArgs e)
        {
           // handler.setSizeForm(755, 700, this);
           // makeViewJob();
           // makeCVDAO = new MakeCVDAO(this.idCandidate);
           // //DataTable dt = makeCVDAO.readData(this.idCandidate);
           //// makeCVDAO.ShowData(idCandidate, uC_MakeCV1.txtAddress,
           // uC_MakeCV1.txtEmail, uC_MakeCV1.txtFirstName, uC_MakeCV1.txtLastName,
           // uC_MakeCV1.txtPhoneNumber,
           // //dt, uC_MakeCV1.dtpYob,
           // uC_MakeCV1.rdoBoy, uC_MakeCV1.rdoGirl);
        }
    }
}
