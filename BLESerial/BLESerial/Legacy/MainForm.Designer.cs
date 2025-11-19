namespace BLESerial
{
    partial class MainForm
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.BaudrateBox = new System.Windows.Forms.ComboBox();
            this.refreshButton = new System.Windows.Forms.Button();
            this.serialPortList = new System.Windows.Forms.ListBox();
            this.connectButton = new System.Windows.Forms.Button();
            this.portBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.consoleBox = new System.Windows.Forms.TextBox();
            this.ConsoleOptionStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.ClearMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.inputBox = new System.Windows.Forms.TextBox();
            this.sendButton = new System.Windows.Forms.Button();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.파일FToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.NewWindowMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.QuitMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.도구TToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.BLEduinoMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.ClientMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.USBCheckerMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.BroadcasterPortLabel = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.ConnectionLabel = new System.Windows.Forms.Label();
            this.BroadcastButton = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.ConsoleLineEndCheck = new System.Windows.Forms.CheckBox();
            this.DelaySetButton = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.DelayBox = new System.Windows.Forms.TextBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.CRCheck = new System.Windows.Forms.CheckBox();
            this.LFCheck = new System.Windows.Forms.CheckBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.ConsoleOptionStrip.SuspendLayout();
            this.menuStrip.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.BaudrateBox);
            this.groupBox1.Controls.Add(this.refreshButton);
            this.groupBox1.Controls.Add(this.serialPortList);
            this.groupBox1.Controls.Add(this.connectButton);
            this.groupBox1.Controls.Add(this.portBox);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 33);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 9, 3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(294, 119);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Serial 연결";
            // 
            // BaudrateBox
            // 
            this.BaudrateBox.FormattingEnabled = true;
            this.BaudrateBox.Items.AddRange(new object[] {
            "300",
            "600",
            "1200",
            "2400",
            "4800",
            "9600",
            "14400",
            "19200",
            "28800",
            "38400",
            "57600",
            "115200",
            "128000",
            "153600",
            "230400",
            "256000",
            "460800",
            "921600"});
            this.BaudrateBox.Location = new System.Drawing.Point(92, 53);
            this.BaudrateBox.Name = "BaudrateBox";
            this.BaudrateBox.Size = new System.Drawing.Size(76, 20);
            this.BaudrateBox.TabIndex = 5;
            // 
            // refreshButton
            // 
            this.refreshButton.Location = new System.Drawing.Point(206, 79);
            this.refreshButton.Name = "refreshButton";
            this.refreshButton.Size = new System.Drawing.Size(82, 32);
            this.refreshButton.TabIndex = 4;
            this.refreshButton.Text = "Refresh";
            this.refreshButton.UseVisualStyleBackColor = true;
            this.refreshButton.Click += new System.EventHandler(this.RefreshButton_Click);
            // 
            // serialPortList
            // 
            this.serialPortList.FormattingEnabled = true;
            this.serialPortList.ItemHeight = 12;
            this.serialPortList.Location = new System.Drawing.Point(174, 21);
            this.serialPortList.Name = "serialPortList";
            this.serialPortList.Size = new System.Drawing.Size(114, 52);
            this.serialPortList.TabIndex = 0;
            this.serialPortList.SelectedIndexChanged += new System.EventHandler(this.SerialPortList_SelectedIndexChanged);
            // 
            // connectButton
            // 
            this.connectButton.Location = new System.Drawing.Point(6, 79);
            this.connectButton.Margin = new System.Windows.Forms.Padding(3, 6, 3, 3);
            this.connectButton.Name = "connectButton";
            this.connectButton.Size = new System.Drawing.Size(194, 32);
            this.connectButton.TabIndex = 3;
            this.connectButton.Text = "Connect";
            this.connectButton.UseVisualStyleBackColor = true;
            this.connectButton.Click += new System.EventHandler(this.ConnectButton_Click);
            // 
            // portBox
            // 
            this.portBox.Location = new System.Drawing.Point(92, 24);
            this.portBox.Name = "portBox";
            this.portBox.Size = new System.Drawing.Size(76, 21);
            this.portBox.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 56);
            this.label2.Name = "label2";
            this.label2.Padding = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.label2.Size = new System.Drawing.Size(67, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Baudrate : ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 24);
            this.label1.Name = "label1";
            this.label1.Padding = new System.Windows.Forms.Padding(0, 10, 0, 0);
            this.label1.Size = new System.Drawing.Size(80, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "포트(COM) : ";
            // 
            // consoleBox
            // 
            this.consoleBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.consoleBox.ContextMenuStrip = this.ConsoleOptionStrip;
            this.consoleBox.Location = new System.Drawing.Point(312, 33);
            this.consoleBox.Margin = new System.Windows.Forms.Padding(3, 9, 3, 3);
            this.consoleBox.Multiline = true;
            this.consoleBox.Name = "consoleBox";
            this.consoleBox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.consoleBox.Size = new System.Drawing.Size(300, 364);
            this.consoleBox.TabIndex = 1;
            // 
            // ConsoleOptionStrip
            // 
            this.ConsoleOptionStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ClearMenu});
            this.ConsoleOptionStrip.Name = "ConsoleOptionStrip";
            this.ConsoleOptionStrip.Size = new System.Drawing.Size(102, 26);
            // 
            // ClearMenu
            // 
            this.ClearMenu.Name = "ClearMenu";
            this.ClearMenu.Size = new System.Drawing.Size(101, 22);
            this.ClearMenu.Text = "Clear";
            this.ClearMenu.Click += new System.EventHandler(this.ClearMenu_Click);
            // 
            // inputBox
            // 
            this.inputBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.inputBox.Location = new System.Drawing.Point(312, 405);
            this.inputBox.Name = "inputBox";
            this.inputBox.Size = new System.Drawing.Size(219, 21);
            this.inputBox.TabIndex = 2;
            this.inputBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.InputBox_KeyDown);
            // 
            // sendButton
            // 
            this.sendButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.sendButton.Location = new System.Drawing.Point(537, 403);
            this.sendButton.Name = "sendButton";
            this.sendButton.Size = new System.Drawing.Size(75, 23);
            this.sendButton.TabIndex = 3;
            this.sendButton.Text = "Send";
            this.sendButton.UseVisualStyleBackColor = true;
            this.sendButton.Click += new System.EventHandler(this.SendButton_Click);
            // 
            // menuStrip
            // 
            this.menuStrip.BackColor = System.Drawing.SystemColors.Window;
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.파일FToolStripMenuItem,
            this.도구TToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(624, 24);
            this.menuStrip.TabIndex = 6;
            this.menuStrip.Text = "menuStrip1";
            // 
            // 파일FToolStripMenuItem
            // 
            this.파일FToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.NewWindowMenu,
            this.QuitMenu});
            this.파일FToolStripMenuItem.Name = "파일FToolStripMenuItem";
            this.파일FToolStripMenuItem.Size = new System.Drawing.Size(57, 20);
            this.파일FToolStripMenuItem.Text = "파일(&F)";
            // 
            // NewWindowMenu
            // 
            this.NewWindowMenu.Name = "NewWindowMenu";
            this.NewWindowMenu.Size = new System.Drawing.Size(147, 22);
            this.NewWindowMenu.Text = "새 창 열기(&N)";
            this.NewWindowMenu.Visible = false;
            this.NewWindowMenu.Click += new System.EventHandler(this.NewWindowMenu_Click);
            // 
            // QuitMenu
            // 
            this.QuitMenu.Name = "QuitMenu";
            this.QuitMenu.Size = new System.Drawing.Size(147, 22);
            this.QuitMenu.Text = "종료(&Q)";
            this.QuitMenu.Click += new System.EventHandler(this.QuitMenu_Click);
            // 
            // 도구TToolStripMenuItem
            // 
            this.도구TToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.BLEduinoMenu,
            this.ClientMenu,
            this.USBCheckerMenu});
            this.도구TToolStripMenuItem.Name = "도구TToolStripMenuItem";
            this.도구TToolStripMenuItem.Size = new System.Drawing.Size(57, 20);
            this.도구TToolStripMenuItem.Text = "도구(&T)";
            // 
            // BLEduinoMenu
            // 
            this.BLEduinoMenu.Name = "BLEduinoMenu";
            this.BLEduinoMenu.Size = new System.Drawing.Size(220, 22);
            this.BLEduinoMenu.Text = "AT 전송(&A)...";
            this.BLEduinoMenu.Click += new System.EventHandler(this.BLEduinoMenu_Click);
            // 
            // ClientMenu
            // 
            this.ClientMenu.Name = "ClientMenu";
            this.ClientMenu.Size = new System.Drawing.Size(220, 22);
            this.ClientMenu.Text = "Broadcast Client Tester(&B)...";
            this.ClientMenu.Click += new System.EventHandler(this.ClientMenu_Click);
            // 
            // USBCheckerMenu
            // 
            this.USBCheckerMenu.Name = "USBCheckerMenu";
            this.USBCheckerMenu.Size = new System.Drawing.Size(220, 22);
            this.USBCheckerMenu.Text = "USB VID/PID(&U)...";
            this.USBCheckerMenu.Click += new System.EventHandler(this.USBCheckerMenu_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.BroadcasterPortLabel);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.ConnectionLabel);
            this.groupBox2.Controls.Add(this.BroadcastButton);
            this.groupBox2.Location = new System.Drawing.Point(12, 342);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(294, 84);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "기능";
            // 
            // label7
            // 
            this.label7.Location = new System.Drawing.Point(137, 50);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(47, 23);
            this.label7.TabIndex = 10;
            this.label7.Text = "포트: ";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // BroadcasterPortLabel
            // 
            this.BroadcasterPortLabel.Location = new System.Drawing.Point(190, 50);
            this.BroadcasterPortLabel.Name = "BroadcasterPortLabel";
            this.BroadcasterPortLabel.Size = new System.Drawing.Size(98, 23);
            this.BroadcasterPortLabel.TabIndex = 10;
            this.BroadcasterPortLabel.Text = "Error";
            this.BroadcasterPortLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(137, 27);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 23);
            this.label5.TabIndex = 10;
            this.label5.Text = "상태: ";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ConnectionLabel
            // 
            this.ConnectionLabel.Location = new System.Drawing.Point(190, 27);
            this.ConnectionLabel.Name = "ConnectionLabel";
            this.ConnectionLabel.Size = new System.Drawing.Size(98, 23);
            this.ConnectionLabel.TabIndex = 10;
            this.ConnectionLabel.Text = "연결 안 됨";
            this.ConnectionLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // BroadcastButton
            // 
            this.BroadcastButton.Location = new System.Drawing.Point(6, 20);
            this.BroadcastButton.Name = "BroadcastButton";
            this.BroadcastButton.Size = new System.Drawing.Size(125, 58);
            this.BroadcastButton.TabIndex = 8;
            this.BroadcastButton.Text = "브로드캐스트 시작";
            this.BroadcastButton.UseVisualStyleBackColor = true;
            this.BroadcastButton.Click += new System.EventHandler(this.BroadcastButton_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.ConsoleLineEndCheck);
            this.groupBox4.Controls.Add(this.DelaySetButton);
            this.groupBox4.Controls.Add(this.label4);
            this.groupBox4.Controls.Add(this.DelayBox);
            this.groupBox4.Location = new System.Drawing.Point(9, 83);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(6);
            this.groupBox4.Size = new System.Drawing.Size(276, 86);
            this.groupBox4.TabIndex = 2;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "수신";
            // 
            // ConsoleLineEndCheck
            // 
            this.ConsoleLineEndCheck.AutoSize = true;
            this.ConsoleLineEndCheck.Location = new System.Drawing.Point(9, 59);
            this.ConsoleLineEndCheck.Margin = new System.Windows.Forms.Padding(3, 12, 3, 3);
            this.ConsoleLineEndCheck.Name = "ConsoleLineEndCheck";
            this.ConsoleLineEndCheck.Size = new System.Drawing.Size(113, 16);
            this.ConsoleLineEndCheck.TabIndex = 3;
            this.ConsoleLineEndCheck.Text = "CR LF Line End";
            this.ConsoleLineEndCheck.UseVisualStyleBackColor = true;
            // 
            // DelaySetButton
            // 
            this.DelaySetButton.Location = new System.Drawing.Point(192, 23);
            this.DelaySetButton.Name = "DelaySetButton";
            this.DelaySetButton.Size = new System.Drawing.Size(75, 23);
            this.DelaySetButton.TabIndex = 2;
            this.DelaySetButton.Text = "설정";
            this.DelaySetButton.UseVisualStyleBackColor = true;
            this.DelaySetButton.Click += new System.EventHandler(this.DelaySetButton_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 26);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 12);
            this.label4.TabIndex = 1;
            this.label4.Text = "Delay";
            // 
            // DelayBox
            // 
            this.DelayBox.Location = new System.Drawing.Point(52, 23);
            this.DelayBox.Name = "DelayBox";
            this.DelayBox.Size = new System.Drawing.Size(134, 21);
            this.DelayBox.TabIndex = 1;
            this.DelayBox.Text = "0";
            this.DelayBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.DelayBox_KeyPress);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.label3);
            this.groupBox5.Controls.Add(this.CRCheck);
            this.groupBox5.Controls.Add(this.LFCheck);
            this.groupBox5.Location = new System.Drawing.Point(9, 23);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Padding = new System.Windows.Forms.Padding(6);
            this.groupBox5.Size = new System.Drawing.Size(276, 54);
            this.groupBox5.TabIndex = 3;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "전송";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 24);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 12);
            this.label3.TabIndex = 1;
            this.label3.Text = "Line End: ";
            // 
            // CRCheck
            // 
            this.CRCheck.AutoSize = true;
            this.CRCheck.Location = new System.Drawing.Point(78, 23);
            this.CRCheck.Name = "CRCheck";
            this.CRCheck.Size = new System.Drawing.Size(70, 16);
            this.CRCheck.TabIndex = 0;
            this.CRCheck.Text = "CR (\\r)";
            this.CRCheck.UseVisualStyleBackColor = true;
            // 
            // LFCheck
            // 
            this.LFCheck.AutoSize = true;
            this.LFCheck.Location = new System.Drawing.Point(174, 23);
            this.LFCheck.Name = "LFCheck";
            this.LFCheck.Size = new System.Drawing.Size(70, 16);
            this.LFCheck.TabIndex = 0;
            this.LFCheck.Text = "LF (\\n)";
            this.LFCheck.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.groupBox5);
            this.groupBox3.Controls.Add(this.groupBox4);
            this.groupBox3.Location = new System.Drawing.Point(12, 158);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(6);
            this.groupBox3.Size = new System.Drawing.Size(294, 178);
            this.groupBox3.TabIndex = 5;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "통신 설정";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(624, 438);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.sendButton);
            this.Controls.Add(this.inputBox);
            this.Controls.Add(this.consoleBox);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menuStrip);
            this.MainMenuStrip = this.menuStrip;
            this.Name = "MainForm";
            this.Text = "Arduino Manager 0.2";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainForm_FormClosed);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ConsoleOptionStrip.ResumeLayout(false);
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button connectButton;
        private System.Windows.Forms.TextBox portBox;
        private System.Windows.Forms.TextBox consoleBox;
        private System.Windows.Forms.TextBox inputBox;
        private System.Windows.Forms.Button sendButton;
        private System.Windows.Forms.ListBox serialPortList;
        private System.Windows.Forms.Button refreshButton;
        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem 파일FToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem QuitMenu;
        private System.Windows.Forms.ToolStripMenuItem 도구TToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem BLEduinoMenu;
        private System.Windows.Forms.ComboBox BaudrateBox;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ContextMenuStrip ConsoleOptionStrip;
        private System.Windows.Forms.ToolStripMenuItem ClearMenu;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.CheckBox ConsoleLineEndCheck;
        private System.Windows.Forms.Button DelaySetButton;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox DelayBox;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox CRCheck;
        private System.Windows.Forms.CheckBox LFCheck;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ToolStripMenuItem NewWindowMenu;
        private System.Windows.Forms.Button BroadcastButton;
        private System.Windows.Forms.ToolStripMenuItem ClientMenu;
        private System.Windows.Forms.Label ConnectionLabel;
        private System.Windows.Forms.ToolStripMenuItem USBCheckerMenu;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label BroadcasterPortLabel;
    }
}

