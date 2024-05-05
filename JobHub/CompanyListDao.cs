using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JobHub
{
    public class CompanyListDao
    {
        DBConection db = new DBConection();

        public SqlDataReader LoadFilterUcCompany(string txt)
        {
            string query = $@"SELECT Company.idCompany, Company.companyName, company.companyAvatar, company.companyAddress, company.companySize
                    FROM Company{txt}";
            return db.loadData(query);
        }


    }
}
