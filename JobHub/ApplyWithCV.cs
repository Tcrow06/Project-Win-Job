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
        CandidateDao cd = new CandidateDao();
        public ApplyWithCV() { }
        public void LoadJobNameOfForm(Label lblJobName, int idJob)
        {
            JobDetail job = new JobDetail();
            JobDetail jobDetail = job.GetInfoJobDetailFromDB(idJob);
            lblJobName.Text = "Ứng tuyển " + jobDetail.NameJob;
        }
        public void LoadForm(FApplyWithCV fa,Guna2Panel pn1, Label cvOn, Label cvLoad, Account account)
        {
            

            SqlDataReader dr = dao.GetUcInfoOnCVOn(account.Id);
            int x = cvOn.Location.X;
            int y = cvOn.Location.Y + cvOn.Height + 10;
            cvOn.Visible = false;
            cvLoad.Visible = false;
            if (dr != null)
            {
                cvOn.Visible = true;
                while (dr.Read())
                {
                    Uc_ChoiceCV job = choiceCV.InsertInfoAndEventIntoUcChoiceCv(fa,dr, account, pn1);
                    pn1.Controls.Add(job);
                    job.Location = new System.Drawing.Point(x,y);
                    y += job.Height;
                }
                dr.Dispose();
            }

            //cvLoad.Hide();
        }
        public void Apply(int idJob,int idCV, Fmain fm)
        {
            cd.ApplyJob(idJob, idCV, fm.Account.Id);
        }


    }
}
