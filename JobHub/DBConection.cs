﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JobHub
{
    class DBConection
    {

        public static string str = @"Data Source=LAPTOP-QHAH49DL\SQLEXPRESS01;Initial Catalog=JobHub;Integrated Security=True;Encrypt=False";
        SqlConnection sqlConnection = new SqlConnection(DBConection.str);

        public void ThucThi(string sqlStr)
        {
            try
            {
                // Ket noi
                if(sqlConnection.State != ConnectionState.Open)
                {
                    sqlConnection.Open();
                }
                SqlCommand cmd = new SqlCommand(sqlStr, sqlConnection);
                if (cmd.ExecuteNonQuery() > 0)
                {
                    MessageBox.Show("Thành công");
                }
                    

            }
            catch (Exception ex)
            {
                MessageBox.Show("Thất bại" + ex);
            }
        }

        public SqlDataReader loadData(string sql)
        {
            SqlDataReader dr = null;
            try
            {
                if (sqlConnection.State != ConnectionState.Open)
                {
                    sqlConnection.Open();
                }
                SqlCommand cmd = new SqlCommand(sql, sqlConnection);
                dr = cmd.ExecuteReader();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return dr;
        }


        public void change(SqlDataReader dr, FlowLayoutPanel flPanel)
        {
            while (dr.Read())
            {
                uC_Job job = new uC_Job();
                job.lblNameJob.Text = dr["nameJob"].ToString();
                ChangTheSize.setSize(130, 25, job.lblNameJob);
                job.lblNameCompany.Text = dr["nameCompany"].ToString();
                job.lblSalary.Text = dr["salary"].ToString();
                job.lblPositon.Text = dr["position"].ToString();
                flPanel.Controls.Add(job);
            }
            if(sqlConnection.State == ConnectionState.Open)
            {
                sqlConnection.Close();
            }
        }
    }
}
