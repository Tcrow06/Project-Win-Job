using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JobHub
{
    public class EditCompany : User
    {
        private EditCompanyDao editcompanyDAO = new EditCompanyDao();

        private int id;
        private string phone;
        private string web;
        private string size;
        private string description;
        private string listCompanyImage;
        private string avatar;

        public EditCompany()
        {

        }
        public EditCompany(int id, string phone, string web, string size, string description)
        {
            this.ID = id;
            this.Phone = phone;
            this.Web = web;
            this.Size = size;
            this.Description = description;
        }
        public string Description { get => description; set => description = value; }
        public string Size { get => size; set => size = value; }
        public string ListCompanyImage { get => listCompanyImage; set => listCompanyImage = value; }
        public string Web { get => web; set => web = value; }
        public int ID { get => id; set => id = value; }
        public string Phone { get => phone; set => phone = value; }

        public string Avatar { get => avatar; set => avatar = value; }

        public void AddCompany()
        {
            editcompanyDAO.AddCompany(this);
        }

        public void AddImagePath()
        {
            editcompanyDAO.AddImage(this);
            MessageBox.Show("Update ảnh thành công");
        }

        public void AddOtherImagePath()
        {
            editcompanyDAO.AddOtherImage(this);
            MessageBox.Show("Update ảnh thành công");
        }

        public void AddAvatar()
        {
            editcompanyDAO.AddAvatar(this);
            MessageBox.Show("Update ảnh thành công");
        }

        public void DeleteImage()
        {
            editcompanyDAO.DeleteImage(this);
            MessageBox.Show("Xóa ảnh thành công");
        }

        public void DeleteOtherImage()
        {
            editcompanyDAO.DeleteOtherImage(this);
            MessageBox.Show("Xóa ảnh thành công");
        }

        public void DeleteOnlyImage()
        {
            editcompanyDAO.DeleteOnlyImage(this);
            MessageBox.Show("Xóa ảnh thành công");
        }
    }

}
