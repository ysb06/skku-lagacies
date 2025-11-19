using System;
using System.Windows.Forms;
using BLESerial.BLEduinoUsbSerial;
using InTheHand.Windows.Forms;
using BLESerial.BLEduinoBluetooth;
using InTheHand.Net.Bluetooth;
using InTheHand.Net.Sockets;
using System.Collections.Generic;
using System.Net.Sockets;
using BLESerial.Network;
using BLESerial.USBChecker;

namespace BLESerial
{
    public enum RunningMode { NONE, BLEDUINO_SERIAL, BLEDUINO_BLUETOOTH_SERIAL }

    public partial class MainForm : Form
    {
        private RunningMode currentMode = RunningMode.NONE;
        private BleduinoManager bManager;

        private List<string> commandList;
        private int commandListCursor = 0;

        private Broadcaster broadcaster;

        public MainForm()
        {
            InitializeComponent();
            bManager = BleduinoManager.GetManager();
            commandList = new List<string>();
            
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            //*
            #region BLEduino 관련 초기화 코드 (BLEduino Initializing Code)
            bManager.SerialPortMessageReceived += SerialPort_Recevie;
            bManager.SystemEventOcurred += SerialPortManager_GetMessage;
            bManager.Deactivated += BManager_Deactivated;

            string[] portNames = bManager.GetCurrentSerialPortNames();

            RefreshPortList(portNames);
            if (serialPortList.Items.Count > 0)
            {
                serialPortList.SelectedIndex = 0;
            }
            BaudrateBox.SelectedIndex = BaudrateBox.Items.Count - 7;
            #endregion
            //*/
            BroadcasterPortLabel.Text = Broadcaster.PORT_NUMBER.ToString();
        }

        #region 공용 폼 컨트롤 코드(General Form Control Code)

        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            bManager.Dispose();
            if(broadcaster != null)
            {
                broadcaster.Dispose();
            }
        }

        private void InputBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                SendButton_Click(sender, e);
            }
            else if(e.KeyCode == Keys.Up)
            {
                commandListCursor--;
                if(commandListCursor < 0)
                {
                    commandListCursor = 0;
                }
                if(commandList.Count > 0)
                    inputBox.Text = commandList[commandListCursor];
            }
            else if(e.KeyCode == Keys.Down)
            {
                commandListCursor++;
                if (commandListCursor >= commandList.Count)
                {
                    commandListCursor = commandList.Count;
                    inputBox.Text = "";
                }
                else
                {
                    inputBox.Text = commandList[commandListCursor];
                }
            }
        }

        private void SerialPort_Recevie(string serialPortName, string message)
        {
            BeginInvoke(new Action(delegate ()
            {
                consoleBox.AppendText(message);
                if(ConsoleLineEndCheck.Checked)
                {
                    consoleBox.AppendText("\r\n");
                }
            }));
        }

        private void SendButton_Click(object sender, EventArgs e)
        {
            string message = inputBox.Text;
            commandList.Add(message);
            commandListCursor = commandList.Count - 1;
            if (CRCheck.Checked)
                message += "\r";
            if (LFCheck.Checked)
                message += "\n";

            switch(currentMode)
            {
                case RunningMode.BLEDUINO_SERIAL:
                    bManager.SendMessage(message);
                    break;
                case RunningMode.NONE:
                    SerialPort_Recevie(null, "<System>: Nothing Happend");
                    break;
                default:
                    break;
            }
            inputBox.Clear();
        }

        private void QuitMenu_Click(object sender, EventArgs e)
        {
            Close();
        }
        #endregion

        #region BLEduino USB-Serial 직접 연결 관련 코드
        private void ConnectButton_Click(object sender, EventArgs e)
        {
            if (int.TryParse(portBox.Text, out int portNum))
            {
                if (bManager.IsActivated)
                {
                    DisconnectPort(portNum);
                }
                else
                {
                    if (int.TryParse(BaudrateBox.Text, out int baudrate))
                    {
                        ConnectPort(portNum, baudrate);
                    }
                }
            }
        }

        private void ConnectPort(int portNum, int baudrate)
        {
            if (bManager.OpenPort(portNum, baudrate))
            {
                Console.WriteLine("Connected");
                connectButton.Text = "Disconnect";
                portBox.Enabled = false;
                BaudrateBox.Enabled = false;
                serialPortList.Enabled = false;
                currentMode = RunningMode.BLEDUINO_SERIAL;
            }
        }

        private void DisconnectPort(int portNum)
        {
            Console.WriteLine("Disconnecting...");
            if (bManager.ClosePort(portNum))
            {
                Console.WriteLine("Disconnected");
                currentMode = RunningMode.NONE;
            }
        }

        private void BManager_Deactivated(string message)
        {
            BeginInvoke(new Action(delegate ()
            {
                connectButton.Text = "Connect";
                portBox.Enabled = true;
                BaudrateBox.Enabled = true;
                serialPortList.Enabled = true;
            }));
        }

        private void SerialPortManager_GetMessage(int messageCode, string message)
        {
            SerialPort_Recevie(null, "\r\n<Manager(" + messageCode + ")>: " + message + "\r\n");
        }

        private void SerialPortList_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (serialPortList.Text.Length > 3)
                portBox.Text = serialPortList.Text.Substring(3);
        }

        private void RefreshButton_Click(object sender, EventArgs e)
        {
            RefreshPortList(bManager.GetCurrentSerialPortNames());
        }

        private void RefreshPortList(string[] portNames)
        {
            serialPortList.Items.Clear();
            serialPortList.Items.AddRange(portNames);
        }
        #endregion

        #region BLEduino 블루투스 동글

        #endregion

        private void DelayBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsDigit(e.KeyChar) || e.KeyChar == Convert.ToChar(Keys.Back)))    //숫자와 백스페이스를 제외한 나머지를 바로 처리
            {
                e.Handled = true;
            }
        }

        private void DelaySetButton_Click(object sender, EventArgs e)
        {
            if (int.TryParse(DelayBox.Text, out int delay))
            {
                bManager.ReceiveDelay = delay;
            }
        }

        private void ClearMenu_Click(object sender, EventArgs e)
        {
            consoleBox.Clear();
        }

        private void NewWindowMenu_Click(object sender, EventArgs e)
        {
            new MainForm().Show();
        }

        private void BLEduinoMenu_Click(object sender, EventArgs e)
        {
            ATConnector atConnector = new ATConnector();
            atConnector.Show();
        }

        private void BroadcastButton_Click(object sender, EventArgs e)
        {
            if (broadcaster == null)
            {
                broadcaster = new Broadcaster();
                bManager.SerialPortMessageReceived += broadcaster.SerialPort_Recevie;
                SerialPort_Recevie(null, "<System>: Broadcasting activated\r\n");
                ConnectionLabel.Text = "연결 됨";
                BroadcastButton.Text = "브로드캐스트 종료";
            }
            else
            {
                BroadcastButton.Text = "브로드캐스트 시작";
                ConnectionLabel.Text = "연결 해제 됨";
                SerialPort_Recevie(null, "<System>: Broadcasting deactivated\r\n");
                bManager.SerialPortMessageReceived -= broadcaster.SerialPort_Recevie;
                broadcaster.Dispose();
                broadcaster = null;
            }
        }

        private void ClientMenu_Click(object sender, EventArgs e)
        {
            SubClient sub = new SubClient();
            sub.Show();
        }

        private void USBCheckerMenu_Click(object sender, EventArgs e)
        {
            USBCheckerForm form = new USBCheckerForm();
            form.Show();
        }
    }
}
