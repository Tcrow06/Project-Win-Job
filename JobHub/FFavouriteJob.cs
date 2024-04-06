using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JobHub
{
    public partial class FFavouriteJob : Form
    {
        private FavoriteJob favoriteJob = new FavoriteJob();
        private Fmain fm;
        public FFavouriteJob()
        {
            InitializeComponent();
        }
        public FFavouriteJob(Fmain fm)
        {
            this.fm = fm;
            InitializeComponent();
        }
        public void LoadUcDetail()
        {
            favoriteJob.LoadUc_JobDetail(flpUC_JobDetail, fm, lblNumberOfSavedJob, this);
        }


        private void FFavoriteJob_Load(object sender, EventArgs e)
        {
            LoadUcDetail();
        }
    }
}
