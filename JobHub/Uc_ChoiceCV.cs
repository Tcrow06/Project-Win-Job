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
        }

        private void UCChoiceCV_MouseHover(object sender, EventArgs e)
        {
            lblView.Visible = true;
            btn.Visible = true;
            pnChoiceCV.BorderColor = Color.FromArgb(0, 139, 0);
        }

        private void UCChoiceCV_MouseLeave(object sender, EventArgs e)
        {
            pnChoiceCV.BorderColor = Color.Silver;
        }

        private void pnChoiceCV_Click(object sender, EventArgs e)
        {
            clickUC?.Invoke(sender,e);

        }

        public Uc_ChoiceCV InsertInfoAndEventIntoUcChoiceCv(FApplyWithCV fa,SqlDataReader dr, Account account, Guna2Panel pn, int CVType)
        {
            Uc_ChoiceCV uc = new Uc_ChoiceCV();
            uc.lblCVName.Text = dr["CVName"].ToString();
            Size textSize = TextRenderer.MeasureText(lblCVName.Text, lblCVName.Font);
            uc.lblCVName.Width = textSize.Width+50;
            uc.lblView.Location = new Point(lblCVName.Location.X + uc.lblCVName.Width, lblView.Location.Y);
            int idCV = int.Parse(dr["idCV"].ToString());
            int idCandidate = account.Id;

            uc.clickUC += (sender, e) =>
            {
                    uc.LoadCVDetails(sender, e, idCV, idCandidate, CVType);
            };
            uc.clickBtn += (sender, e) =>
            {
                uc.LoadSelectedForm(sender, e,uc, fa, idCV, CVType);
            };
            return uc;
        }
        public void LoadCVDetails(object sender, EventArgs e, int idCV, int idCandidate, int CVType)
        {
            FormHandler handler = new FormHandler();
            if (CVType == 0)
            {
                handler.OpenNewForm(idCandidate, idCV);
            }
            else
            {
                handler.OpenImage(idCV);
            }
        }

        public void LoadSelectedForm(object sender, EventArgs e, Uc_ChoiceCV uc, FApplyWithCV fa, int idCV, int CVType)
        {
            fa.LoadFormChoiceCVOn(uc,idCV, CVType);
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
