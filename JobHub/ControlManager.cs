using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.Remoting.Channels;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JobHub
{
    internal class ControlManager
    {
        private int idCV;
        private int idCadidate;
        public ControlManager(int idCV, int idCadidate)
        {
            this.idCV = idCV;

            this.idCadidate = idCadidate;

        }
        public void AddPenal(FlowLayoutPanel fpn, uC_LoadIfJob olduC_LoadJob, Stack<uC_LoadIfJob> containUC)
        {
            uC_LoadIfJob newUC_LoadJob = new uC_LoadIfJob();
            containUC.Push(newUC_LoadJob);
            olduC_LoadJob.btnAddPanel.Visible = false;
            newUC_LoadJob.btnAddPanel.Visible = true;
            newUC_LoadJob.AddPanel += (sender, e) =>
            {
                AddPenal(fpn, newUC_LoadJob, containUC);
            };
            newUC_LoadJob.RemovePanel += (sender, e) =>
            {
                RemoveControl(fpn, newUC_LoadJob, containUC);
            };
            fpn.Controls.Add(newUC_LoadJob);
        }

        public void RemoveControl(FlowLayoutPanel fpn, uC_LoadIfJob load, Stack<uC_LoadIfJob> containUC)
        {
            string cmd = $@"select CV.CVDescription
                            from CV
                            inner join Candidate on CV.idCandidate = Candidate.idCandidate
                            where CV.idCV = {this.idCV}";
            Function function = new Function();
            DataTable dt = function.ReadData(cmd);
            if(load.txtReviewJob.Text.Trim().Length > 0 && load.txtReviewJob.Text.Trim().Length > 0 && load.txtTime.Text.Trim().Length > 0)
            {
                string newExperience = "+" + load.txtWhatJob.Text.Trim() + "-" + load.txtTime.Text.Trim() + ">" + load.txtReviewJob.Text.Trim();
                string oldExperience = dt.Rows[0]["CVDescription"].ToString().Trim();
                string result = oldExperience.Replace(newExperience, "").Trim();
                string cmdUpdate = $@"Update CV
                                  SET CV.CVDescription = N'{result}'
                                  from CV
                                  inner join Candidate on Candidate.idCandidate = CV.idCandidate
                                  where CV.idCV = {this.idCV}";
                function.Update(cmdUpdate);
            }
            if (load.btnAddPanel.Visible == true)
            {
                containUC.Pop();
                if(containUC.Count > 0)
                {
                    uC_LoadIfJob first = containUC.Peek();
                    if (first == load)
                    {
                        containUC.Pop();
                        uC_LoadIfJob second = containUC.Peek();
                        second.btnAddPanel.Visible = true;
                    }
                    else
                    {
                        first.btnAddPanel.Visible = true;
                    }
                }
            }
            else
            {
                uC_LoadIfJob[] uC_LoadIfJob = containUC.ToArray();
                containUC.Clear();
                uC_LoadIfJob[] newArray = new uC_LoadIfJob[uC_LoadIfJob.Length - 1];
                for (int i = 0; i < uC_LoadIfJob.Length; i++)
                {
                    if (uC_LoadIfJob[i] == load)
                    {
                        Array.Copy(uC_LoadIfJob, 0, newArray, 0, i);
                        Array.Copy(uC_LoadIfJob, i + 1, newArray, i, uC_LoadIfJob.Length - i - 1);
                    }
                }
                for(int i = newArray.Length - 1; i>= 0; i--)
                {
                    containUC.Push(newArray[i]);
                } 
            }

            if(containUC.Count == 0)
            {
                AddPenal(fpn, load, containUC);
            }
            fpn.Controls.Remove(load);
        }

        public void LoadData(int idCompany, int idJob)
        {

        }
    }
}
