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
    }
}
