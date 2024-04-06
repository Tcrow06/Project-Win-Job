using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ToolTip;

namespace JobHub
{
    public partial class NhapFCustomerMessageBox : Form
    {
        public NhapFCustomerMessageBox()
        {
            InitializeComponent();
        }
        private void SetFormSize()
        {
            int widht = this.lblMessage.Width + this.pictureBoxIcon.Width + this.pnBody.Padding.Left;
            int height = this.pnNav.Height + this.lblMessage.Height + this.pnButton.Height + this.pnBody.Padding.Top;
            this.Size = new Size(widht, height);
        }
        public NhapFCustomerMessageBox(string text)
        {
            InitializeComponent();
            InitializeItems();
            //this.PrimaryColor = primaryColor;
            this.lblMessage.Text = text;
            this.lblCaption.Text = "";
            SetFormSize();
            SetButtons(MessageBoxButtons.OK, MessageBoxDefaultButton.Button1);//Set Default Buttons
        }
        public NhapFCustomerMessageBox(string text, string caption)
        {
            InitializeComponent();
            InitializeItems();
            //this.PrimaryColor = primaryColor;
            this.lblMessage.Text = text;
            this.lblCaption.Text = caption;
            SetFormSize();
            SetButtons(MessageBoxButtons.OK, MessageBoxDefaultButton.Button1);//Set Default Buttons
        }
        public NhapFCustomerMessageBox(string text, string caption, MessageBoxButtons buttons)
        {
            InitializeComponent();
            InitializeItems();
            //this.PrimaryColor = primaryColor;
            this.lblMessage.Text = text;
            this.lblCaption.Text = caption;
            SetFormSize();
            SetButtons(buttons, MessageBoxDefaultButton.Button1);//Set [Default Button 1]
        }
        public NhapFCustomerMessageBox(string text, string caption, MessageBoxButtons buttons, MessageBoxIcon icon)
        {
            InitializeComponent();
            InitializeItems();
            //this.PrimaryColor = primaryColor;
            this.lblMessage.Text = text;
            this.lblCaption.Text = caption;
            SetFormSize();
            SetButtons(buttons, MessageBoxDefaultButton.Button1);//Set [Default Button 1]
            SetIcon(icon);
        }
        public NhapFCustomerMessageBox(string text, string caption, MessageBoxButtons buttons, MessageBoxIcon icon, MessageBoxDefaultButton defaultButton)
        {
            InitializeComponent();
            InitializeItems();
            //this.PrimaryColor = primaryColor;
            this.lblMessage.Text = text;
            this.lblCaption.Text = caption;
            SetFormSize();
            SetButtons(buttons, defaultButton);
            SetIcon(icon);
        }

