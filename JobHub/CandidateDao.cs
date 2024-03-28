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
            db.ExcuteNoMess(sql);
        }
        public void UnSavedJob(int idJob, int idCan)
        {
            string sql = string.Format($"delete SavedJob where idJob = {idJob} and  idCandidate = {idCan}  ");
            db.ExcuteNoMess(sql);
        }

        public void FollowedCompany(int idCan, int idCompany)
        {
            string sql = string.Format($"insert into FollowedCompany(idCandidate, idCompany) values ({idCan},{idCompany})");
            db.ExcuteNoMess(sql);
        }
        public void UnFollowedCompany(int idCan, int idCompany)
        {
            string sql = string.Format($"delete FollowedCompany where idCandidate ={idCan} and idCompany = {idCompany} ");
            db.ExcuteNoMess(sql);
        }
        public bool CheckSaveStatus(int idJob, int idCan)
        {
            string sql = string.Format($"select * from SavedJob where idJob = {idJob} and idCandidate = {idCan}");
            return db.CheckNull(sql);
        }

    }
}
