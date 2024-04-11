using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JobHub
{
    public partial class Uc_ChoiceCV : UserControl
    {
        public event EventHandler clickUC;
        public event EventHandler clickBtn;

        public Uc_ChoiceCV()
        {
            InitializeComponent();
            lblView.Visible = false;
            btn.Visible = false;
        }

        private void UCChoiceCV_MouseHover(object sender, EventArgs e)
        {
            lblView.Visible = true;
            btn.Visible = true;
            pnChoiceCV.BorderColor = Color.FromArgb(0, 139, 0);
        }

        private void UCChoiceCV_MouseLeave(object sender, EventArgs e)
        {
            lblView.Visible = false ;
            btn.Visible = false;
            pnChoiceCV.BorderColor = Color.Silver;
        }

        private void pnChoiceCV_Click(object sender, EventArgs e)
        {
            clickUC?.Invoke(sender,e);

        }

        public Uc_ChoiceCV InsertInfoAndEventIntoUcChoiceCv(FApplyWithCV fa,SqlDataReader dr, Account account, Guna2Panel pn, int idCv)
        {
            Uc_ChoiceCV uc = new Uc_ChoiceCV();
            uc.lblCVName.Text = dr["CVName"].ToString();
            //MessageBox.Show(uc.lblCVName.Text);
            Size textSize = TextRenderer.MeasureText(lblCVName.Text, lblCVName.Font);
            uc.lblCVName.Width = textSize.Width+50;
            uc.lblView.Location = new Point(lblCVName.Location.X + uc.lblCVName.Width + 10, lblView.Location.Y);
            //int idJob1 = idJob;
            int idCV = int.Parse(dr["idCv"].ToString());
            int idCandidate = account.Id;

            uc.clickUC += (sender, e) =>
            {
                uc.LoadCVDetails(sender, e, idCV, idCandidate);
            };
            uc.clickBtn += (sender, e) =>
            {
                //MessageBox.Show("");
                uc.LoadSelectedForm(sender, e,uc, fa);
                /*idCv= idCV;*/
            };
            return uc;
        }
        public void LoadCVDetails(object sender, EventArgs e, int idCV, int idCandidate)
        {
            FormHandler handler = new FormHandler();
            handler.OpenNewForm(idCandidate, idCV);
        }
        public void LoadSelectedForm(object sender, EventArgs e, Uc_ChoiceCV uc, FApplyWithCV fa)
        {
            fa.LoadFormChoiceCVOn(uc);
        }
        public void ChoiceCV(object sender, EventArgs e, int idCV, int idCandidate)
        {
            FormHandler handler = new FormHandler();
            handler.OpenNewForm(idCandidate, idCV);
        }


        private void btn_Click(object sender, EventArgs e)
        {
            clickBtn?.Invoke(sender, e);
        }
    }
}
