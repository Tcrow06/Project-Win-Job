using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Common;
using System.Security.Cryptography;
using System.Windows.Forms;
using System.IO;
using System.Drawing;

namespace JobHub
{
    public class CompanyDetailDAO
    {
        DBConection dbc = new DBConection();
        CandidateDAO cd = new CandidateDAO();
        public CompanyDetailDAO() { }

        public SqlDataReader GetInfoCompanyDetailFromDB(int idCompany)
        {
            string query = $"select * from Company where  Company.idCompany = {idCompany}";
            return dbc.loadData(query);
        
        }
        public SqlDataReader LoadAllCompanyJobInformation(int idCompany)
        {
            string query = $"select * from Job inner join Company on Company.idCompany = Job.idCompany where job.idCompany = {idCompany}";
            return dbc.loadData(query);
        }
        public SqlDataReader LoadUc_JobEvaluate(int idCompany)
        {
            string sql = $@"select* from CompanyEvaluate join Candidate on Candidate.idCandidate = CompanyEvaluate.idCandidate
                            where idCompany = {idCompany}";
            return dbc.loadData(sql);
        }
        public SqlDataReader LoadInfoEvaluate(int idCompany)
        {
            string sql = $@"SELECT idCompany,
                            COUNT(CASE WHEN star = 1 THEN 1 END) AS s1,
                            COUNT(CASE WHEN star = 2 THEN 1 END) AS s2,
                            COUNT(CASE WHEN star = 3 THEN 1 END) AS s3,
                            COUNT(CASE WHEN star = 4 THEN 1 END) AS s4,
                            COUNT(CASE WHEN star = 5 THEN 1 END) AS s5
                        FROM 
                            CompanyEvaluate 
                        WHERE 
                            idCompany = {idCompany} 
                        GROUP BY 
                            idCompany;";
            return dbc.loadData(sql);
        }
        public DataTable CheckEvaluated(int idCandidate)
        {
            string sql = $"select* from CompanyEvaluate where idCandidate ={idCandidate}";
            return dbc.ExcutionReadData(sql);
        }
    }
}
