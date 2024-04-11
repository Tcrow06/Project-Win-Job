using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace JobHub
{
    public class ApplyWithCV
    {
        ApplyWithCVDAO dao = new ApplyWithCVDAO();
        Uc_ChoiceCV choiceCV = new Uc_ChoiceCV();
        public ApplyWithCV() { }

        public void LoadForm(FApplyWithCV fa,Guna2Panel pn1, Label cvOn, Label cvLoad, Account account, int idJob,int idCV)
        {
            SqlDataReader dr = dao.GetUcInfoOnCVOn(account.Id);
            if (dr != null)
            {
                int x = cvOn.Location.X;
                int y = cvOn.Location.Y + cvOn.Height+10;
               
                while (dr.Read())
                {
                    Uc_ChoiceCV job = choiceCV.InsertInfoAndEventIntoUcChoiceCv(fa,dr, account, pn1, idCV);
                    pn1.Controls.Add(job);
                    job.Location = new System.Drawing.Point(x,y);
                    y += job.Height;
                }
                dr.Dispose();
            }
            cvLoad.Hide();
        }

    }
}
