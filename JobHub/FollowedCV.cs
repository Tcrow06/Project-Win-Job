using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JobHub
{
    internal class FollowedCV
    {
        private FollowedCVDAO dao = new FollowedCVDAO();
        public FollowedCV() { }
        public DataTable LoadFollowedCV(int idCompany)
        {
            return dao.LoadFollowedCV(idCompany);
        }
        public DataTable GetInfoCV(int idCV, int CVType)
        {
            return dao.GetInfoCV(idCV,CVType);
        }
    }
}
