using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JobHub
{
    public abstract partial class FJobParent : Form
    {
        public FJobParent()
        {
            InitializeComponent();
        }
        public abstract void LoadForm(Account account);
    }
}
