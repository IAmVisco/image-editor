namespace LIDL_Photoshop
{
    partial class AttributesForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.brightnessBar = new System.Windows.Forms.TrackBar();
            this.confirmBtn = new System.Windows.Forms.Button();
            this.brightnessField = new System.Windows.Forms.NumericUpDown();
            this.contrastField = new System.Windows.Forms.NumericUpDown();
            this.contrastBar = new System.Windows.Forms.TrackBar();
            this.label2 = new System.Windows.Forms.Label();
            this.cancelBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.brightnessBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.brightnessField)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.contrastField)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.contrastBar)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Brightness";
            // 
            // brightnessBar
            // 
            this.brightnessBar.LargeChange = 10;
            this.brightnessBar.Location = new System.Drawing.Point(87, 12);
            this.brightnessBar.Maximum = 255;
            this.brightnessBar.Minimum = -255;
            this.brightnessBar.Name = "brightnessBar";
            this.brightnessBar.Size = new System.Drawing.Size(104, 45);
            this.brightnessBar.TabIndex = 1;
            this.brightnessBar.TickFrequency = 50;
            this.brightnessBar.ValueChanged += new System.EventHandler(this.BrightnessBar_ValueChanged);
            // 
            // confirmBtn
            // 
            this.confirmBtn.Location = new System.Drawing.Point(197, 106);
            this.confirmBtn.Name = "confirmBtn";
            this.confirmBtn.Size = new System.Drawing.Size(75, 23);
            this.confirmBtn.TabIndex = 2;
            this.confirmBtn.Text = "Confirm";
            this.confirmBtn.UseVisualStyleBackColor = true;
            this.confirmBtn.Click += new System.EventHandler(this.ConfirmBtn_Click);
            // 
            // brightnessField
            // 
            this.brightnessField.Location = new System.Drawing.Point(197, 23);
            this.brightnessField.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.brightnessField.Minimum = new decimal(new int[] {
            255,
            0,
            0,
            -2147483648});
            this.brightnessField.Name = "brightnessField";
            this.brightnessField.Size = new System.Drawing.Size(75, 20);
            this.brightnessField.TabIndex = 3;
            this.brightnessField.ValueChanged += new System.EventHandler(this.BirghtnessField_ValueChanged);
            // 
            // contrastField
            // 
            this.contrastField.Location = new System.Drawing.Point(197, 72);
            this.contrastField.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.contrastField.Minimum = new decimal(new int[] {
            255,
            0,
            0,
            -2147483648});
            this.contrastField.Name = "contrastField";
            this.contrastField.Size = new System.Drawing.Size(75, 20);
            this.contrastField.TabIndex = 6;
            this.contrastField.ValueChanged += new System.EventHandler(this.ContrastField_ValueChanged);
            // 
            // contrastBar
            // 
            this.contrastBar.LargeChange = 10;
            this.contrastBar.Location = new System.Drawing.Point(87, 61);
            this.contrastBar.Maximum = 255;
            this.contrastBar.Minimum = -255;
            this.contrastBar.Name = "contrastBar";
            this.contrastBar.Size = new System.Drawing.Size(104, 45);
            this.contrastBar.TabIndex = 5;
            this.contrastBar.TickFrequency = 50;
            this.contrastBar.ValueChanged += new System.EventHandler(this.ContrastBar_ValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Contrast";
            // 
            // cancelBtn
            // 
            this.cancelBtn.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cancelBtn.Location = new System.Drawing.Point(116, 106);
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.Size = new System.Drawing.Size(75, 23);
            this.cancelBtn.TabIndex = 7;
            this.cancelBtn.Text = "Cancel";
            this.cancelBtn.UseVisualStyleBackColor = true;
            this.cancelBtn.Click += new System.EventHandler(this.cancelBtn_Click);
            // 
            // AttributesForm
            // 
            this.AcceptButton = this.confirmBtn;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.cancelBtn;
            this.ClientSize = new System.Drawing.Size(284, 141);
            this.Controls.Add(this.cancelBtn);
            this.Controls.Add(this.contrastField);
            this.Controls.Add(this.contrastBar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.brightnessField);
            this.Controls.Add(this.confirmBtn);
            this.Controls.Add(this.brightnessBar);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AttributesForm";
            this.Text = "BrightnessForm";
            ((System.ComponentModel.ISupportInitialize)(this.brightnessBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.brightnessField)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.contrastField)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.contrastBar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TrackBar brightnessBar;
        private System.Windows.Forms.Button confirmBtn;
        private System.Windows.Forms.NumericUpDown brightnessField;
        private System.Windows.Forms.NumericUpDown contrastField;
        private System.Windows.Forms.TrackBar contrastBar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button cancelBtn;
    }
}