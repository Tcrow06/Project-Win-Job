using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JobHub
{
    internal class CustomMessageBox
    {
        public static FCustomerMessageBox FCustomerMessageBox;
        public static void Show(string message)
        {
            FCustomerMessageBox = new FCustomerMessageBox();
            FCustomerMessageBox.lblMessage.Text = message;
            FCustomerMessageBox.Show();
        }
    }
}