        //-> Private Methods
        private void InitializeItems()
        {
            this.FormBorderStyle = FormBorderStyle.None;
           // this.Padding = new Padding(borderSize);//Set border size
            this.lblMessage.MaximumSize = new Size(420, 100);
            //this.btnClose = new CTClose();
            this.btnYes.DialogResult = DialogResult.OK;
            this.btnYes.Visible = false;
            this.btnNo.Visible = false;
            this.btnNo.Visible = false;
        }
        private void guna2Button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void SetIcon(MessageBoxIcon icon)
        {
            switch (icon)
            {
                case MessageBoxIcon.Error: //Error
                    this.pictureBoxIcon.Image = Properties.Resources.error;
                    //PrimaryColor = Color.FromArgb(224, 79, 95);
                    //this.btnClose.FlatAppearance.MouseOverBackColor = Color.Crimson;
                    break;
                case MessageBoxIcon.Information: //Information
                    this.pictureBoxIcon.Image = Properties.Resources.message;
                    //PrimaryColor = Color.FromArgb(38, 191, 166);
                    break;
                case MessageBoxIcon.Question://Question
                    this.pictureBoxIcon.Image = Properties.Resources.question;
                    //PrimaryColor = Color.FromArgb(10, 119, 232);
                    break;
                case MessageBoxIcon.Exclamation://Exclamation
                    this.pictureBoxIcon.Image = Properties.Resources.warning;
                    //PrimaryColor = Color.FromArgb(255, 140, 0);
                    break;
            }
        }
        private void SetButtons(MessageBoxButtons buttons, MessageBoxDefaultButton defaultButton)
        {
            int xCenter = (this.pnButton.Width - btnYes.Width) / 2;
            int yCenter = (this.pnButton.Height - btnYes.Height) / 2;

            switch (buttons)
            {
                case MessageBoxButtons.OK:
                    //OK Button
                    btnYes.Visible = true;
                    btnYes.Location = new Point(xCenter, yCenter);
                    btnYes.Text = "OK";
                    btnYes.DialogResult = DialogResult.OK;//Set DialogResult
                    this.AcceptButton = btnYes;
                    //Set Default Button
                    break;
            }
            /*
                case MessageBoxButtons.OKCancel:
                    //OK Button
                    btnYes.Visible = true;
                    btnYes.Location = new Point(xCenter - (btnYes.Width / 2) - 5, yCenter);
                    btnYes.Text = "OK";
                    btnYes.DialogResult = DialogResult.OK;//Set DialogResult

                    //Cancel Button
                    btnNo.Visible = true;
                    btnNo.Location = new Point(xCenter + (btnNo.Width / 2) + 5, yCenter);
                    btnNo.Text = "Hủy";
                    btnNo.DialogResult = DialogResult.Cancel;//Set DialogResult
                    btnNo.BackColor = Color.Goldenrod;
                    break;

                case MessageBoxButtons.RetryCancel:
                    //Retry Button
                    btnYes.Visible = true;
                    btnYes.Location = new Point(xCenter - (btnYes.Width / 2) - 5, yCenter);
                    btnYes.Text = "Thử lại";
                    btnYes.DialogResult = DialogResult.Retry;//Set DialogResult

                    //Cancel Button
                    btnNo.Visible = true;
                    btnNo.Location = new Point(xCenter + (btnNo.Width / 2) + 5, yCenter);
                    btnNo.Text = "Hủy";
                    btnNo.DialogResult = DialogResult.Cancel;//Set DialogResult
                    btnNo.BackColor = Color.Goldenrod;

                    //Set Default Button
                    if (defaultButton != MessageBoxDefaultButton.Button3)//There are only 2 buttons, so the Default Button cannot be Button3
                        SetDefaultButton(defaultButton);
                    else SetDefaultButton(MessageBoxDefaultButton.Button1);
                    break;

                case MessageBoxButtons.YesNo:
                    //Yes Button
                    btnYes.Visible = true;
                    btnYes.Location = new Point(xCenter - (btnYes.Width / 2) - 5, yCenter);
                    btnYes.Text = "Có";
                    btnYes.DialogResult = DialogResult.Yes;//Set DialogResult
                    this.AcceptButton = button1;
                    //No Button
                    btnNo.Visible = true;
                    btnNo.Location = new Point(xCenter + (btnNo.Width / 2) + 5, yCenter);
                    btnNo.Text = "Không";
                    btnNo.DialogResult = DialogResult.No;//Set DialogResult
                    btnNo.BackColor = Color.FromArgb(252, 87, 83);

                    //Set Default Button
                    if (defaultButton != MessageBoxDefaultButton.Button3)//There are only 2 buttons, so the Default Button cannot be Button3
                        SetDefaultButton(defaultButton);
                    else SetDefaultButton(MessageBoxDefaultButton.Button1);
                    break;
                case MessageBoxButtons.YesNoCancel:
                    //Yes Button
                    btnYes.Visible = true;
                    button1.Location = new Point(xCenter - button1.Width - 5, yCenter);
                    btnYes.Text = "Có";
                    button1.DialogResult = DialogResult.Yes;//Set DialogResult
                    this.AcceptButton = button1;
                    //No Button
                    button2.Visible = true;
                    button2.Location = new Point(xCenter, yCenter);
                    button2.Text = "Không";
                    button2.DialogResult = DialogResult.No;//Set DialogResult
                    button2.BackColor = Color.FromArgb(252, 87, 83);

                    //Cancel Button
                    button3.Visible = true;
                    button3.Location = new Point(xCenter + button2.Width + 5, yCenter);
                    button3.Text = "Hủy";
                    button3.DialogResult = DialogResult.Cancel;//Set DialogResult
                    button3.BackColor = Color.Goldenrod;

                    //Set Default Button
                    SetDefaultButton(defaultButton);
                    break;

                case MessageBoxButtons.AbortRetryIgnore:
                    //Abort Button
                    button1.Visible = true;
                    button1.Location = new Point(xCenter - button1.Width - 5, yCenter);
                    button1.Text = "Hủy bỏ";
                    button1.DialogResult = DialogResult.Abort;//Set DialogResult
                    button1.BackColor = Color.Goldenrod;

                    //Retry Button
                    button2.Visible = true;
                    button2.Location = new Point(xCenter, yCenter);
                    button2.Text = "Thử lại";
                    button2.DialogResult = DialogResult.Retry;//Set DialogResult                    

                    //Ignore Button
                    button3.Visible = true;
                    button3.Location = new Point(xCenter + button2.Width + 5, yCenter);
                    button3.Text = "Bỏ qua";
                    button3.DialogResult = DialogResult.Ignore;//Set DialogResult
                    button3.BackColor = Color.FromArgb(252, 87, 83);

                    //Set Default Button
                    SetDefaultButton(defaultButton);
                    break;
            }*/
        }
    }
}
