using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI.WebControls;
using System.Windows.Forms;

namespace JobHub
{
    internal class DetailCVDAO
    {
        Function function = new Function();

        public DataTable ReadData(string cmd)
        {
            return function.ReadData(cmd);
        }
       
        public void WriteData(System.Windows.Forms.Label lblFirstName, System.Windows.Forms.Label lblLastName, System.Windows.Forms.Label lblJobName,
            System.Windows.Forms.Label lblIntroduce, System.Windows.Forms.Label lblPhoneNumber, System.Windows.Forms.Label lblEmail,
            System.Windows.Forms.Label lblAddress, System.Windows.Forms.Label lblSkill, 
            System.Windows.Forms.Label lblInfEdu, FlowLayoutPanel pnExperience, Guna2CirclePictureBox picAvatarCV, DataTable dt)
        {
            function.WriteData(lblFirstName, lblLastName, lblJobName, lblIntroduce,
            lblPhoneNumber, lblEmail, lblAddress, lblSkill, lblInfEdu, pnExperience, picAvatarCV, dt);
        }

        public void Update(string cmd)
        {
            function.Update(cmd);
        }

        public string SelectImageButton(string pathRoot, string dir)
        {
            return function.SelectImageButton(pathRoot, dir);
        }
    }
}
