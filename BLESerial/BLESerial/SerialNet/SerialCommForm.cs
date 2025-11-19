using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLESerial.SerialNet;

namespace BLESerial.SerialNet
{
    public partial class SerialCommForm : Form, IModule
    {
        private SerialConnector connector;
        private List<string> pastCommandList;
        private int commandCursor = 0;

        public string ModuleName {
            get
            {
                if(connector != null)
                {
                    if (connector.IsConnected)
                    {
                        return "Serial Port " + connector.Name;
                    }
                    else
                    {
                        return "Serial Port";
                    }
                }
                else
                {
                    return "Serial Port";
                }
            }
        }

        public event CommunicationEventHandler OnMessageBroadcasted;

        public SerialCommForm()
        {
            InitializeComponent();
            pastCommandList = new List<string>();
        }

        private void OnBtnSerialConnectionClick(object sender, EventArgs e)
        {
            if(!int.TryParse(txtSerialPort.Text, out int port))
            {
                port = 0;
            }

            if (!int.TryParse(cmbSerialBaudrate.Text, out int baudrate))
            {
                baudrate = 9600;
            }

            //*
            connector = new SerialConnector(port, baudrate);
            connector.OnDataReceived += Connector_DataReceived;
            connector.OnSystemEventOccurred += Connector_SystemEventOccurred;
            connector.Initialize();
            //*/

            txtSerialPort.Enabled = false;
            cmbSerialBaudrate.Enabled = false;
            btnSerialConnection.Enabled = false;
            btnRefreshPortList.Enabled = false;
            lstSerialPort.Enabled = false;

            UpdateStatus();
            Text = ModuleName;
        }

        private void Connector_SystemEventOccurred(object sender, SystemEventArgs e)
        {
            string message = e.EventName + ": " + e.Description;
            switch(e.EventName)
            {
                case SystemEvent.Connected:
                    message = "Normal: (Connected) '" + connector.Name + "'에 연결되었습니다.";
                    break;
                case SystemEvent.Disconnected:
                    message = "Error: (Disconnected) 현재 연결을 닫고 새 연결을 만드세요";
                    break;
                case SystemEvent.Timeout:
                    message = "Error: (Timeout) 응답시간이 초과되었습니다";
                    break;
            }

            BeginInvoke(new Action(delegate ()
            {
                txtConsole.AppendText(message + "\r\n");
                UpdateStatus();
            }));
        }

        private void Connector_DataReceived(object sender, DataReceivedEventArgs e)
        {
            BeginInvoke(new Action(delegate ()
            {
                CommunicationEventArgs ce = new CommunicationEventArgs
                {
                    Message = e.Message,
                    OriginAddress = e.Origin
                };
                OnMessageBroadcasted?.Invoke(this, ce);
                txtConsole.AppendText(e.Message);
                if (ConsoleLineEndCheck.Checked)
                {
                    txtConsole.AppendText("\r\n");
                }
            }));
        }

        private void SerialCommForm_Load(object sender, EventArgs e)
        {
            lstSerialPort.Items.AddRange(SerialPort.GetPortNames());
            if (lstSerialPort.Items.Count > 0)
            {
                lstSerialPort.SelectedIndex = 0;
            }
            cmbSerialBaudrate.SelectedIndex = 11;
            UpdateStatus();
        }

        private void OnBtnRefreshPortList_Click(object sender, EventArgs e)
        {
            lstSerialPort.Items.Clear();
            lstSerialPort.Items.AddRange(SerialPort.GetPortNames());
        }

        private void OnLstSerialPort_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstSerialPort.SelectedItem != null)
            {
                txtSerialPort.Text = ((string)lstSerialPort.SelectedItem).Substring(3);
            }
        }

        private void UpdateStatus()
        {
            if(connector != null)
            {
                if (connector.IsConnected)
                {
                    lblCurrentConnection.Text = "연결됨";
                }
                else
                {
                    lblCurrentConnection.Text = "연결되지 않음";
                }
                lblCurrentConnectionName.Text = connector.Name;
            }
            else
            {
                lblCurrentConnection.Text = "초기화되지 않음";
            }
        }

        private void OnTxtInput_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter && !txtInput.Text.Equals(""))
            {
                OnBtnSend_Click(sender, e);
            }

            if (e.KeyCode == Keys.Up)
            {
                if (commandCursor > 0)
                {
                    commandCursor--;
                }
                if(commandCursor > 0 && commandCursor < pastCommandList.Count)
                    txtInput.Text = pastCommandList[commandCursor];
            }
            else if(e.KeyCode == Keys.Down)
            {
                if (commandCursor < pastCommandList.Count - 1)
                {
                    commandCursor++;
                }
                if (commandCursor > 0 && commandCursor < pastCommandList.Count)
                    txtInput.Text = pastCommandList[commandCursor];
            }
            else
            {
                commandCursor = pastCommandList.Count;
            }
        }

        private void OnBtnSend_Click(object sender, EventArgs e)
        {
            if (connector != null)
            {
                connector.Send(txtInput.Text);
            }
            pastCommandList.Add(txtInput.Text);
            txtInput.Text = "";
        }

        private void SerialCommForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (connector != null)
            {
                connector.Dispose();
            }
        }

        public void ReceiveMessage(string message)
        {
            connector.Send(message);
        }

        public override string ToString()
        {
            return ModuleName;
        }
    }
}
