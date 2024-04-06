using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JobHub
{
    public class uc_JobComparer : IEqualityComparer<uC_Job>
    {
        public bool Equals(uC_Job x , uC_Job y)
        {
            return x.IdJob == y.IdJob;
        }

        public int GetHashCode(uC_Job obj)
        {
            return obj.IdJob.GetHashCode();
        }
    }
}
