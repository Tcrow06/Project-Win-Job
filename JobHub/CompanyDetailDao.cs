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
                cd.Name = dr["nameCompany"].ToString();
                cd.Address = dr["addressCompany"].ToString();
                cd.Size = int.Parse(dr["size"].ToString());
            }
            return cd;
        
        }
    }
}
