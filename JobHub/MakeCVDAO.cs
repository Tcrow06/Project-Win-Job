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
    internal class MakeCVDAO
    {
        private int idCandidate;
        Function function = new Function();
        public MakeCVDAO(int idCandidate)
        {
            this.idCandidate = idCandidate;
        }

        public DataTable ReadData(string cmd)
        {
            return function.ReadData(cmd);
        }

        public void Insert(DetailCV detailcv)
        {
            string cmd = $@"INSERT INTO CV (idCV, idCandidate, CVAvatar, jobName, CVDescription, Skill)
                            VALUES ('{detailcv.Id}', '{detailcv.IdCandidate}', '{detailcv.CVAvatar1}', N'{detailcv.JobName}', N'{detailcv.Experience}', N'{detailcv.Skill}')";
            function.Insert(cmd);
        }
        public DataTable readData(int idCadidate)
        {
            string cmd = $@"SELECT Candidate.*
                        FROM Candidate                       
                        where Candidate.idCandidate = {idCadidate}";
            return function.ReadData(cmd);
        }

        public void ShowData(int idCandidate, Guna2TextBox txtAddress,
            Guna2TextBox txtEmail, Guna2TextBox txtFirstName, Guna2TextBox txtLastName,
            Guna2TextBox txtPhoneNumber,
            DataTable dt, Guna2DateTimePicker yob,
            Guna2CustomRadioButton boy, Guna2CustomRadioButton girl)
        {
            function.ShowData(idCandidate, txtAddress, txtEmail, txtFirstName, txtLastName, txtPhoneNumber, dt,yob, boy, girl);
        }
    }
}
