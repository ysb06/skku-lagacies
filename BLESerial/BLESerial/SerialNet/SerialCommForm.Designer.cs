namespace BLESerial.SerialNet
{
    partial class SerialCommForm
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
            this.btnSend = new System.Windows.Forms.Button();
            this.txtInput = new System.Windows.Forms.TextBox();
            this.txtConsole = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label12 = new System.Windows.Forms.Label();
            this.lblCurrentConnection = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.lblCurrentConnectionName = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.gbxCommTransfer = new System.Windows.Forms.GroupBox();
            this.cmbForwarder = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.CRCheck = new System.Windows.Forms.CheckBox();
            this.LFCheck = new System.Windows.Forms.CheckBox();
            this.label10 = new System.Windows.Forms.Label();
            this.gbxCommReceive = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.ConsoleLineEndCheck = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.DelayBox = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cmbSerialBaudrate = new System.Windows.Forms.ComboBox();
            this.btnRefreshPortList = new System.Windows.Forms.Button();
            this.lstSerialPort = new System.Windows.Forms.ListBox();
            this.btnSerialConnection = new System.Windows.Forms.Button();
            this.txtSerialPort = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.ttpHelp = new System.Windows.Forms.ToolTip(this.components);
            this.groupBox3.SuspendLayout();
            this.gbxCommTransfer.SuspendLayout();
            this.gbxCommReceive.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSend
            // 
            this.btnSend.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSend.Location = new System.Drawing.Point(697, 526);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(75, 23);
            this.btnSend.TabIndex = 11;
            this.btnSend.Text = "Send";
            this.btnSend.UseVisualStyleBackColor = true;
            this.btnSend.Click += new System.EventHandler(this.OnBtnSend_Click);
            // 
            // txtInput
            // 
            this.txtInput.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtInput.Location = new System.Drawing.Point(346, 528);
            this.txtInput.Name = "txtInput";
            this.txtInput.Size = new System.Drawing.Size(345, 21);
            this.txtInput.TabIndex = 10;
            this.txtInput.KeyUp += new System.Windows.Forms.KeyEventHandler(this.OnTxtInput_KeyUp);
            // 
            // txtConsole
            // 
            this.txtConsole.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtConsole.Location = new System.Drawing.Point(346, 18);
            this.txtConsole.Margin = new System.Windows.Forms.Padding(3, 9, 3, 3);
            this.txtConsole.Multiline = true;
            this.txtConsole.Name = "txtConsole";
            this.txtConsole.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtConsole.Size = new System.Drawing.Size(426, 502);
            this.txtConsole.TabIndex = 9;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label12);
            this.groupBox3.Controls.Add(this.lblCurrentConnection);
            this.groupBox3.Controls.Add(this.label11);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.lblCurrentConnectionName);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Location = new System.Drawing.Point(18, 410);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(9);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(316, 139);
            this.groupBox3.TabIndex = 17;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "상태";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(130, 109);
            this.label12.Margin = new System.Windows.Forms.Padding(3, 10, 3, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(61, 12);
            this.label12.TabIndex = 2;
            this.label12.Text = "Undefined";
            // 
            // lblCurrentConnection
            // 
            this.lblCurrentConnection.AutoSize = true;
            this.lblCurrentConnection.Location = new System.Drawing.Point(130, 68);
            this.lblCurrentConnection.Margin = new System.Windows.Forms.Padding(3, 10, 3, 0);
            this.lblCurrentConnection.Name = "lblCurrentConnection";
            this.lblCurrentConnection.Size = new System.Drawing.Size(61, 12);
            this.lblCurrentConnection.TabIndex = 2;
            this.lblCurrentConnection.Text = "Undefined";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(11, 109);
            this.label11.Margin = new System.Windows.Forms.Padding(3, 10, 3, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(113, 12);
            this.label11.TabIndex = 3;
            this.label11.Text = "브로드캐스팅 상태: ";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(59, 68);
            this.label9.Margin = new System.Windows.Forms.Padding(3, 10, 3, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(65, 12);
            this.label9.TabIndex = 3;
            this.label9.Text = "연결 상태: ";
            // 
            // lblCurrentConnectionName
            // 
            this.lblCurrentConnectionName.AutoSize = true;
            this.lblCurrentConnectionName.Location = new System.Drawing.Point(130, 27);
            this.lblCurrentConnectionName.Margin = new System.Windows.Forms.Padding(3, 10, 3, 0);
            this.lblCurrentConnectionName.Name = "lblCurrentConnectionName";
            this.lblCurrentConnectionName.Size = new System.Drawing.Size(61, 12);
            this.lblCurrentConnectionName.TabIndex = 1;
            this.lblCurrentConnectionName.Text = "Undefined";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(59, 27);
            this.label6.Margin = new System.Windows.Forms.Padding(3, 10, 3, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 12);
            this.label6.TabIndex = 1;
            this.label6.Text = "연결 이름: ";
            // 
            // gbxCommTransfer
            // 
            this.gbxCommTransfer.Controls.Add(this.cmbForwarder);
            this.gbxCommTransfer.Controls.Add(this.label3);
            this.gbxCommTransfer.Controls.Add(this.CRCheck);
            this.gbxCommTransfer.Controls.Add(this.LFCheck);
            this.gbxCommTransfer.Controls.Add(this.label10);
            this.gbxCommTransfer.Location = new System.Drawing.Point(18, 155);
            this.gbxCommTransfer.Margin = new System.Windows.Forms.Padding(9);
            this.gbxCommTransfer.Name = "gbxCommTransfer";
            this.gbxCommTransfer.Padding = new System.Windows.Forms.Padding(6);
            this.gbxCommTransfer.Size = new System.Drawing.Size(316, 80);
            this.gbxCommTransfer.TabIndex = 15;
            this.gbxCommTransfer.TabStop = false;
            this.gbxCommTransfer.Text = "전송";
            this.ttpHelp.SetToolTip(this.gbxCommTransfer, "열려있는 다른 연결의 출력을 현재 연결의 입력으로 전달합니다.");
            // 
            // cmbForwarder
            // 
            this.cmbForwarder.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbForwarder.FormattingEnabled = true;
            this.cmbForwarder.Items.AddRange(new object[] {
            "(없음)"});
            this.cmbForwarder.Location = new System.Drawing.Point(72, 49);
            this.cmbForwarder.Margin = new System.Windows.Forms.Padding(3, 7, 3, 3);
            this.cmbForwarder.Name = "cmbForwarder";
            this.cmbForwarder.Size = new System.Drawing.Size(218, 20);
            this.cmbForwarder.TabIndex = 2;
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
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(9, 52);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(57, 12);
            this.label10.TabIndex = 0;
            this.label10.Text = "모듈 연결";
            // 
            // gbxCommReceive
            // 
            this.gbxCommReceive.Controls.Add(this.groupBox2);
            this.gbxCommReceive.Controls.Add(this.ConsoleLineEndCheck);
            this.gbxCommReceive.Controls.Add(this.label4);
            this.gbxCommReceive.Controls.Add(this.DelayBox);
            this.gbxCommReceive.Location = new System.Drawing.Point(18, 253);
            this.gbxCommReceive.Margin = new System.Windows.Forms.Padding(9);
            this.gbxCommReceive.Name = "gbxCommReceive";
            this.gbxCommReceive.Padding = new System.Windows.Forms.Padding(6);
            this.gbxCommReceive.Size = new System.Drawing.Size(316, 139);
            this.gbxCommReceive.TabIndex = 14;
            this.gbxCommReceive.TabStop = false;
            this.gbxCommReceive.Text = "수신";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Controls.Add(this.textBox1);
            this.groupBox2.Location = new System.Drawing.Point(18, 65);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(12, 18, 12, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(5);
            this.groupBox2.Size = new System.Drawing.Size(280, 60);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "브로드캐스팅";
            this.ttpHelp.SetToolTip(this.groupBox2, "외부 프로그램에서도 확인할 수 있도록 TCP/IP 프로토콜로 브로드캐스팅합니다.");
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(8, 29);
            this.label5.Margin = new System.Windows.Forms.Padding(3, 10, 3, 10);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 12);
            this.label5.TabIndex = 6;
            this.label5.Text = "포트: ";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(199, 24);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 10, 3, 10);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(73, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "연결";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(51, 25);
            this.textBox1.Margin = new System.Windows.Forms.Padding(3, 10, 3, 10);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(142, 21);
            this.textBox1.TabIndex = 5;
            // 
            // ConsoleLineEndCheck
            // 
            this.ConsoleLineEndCheck.AutoSize = true;
            this.ConsoleLineEndCheck.Location = new System.Drawing.Point(156, 25);
            this.ConsoleLineEndCheck.Margin = new System.Windows.Forms.Padding(3, 12, 3, 3);
            this.ConsoleLineEndCheck.Name = "ConsoleLineEndCheck";
            this.ConsoleLineEndCheck.Size = new System.Drawing.Size(142, 16);
            this.ConsoleLineEndCheck.TabIndex = 3;
            this.ConsoleLineEndCheck.Text = "Line End with CR/LF";
            this.ConsoleLineEndCheck.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 26);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 12);
            this.label4.TabIndex = 1;
            this.label4.Text = "Delay";
            // 
            // DelayBox
            // 
            this.DelayBox.Location = new System.Drawing.Point(59, 23);
            this.DelayBox.Name = "DelayBox";
            this.DelayBox.Size = new System.Drawing.Size(53, 21);
            this.DelayBox.TabIndex = 1;
            this.DelayBox.Text = "0";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cmbSerialBaudrate);
            this.groupBox1.Controls.Add(this.btnRefreshPortList);
            this.groupBox1.Controls.Add(this.lstSerialPort);
            this.groupBox1.Controls.Add(this.btnSerialConnection);
            this.groupBox1.Controls.Add(this.txtSerialPort);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(18, 18);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(9);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(316, 119);
            this.groupBox1.TabIndex = 16;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Serial 연결";
            // 
            // cmbSerialBaudrate
            // 
            this.cmbSerialBaudrate.FormattingEnabled = true;
            this.cmbSerialBaudrate.Items.AddRange(new object[] {
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
            this.cmbSerialBaudrate.Location = new System.Drawing.Point(101, 53);
            this.cmbSerialBaudrate.Name = "cmbSerialBaudrate";
            this.cmbSerialBaudrate.Size = new System.Drawing.Size(90, 20);
            this.cmbSerialBaudrate.TabIndex = 5;
            // 
            // btnRefreshPortList
            // 
            this.btnRefreshPortList.Location = new System.Drawing.Point(197, 79);
            this.btnRefreshPortList.Name = "btnRefreshPortList";
            this.btnRefreshPortList.Size = new System.Drawing.Size(100, 32);
            this.btnRefreshPortList.TabIndex = 4;
            this.btnRefreshPortList.Text = "Refresh";
            this.btnRefreshPortList.UseVisualStyleBackColor = true;
            this.btnRefreshPortList.Click += new System.EventHandler(this.OnBtnRefreshPortList_Click);
            // 
            // lstSerialPort
            // 
            this.lstSerialPort.FormattingEnabled = true;
            this.lstSerialPort.ItemHeight = 12;
            this.lstSerialPort.Location = new System.Drawing.Point(197, 21);
            this.lstSerialPort.Name = "lstSerialPort";
            this.lstSerialPort.Size = new System.Drawing.Size(100, 52);
            this.lstSerialPort.TabIndex = 0;
            this.lstSerialPort.SelectedIndexChanged += new System.EventHandler(this.OnLstSerialPort_SelectedIndexChanged);
            // 
            // btnSerialConnection
            // 
            this.btnSerialConnection.Location = new System.Drawing.Point(15, 79);
            this.btnSerialConnection.Margin = new System.Windows.Forms.Padding(3, 6, 3, 3);
            this.btnSerialConnection.Name = "btnSerialConnection";
            this.btnSerialConnection.Size = new System.Drawing.Size(176, 32);
            this.btnSerialConnection.TabIndex = 3;
            this.btnSerialConnection.Text = "Connect";
            this.btnSerialConnection.UseVisualStyleBackColor = true;
            this.btnSerialConnection.Click += new System.EventHandler(this.OnBtnSerialConnectionClick);
            // 
            // txtSerialPort
            // 
            this.txtSerialPort.Location = new System.Drawing.Point(101, 24);
            this.txtSerialPort.Name = "txtSerialPort";
            this.txtSerialPort.Size = new System.Drawing.Size(90, 21);
            this.txtSerialPort.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 56);
            this.label2.Name = "label2";
            this.label2.Padding = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.label2.Size = new System.Drawing.Size(67, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Baudrate : ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 24);
            this.label1.Name = "label1";
            this.label1.Padding = new System.Windows.Forms.Padding(0, 10, 0, 0);
            this.label1.Size = new System.Drawing.Size(80, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "포트(COM) : ";
            // 
            // ttpHelp
            // 
            this.ttpHelp.IsBalloon = true;
            this.ttpHelp.ShowAlways = true;
            // 
            // SerialCommForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.gbxCommTransfer);
            this.Controls.Add(this.gbxCommReceive);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnSend);
            this.Controls.Add(this.txtInput);
            this.Controls.Add(this.txtConsole);
            this.HelpButton = true;
            this.MaximumSize = new System.Drawing.Size(1600, 600);
            this.MinimumSize = new System.Drawing.Size(16, 600);
            this.Name = "SerialCommForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Serial Port";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.SerialCommForm_FormClosed);
            this.Load += new System.EventHandler(this.SerialCommForm_Load);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.gbxCommTransfer.ResumeLayout(false);
            this.gbxCommTransfer.PerformLayout();
            this.gbxCommReceive.ResumeLayout(false);
            this.gbxCommReceive.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.TextBox txtInput;
        private System.Windows.Forms.TextBox txtConsole;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label lblCurrentConnection;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lblCurrentConnectionName;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox gbxCommTransfer;
        private System.Windows.Forms.ComboBox cmbForwarder;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox CRCheck;
        private System.Windows.Forms.CheckBox LFCheck;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.GroupBox gbxCommReceive;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.CheckBox ConsoleLineEndCheck;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox DelayBox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cmbSerialBaudrate;
        private System.Windows.Forms.Button btnRefreshPortList;
        private System.Windows.Forms.ListBox lstSerialPort;
        private System.Windows.Forms.Button btnSerialConnection;
        private System.Windows.Forms.TextBox txtSerialPort;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolTip ttpHelp;
    }
}