using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI;
using System.Windows.Forms;

namespace JobHub
{
    internal class FixCVDAO
    {
        Function function = new Function();
        private int idCV;
        private int idCadidate;

        public FixCVDAO()
        {
            
        }
        public FixCVDAO(int idCV, int idCandidate)
        {
            this.idCV = idCV;
            this.idCadidate = idCandidate;
        }
        public DataTable readData(int idCadidate, int idCV)
        {
            string cmd = $@"SELECT Candidate.*, CV.*
                        FROM Candidate
                        INNER JOIN CV ON CV.idCandidate = Candidate.idCandidate
                        where Candidate.idCandidate = {idCadidate} And CV.idCV = {idCV}";
            return function.ReadData(cmd);
        }

        public void writeData(DataTable dt, Form form)
        {

        }

        public void UpdateData(DetailCV detailCV)
        {
            string cmd = $@"UPDATE CV
                        SET CV.jobName = N'{detailCV.JobName}', CV.CVDescription = N'{detailCV.Experience}', CV.Skill = N'{detailCV.Skill}'
                        WHERE CV.idCV = {this.idCV} and CV.idCandidate = {idCadidate};";
            function.Update(cmd);
        }

        public void UpdateData(Candidate candidate)
        {
            string cmd = $@"UPDATE Candidate
                SET Candidate.candidateFirstName = N'{candidate.FirstName}', Candidate.candidateLastName = N'{candidate.LastName}', Candidate.candidatePhone = '{candidate.Phone}', Candidate.candidateEmail = '{candidate.Email}', Candidate.candidateAddress = N'{candidate.Address}',
                Candidate.candidateGender = '{candidate.Gender}', Candidate.candidateBirth = '{candidate.Birth}'
                FROM Candidate
                INNER JOIN CV ON Candidate.idCandidate = CV.idCandidate
                WHERE Candidate.idCandidate = {this.idCadidate};";
            function.Update(cmd);
        }

        public void ShowData(int idCV, int idCandidate, Guna2TextBox txtAddress, Guna2TextBox txtEducation, 
            Guna2TextBox txtEmail, Guna2TextBox txtFirstName, Guna2TextBox txtLastName, 
            Guna2TextBox txtNameJob, Guna2TextBox txtPhoneNumber, 
            Guna2TextBox txtSkill, DataTable dt, FlowLayoutPanel fpnContain, 
            Guna2CustomRadioButton boy, Guna2CustomRadioButton girl, Guna2DateTimePicker yob)
        {
            function.ShowData(idCV, idCandidate, txtAddress, txtEducation, txtEmail, txtFirstName, txtLastName, txtNameJob, txtPhoneNumber, txtSkill, dt, fpnContain, boy, girl, yob);
        }

        public void LoadData(string s, Guna2TextBox txtWhatJob, Guna2TextBox txtTime, Guna2TextBox txtReviewJob, Guna2TextBox txtEducation)
        {
            string[] array = s.Split('+');
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] != "")
                {
                    string[] subArray = array[i].Split('-');
                    txtWhatJob.Text = subArray[0];
                    string[] subArray1 = subArray[1].Split('>');
                    txtTime.Text = subArray1[0];
                    if (i == array.Length - 1)
                    {
                        string[] sunArray2 = subArray1[1].Split('<');
                        txtReviewJob.Text = sunArray2[0];
                        txtEducation.Text = sunArray2[1];
                    }
                    else
                    {
                        txtReviewJob.Text = subArray1[1];
                    }
                }
            }
        }
    }
}
