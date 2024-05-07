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
        private GunaSplineAreaDataset gunaPieDataset;
        private GunaAreaDataset gunaAreaDataset;
        private GunaHorizontalBarDataset gunaHorizontalBarDataset;
        private GunaLineDataset gunaLineDataset;
        private GunaBarDataset gunaBarDataset;
        public void InitializeGunaChart(GunaChart gunaChart, string s)
        {
            if(s == "Tron")
            {
                gunaPieDataset = new GunaSplineAreaDataset();
                gunaPieDataset.YFormat = "Total {0:P}";
                gunaPieDataset.Label = "FPT";
                gunaPieDataset.LegendBoxFillColor = Color.FromArgb(45, 151, 255);
                gunaChart.Datasets.Add(gunaPieDataset);
            }
            else if(s == "Duong")
            {
                gunaAreaDataset = new GunaAreaDataset();
                gunaAreaDataset.Label = "NextTech";
                gunaAreaDataset.LegendBoxFillColor = Color.FromArgb(221, 238, 254);
                gunaAreaDataset.YFormat = "Total {0:P}";
                gunaChart.Datasets.Add(gunaAreaDataset);
            }
            else if(s == "Cot")
            {
                gunaHorizontalBarDataset = new GunaHorizontalBarDataset();
                gunaHorizontalBarDataset.Label = "VinGroup";
                gunaHorizontalBarDataset.LegendBoxFillColor = Color.MediumSlateBlue;
                gunaHorizontalBarDataset.YFormat = "Total {0:P}";
                gunaChart.Datasets.Add(gunaHorizontalBarDataset);
            }
            else if(s == "Line")
            {
                gunaLineDataset = new GunaLineDataset();
                gunaLineDataset.Label = "Lương Theo Kinh Nghiệm";
                gunaLineDataset.LegendBoxFillColor = Color.DodgerBlue;
                gunaLineDataset.FillColor = Color.DodgerBlue;
                gunaLineDataset.BorderColor = Color.DodgerBlue;
                gunaLineDataset.YFormat = "Income {0:C}";
                gunaChart.Datasets.Add(gunaLineDataset);
            }
        }



        public void Insert()
        {
            string[] kn = { "1", "2", "3", "5", "10" };
            int[] Salary = { 10, 12, 15, 20, 50 };
            var random = new Random();
            for(int i = 0; i < kn.Length; ++i)
            {
                gunaLineDataset.DataPoints.Add(new LPoint()
                {
                    Label = kn[i],
                    Y = Salary[i], 
                });        
            }
        }
    
        public void GenerateDataAndLabels()
        {
            string[] monthLabels = { "Anuary", "March", "May", "July", "August"};

            var random = new Random();
            foreach (var label in monthLabels)
            {
                gunaPieDataset.DataPoints.Add(new LPoint()
                {
                    Label = label,
                    Y = random.Next(10, 100),
                });

                gunaAreaDataset.DataPoints.Add(new LPoint()
                {
                    Label = label,
                    Y = random.Next(10, 100),
                });
                gunaHorizontalBarDataset.DataPoints.Add(new LPoint()
                {
                    Label = label,
                    Y = random.Next(10, 100),
                });
            }
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

        public void InitializeGunaChart(GunaChart gunaChart)
        {
            gunaLineDataset = new GunaLineDataset();
            gunaLineDataset.Label = "CV";
            gunaLineDataset.LegendBoxFillColor = Color.DodgerBlue;
            gunaLineDataset.FillColor = Color.DodgerBlue;
            gunaLineDataset.BorderColor = Color.DodgerBlue;
            gunaLineDataset.YFormat = "Income {0:C}";

            gunaBarDataset = new GunaBarDataset();
            gunaBarDataset.Label = "Month";
            gunaBarDataset.LegendBoxFillColor = Color.MediumSlateBlue;
            gunaBarDataset.FillColors.Add(Color.MediumSlateBlue);
            gunaBarDataset.FillColors.Add(Color.MediumPurple);
            gunaBarDataset.YFormat = "C";

            gunaChart.Datasets.Add(gunaLineDataset);
            gunaChart.Datasets.Add(gunaBarDataset);

            GenerateDataAndLabels_1();
        }

        public void InitializeGunaChart(GunaChart gunaChart,string a, string b)
        {
            gunaLineDataset = new GunaLineDataset();
            gunaLineDataset.Label = a;
            gunaLineDataset.LegendBoxFillColor = Color.DodgerBlue;
            gunaLineDataset.FillColor = Color.DodgerBlue;
            gunaLineDataset.BorderColor = Color.DodgerBlue;
            gunaLineDataset.YFormat = "Income {0:C}";

            gunaBarDataset = new GunaBarDataset();
            gunaBarDataset.Label = b;
            gunaBarDataset.LegendBoxFillColor = Color.MediumSlateBlue;
            gunaBarDataset.FillColors.Add(Color.MediumSlateBlue);
            gunaBarDataset.FillColors.Add(Color.MediumPurple);
            gunaBarDataset.YFormat = "C";

            gunaChart.Datasets.Add(gunaLineDataset);
            gunaChart.Datasets.Add(gunaBarDataset);

            GenerateDataAndLabels_1();
        }

        public void GenerateDataAndLabels_1()
        {
            string[] monthLabels = { "January", "February", "June", "July" };
            var random = new Random();
            foreach (var label in monthLabels)
            {
                gunaLineDataset.DataPoints.Add(new LPoint()
                {
                    Label = label,
                    Y = random.Next(10, 100),
                });

                gunaBarDataset.DataPoints.Add(new LPoint()
                {
                    Label = label,
                    Y = random.Next(10, 100),
                });
            }
        }
    }
}
