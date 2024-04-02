using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JobHub
{
    public class CustomMessageBox
    {
        public FCustomerMessageBox FCustomerMessageBox;
        public CustomMessageBox() { }
        public void Show(string message)
        {
            FCustomerMessageBox = new FCustomerMessageBox();
            FCustomerMessageBox.lblMessage.Text = message;
            FCustomerMessageBox.Show();
        }
        public void ShowDialog(string message)
        {
            FCustomerMessageBox = new FCustomerMessageBox();
            FCustomerMessageBox.lblMessage.Text = message;
            FCustomerMessageBox.ShowDialog();
        }
    }
}
