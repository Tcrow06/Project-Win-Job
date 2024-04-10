using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JobHub
{
    internal class Function
    {
        DBConection conection = new DBConection();
        public void Insert()
        {

        }

        public void Update()
        {
        }

        public void Delete()
        {

        }

        public DataTable ReadData(string cmd)
        {
            return conection.ExcutionReadData(cmd);
        }

        public void WriteData(DataTable dt, FlowLayoutPanel fpn)
        {
             conection.ExcutionWriteData(dt, fpn);
        }
    }
}
