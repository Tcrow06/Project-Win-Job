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
    public partial class FEditCompany : Form
    {
        EditCompany ec = new EditCompany();
        Fmain fm = new Fmain();
        private int ID;
        public FEditCompany(Fmain fm)
        {
            InitializeComponent();
            this.fm = fm;
            ID = fm.Account.Id;
        }

        private void FEditCompany_Load(object sender, EventArgs e)
        {

        }

        private void btnXacNhan_Click(object sender, EventArgs e)
        {
            EditCompany ec = new EditCompany(ID, txtPhone.Text, txtWeb.Text, txtCompanySize.Text, txtDescription.Text);
            try
            {
                ec.AddCompany();
            }
            catch
            {
                MessageBox.Show("Gặp lỗi bất ngờ");
            }
            finally
            {
                MessageBox.Show("Update thông tin thành công", "Thành công");
                

            }
            FCompanyDetails2 fcd2 = new FCompanyDetails2();
            fcd2.LoadCompanyDetail();
        }
    }
}
