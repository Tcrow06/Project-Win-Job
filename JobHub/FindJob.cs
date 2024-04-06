using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JobHub
{
    public class FindJob
    {
        private FindJobDao findJobDao = new FindJobDao();
        ChangTheSize changTheSize = new ChangTheSize();
        JobDetail jobDetail = new JobDetail();
        public FindJob() { }

        public void LoadUc_Job(FlowLayoutPanel flPanel, Fmain fm)
        {
            List<ListUcJobAndBool> ls = new List<ListUcJobAndBool>();
            ls.Add(new ListUcJobAndBool());
            SqlDataReader dr = findJobDao.LoadUc_Job();
            LoadUCIntoList(dr, flPanel, fm, ls, 0);
            LoadUc(ls, fm, flPanel);
        }
        public void LoadButton(FlowLayoutPanel flPanel, Fmain fm, string txtButton, List<ListUcJobAndBool> list, int index)
        {
            SqlDataReader dr = findJobDao.LoadButton(txtButton);
            LoadUCIntoList(dr, flPanel, fm, list, index);
            LoadUc(list, fm, flPanel);
        }
        public void LoadTxtSearch(FlowLayoutPanel flPanel, Fmain fm, string txtSearch, List<ListUcJobAndBool> list, int index)
        {
            SqlDataReader dr = findJobDao.LoadTxtSearch(txtSearch);
            LoadUCIntoList(dr, flPanel, fm, list, index);
            LoadUc(list, fm, flPanel);

        }
        public void LoadTxtExperience(FlowLayoutPanel flPanel, Fmain fm, string txtEx, List<ListUcJobAndBool> list, int index)
        {
            SqlDataReader dr = findJobDao.LoadTxtExperience(txtEx);
            LoadUCIntoList(dr, flPanel, fm, list, index);
            LoadUc(list, fm, flPanel);
        }
        public void LoadTxtAddress(FlowLayoutPanel flPanel, Fmain fm, string txtAddress, List<ListUcJobAndBool> list, int index)
        {
            SqlDataReader dr = findJobDao.LoadTxtAddress(txtAddress);
            LoadUCIntoList(dr, flPanel, fm, list, index);
            LoadUc(list, fm, flPanel);
        }
        public void LoadTxtIndustry(FlowLayoutPanel flPanel, Fmain fm, string txtIndustry, List<ListUcJobAndBool> list, int index)
        {
            SqlDataReader dr = findJobDao.LoadTxtIndustry(txtIndustry);
            LoadUCIntoList(dr, flPanel, fm, list, index);
            LoadUc(list, fm, flPanel);
        }
        public void LoadTxtSalary(FlowLayoutPanel flPanel, Fmain fm, string txtSalary, List<ListUcJobAndBool> list, int index)
        {
            SqlDataReader dr = findJobDao.LoadTxtSalary(txtSalary);
            LoadUCIntoList(dr, flPanel, fm, list, index);
            LoadUc(list, fm, flPanel);
        }
        private void LoadUCIntoList(SqlDataReader dr, FlowLayoutPanel flPanel, Fmain fm, List<ListUcJobAndBool> list, int index)
        {
            list[index].List.Clear();
            flPanel.Controls.Clear();
            if (dr != null)
            {
                while (dr.Read())
                {
                    uC_Job job = jobDetail.InsertInfoAndEventIntoUcJob(dr, fm);
                    changTheSize.setSize(130, 25, job.lblJobName);
                    list[index].List.Add(job);
                }
                dr.Dispose();
            }
        }
        private ListUcJobAndBool UnionAndInter(List<ListUcJobAndBool> list)
        {
            bool check = true;
            ListUcJobAndBool lst1 = new ListUcJobAndBool();
            for (int i = 0; i <= Math.Min(3, list.Count - 1); i++)
            {
                if (list[i].Check == true)
                {
                    check = false;

                }
                if (list[i].List.Count > 0)
                {
                    lst1.List.AddRange(list[i].List);
                }

            }

            ListUcJobAndBool lst2 = new ListUcJobAndBool();
            ListUcJobAndBool lst3 = new ListUcJobAndBool();
            if (lst1.List.Count > 0)
                lst2 = lst1;
            bool check1 = true;
            for (int i = Math.Min(4, list.Count - 1); i <= Math.Min(7, list.Count - 1); i++)
            {
                if (i < 4) break;
                if (list[i].Check == true)
                {
                    if (lst2.List.Count == 0 && check1 && check)
                    {
                        check1 = false;
                        if (list[i].List.Count > 0)
                        {

                            lst2 = list[i];
                        }

                    }
                    var comparer = new UcJobComparer();
                    foreach (uC_Job job in lst2.List)
                        if (list[i].List.Contains(job, comparer))
                            lst3.List.Add(job);
                    lst2 = lst3;
                    lst3 = new ListUcJobAndBool();
                }
            }

            return lst2;
        }
        public void LoadUc(List<ListUcJobAndBool> list, Fmain fm, FlowLayoutPanel flPanel)
        {


            ListUcJobAndBool uc = UnionAndInter(list);
            flPanel.Controls.Clear();
            foreach (var job in uc.List)
            {
                flPanel.Controls.Add(job);
            }
        }
    }
}
