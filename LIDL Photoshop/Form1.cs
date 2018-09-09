using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LIDL_Photoshop
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            ChangeMenuOptions(false);
        }

        private void ChangeMenuOptions(bool value)
        {
            this.resizeToolStripMenuItem.Enabled = value;
            this.rotateToolStripMenuItem.Enabled = value;
            this.saveToolStripMenuItem.Enabled = value;
        }

        private void ExitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void OpenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ofd.Title = "Select an Image";
            ofd.Filter = "JPEG Files|*.jpg|Windows Bitmaps|*.bmp";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                Image img = Image.FromFile(ofd.FileName);
                MemoryStream imgStream = new MemoryStream();
                img.Save(imgStream, System.Drawing.Imaging.ImageFormat.Bmp);
                ResizeWindow(img.Width, img.Height);
                ImageBox.Image = Image.FromStream(imgStream);
                img.Dispose();
                ChangeMenuOptions(true);
            }
        }

        public void ResizeWindow(int width, int height)
        {
            ImageBox.Height = height;
            this.Height = height + 100;
            ImageBox.Width = width;
            this.Width = width + 100;
            this.CenterToScreen();
        }

        private void RotateToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void ResizeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ResizeForm resizeForm = new ResizeForm(ImageBox.Image.Width, ImageBox.Image.Height);
            if (resizeForm.ShowDialog() == DialogResult.OK)
            {
                Bitmap image = (Bitmap)ImageBox.Image;
                ImageBox.Image = image.Resize(resizeForm.NewWidth, resizeForm.NewHeight);
                ResizeWindow(resizeForm.NewWidth, resizeForm.NewHeight);
            }
        }
    }
}
