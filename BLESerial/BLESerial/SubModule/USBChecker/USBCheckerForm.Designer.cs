namespace BLESerial.USBChecker
{
    partial class USBCheckerForm
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
            this.DeviceListBox = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.VidLabel = new System.Windows.Forms.Label();
            this.PidLabel = new System.Windows.Forms.Label();
            this.DesLabel = new System.Windows.Forms.Label();
            this.RefreshButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // DeviceListBox
            // 
            this.DeviceListBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.DeviceListBox.FormattingEnabled = true;
            this.DeviceListBox.ItemHeight = 12;
            this.DeviceListBox.Location = new System.Drawing.Point(13, 13);
            this.DeviceListBox.Name = "DeviceListBox";
            this.DeviceListBox.Size = new System.Drawing.Size(220, 136);
            this.DeviceListBox.TabIndex = 0;
            this.DeviceListBox.SelectedIndexChanged += new System.EventHandler(this.DeviceListBox_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(268, 18);
            this.label1.Margin = new System.Windows.Forms.Padding(3, 9, 3, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 12);
            this.label1.TabIndex = 1;
            this.label1.Text = "Device ID: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(239, 48);
            this.label2.Margin = new System.Windows.Forms.Padding(3, 9, 3, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "PNP Device ID: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(258, 78);
            this.label3.Margin = new System.Windows.Forms.Padding(3, 9, 3, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 12);
            this.label3.TabIndex = 1;
            this.label3.Text = "Description: ";
            // 
            // VidLabel
            // 
            this.VidLabel.AutoSize = true;
            this.VidLabel.Location = new System.Drawing.Point(340, 18);
            this.VidLabel.Margin = new System.Windows.Forms.Padding(3, 9, 3, 9);
            this.VidLabel.Name = "VidLabel";
            this.VidLabel.Size = new System.Drawing.Size(32, 12);
            this.VidLabel.TabIndex = 1;
            this.VidLabel.Text = "Error";
            // 
            // PidLabel
            // 
            this.PidLabel.AutoSize = true;
            this.PidLabel.Location = new System.Drawing.Point(340, 48);
            this.PidLabel.Margin = new System.Windows.Forms.Padding(3, 9, 3, 9);
            this.PidLabel.Name = "PidLabel";
            this.PidLabel.Size = new System.Drawing.Size(32, 12);
            this.PidLabel.TabIndex = 1;
            this.PidLabel.Text = "Error";
            // 
            // DesLabel
            // 
            this.DesLabel.AutoSize = true;
            this.DesLabel.Location = new System.Drawing.Point(340, 78);
            this.DesLabel.Margin = new System.Windows.Forms.Padding(3, 9, 3, 9);
            this.DesLabel.Name = "DesLabel";
            this.DesLabel.Size = new System.Drawing.Size(32, 12);
            this.DesLabel.TabIndex = 1;
            this.DesLabel.Text = "Error";
            // 
            // RefreshButton
            // 
            this.RefreshButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.RefreshButton.Location = new System.Drawing.Point(13, 162);
            this.RefreshButton.Name = "RefreshButton";
            this.RefreshButton.Size = new System.Drawing.Size(599, 30);
            this.RefreshButton.TabIndex = 2;
            this.RefreshButton.Text = "갱신";
            this.RefreshButton.UseVisualStyleBackColor = true;
            this.RefreshButton.Click += new System.EventHandler(this.RefreshButton_Click);
            // 
            // USBCheckerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(624, 201);
            this.Controls.Add(this.RefreshButton);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.DesLabel);
            this.Controls.Add(this.PidLabel);
            this.Controls.Add(this.VidLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DeviceListBox);
            this.MinimumSize = new System.Drawing.Size(480, 240);
            this.Name = "USBCheckerForm";
            this.Text = "USBCheckerForm";
            this.Load += new System.EventHandler(this.USBCheckerForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox DeviceListBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label VidLabel;
        private System.Windows.Forms.Label PidLabel;
        private System.Windows.Forms.Label DesLabel;
        private System.Windows.Forms.Button RefreshButton;
    }
}