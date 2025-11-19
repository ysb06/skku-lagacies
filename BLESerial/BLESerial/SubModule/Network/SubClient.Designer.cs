namespace BLESerial.Network
{
    partial class SubClient
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
            this.ClientTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // ClientTextBox
            // 
            this.ClientTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ClientTextBox.Location = new System.Drawing.Point(12, 12);
            this.ClientTextBox.Multiline = true;
            this.ClientTextBox.Name = "ClientTextBox";
            this.ClientTextBox.Size = new System.Drawing.Size(260, 237);
            this.ClientTextBox.TabIndex = 0;
            // 
            // SubClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.ClientTextBox);
            this.Name = "SubClient";
            this.Text = "SubClient";
            this.Load += new System.EventHandler(this.SubClient_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox ClientTextBox;
    }
}