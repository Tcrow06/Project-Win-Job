using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JobHub
{
    public class UcJobComparer : IEqualityComparer<uC_Job>
    {
        public bool Equals(uC_Job x, uC_Job y)
        {
            // Xác định xem hai đối tượng có bằng nhau hay không dựa trên điều kiện của bạn
            // Giả sử có một trường trong uC_Job là JobId, bạn muốn so sánh theo trường này
            return x.IdJob == y.IdJob; // Thay JobId bằng trường tương ứng trong uC_Job của bạn
        }

        public int GetHashCode(uC_Job obj)
        {
            // Bạn cần triển khai phương thức này, nhưng nó không cần thiết trong trường hợp này
            return obj.GetHashCode();
        }
    }
}
