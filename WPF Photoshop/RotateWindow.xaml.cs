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
    /// Interaction logic for RotateWindow.xaml
    /// </summary>
    public partial class RotateWindow : Window
    {
        public int Angle { get; set; }

        public RotateWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Angle = Convert.ToInt32(AngleSlider.Value);
            this.DialogResult = true;
        }

        private void RotateSlider_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            AngleField.Text = Convert.ToInt32(AngleSlider.Value).ToString();
        }

        private void AngleChanged(object sender, TextChangedEventArgs e)
        {
            try
            {
                AngleSlider.Value = Int32.Parse(AngleField.Text);
            }
            catch (Exception)
            { }
        }
    }
}
