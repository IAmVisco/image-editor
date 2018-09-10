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
using ImageOperations;

namespace LIDL_Photoshop
{
    public partial class MainForm : Form
    {
        private AttributesForm attrsForm;
        private Image image;

        Stack<Image> Undo = new Stack<Image>(5);
        Stack<Image> Redo = new Stack<Image>(5);

        public MainForm()
        {
            InitializeComponent();
            ChangeMenuOptions(false);
        }

        public void UndoAdd(Image img)
        {
            Undo.Push(img);
            undoToolStripMenuItem.Enabled = true;
        }

        public void RedoAdd(Image img)
        {
            Redo.Push(img);
            redoToolStripMenuItem.Enabled = true;
        }

        private void ChangeMenuOptions(bool value)
        {
            saveToolStripMenuItem.Enabled = value;

            resizeToolStripMenuItem.Enabled = value;
            rotateToolStripMenuItem.Enabled = value;
            attributesToolStripMenuItem.Enabled = value;

            redoToolStripMenuItem.Enabled = value;
            undoToolStripMenuItem.Enabled = value;

            toGrayscaleToolStripMenuItem.Enabled = value;
        }

        private void ExitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void OpenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ofd.Title = "Select an Image";
            ofd.FileName = "";
            ofd.Filter = "PNG Files|*.png|JPEG Files|*.jpg|Windows Bitmaps|*.bmp";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                Image img = Image.FromFile(ofd.FileName);
                MemoryStream imgStream = new MemoryStream();
                img.Save(imgStream, System.Drawing.Imaging.ImageFormat.Png);
                ResizeWindow(img.Width, img.Height);
                ImageBox.Image = Image.FromStream(imgStream);
                img.Dispose();
                ChangeMenuOptions(true);
                Undo.Clear();
                Redo.Clear();
            }
        }

        private void SaveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            try
            {
                sfd.Title = "Save Image";
                sfd.Filter = "Please select a file type||JPEG file (*.jpg)|*.jpg|PNG file(*.png)|*.png";
                if (sfd.ShowDialog() == System.Windows.Forms.DialogResult.Cancel)
                {
                    return;
                }
            }
            catch (Exception)
            {
                return;
            }

            if (sfd.FileName.Contains(".jpg"))
            {
                ImageBox.Image.Save(sfd.FileName, System.Drawing.Imaging.ImageFormat.Jpeg);
            }
            else if (sfd.FileName.Contains(".png"))
            {
                ImageBox.Image.Save(sfd.FileName, System.Drawing.Imaging.ImageFormat.Png);
            }
            else
            {
                ImageBox.Image.Save(sfd.FileName, System.Drawing.Imaging.ImageFormat.Bmp);
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
            RotateForm rotateForm = new RotateForm();
            if (rotateForm.ShowDialog() == DialogResult.OK)
            {
                UndoAdd(ImageBox.Image);
                Image image = ImageBox.Image;
                ImageBox.Image = image.Rotate(rotateForm.Angle);
                ResizeWindow(ImageBox.Image.Width, ImageBox.Image.Height);
                Redo.Clear();
            }
        }

        private void ResizeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ResizeForm resizeForm = new ResizeForm(ImageBox.Image.Width, ImageBox.Image.Height);
            if (resizeForm.ShowDialog() == DialogResult.OK)
            {
                UndoAdd(ImageBox.Image);
                Image image = ImageBox.Image;
                ImageBox.Image = image.Resize(resizeForm.NewWidth, resizeForm.NewHeight);
                ResizeWindow(resizeForm.NewWidth, resizeForm.NewHeight);
                Redo.Clear();
            }
        }

        private void ToBlackAndWhiteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UndoAdd(ImageBox.Image);
            Bitmap image = (Bitmap)ImageBox.Image;
            ImageBox.Image = image.ToGrayscale();
            Redo.Clear();
        }

        private void AttributesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            attrsForm = new AttributesForm(this);
            image = ImageBox.Image;
            Image backup = (Image)ImageBox.Image.Clone();
            UndoAdd(ImageBox.Image);
            DialogResult res = attrsForm.ShowDialog();
            if (res == DialogResult.Cancel)
            {
                ImageBox.Image = backup;
            }
            else if (res == DialogResult.OK)
            {
                Redo.Clear();
            }
        }

        public void ChangeAttributes()
        {
            ImageBox.Image = (image as Bitmap).ChangeAttributes(attrsForm.Brightness, attrsForm.Contrast);
        }
    }
}
