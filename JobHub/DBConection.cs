using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JobHub
{
    class DBConection
    {
        public static string str = @"Data Source=(local);Initial Catalog=JobHub;Integrated Security=True";

        SqlConnection sqlConnection = new SqlConnection(DBConection.str);

        public void ThucThi(string sqlStr)
        {
            try
            {
                // Ket noi
                sqlConnection.Open();
                SqlCommand cmd = new SqlCommand(sqlStr, sqlConnection);
                if (cmd.ExecuteNonQuery() > 0)
                    MessageBox.Show("Thành công");

            }
            catch (Exception ex)
            {
                MessageBox.Show("Thất bại" + ex);
            }
            finally
            {
                sqlConnection.Close();
            }

        }

    }
}
