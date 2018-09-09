using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LIDL_Photoshop
{
    public partial class AttributesForm : Form
    {
        public float Brightness { get; set; }
        public float Contrast { get; set; }
        public float Gamma { get; set; }

        private MainForm parent;

        public AttributesForm(MainForm parent)
        {
            InitializeComponent();
            this.parent = parent;
        }

        private void ConfirmBtn_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void BirghtnessField_ValueChanged(object sender, EventArgs e)
        {
            brightnessBar.Value = (int)brightnessField.Value;
            Brightness = (float)brightnessField.Value / 100;
            parent.ChangeAttributes();
        }

        private void BrightnessBar_ValueChanged(object sender, EventArgs e)
        {
            brightnessField.Value = brightnessBar.Value;
        }

        private void ContrastField_ValueChanged(object sender, EventArgs e)
        {
            contrastBar.Value = (int)contrastField.Value;
            Contrast = (float)contrastField.Value / 100;
            parent.ChangeAttributes();
        }

        private void ContrastBar_ValueChanged(object sender, EventArgs e)
        {
            contrastField.Value = contrastBar.Value;
        }
    }
}
