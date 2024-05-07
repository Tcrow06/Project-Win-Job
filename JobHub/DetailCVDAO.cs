using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JobHub
{
    internal class DetailCVDAO
    {
        Function function = new Function();
        private DBConection db =new DBConection();

        public DataTable ReadData(string cmd)
        {
            return function.ReadData(cmd);
        }
       
        public void WriteData(System.Windows.Forms.Label lblFirstName, System.Windows.Forms.Label lblLastName, System.Windows.Forms.Label lblJobName,
            System.Windows.Forms.Label lblIntroduce, System.Windows.Forms.Label lblPhoneNumber, System.Windows.Forms.Label lblEmail,
            System.Windows.Forms.Label lblAddress, System.Windows.Forms.Label lblSkill, 
            System.Windows.Forms.Label lblInfEdu, FlowLayoutPanel pnExperience, Guna2CirclePictureBox picAvatarCV, DataTable dt, Guna2Panel pnContailMenu)
        {
            function.WriteData(lblFirstName, lblLastName, lblJobName, lblIntroduce,
            lblPhoneNumber, lblEmail, lblAddress, lblSkill, lblInfEdu, pnExperience, picAvatarCV, dt, pnContailMenu);
        }

        public void Update(string cmd)
        {
            function.Update(cmd);
        }

        public string SelectImageButton(string pathRoot, string dir)
        {
            return function.SelectImageButton(pathRoot, dir);
        }
        public SqlDataReader GetNameImageInDB(int idCV)
        {
            string sql = $@"select CVAvatar from CV where idCV ={idCV}";
            return db.loadData(sql);
        }
        public void UpdateImageCV(string nameImage, int idCV)
        {
            string sql = $"update CV set CVAvatar = N'{nameImage}' where idCV = {idCV}";
            db.ExcuteNoMess(sql);   
        }
    }
}
