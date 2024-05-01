using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JobHub
{
    internal class FindCandidate
    {
        private FindCandidateDAO dao = new FindCandidateDAO();
        public DataTable GetUCCV()
        {
            return dao.GetUCCV();
        }
        public DataTable GetInfoCV(int idCV, int CVType)
        {
            return dao.GetInfoCV(idCV, CVType);
        }
    }
}
