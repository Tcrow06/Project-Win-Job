using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JobHub
{

    internal class EditName
    {
        private EditNameDAO editNameDAO = new EditNameDAO();    
        public EditName() { }

        public void UpdateCVName(string CVName, int idCV)
        {
            editNameDAO.UpdateCVName(CVName, idCV);
        }
    }
}
