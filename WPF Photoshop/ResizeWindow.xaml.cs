using System;
using System.Collections.Generic;
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
using System.Windows.Shapes;

namespace WPF_Photoshop
{
    /// <summary>
    /// Interaction logic for ResizeWindow.xaml
    /// </summary>
    public partial class ResizeWindow : Window
    {
        public int NewWidth { get; set; }
        public int NewHeight { get; set; }

        public ResizeWindow(int width, int height)
        {
            InitializeComponent();
            this.WidthField.Text = width.ToString();
            this.HeightField.Text = height.ToString();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            NewWidth = Convert.ToInt16(WidthField.Text);
            NewHeight = Convert.ToInt16(HeightField.Text);
            this.DialogResult = true;
        }
    }
}
