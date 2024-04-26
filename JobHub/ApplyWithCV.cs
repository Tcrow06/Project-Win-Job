using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Drawing;
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
        CandidateDAO cd = new CandidateDAO();
        public ApplyWithCV() { }
        public void LoadJobNameOfForm(Label lblJobName, int idJob)
        {
            JobDetail job = new JobDetail();
            JobDetail jobDetail = job.GetInfoJobDetailFromDB(idJob);
            lblJobName.Text = "Ứng tuyển " + jobDetail.NameJob;
        }
        public void LoadUC_CV(FApplyWithCV fa,Guna2Panel pn1, Label cvOn, Label cvLoad, Account account)
        {
            

            SqlDataReader drON = dao.GetUcInfoOnCV(account.Id);
            int x = cvOn.Location.X;
            int y = cvOn.Location.Y + cvOn.Height + 10;
            cvOn.Visible = false;
            cvLoad.Visible = false;
            if (drON != null)
            {
                cvOn.Visible = true;
                while (drON.Read())
                {
                    Uc_ChoiceCV job = choiceCV.InsertInfoAndEventIntoUcChoiceCv(fa, drON, account, pn1,0);
                    pn1.Controls.Add(job);
                    job.Location = new System.Drawing.Point(x,y);
                    y += job.Height;
                }
                drON.Dispose();
            }
            cvLoad.Location = new Point(x, y + 20);
            y = y + cvLoad.Height + 25;
            SqlDataReader drLoad = dao.GetUcInfoLoadCV(account.Id);
            if (drLoad != null)
            {

                cvLoad.Visible = true;
                while (drLoad.Read())
                {
                    Uc_ChoiceCV job = choiceCV.InsertInfoAndEventIntoUcChoiceCv(fa, drLoad, account, pn1,1);
                    pn1.Controls.Add(job);
                    job.Location = new System.Drawing.Point(x, y);
                    y += job.Height;
                }
                drLoad.Dispose();
            }
            pn1.Height = y - pn1.Location.Y+ 20;
            fa.HeightPanel1 = pn1.Height;

        }
        public void Apply(int idJob,int idCV, Fmain fm)
        {
            cd.ApplyJob(idJob, idCV, fm.Account.Id);
        }
        public void Apply(int idJob, int idCV, Fmain fm, int CVType)
        {
            cd.ApplyJob(idJob, idCV, fm.Account.Id, CVType);
        }


    }
}
