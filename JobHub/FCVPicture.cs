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
    public partial class FCVPicture : Form
    {
        public FCVPicture()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Title = "Chọn ảnh";
                openFileDialog.Filter = "Tất cả các tệp (*.*)|*.*|Ảnh (*.png;*.jpg;*.jpeg;*.gif;*.bmp)|*.png;*.jpg;*.jpeg;*.gif;*.bmp";
                openFileDialog.FilterIndex = 2;
                openFileDialog.RestoreDirectory = true;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        string imagePath = openFileDialog.FileName;
                        Image im= Image.FromFile(imagePath);
                        // Đặt kích thước của PictureBox theo kích thước của ảnh và giữ chiều rộng không đổi
                        if(guna2PictureBox1.Width < im.Width)
                        {
                            guna2PictureBox1.Height= guna2PictureBox1.Width*im.Height/im.Width;
                        }
                        else
                        {
                            guna2PictureBox1.Size = im.Size;
                        }
                        guna2PictureBox1.SizeMode = PictureBoxSizeMode.Zoom;

                        // Hiển thị ảnh trong PictureBox
                        guna2PictureBox1.Image = im;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Lỗi khi mở tệp ảnh: " + ex.Message);
                    }
                }
            }
        }
    }
}
