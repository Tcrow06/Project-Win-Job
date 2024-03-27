using System;
using System.Collections.Generic;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JobHub
{
    public class CandidateDao
    {
        private DBConection db = new DBConection();
        public CandidateDao() { }
        
        public void Apply(int idJob, int idCan, int idCv)
        {
            string sql = string.Format($"insert into AppliedCV(idJob, idCandidate, idCV) values ({idJob}, {idCan}, {idCv})"); 
            db.ThucThi(sql);
        }
        public void SavedJob(int idJob, int idCan)
        {
            string sql = string.Format($"insert into SavedJob(idJob, idCandidate) values ({idJob},{idCan})");
            db.ThucThi(sql);
        }
        public void FollowedCompany(int idCan, int idCompany)
        {
            string sql = string.Format($"insert into FollowedCompany(idCandidate, idCompany) values ({idCan},{idCompany})");
            db.ThucThi(sql);
        }

    }
}
