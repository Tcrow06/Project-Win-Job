using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JobHub
{
    public class CandidateDAO
    {
        private DBConection db = new DBConection();
        public CandidateDAO() { }
        
        public SqlDataReader GetInfoCandidate(int idCan)
        {
            string sql = string.Format($"select * from Candidate where idCandidate = {idCan}");
            return db.loadData(sql);
                
        }
        public void ApplyJob(int idJob, int idCv, int idCan)
        {
            string sql = string.Format($"insert into AppliedCV(idJob, idCandidate, idCV) values ({idJob}, {idCan}, {idCv})"); 
            db.ThucThi(sql);
        }
        public void ApplyJob(int idJob, int idCv, int idCan, int CVType)
        {
            string sql = string.Format($"insert into AppliedCV(idJob, idCandidate, idCV, CVType) values ({idJob}, {idCan}, {idCv}, {CVType})");
            db.ThucThi(sql);
        }
        public void AddCandidate(Candidate candidate)
        {
            
            string sql = string.Format($@"insert into Candidate(idCandidate,candidateFirstName,candidateLastname, candidateEmail) values(
                                       {candidate.Id},N'{candidate.FirstName}',N'{candidate.LastName}','{candidate.Email}')");
            db.ExcuteNoMess(sql);   
        }

        public void UnApplyJob(int idJob, int idCan)
        {
            string sql = string.Format($"delete AppliedCV where idJob = {idJob} and idCandidate = {idCan}");
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
        public bool CheckApplyStatus(int idJob, int idCan)
        {
            string sql = string.Format($"select * from AppliedCV where idJob = {idJob} and idCandidate = {idCan}");
            return db.CheckNull(sql);
        }
        public bool CheckFollowStatus(int idCompany, int idCan)
        {
            string sql = string.Format($"select * from FollowedCompany where idCandidate = {idCan} and idCompany = {idCompany}");
            return db.CheckNull(sql);
        }
    }
}
