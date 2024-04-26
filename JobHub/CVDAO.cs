using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JobHub
{
    internal class CVDAO
    {
        public CVDAO() { }
        private CV myCV;
        Function function = new Function();

        public DataTable ReadData(string cmd)
        {
            return function.ReadData(cmd);
        }

        public void Insert(string cmd )
        {
            function.Insert(cmd);   
        }
        public void WriteData(DataTable dt, FlowLayoutPanel fpn)
        {
             function.WriteData(dt, fpn);
        }

        public string SelectImageButton(string pathRoot, string dir)
        {
            return function.SelectImageButton(pathRoot, dir);
        }

        public void Update(string cmd)
        {
            function.Update(cmd);
        }
        internal CV MyCV { get => myCV; set => myCV = value; }
    }
}
