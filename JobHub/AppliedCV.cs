using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JobHub
{
    internal class AppliedCV
    {
        private AppliedCVDAO dao = new AppliedCVDAO();  
        public AppliedCV() { }
        public SqlDataReader LoadAppliedCV(int idCandidate)
        {
            return dao.LoadAppliedCV(idCandidate);   
        }
    }
}
