using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using ImageOperations;

namespace WPF_Photoshop
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            ChangeMenuOptions(false);
        }

        private void OpenCommand_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog
            {
                Title = "Select an Image",
                FileName = "",
                Filter = "JPEG Files|*.jpg|PNG Files|*.png|Windows Bitmaps|*.bmp"
            };
            //if (ofd.ShowDialog() == true)
            //{
            //    Image img = Image.FromFile(ofd.FileName);
            //    MemoryStream imgStream = new MemoryStream();
            //    img.Save(imgStream, System.Drawing.Imaging.ImageFormat.Png);
            //    ResizeWindow(img.Width, img.Height);
            //    ImageBox.Image = Image.FromStream(imgStream);
            //    img.Dispose();
            //    ChangeMenuOptions(true);
            //    Undo.Clear();
            //    Redo.Clear();
            //}
            MessageBox.Show("Open");
        }

        private void ChangeMenuOptions(bool value)
        {
            SaveBtn.IsEnabled = value;
            ResizeBtn.IsEnabled = value;
            RotateBtn.IsEnabled = value;
            RedoBtn.IsEnabled = value;
            UndoBtn.IsEnabled = value;
        }

        private void ResizeWindow(double width, double height)
        {
            throw new NotImplementedException();
        }
    }
}
