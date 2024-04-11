using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JobHub
{
    internal class Function
    {
        DBConection conection = new DBConection();
        public void Insert()
        {

        }

        public void Update(string cmd)
        {
            conection.ExcutionUpdateDate(cmd);
        }

        public void Delete()
        {

        }

        public DataTable ReadData(string cmd)
        {
            return conection.ExcutionReadData(cmd);
        }

        public void WriteData(DataTable dt, FlowLayoutPanel fpn)
        {
             conection.ExcutionWriteData(dt, fpn);
        }

        public void ShowData(Guna2TextBox txtAddress, Guna2TextBox txtEducation, Guna2TextBox txtEmail, Guna2TextBox txtFirstName, Guna2TextBox txtLastName, Guna2TextBox txtLink, Guna2TextBox txtNameJob, Guna2TextBox txtPhoneNumber, Guna2TextBox txtSkill, DataTable dt, FlowLayoutPanel fpn, Guna2CustomRadioButton boy, Guna2CustomRadioButton girl, Guna2DateTimePicker yob)
        {
            //conection.ShowData(txtAddress, txtEducation, txtEmail, txtFirstName, txtLastName, txtLink, txtNameJob, txtPhoneNumber, txtSkill, dt, fpnContain, boy, girl, yob);
            foreach (DataRow row in dt.Rows)
            {
                txtAddress.Text = row["candidateAddress"].ToString();
                txtPhoneNumber.Text = row["candidatePhone"].ToString();
                txtEmail.Text = row["candidateEmail"].ToString();
                txtFirstName.Text = row["candidateFirstName"].ToString();
                txtLastName.Text = row["candidateLastName"].ToString();
                txtLink.Text = row["CVAvatar"].ToString();
                txtNameJob.Text = row["jobName"].ToString();
                txtSkill.Text = row["Skill"].ToString();
                txtAddress.Text = row["candidateAddress"].ToString();
                yob.Value = DateTime.Parse(row["candidateBirth"].ToString());
                if (bool.Parse(row["candidateGender"].ToString()))
                {
                    boy.Checked = true;
                    girl.Checked = false;
                }
                else
                {
                    boy.Checked = false;
                    girl.Checked = true;
                }

                string s = row["CVDescription"].ToString().Trim();
                string[] array = s.Split('+');
                ControlManager controlManager = new ControlManager();
                Stack<uC_LoadIfJob> containUC = new Stack<uC_LoadIfJob>();
                for (int i = 0; i < array.Length; i++)
                {
                    if (array[i] != "")
                    {
                        uC_LoadIfJob uC_LoadIfJob = new uC_LoadIfJob();
                        containUC.Push(uC_LoadIfJob);
                        string[] subArray = array[i].Split('-');
                        uC_LoadIfJob.txtWhatJob.Text = subArray[0];
                        string[] subArray1 = subArray[1].Split('>');
                        uC_LoadIfJob.txtTime.Text = subArray1[0];
                        if (i == array.Length - 1)
                        {
                            string[] sunArray2 = subArray1[1].Split('<');
                            uC_LoadIfJob.txtReviewJob.Text = sunArray2[0];
                            txtEducation.Text = sunArray2[1];
                            uC_LoadIfJob.btnAddPanel.Visible = true;
                        }
                        else
                        {
                            uC_LoadIfJob.txtReviewJob.Text = subArray1[1];
                        }

                        uC_LoadIfJob.AddPanel += (sender, e) =>
                        {
                            controlManager.AddPenal(fpn, uC_LoadIfJob, containUC);
                        };
                        uC_LoadIfJob.RemovePanel += (sender, e) =>
                        {
                            controlManager.RemoveControl(fpn, uC_LoadIfJob, containUC);
                        };
                        fpn.Controls.Add(uC_LoadIfJob);
                    }
                }
            }
        }
    }
}
