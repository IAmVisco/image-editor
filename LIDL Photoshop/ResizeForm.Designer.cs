namespace LIDL_Photoshop
{
    partial class ResizeForm
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
            this.label2 = new System.Windows.Forms.Label();
            this.confirmBtn = new System.Windows.Forms.Button();
            this.heightField = new System.Windows.Forms.NumericUpDown();
            this.widthField = new System.Windows.Forms.NumericUpDown();
            this.proportionLock = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.heightField)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.widthField)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(35, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Height";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(35, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Width";
            // 
            // confirmBtn
            // 
            this.confirmBtn.Location = new System.Drawing.Point(197, 102);
            this.confirmBtn.Name = "confirmBtn";
            this.confirmBtn.Size = new System.Drawing.Size(75, 23);
            this.confirmBtn.TabIndex = 2;
            this.confirmBtn.Text = "Confirm";
            this.confirmBtn.UseVisualStyleBackColor = true;
            this.confirmBtn.Click += new System.EventHandler(this.ConfirmBtn_Click);
            // 
            // heightField
            // 
            this.heightField.Location = new System.Drawing.Point(76, 65);
            this.heightField.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.heightField.Name = "heightField";
            this.heightField.Size = new System.Drawing.Size(89, 20);
            this.heightField.TabIndex = 0;
            this.heightField.ValueChanged += new System.EventHandler(this.heightField_ValueChanged);
            // 
            // widthField
            // 
            this.widthField.Location = new System.Drawing.Point(76, 29);
            this.widthField.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.widthField.Name = "widthField";
            this.widthField.Size = new System.Drawing.Size(89, 20);
            this.widthField.TabIndex = 1;
            this.widthField.ValueChanged += new System.EventHandler(this.widthField_ValueChanged);
            // 
            // proportionLock
            // 
            this.proportionLock.AutoSize = true;
            this.proportionLock.Checked = true;
            this.proportionLock.CheckState = System.Windows.Forms.CheckState.Checked;
            this.proportionLock.Location = new System.Drawing.Point(76, 106);
            this.proportionLock.Name = "proportionLock";
            this.proportionLock.Size = new System.Drawing.Size(105, 17);
            this.proportionLock.TabIndex = 3;
            this.proportionLock.Text = "Lock proportions";
            this.proportionLock.UseVisualStyleBackColor = true;
            this.proportionLock.CheckedChanged += new System.EventHandler(this.ProportionLock_CheckedChanged);
            // 
            // ResizeForm
            // 
            this.AcceptButton = this.confirmBtn;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 141);
            this.Controls.Add(this.proportionLock);
            this.Controls.Add(this.widthField);
            this.Controls.Add(this.heightField);
            this.Controls.Add(this.confirmBtn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ResizeForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Resize Image";
            ((System.ComponentModel.ISupportInitialize)(this.heightField)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.widthField)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button confirmBtn;
        private System.Windows.Forms.NumericUpDown heightField;
        private System.Windows.Forms.NumericUpDown widthField;
        private System.Windows.Forms.CheckBox proportionLock;
    }
}