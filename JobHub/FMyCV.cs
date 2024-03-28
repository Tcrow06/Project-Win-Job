using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JobHub
{
    public partial class FMyCV : Form
    {
        DBConection con = new DBConection();
        
        private int id;

        public int Id { get => id; set => id = value; }

        public FMyCV()
        {
            InitializeComponent();
        }

        private void FMyCV_Load(object sender, EventArgs e)
        {
            string query = $@"SELECT Candidate.*, CV.*
                            FROM CV
                            INNER JOIN Candidate ON CV.idCandidate = Candidate.idCandidate";

            SqlDataReader reader = con.loadData(query);
            while (reader.Read())
            {
                uC_CV uC_CV = new uC_CV();
                uC_CV.lblFirstName.Text = reader["candidateFirstName"].ToString();
                uC_CV.lblLastName.Text = reader["candidateLastName"].ToString();
                uC_CV.lblJobName.Text = reader["jobName"].ToString();
                uC_CV.lblIntroduce.Text = $@"Xin chào, tôi tên là {uC_CV.lblFirstName.Text} {uC_CV.lblLastName.Text}
                                              ";
                Id = Int32.Parse(reader["idCandidate"].ToString());
                pnContainCV.Controls.Add(uC_CV);
                uC_CV.loadJob += OpenForm;
            }
        }

        public void OpenForm(Object sender,  EventArgs e)
        {
            FCVDetail fCv = new FCVDetail(1);
            fCv.Show();
        }
    }
}
