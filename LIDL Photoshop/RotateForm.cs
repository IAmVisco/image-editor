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
    public partial class RotateForm : Form
    {
        public int Angle { get; set; }

        public RotateForm()
        {
            InitializeComponent();
        }

        private void AngleField_ValueChanged(object sender, EventArgs e)
        {
            angleBar.Value = (int)angleField.Value;
        }

        private void AngleBar_ValueChanged(object sender, EventArgs e)
        {
            angleField.Value = angleBar.Value;
        }

        private void ConfirmBtn_Click(object sender, EventArgs e)
        {
            Angle = Convert.ToInt16(angleField.Value);
            this.DialogResult = DialogResult.OK;
        }
    }
}
