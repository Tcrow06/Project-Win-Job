using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace JobHub
{
    public class ApplyWithCV
    {
        ApplyWithCVDAO dao = new ApplyWithCVDAO();
        public ApplyWithCV() { }

        public void LoadForm(Guna2Panel pn1, Label cvOn, Label cvLoad, Account account)
        {
            SqlDataReader dr = dao.GetUcInfoOnCVOn(account.Id);
            if (dr != null)
            {
                MessageBox.Show("khong");
            }
        }

    }
}
