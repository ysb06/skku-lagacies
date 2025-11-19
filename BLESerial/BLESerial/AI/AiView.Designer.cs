namespace BLESerial.AI
{
    partial class AiView
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
            this.button1 = new System.Windows.Forms.Button();
            this.gv = new BLESerial.AI.GridVisualizer();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(13, 13);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.OnButtonClicked);
            // 
            // gv
            // 
            this.gv.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gv.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.gv.GridBorderColor = System.Drawing.Color.Black;
            this.gv.GridBorderWidth = 1;
            this.gv.Location = new System.Drawing.Point(250, 12);
            this.gv.MapSize = new System.Drawing.Size(4, 8);
            this.gv.Name = "gv";
            this.gv.Size = new System.Drawing.Size(178, 225);
            this.gv.TabIndex = 0;
            this.gv.TileClicked += new System.EventHandler<BLESerial.AI.TileClickedEventArgs>(this.Gv_TileClicked);
            // 
            // AiView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(440, 249);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.gv);
            this.Name = "AiView";
            this.Text = "AiView";
            this.ResumeLayout(false);

        }

        #endregion

        private GridVisualizer gv;
        private System.Windows.Forms.Button button1;
    }
}