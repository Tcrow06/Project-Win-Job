using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JobHub
{
    public class ShowImage
    {
        ShowImageDao dao = new ShowImageDao();
        public string GetNameImage(int idCV)
        {
            SqlDataReader dr = dao.getNameImage(idCV);
            if (dr.Read())
            {
                return dr["CVName"].ToString();

            }
            return null;
        }
    }
}
