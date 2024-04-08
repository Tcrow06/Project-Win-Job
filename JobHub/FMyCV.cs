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
        CVDAO CVDAO = new CVDAO();
        
        private int id;

        public int Id { get => id; set => id = value; }

        public FMyCV()
        {
            InitializeComponent();
        }

        public FMyCV(int id)
        {
            InitializeComponent();
            this.Id = id;
            DataTable dt = CVDAO.ReadData(this.Id);
            CVDAO.WriteData(dt, pnContainCV);
        }

        private void FMyCV_Load(object sender, EventArgs e)
        {

        }
    }
}
