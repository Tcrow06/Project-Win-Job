using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Guna.Charts.Interfaces;
using Guna.Charts.WinForms;

namespace JobHub
{
    public partial class FCharts : Form
    {
        Charts charts = new Charts();
        ChartsDAO ChartsDAO = new ChartsDAO();
        public FCharts()
        {
            InitializeComponent();
        }
        
        private void ReadData(string cmd, Label label)
        {
            DataTable dt = ChartsDAO.ReadData(cmd);
            ChartsDAO.WriteData(dt, label);
        }
        private void LoadData()
        {
            charts.GenerateDataAndLabels(bIT, bEconomy, bTechnical, bOrther);
            string cmd = $@"Select count(*)
                            From Job";
            ReadData(cmd, lblTotalJob);
            string cmd_1 = $@"Select count(*)
                            From Company";
            ReadData(cmd_1, lblTotalCompany);

            string cmd_2 = $@"select jobField, avg(jobMaxSalary) as avg
                              from Job
                              group by jobField";
            DataTable dt = ChartsDAO.ReadData(cmd_2);
            charts.PaintCharts(dt, gunaChart2 );
        }
        private void FCharts_Load(object sender, EventArgs e)
        {
            LoadData();
        }
   
    }
}
