using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JobHub
{
    internal class FindCandidateDAO
    {
        DBConection db = new DBConection();
        public DataTable GetUCCV()
        {
            string sql = $@"select * from CVReady 
                            where not exists (
                                select * from FollowedCV 
                                where CVReady.idCV = FollowedCV.idCV and CVReady.CVType = FollowedCV.CVType and idCompany = 2
                                               )";
            return db.ExcutionReadData(sql);
        }
        public DataTable GetInfoCV(int idCV, int CVType)
        {
            string sql = $@"SELECT Candidate.idCandidate,Candidate.candidateFirstName, Candidate.candidateLastName, Candidate.candidateAvatar, cv.idCV ,";


            if (CVType == 0)
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
