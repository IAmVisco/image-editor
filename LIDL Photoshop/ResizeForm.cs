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
    public partial class ResizeForm : Form
    {
        private bool isLocked, isAllowed = false;
        private double coef;

        public int NewWidth { get; set; }
        public int NewHeight { get; set; }

        public ResizeForm(int width, int height)
        {
            InitializeComponent();
            this.widthField.Value = width;
            this.heightField.Value = height;
            ProportionLock_CheckedChanged(null, null);
            isAllowed = true;
        }

        private void ProportionLock_CheckedChanged(object sender, EventArgs e)
        {
            isLocked = proportionLock.Checked;
            coef = (double)(widthField.Value / this.heightField.Value);
        }

        private void ConfirmBtn_Click(object sender, EventArgs e)
        {
            NewWidth = Convert.ToInt16(widthField.Text);
            NewHeight = Convert.ToInt16(heightField.Text);
            this.DialogResult = DialogResult.OK;
        }

        private void heightField_ValueChanged(object sender, EventArgs e)
        {
            if (isLocked && isAllowed)
            {
                isAllowed = false;
                widthField.Value = (decimal)((double)heightField.Value * coef);
                isAllowed = true;
            }
        }

        private void widthField_ValueChanged(object sender, EventArgs e)
        {
            if (isLocked && isAllowed)
            {
                isAllowed = false;
                heightField.Value = (decimal)((double)widthField.Value * coef);
                isAllowed = true;
            }
        }
    }
}
