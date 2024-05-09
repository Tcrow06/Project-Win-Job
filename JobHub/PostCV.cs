using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JobHub
{
    internal class PostCV
    {
        Function func = new Function();
        Candidate can = new Candidate();
        public DataTable ReadData(string cmd)
        {
            return func.ReadData(cmd);
        }

        public void WriteCV(DataTable dt, FlowLayoutPanel fpnContainCV)
        {
            foreach(DataRow dr in dt.Rows)
            {
                uC_PostCV postCV = new uC_PostCV();
                Candidate candidate = can.GetInfoCandidate(int.Parse(dr["idCandidate"].ToString()));
                postCV.lblKN.Text = dr["des"].ToString();
                postCV.lblOffer.Text = dr["salaryOffer"].ToString();
                postCV.btnName.Text = candidate.FullName;
                postCV.btnEmail.Text = candidate.Email;
                postCV.btnJob.Text = dr["jobName"].ToString();
                fpnContainCV.Controls.Add(postCV);

            }
        }
    }
}
