using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JobHub
{
    public  class ListUcJobAndBool
    {
        private List<uC_Job> list;
        private bool check;
        public ListUcJobAndBool()
        {
            this.List = new List<uC_Job>();
            this.check = false;
        }
        public ListUcJobAndBool(List<uC_Job> list, bool check)
        {
            this.List = list;
            this.Check = check;
        }

        public List<uC_Job> List { get => list; set => list = value; }
        public bool Check { get => check; set => check = value; }
    }
}
