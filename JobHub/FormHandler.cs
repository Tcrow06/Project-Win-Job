using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JobHub
{
    internal class FormHandler
    {
        DBConection db = new DBConection();
        public FormHandler() { }
        public void OpenNewForm(int idCadidate, int idCV)
        {
            FCVDetail fCVDetail = new FCVDetail(idCadidate, idCV);
            fCVDetail.ShowDialog();
        }
        public void OpenImage(int idCadidate, int idCV)
        {
            string sql = $"select * from ImageCV where idCV = {idCV}";
            SqlDataReader dr = db.loadData(sql);
            string nameImage = "";
            if (dr.Read())
            {
                nameImage=  dr["image"].ToString();

            }
            FShowImage fShowImage = new FShowImage(nameImage);
            fShowImage.ShowDialog();
        }

        public void setSizeForm(int width, int height, Form form) 
        {
            form.Width = width;
            form.Height = height;
        }

    }
}
