using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JobHub
{
    public class ShowImageDao
    {
        DBConection db = new DBConection();
        public SqlDataReader getNameImage(int idCV)
        {
            string sql = $"select * from ImageCV where idCV = {idCV}";
            return db.loadData(sql);
        }
    }
}
