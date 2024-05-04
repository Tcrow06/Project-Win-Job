using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Markup;

namespace JobHub
{
    internal class FeedBack
    {
        private int idCandidate;
        private int idJob;
        private string des;
        private int start;
        private string image;
        public FeedBack(int idCandidate, int idJob, string des, int start, string image)
        {
            this.idCandidate = idCandidate;
            this.idJob = idJob;
            this.des = des;
            this.start = start;
            this.Image = image;
        }


        public FeedBack(int idCandidate, int idJob, string des, int start)
        {
            this.idCandidate = idCandidate;
            this.idJob = idJob;
            this.des = des;
            this.start = start;
        }
        public FeedBack(int idCandidate, int idJob, int start, string image)
        {
            this.idCandidate = idCandidate;
            this.idJob = idJob;
            this.start = start;
            this.Image = image;
        }
        public int IdCandidate { get => idCandidate; set => idCandidate = value; }
        public int IdJob { get => idJob; set => idJob = value; }
        public string Des { get => des; set => des = value; }
        public int Start { get => start; set => start = value; }
        public string Image { get => image; set => image = value; }
    }
}
