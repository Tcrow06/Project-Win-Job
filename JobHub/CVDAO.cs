using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JobHub
{
    internal class CVDAO
    {
        public CVDAO() { }
        private CV myCV;
        Function function = new Function();

        public DataTable ReadData(int id)
        {
            string cmd = $@"SELECT Candidate.idCandidate,Candidate.candidateFirstName, Candidate.candidateLastName, CV.jobName, CV.CVAvatar, CV.idCV
                            FROM Candidate
                            INNER JOIN CV ON CV.idCandidate = Candidate.idCandidate
                            where Candidate.idCandidate = {id}";
            return function.ReadData(cmd);
        }

        public void WriteData(DataTable dt, FlowLayoutPanel fpn)
        {
             function.WriteData(dt, fpn);
        }
        internal CV MyCV { get => myCV; set => myCV = value; }
    }
}
