using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace JobHub
{
    internal class CV
    {
        private List<DetailCV> myCV = new List<DetailCV>();
        public CV(int id, string jobName, string nameUser, string aboutMe)
        {
            DetailCV detailCV = new DetailCV(id, jobName, nameUser, aboutMe);
            MyCV.Add(detailCV);
        }
        public List<DetailCV> MyCV { get => myCV; set => myCV = value; }
    }
}
