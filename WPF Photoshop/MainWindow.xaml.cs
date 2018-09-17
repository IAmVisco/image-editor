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
using System.Drawing;
using System.Drawing.Imaging;
using ImageOperations;
using System.Runtime.InteropServices;
using System.Windows.Interop;

namespace WPF_Photoshop
{
    public partial class MainWindow : Window
    {
        Stack<ImageSource> Undo = new Stack<ImageSource>(5);
        Stack<ImageSource> Redo = new Stack<ImageSource>(5);
        AttributesWindow attrWindow;
        Bitmap image, backup;

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
                Filter = "PNG Files|*.png|JPEG Files|*.jpg|Windows Bitmaps|*.bmp"
            };
            if (ofd.ShowDialog() == true)
            {
                ImageBox.Source = new BitmapImage(new Uri(ofd.FileName));
                ResizeWindow();
                ChangeMenuOptions(true);
                Undo.Clear();
                Redo.Clear();
            }
        }

        private void SaveCommand_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            try
            {
                sfd.Title = "Save Image";
                sfd.Filter = "JPEG file (*.jpg)|*.jpg|PNG file(*.png)|*.png";
                if (sfd.ShowDialog() == false)
                {
                    return;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            if (sfd.FileName.Contains(".jpg"))
            {
                var encoder = new JpegBitmapEncoder();
                encoder.Frames.Add(BitmapFrame.Create((BitmapSource)ImageBox.Source));
                using (FileStream stream = new FileStream(sfd.FileName, FileMode.Create))
                    encoder.Save(stream);
            }
            else if (sfd.FileName.Contains(".png"))
            {
                var encoder = new PngBitmapEncoder();
                encoder.Frames.Add(BitmapFrame.Create((BitmapSource)ImageBox.Source));
                using (FileStream stream = new FileStream(sfd.FileName, FileMode.Create))
                    encoder.Save(stream);
            }
        }

        private void ChangeMenuOptions(bool value)
        {
            SaveBtn.IsEnabled = value;
            ResizeBtn.IsEnabled = value;
            RotateBtn.IsEnabled = value;
            RedoBtn.IsEnabled = value;
            AttrsBtn.IsEnabled = value;
            UndoBtn.IsEnabled = value;
        }

        private void ResizeWindow()
        {
            Application.Current.MainWindow.Height = ImageBox.Source.Height + 100;
            Application.Current.MainWindow.Width = ImageBox.Source.Width + 100;
            CenterWindowOnScreen();
        }

        private void CenterWindowOnScreen()
        {
            double screenWidth = SystemParameters.PrimaryScreenWidth;
            double screenHeight = SystemParameters.PrimaryScreenHeight;
            this.Left = (screenWidth / 2) - (this.Width / 2);
            this.Top = (screenHeight / 2) - (this.Height / 2);
        }

        public void UndoAdd(ImageSource img)
        {
            Undo.Push(img);
            UndoBtn.IsEnabled = true;
        }

        public void RedoAdd(ImageSource img)
        {
            Redo.Push(img);
            RedoBtn.IsEnabled = true;
        }

        private void Undo_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            if (Undo.Count != 0)
            {
                RedoAdd(ImageBox.Source);
                ImageBox.Source = Undo.Pop();
                if (Undo.Count == 0)
                {
                    UndoBtn.IsEnabled = false;
                }
                else
                {
                    UndoBtn.IsEnabled = true;
                }
            }
        }

        private void Redo_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            if (Redo.Count != 0)
            {
                UndoAdd(ImageBox.Source);
                ImageBox.Source = Redo.Pop();
                if (Redo.Count == 0)
                {
                    RedoBtn.IsEnabled = false;
                }
                else
                {
                    RedoBtn.IsEnabled = true;
                }
            }
        }

        private void Close_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            this.Close();
        }

        public static Bitmap ConvertToBitmap(BitmapSource bitmapSource)
        {
            var width = bitmapSource.PixelWidth;
            var height = bitmapSource.PixelHeight;
            var stride = width * ((bitmapSource.Format.BitsPerPixel + 7) / 8);
            var memoryBlockPointer = Marshal.AllocHGlobal(height * stride);
            bitmapSource.CopyPixels(new Int32Rect(0, 0, width, height), memoryBlockPointer, height * stride, stride);
            var bitmap = new Bitmap(width, height, stride, System.Drawing.Imaging.PixelFormat.Format32bppPArgb, memoryBlockPointer);
            return bitmap;
        }

        [DllImport("gdi32.dll", EntryPoint = "DeleteObject")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool DeleteObject([In] IntPtr hObject);

        public ImageSource BitmapToImageSource(Bitmap bmp)
        {
            var handle = bmp.GetHbitmap();
            try
            {
                return Imaging.CreateBitmapSourceFromHBitmap(handle, IntPtr.Zero, Int32Rect.Empty, BitmapSizeOptions.FromEmptyOptions());
            }
            finally { DeleteObject(handle); }
        }

        private void ResizeBtn_Click(object sender, RoutedEventArgs e)
        {
            ResizeWindow resizeWindow = new ResizeWindow(Convert.ToInt32(ImageBox.Source.Width), Convert.ToInt32(ImageBox.Source.Height));
            if (resizeWindow.ShowDialog() == true)
            {
                UndoAdd(ImageBox.Source);
                Bitmap image = ConvertToBitmap(ImageBox.Source as BitmapSource);
                ImageBox.Source = BitmapToImageSource(image.Resize(resizeWindow.NewWidth, resizeWindow.NewHeight));
                ResizeWindow();
                Redo.Clear();
            }
        }

        private void RotateBtn_Click(object sender, RoutedEventArgs e)
        {
            RotateWindow rotateWindow = new RotateWindow();
            if (rotateWindow.ShowDialog() == true)
            {
                UndoAdd(ImageBox.Source);
                Bitmap image = ConvertToBitmap(ImageBox.Source as BitmapSource);
                ImageBox.Source = BitmapToImageSource(image.Rotate(rotateWindow.Angle));
                ResizeWindow();
                Redo.Clear();
            }
        }

        private void AttrsBtn_Click(object sender, RoutedEventArgs e)
        {
            attrWindow = new AttributesWindow(this);
            image = ConvertToBitmap(ImageBox.Source as BitmapSource);
            backup = (Bitmap)ConvertToBitmap(ImageBox.Source as BitmapSource).Clone();
            if (attrWindow.ShowDialog() == true)
            {
                UndoAdd(ImageBox.Source);
                ImageBox.Source = BitmapToImageSource(image.ChangeAttributes(attrWindow.Brightness, attrWindow.Contrast));
                ResizeWindow();
                Redo.Clear();
            }
            else
            {
                ImageBox.Source = BitmapToImageSource(backup);
            }
        }

        private void ToGrayscale(object sender, RoutedEventArgs e)
        {
            UndoAdd(ImageBox.Source);
            Bitmap image = ConvertToBitmap(ImageBox.Source as BitmapSource);
            ImageBox.Source = BitmapToImageSource(image.ToGrayscale());
            Redo.Clear();
        }

        public void ChangeAttributes()
        {
            ImageBox.Source = BitmapToImageSource(image.ChangeAttributes(attrWindow.Brightness, attrWindow.Contrast));
        }
    }
}
