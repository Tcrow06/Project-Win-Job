using Guna.UI2.WinForms;
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
    public partial class FUserInfo : Form
    {
        public FUserInfo()
        {
            InitializeComponent();
        }

        private void clickTextbox(Label label, Guna2TextBox textBox)
        {
            label.Visible = true;
            textBox.PlaceholderText = "";
            guna2Transition1.ShowSync(label);
        }

        private void leaveMouse(Label label, Guna2TextBox textBox, string palceholderText)
        {
            if(textBox.Text.Trim() == "")
            {
                label.Visible = false;
                textBox.PlaceholderText = palceholderText;
            }
        }

        private void txtName_Click(object sender, EventArgs e)
        {
            clickTextbox(lblNavName, txtFirstName);
        }

        private void txtName_MouseLeave(object sender, EventArgs e)
        {
            leaveMouse(lblNavName, txtFirstName, "Nhập họ tên");
        }

        private void txtPhoneNumber_Click(object sender, EventArgs e)
        {
            clickTextbox(lblSubPhoneNumber, txtPhoneNumber);
        }

        private void txtPhoneNumber_MouseLeave(object sender, EventArgs e)
        {
            leaveMouse(lblSubPhoneNumber, txtPhoneNumber, "Nhập số điện thoại");
        }

        private void txtEmail_Click(object sender, EventArgs e)
        {
            clickTextbox(lblSubEmail, txtEmail);
        }

        private void txtEmail_MouseLeave(object sender, EventArgs e)
        {
            leaveMouse(lblSubEmail, txtEmail, "Nhập email");
        }

        private void lblLink_Click(object sender, EventArgs e)
        {
            clickTextbox(lblSubLink, txtLink);
        }

        private void txtLink_MouseLeave(object sender, EventArgs e)
        {
            leaveMouse(lblSubLink, txtLink, "Nhập link");
        }

        private void txtAddress_Click(object sender, EventArgs e)
        {
            clickTextbox(lblSubAdd, txtAddress);
        }

        private void txtAddress_MouseLeave(object sender, EventArgs e)
        {
            leaveMouse(lblSubAdd, txtAddress, "Nhập địa chỉ");
        }
    }
}
