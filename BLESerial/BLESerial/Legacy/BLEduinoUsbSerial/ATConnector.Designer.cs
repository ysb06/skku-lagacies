namespace BLESerial.BLEduinoUsbSerial
{
    partial class ATConnector
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
            this.components = new System.ComponentModel.Container();
            this.statusLabel = new System.Windows.Forms.Label();
            this.StopButton = new System.Windows.Forms.Button();
            this.CountTimer = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // statusLabel
            // 
            this.statusLabel.Location = new System.Drawing.Point(12, 9);
            this.statusLabel.Name = "statusLabel";
            this.statusLabel.Size = new System.Drawing.Size(260, 104);
            this.statusLabel.TabIndex = 0;
            this.statusLabel.Text = "BLEduino 연결중...";
            this.statusLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.statusLabel.Click += new System.EventHandler(this.statusLabel_Click);
            // 
            // StopButton
            // 
            this.StopButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.StopButton.Location = new System.Drawing.Point(13, 116);
            this.StopButton.Name = "StopButton";
            this.StopButton.Size = new System.Drawing.Size(259, 33);
            this.StopButton.TabIndex = 1;
            this.StopButton.Text = "중지";
            this.StopButton.UseVisualStyleBackColor = true;
            this.StopButton.Click += new System.EventHandler(this.StopButton_Click);
            // 
            // CountTimer
            // 
            this.CountTimer.Tick += new System.EventHandler(this.CountTimer_Tick);
            // 
            // ATConnector
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 161);
            this.Controls.Add(this.StopButton);
            this.Controls.Add(this.statusLabel);
            this.Name = "ATConnector";
            this.Text = "BLEduino 연결";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ATConnector_FormClosed);
            this.Load += new System.EventHandler(this.ATConnector_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label statusLabel;
        private System.Windows.Forms.Button StopButton;
        private System.Windows.Forms.Timer CountTimer;
    }
}