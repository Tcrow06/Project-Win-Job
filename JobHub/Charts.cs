using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using Guna.Charts.WinForms;
using Guna.Charts.Interfaces;
using static Guna.UI2.WinForms.Suite.Descriptions;
using System.Windows.Forms;
using System.Data;
using System.Windows.Controls;
using System.Threading;


namespace JobHub
{
    internal class Charts
    {
        public Charts()
        {
        }

        public void GenerateDataAndLabels(GunaBarDataset bIT, GunaBarDataset bEconomy, GunaBarDataset bTechnical, GunaBarDataset bOrther)
        {

            Function function = new Function();
            string cmd = $@"select jobField, count(*) as soLuong
                            From Job
                            Group by jobField";
            DataTable dt = function.ReadData(cmd);
            int id = 0;
            int kt = 0;
            int kth = 0;
            int cl = 0;
            foreach (DataRow dr in dt.Rows)
            {
                if (dr["jobField"].ToString().Trim() == "Công nghệ")
                {
                    id = int.Parse(dr["soLuong"].ToString());
                }
                else if (dr["jobField"].ToString().Trim() == "Kinh tế")
                {
                    kt = int.Parse(dr["soLuong"].ToString().Trim());
                }
                else if (dr["jobField"].ToString().Trim() == "Sản xuất và chế biến")
                {
                    kth = int.Parse(dr["soLuong"].ToString().Trim());
                }
                else
                {
                    cl = cl + int.Parse(dr["soLuong"].ToString().Trim());
                }
            }
            var random = new Random();
            bIT.DataPoints.Add(new LPoint()
            {
                Label = "",
                Y = id,
            });
            bEconomy.DataPoints.Add(new LPoint()
            {
                Label = "",
                Y = kt,
            });
            bTechnical.DataPoints.Add(new LPoint()
            {
                Label = "",
                Y = kth,
            });
            bOrther.DataPoints.Add(new LPoint()
            {
                Label = "",
                Y = cl,
            });
        }

        public void PaintCharts(DataTable dt, GunaChart guna)
        {
            foreach(DataRow dr in dt.Rows)
            {
                Random random = new Random();
                int red = random.Next(200, 256);
                int green = random.Next(200, 256);
                int blue = random.Next(200, 256);
                 
                System.Drawing.Color randomColor = System.Drawing.Color.FromArgb(red, green, blue);

                GunaBarDataset gunaBarDataset = new GunaBarDataset();
                gunaBarDataset.Label = dr["jobField"].ToString().Trim();
                gunaBarDataset.LegendBoxFillColor = randomColor;
                gunaBarDataset.FillColors.Add(randomColor);
                gunaBarDataset.FillColors.Add(randomColor);

                guna.Datasets.Add(gunaBarDataset);
                gunaBarDataset.DataPoints.Add(new LPoint()
                {
                    Label ="",
                    Y = double.Parse(dr["avg"].ToString().Trim()),
                });
                Thread.Sleep(100);
            } 
        }
    }
}
