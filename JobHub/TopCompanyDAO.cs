using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JobHub
{
    internal class TopCompanyDAO
    {
        Function func = new Function();
        public DataTable ReadData()
        {
            string cmd = $@"Select Company.idCompany, Company.companySize, Company.companyName ,CompanyEvaluate.star
                            from Company
                            inner join CompanyEvaluate on CompanyEvaluate.idCompany = Company.idCompany ";
            return func.ReadData(cmd);
        }

        public void WriteData(DataTable dt, Guna2DataGridView dgvCompany)
        {
            int index = 1;
            dt.Columns.Add("Rank", typeof(double));
            dt.Columns["idCompany"].ColumnName = "Mã công ty";
            dt.Columns["companyName"].ColumnName = "Tên công ty";
            dt.Columns["companySize"].ColumnName = "Quy mô";
            dt.Columns["star"].ColumnName = "Đánh giá";
            foreach (DataRow dr in dt.Rows)
            {
                dr["Rank"] = index;
                index++;
            }
            dt.Rows.Add(3, "10-20", "FLC TH", 2, ++index);
            dt.Rows.Add(4, "30-40", "Công ty Cổ phần Dược phẩm Imex", 2, ++index);
            dt.Rows.Add(5, "25-40", "Công ty Cổ phần Transimex", 1.8, ++index);
            dt.Rows.Add(6, "89+", "Công ty Cổ phần Tập đoàn PAN", 1.8, ++index);
            dt.Rows.Add(7, "23-54", "Công ty Cổ phần Bột giặt Lix", 1.6, ++index);
            dt.Rows.Add(8, "12-32", "Công ty Cổ phần Vicostone", 1.5, ++index);



            dgvCompany.DataSource = dt;
        }
    }
}
