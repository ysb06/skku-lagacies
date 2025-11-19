namespace BLESerial
{
    partial class EntryForm
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
            this.mspMain = new System.Windows.Forms.MenuStrip();
            this.파일FToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.새연결ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.msiSerialPort = new System.Windows.Forms.ToolStripMenuItem();
            this.msiTilemap = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.msiQuit = new System.Windows.Forms.ToolStripMenuItem();
            this.도구TToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.msiUSB = new System.Windows.Forms.ToolStripMenuItem();
            this.msiBroadcast = new System.Windows.Forms.ToolStripMenuItem();
            this.lsbModuleList = new System.Windows.Forms.ListBox();
            this.button1 = new System.Windows.Forms.Button();
            this.iModuleBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.mspMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iModuleBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // mspMain
            // 
            this.mspMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.파일FToolStripMenuItem,
            this.도구TToolStripMenuItem});
            this.mspMain.Location = new System.Drawing.Point(0, 0);
            this.mspMain.Name = "mspMain";
            this.mspMain.Size = new System.Drawing.Size(784, 24);
            this.mspMain.TabIndex = 0;
            this.mspMain.Text = "menuStrip1";
            // 
            // 파일FToolStripMenuItem
            // 
            this.파일FToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.새연결ToolStripMenuItem,
            this.toolStripSeparator1,
            this.msiQuit});
            this.파일FToolStripMenuItem.Name = "파일FToolStripMenuItem";
            this.파일FToolStripMenuItem.Size = new System.Drawing.Size(57, 20);
            this.파일FToolStripMenuItem.Text = "파일(&F)";
            // 
            // 새연결ToolStripMenuItem
            // 
            this.새연결ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.msiSerialPort,
            this.msiTilemap});
            this.새연결ToolStripMenuItem.Name = "새연결ToolStripMenuItem";
            this.새연결ToolStripMenuItem.Size = new System.Drawing.Size(131, 22);
            this.새연결ToolStripMenuItem.Text = "새 모듈(&N)";
            // 
            // msiSerialPort
            // 
            this.msiSerialPort.Name = "msiSerialPort";
            this.msiSerialPort.Size = new System.Drawing.Size(162, 22);
            this.msiSerialPort.Text = "시리얼 포트(&S)...";
            this.msiSerialPort.Click += new System.EventHandler(this.OnMenuStripItems_Click);
            // 
            // msiTilemap
            // 
            this.msiTilemap.Name = "msiTilemap";
            this.msiTilemap.Size = new System.Drawing.Size(162, 22);
            this.msiTilemap.Text = "타일 맵 뷰(&T)...";
            this.msiTilemap.Click += new System.EventHandler(this.OnMenuStripItems_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(128, 6);
            // 
            // msiQuit
            // 
            this.msiQuit.Name = "msiQuit";
            this.msiQuit.Size = new System.Drawing.Size(131, 22);
            this.msiQuit.Text = "종료(&Q)";
            this.msiQuit.Click += new System.EventHandler(this.OnMenuStripItems_Click);
            // 
            // 도구TToolStripMenuItem
            // 
            this.도구TToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.msiUSB,
            this.msiBroadcast});
            this.도구TToolStripMenuItem.Name = "도구TToolStripMenuItem";
            this.도구TToolStripMenuItem.Size = new System.Drawing.Size(57, 20);
            this.도구TToolStripMenuItem.Text = "도구(&T)";
            // 
            // msiUSB
            // 
            this.msiUSB.Name = "msiUSB";
            this.msiUSB.Size = new System.Drawing.Size(210, 22);
            this.msiUSB.Text = "USB 장치 목록(&U)...";
            this.msiUSB.Click += new System.EventHandler(this.OnMenuStripItems_Click);
            // 
            // msiBroadcast
            // 
            this.msiBroadcast.Name = "msiBroadcast";
            this.msiBroadcast.Size = new System.Drawing.Size(210, 22);
            this.msiBroadcast.Text = "브로드캐스팅 테스트(&B)...";
            this.msiBroadcast.Click += new System.EventHandler(this.OnMenuStripItems_Click);
            // 
            // lsbModuleList
            // 
            this.lsbModuleList.FormattingEnabled = true;
            this.lsbModuleList.ItemHeight = 12;
            this.lsbModuleList.Location = new System.Drawing.Point(12, 29);
            this.lsbModuleList.Name = "lsbModuleList";
            this.lsbModuleList.Size = new System.Drawing.Size(380, 400);
            this.lsbModuleList.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(657, 360);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.OnButtonClicked);
            // 
            // iModuleBindingSource
            // 
            this.iModuleBindingSource.DataSource = typeof(BLESerial.IModule);
            // 
            // EntryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 441);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lsbModuleList);
            this.Controls.Add(this.mspMain);
            this.MainMenuStrip = this.mspMain;
            this.Name = "EntryForm";
            this.Text = "EntryForm";
            this.Load += new System.EventHandler(this.EntryForm_Load);
            this.mspMain.ResumeLayout(false);
            this.mspMain.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iModuleBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mspMain;
        private System.Windows.Forms.ToolStripMenuItem 파일FToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 새연결ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem msiSerialPort;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem msiQuit;
        private System.Windows.Forms.ToolStripMenuItem msiTilemap;
        private System.Windows.Forms.ToolStripMenuItem 도구TToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem msiUSB;
        private System.Windows.Forms.ToolStripMenuItem msiBroadcast;
        private System.Windows.Forms.ListBox lsbModuleList;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.BindingSource iModuleBindingSource;
    }
}