namespace LIDL_Photoshop
{
    partial class RotateForm
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
            this.angleBar = new System.Windows.Forms.TrackBar();
            this.angleField = new System.Windows.Forms.NumericUpDown();
            this.confirmBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.angleBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.angleField)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Angle";
            // 
            // angleBar
            // 
            this.angleBar.LargeChange = 10;
            this.angleBar.Location = new System.Drawing.Point(54, 53);
            this.angleBar.Maximum = 360;
            this.angleBar.Name = "angleBar";
            this.angleBar.Size = new System.Drawing.Size(104, 45);
            this.angleBar.TabIndex = 1;
            this.angleBar.TickFrequency = 45;
            this.angleBar.ValueChanged += new System.EventHandler(this.AngleBar_ValueChanged);
            // 
            // angleField
            // 
            this.angleField.Location = new System.Drawing.Point(165, 53);
            this.angleField.Maximum = new decimal(new int[] {
            360,
            0,
            0,
            0});
            this.angleField.Name = "angleField";
            this.angleField.Size = new System.Drawing.Size(63, 20);
            this.angleField.TabIndex = 2;
            this.angleField.ValueChanged += new System.EventHandler(this.AngleField_ValueChanged);
            // 
            // confirmBtn
            // 
            this.confirmBtn.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.confirmBtn.Location = new System.Drawing.Point(197, 106);
            this.confirmBtn.Name = "confirmBtn";
            this.confirmBtn.Size = new System.Drawing.Size(75, 23);
            this.confirmBtn.TabIndex = 3;
            this.confirmBtn.Text = "Confirm";
            this.confirmBtn.UseVisualStyleBackColor = true;
            this.confirmBtn.Click += new System.EventHandler(this.ConfirmBtn_Click);
            // 
            // RotateForm
            // 
            this.AcceptButton = this.confirmBtn;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 141);
            this.Controls.Add(this.confirmBtn);
            this.Controls.Add(this.angleField);
            this.Controls.Add(this.angleBar);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "RotateForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Rotate Image";
            ((System.ComponentModel.ISupportInitialize)(this.angleBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.angleField)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TrackBar angleBar;
        private System.Windows.Forms.NumericUpDown angleField;
        private System.Windows.Forms.Button confirmBtn;
    }
}