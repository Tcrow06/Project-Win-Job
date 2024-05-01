using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace JobHub
{
    internal class FollowedCVDAO
    {
        DBConection db = new DBConection();
        public FollowedCVDAO() { }  
        public DataTable LoadFollowedCV(int idCompany)
        {
            string sql = $"select * from FollowedCV where idCompany = {idCompany}";
            return db.ExcutionReadData(sql);
        }
        public DataTable GetInfoCV(int idCV, int CVType)
        {
            string sql = $@"SELECT Candidate.idCandidate,Candidate.candidateFirstName, Candidate.candidateLastName, Candidate.candidateAvatar, cv.idCV ,";
           
                           
            if(CVType == 0)
            {
                sql += $@" cv.jobName, cv.CVAvatar
                            FROM Candidate
                            INNER JOIN CV as cv";
            }
            else
            {
                sql += $@" cv.image, cv.CVName 
                        from Candidate 
                        join ImageCV as cv ";
            }
            sql += $" ON cv.idCandidate = Candidate.idCandidate where cv.IdCV = {idCV}";
            return db.ExcutionReadData(sql);
        }
    }
}
