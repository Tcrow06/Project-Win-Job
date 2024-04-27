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
    public partial class FShowImage : Form
    {
        private string nameImage;
        private Function function = new Function();
        public FShowImage(string nameImage)
        {
            InitializeComponent();
            this.nameImage = nameImage;
        }
        private void LoadImage()
        {

            try
            {
                string imagePath = function.getPathImage(nameImage);
                Image im = Image.FromFile(imagePath);
                if (pbImage.Width < im.Width)
                {
                    pbImage.Height = pbImage.Width * im.Height / im.Width;
                }
                else
                {
                    pbImage.Size = im.Size;
                }
                pbImage.SizeMode = PictureBoxSizeMode.Zoom;

                pbImage.Image = im;
            }
            catch (Exception)
            {
                MessageBox.Show("Lỗi không tồn tại ảnh trong server", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void FShowImage_Load(object sender, EventArgs e)
        {
            LoadImage();    
        }
    }
}
