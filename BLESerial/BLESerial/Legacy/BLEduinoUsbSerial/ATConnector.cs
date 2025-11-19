using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace BLESerial.BLEduinoUsbSerial
{
    public enum ATCommand {CHECK, VERSION, HELP, NAME, BAUDRATE, RENEW, ROLE, SCAN, CONNECT, MAC, TRANSMIT_MODE};

    public partial class ATConnector : Form
    {
        private BleduinoManager bManager;
        private string status = "BLEduino 연결중...";
        private int statusCode = 0;

        private Queue<ATCommand> workList;

        public ATConnector()
        {
            InitializeComponent();
            workList = new Queue<ATCommand>();
        }

        private void ATConnector_Load(object sender, EventArgs e)
        {
            

            bManager = BleduinoManager.GetManager();
            if (bManager.IsActivated)
            {
                bManager.SerialPortMessageReceived += BManager_SerialPortMessageReceived;
                bManager.SystemEventOcurred += BManager_SystemEventOcurred;
                bManager.SendMessage("AT");
            }
            else
            {
                MessageBox.Show("먼저 포트를 연결해 주세요", "아두이노 접속 실패", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Close();
            }
            CountTimer.Start();
        }

        private void BManager_SystemEventOcurred(int statusCode, string message)
        {
            if (statusCode == 4)
            {
                BeginInvoke(new Action(delegate ()
                {
                    Close();
                }));
                MessageBox.Show("연결이 끊겼습니다. 다시 시도해 주세요.", "연결 끊김", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool isDeviceFound = false;
        private int count = 0;

        private void BManager_SerialPortMessageReceived(string serialPortName, string message)
        {
            if (message.Contains("OK"))
            {
                bManager.SendMessage("AT+SCAN");
                status = "기기 찾는 중";
                counter = 0;
                counting = false;
                statusCode = 1;
            }

            if (message.Contains("B_SLAVE"))
            {
                status = "B_SLAVE 기기 발견함";
                isDeviceFound = true;
            }

            if (message.Contains("finished!"))
            {
                if(isDeviceFound)
                {
                    bManager.SendMessage("AT+CON 1");
                    status = "기기 연결 중";
                }
                else
                {
                    count++;
                    if (count > 5)
                    {
                        status = "연결 중입니다만, 연결이 제대로 되지 않는 것 같습니다.\n수신부 및 원격에 있는 아두이노의 전원을 뺐다 다시껴서 리셋 후 다시 시도해 주세요.";
                    }
                    bManager.SendMessage("AT+SCAN");
                }
            }

            if (message.Contains("ok!"))
            {
                status = "기기 연결 완료";
                Close();
            }
        }

        private void ATConnector_FormClosed(object sender, FormClosedEventArgs e)
        {
            bManager.SerialPortMessageReceived -= BManager_SerialPortMessageReceived;
            bManager.SystemEventOcurred -= BManager_SystemEventOcurred;
        }

        private void StopButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        int counter = 0;
        bool counting = false;
        private void CountTimer_Tick(object sender, EventArgs e)
        {
            switch (statusCode)
            {
                case 0:
                    if(counter == 0)
                    {
                        counting = true;
                    }
                    else if(counter > 30)
                    {
                        status = "시리얼 통신은 정상이나\n기기에서 응답이 오지 않습니다.\n이미 연결되었을 수도 있습니다.";
                    }
                    break;
                case 1:
                    if (counter == 0)
                    {
                        counting = true;
                    }
                    else if (counter > 50)
                    {
                        status = "기기가 검색되지 않고 있습니다." +
                            "\n\n기기 이름이 잘못되었을 수도 있습니다." +
                            "\n이 경우 기기 이름을 B_SLAVE로 재설정해 주세요" +
                            "\n\n또는 기기를 재부팅해 보세요";
                    }
                    break;
            }

            if (counting)
            {
                counter++;
            }
            else
            {
                counter = 0;
            }
            statusLabel.Text = status;
            //runTask();
        }

        private void runTask()
        {
            if(workList.Count > 0)
            {
                switch(workList.Dequeue())
                {
                    case ATCommand.CHECK:
                        break;
                }
            }
        }

        private void statusLabel_Click(object sender, EventArgs e)
        {

        }
    }
}
