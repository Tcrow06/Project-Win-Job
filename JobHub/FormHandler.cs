using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JobHub
{
    internal class FormHandler
    {
        public FormHandler() { }
        public void OpenNewForm(int idCadidate, int idCV)
        {
            FCVDetail fCVDetail = new FCVDetail(idCadidate, idCV);
            fCVDetail.ShowDialog();
        }

        public void setSizeForm(int width, int height, Form form) 
        {
            form.Width = width;
            form.Height = height;
        }

    }
}
