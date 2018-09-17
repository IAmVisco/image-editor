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
    /// Interaction logic for AttributesWindow.xaml
    /// </summary>
    public partial class AttributesWindow : Window
    {
        public int Brightness { get; set; }
        public int Contrast { get; set; }
        private MainWindow parent;

        public AttributesWindow(MainWindow parent)
        {
            InitializeComponent();
            this.parent = parent;
        }

        private void BrightnessChanged(object sender, TextChangedEventArgs e)
        {
            try
            {
                BrightnessSlider.Value = Int32.Parse(BrightnessField.Text);
                Brightness = Convert.ToInt32(BrightnessSlider.Value);
                parent.ChangeAttributes();
            }
            catch (Exception)
            { }
        }

        private void BrightnessSlider_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            BrightnessField.Text = Convert.ToInt32(BrightnessSlider.Value).ToString();
        }

        private void ContrastChanged(object sender, TextChangedEventArgs e)
        {
            try
            {
                ContrastSlider.Value = Int32.Parse(ContrastField.Text);
                Contrast = Convert.ToInt32(ContrastSlider.Value);
                parent.ChangeAttributes();
            }
            catch (Exception)
            { }
        }

        private void ContrastSlider_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            ContrastField.Text = Convert.ToInt32(ContrastSlider.Value).ToString();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            this.DialogResult = true;
        }
    }
}
