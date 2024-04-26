using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JobHub
{
    internal class BestApplyDAO
    {
        Function func = new Function();
        public DataTable ReadData(string cmd)
        {
            return func.ReadData(cmd);
        }

        public void LoadData(DataTable dt, FlowLayoutPanel Job, FlowLayoutPanel contain)
        {
            func.LoadJob(dt, Job, contain);
        }
    }
}
