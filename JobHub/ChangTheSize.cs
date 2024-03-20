using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JobHub
{
    internal class ChangTheSize
    {
        SqlConnection conn = new SqlConnection();
        public void setSize(int width, int height, Label label)
        {
            label.Width = width;
            label.Height = height;
        }
    }
}
