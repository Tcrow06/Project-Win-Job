using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JobHub
{

    public class ApplyWithCVDAO
    {
        DBConection db = new DBConection();
        public SqlDataReader GetUcInfoOnCVOn(int idCandidate)
        {
            string sql = $"select* from CV where CV.idCandidate ={idCandidate}";
            return db.loadData(sql);
        }
    }
}
