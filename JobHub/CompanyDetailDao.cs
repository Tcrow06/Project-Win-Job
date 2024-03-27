using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Common;

namespace JobHub
{
    public class CompanyDetailDao
    {
        //SqlConnection sqlConnection = new SqlConnection(Properties.Settings.Default.conn);
        DBConection dbc = new DBConection();
        public CompanyDetailDao() { }

        public CompanyDetail GetInfoCompanyDetailFromDB(int idCompany)
        {
            CompanyDetail cd = new CompanyDetail();
            string query = $"select * from Company where  Company.idCompany = {idCompany}";

            SqlDataReader dr = dbc.loadData(query);
            if (dr.HasRows)
            {
                dr.Read();
                cd.Name = dr["companyName"].ToString();
                cd.Avatar = dr["companyAvatar"].ToString() ;
                cd.Address = dr["companyAddress"].ToString();
                cd.Phone = dr["companyPhone"].ToString();
                cd.Description = dr["companyDescription"].ToString();
                cd.Email = dr["companyEmail"].ToString();
                cd.Link = dr["companyLink"].ToString();
                cd.Size = dr["companySize"].ToString();
                
            }
            return cd;
        
        }
    }
}
