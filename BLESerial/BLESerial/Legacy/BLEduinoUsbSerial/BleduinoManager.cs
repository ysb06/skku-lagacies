using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace BLESerial.BLEduinoUsbSerial
{
    //추후 이벤트 형식을 통일 시키는 것을 고려
    //예) 매니저 이름(string), 이벤트 정보 객체
    public delegate void ManagerEventHandler(int statusCode, string message);
    public delegate void SerialReceivingEventHandler(string serialPortName, string message);
    public delegate void ActivationEventHandler(string message);

    public class BleduinoManager
    {
        /// <summary>
        /// BLEduino 관리 싱글톤 객체
        /// </summary>
        private static BleduinoManager instance;

        /// <summary>
        /// Bleduino 관리 객체를 가져옵니다.
        /// </summary>
        /// <returns></returns>
        public static BleduinoManager GetManager()
        {
            if (instance == null)
            {
                instance = new BleduinoManager();
            }
            return instance;
        }

        public event ManagerEventHandler SystemEventOcurred;
        public event SerialReceivingEventHandler SerialPortMessageReceived;
        public event ActivationEventHandler Deactivated;

        private List<SerialPort> serialPorts;
        private Thread thread;
        public bool IsActivated { get; private set; }
        private SerialPort currentActivatedPort = null;

        private int receiveDelay = 0;
        public int ReceiveDelay
        {
            get { return receiveDelay; }
            set {
                SystemEventOcurred?.Invoke(15, "Receive Delay Set to " + value);
                receiveDelay = value;
            }
        }
        private Thread receiveThread;

        private BleduinoManager()
        {
            serialPorts = new List<SerialPort>();
        }

        public bool OpenPort(int portNumber, int baudrate)
        {
            //시리얼 포트 열기, 이미 얻어진 시리얼포트가 있는 경우에는 해당 포트를 찾아서 열기
            SerialPort serialPort = null;
            foreach (SerialPort port in serialPorts)
            {
                if (int.TryParse(port.PortName.Substring(3), out int portNum))
                {
                    if (portNum == portNumber)
                    {
                        if (port.IsOpen)
                        {
                            SystemEventOcurred?.Invoke(12, "The serial port is already opened in " + port.PortName);
                            if (thread == null)
                            {
                                thread = new Thread(CheckConnection);
                                IsActivated = true;
                                thread.Start();
                            }
                            SystemEventOcurred?.Invoke(13, "Reactivated Manager");
                            return true;
                        }
                        else
                        {
                            Console.WriteLine("Reusing " + port.PortName + "...");
                            serialPort = port;
                            serialPort.BaudRate = baudrate;
                        }

                    }

                }
            }

            if (serialPort == null)
            {
                serialPort = new SerialPort
                {
                    PortName = "COM" + portNumber,
                    BaudRate = baudrate,
                    Parity = Parity.None,
                    StopBits = StopBits.One,
                    Handshake = Handshake.None,
                    WriteTimeout = 5000
                };
            }
            //---------------//

            serialPort.RtsEnable = true;
            serialPort.DtrEnable = true;

            try
            {
                serialPort.Open();
            }
            catch (UnauthorizedAccessException e)
            {
                Console.WriteLine(e);
                SystemEventOcurred?.Invoke(2, "Failed to connect. The port is may be in use.");
                return false;
            }
            catch (IOException e)
            {
                SystemEventOcurred?.Invoke(9, "Failed to connect. There is no such port named " + serialPort.PortName);
                Console.WriteLine(e);
                return false;
            }
            if(!serialPorts.Contains(serialPort))
            {
                serialPorts.Add(serialPort);
            }

            currentActivatedPort = serialPort;
            currentActivatedPort.DataReceived += CurrentActivatedPort_DataReceived;
            //*
            if (thread == null)
            {
                thread = new Thread(CheckConnection);
                IsActivated = true;
                thread.Start();
            }
            //*/
            SystemEventOcurred?.Invoke(1, "Success to open the port");
            SystemEventOcurred?.Invoke(14, "Current --> (" + serialPort.PortName + ", " + serialPort.BaudRate + ")");
            return true;
        }

        private void CurrentActivatedPort_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            if (receiveDelay != 0)
            {
                if (receiveThread == null || !receiveThread.IsAlive)
                {
                    receiveThread = new Thread(ReceiveMessage);
                    receiveThread.Start();
                }
            }
            else
            {
                ReceiveMessage();
            }
        }

        private void ReceiveMessage()
        {
            Console.WriteLine("Receive(" + currentActivatedPort.PortName + "): " + currentActivatedPort.BytesToRead);
            string bufferString = "";
            bufferString = currentActivatedPort.ReadExisting();
            SerialPortMessageReceived?.Invoke(currentActivatedPort.PortName, bufferString);
            Console.WriteLine(bufferString);

            Thread.Sleep(receiveDelay);
        }



        private void CheckConnection()
        {
            //string bufferString = "";
            Stopwatch watch = new Stopwatch();
            watch.Start();
            long prevTime = watch.ElapsedMilliseconds;

            while (IsActivated)
            {
                if (watch.ElapsedMilliseconds - prevTime > 1000)
                {
                    prevTime = watch.ElapsedMilliseconds;
                    foreach (SerialPort port in serialPorts)
                    {
                        try
                        {
                            /*
                            if (port == currentActivatedPort)
                            {
                                if (port.BytesToRead > 0)
                                {
                                    Console.WriteLine("Receive(" + port.PortName + "): " + port.BytesToRead);
                                    bufferString = port.ReadExisting();
                                    SerialPortMessageReceived?.Invoke(port.PortName, bufferString);
                                    Console.WriteLine(bufferString);
                                }
                            }
                            //*/
                            int temp = port.BytesToRead;
                        }
                        catch (InvalidOperationException)
                        {
                            SystemEventOcurred?.Invoke(10, "Unexpected serial port close");
                            SystemEventOcurred?.Invoke(4, "The BLEduino may disconnect the connection");

                            AbortPort(port);
                        }
                        catch (IOException)
                        {
                            SystemEventOcurred?.Invoke(11, "Problem with the BLEduino");
                            SystemEventOcurred?.Invoke(4, "The BLEduino may disconnect the connection");

                            AbortPort(port);
                        }
                    }
                }
                Thread.Sleep(0);
            }
            Console.WriteLine("Thread finalizing...");
            Deactivated?.Invoke("BLEduino Manager");
        }

        private void AbortPort(SerialPort port)
        {
            //다중 연결을 고려하지 않음. 추후 수정 필요
            //굳이 이 부분을 손대지 않고 포트 당 스레드 여러개를 만들어서 관리하는 것이 더 좋을 수 있음
            port.Close();
            IsActivated = false;
            Thread temp = thread;
            thread = null;
            Deactivated?.Invoke("BLEduino Manager_Error");
            temp.Abort();
        }

        public void SendMessage(string message)
        {
            if (serialPorts.Count > 0)
            {
                if (int.TryParse(currentActivatedPort.PortName.Substring(3), out int portNum))
                {
                    SendMessage(message, portNum);
                }
            }
        }

        public void SendMessage(string message, int targetPortNumber)
        {
            if(serialPorts.Count > 0)
            {
                foreach (SerialPort port in serialPorts)
                {
                    if (int.TryParse(port.PortName.Substring(3), out int portNum))
                    {
                        if (portNum == targetPortNumber)
                        {
                            if (port.IsOpen)
                            {
                                try
                                {
                                    port.Write(message);
                                }
                                catch (TimeoutException)
                                {
                                    SystemEventOcurred?.Invoke(16, "Error --> Write Timeout");
                                }
                                /*
                                if(message.Length > 0)
                                {
                                    int t1 = message[message.Length - 1];
                                    int t2 = 0;
                                    if (message.Length > 1)
                                    {
                                        t2 = message[message.Length - 2];
                                    }
                                    message += "<" + t1 + "><" + t2 + ">";
                                }
                                //*/
                                SystemEventOcurred?.Invoke(3, "--> " + message);
                            }
                            else
                            {
                                Console.WriteLine("BleduinoManager(Warning) : The serial port is closed");
                                SystemEventOcurred?.Invoke(5, "The port is closed. Open the port, please.");
                            }
                        }
                    }
                }
            }
            else
            {
                Console.WriteLine("BleduinoManager(Warning) : There is no connected serial port");
            }
        }


        public bool ClosePort(int portNumber)
        {
            foreach (SerialPort port in serialPorts)
            {
                if (port.PortName.Equals("COM" + portNumber))
                {
                    Console.WriteLine("Found Target");
                    return ClosePort(port);
                }
            }
            SystemEventOcurred?.Invoke(6, "Unknow serial port number. Please reboot this program.");
            return false;
        }
        
        private bool ClosePort(SerialPort serialPort)
        {
            //주의 : 현재 코드는 다중 연결 상황을 고려하지 않았음. 추후 수정 필요
            try
            {
                IsActivated = false;
                thread.Join();
                serialPort.Close();
                thread = null;
                SystemEventOcurred?.Invoke(7, serialPort.PortName + " Port is closed");
                return true;
            }
            catch (Exception e)
            {
                SystemEventOcurred?.Invoke(0, e.ToString());
                SystemEventOcurred?.Invoke(8, "Unknown serial port status. You may need to reboot this program.");
                return false;
            }
        }

        public void Dispose()
        {
            IsActivated = false;
            if (thread != null)
            {
                thread.Join();
            }

            foreach (SerialPort target in serialPorts)
            {
                target.Close();
            }
        }

        public string[] GetCurrentSerialPortNames()
        {
            string[] portNames = SerialPort.GetPortNames();
            return portNames;
        }

        public bool GetSerialPortOpened(int portNumber)
        {
            string requestedPortName = "COM" + portNumber;
            foreach (SerialPort port in serialPorts)
            {
                if(port.PortName.Equals(requestedPortName))
                {
                    if(port.IsOpen)
                    {
                        return true;
                    }
                }
            }
            return false;
        }
    }
}

/********** Status 코드 **********
 * 0: Runtime 에러 메시지
 * 1: 연결 성공
 * 2: 연결 실패(포트 사용 중)
 * 3: 시리얼 포트에 송신한 메시지 Echo
 * 4: 연결 끊어짐(BLEduino 에서 끊김)
 * 5: 전송 실패(포트가 열리지 않음)
 * 6: 포트 닫기 실패(닫기 요청된 포트 번호가 연결 시리얼 포트 리스트에 없음)
 * 7: 포트 닫기 성공
 * 8: 포트 닫는 중 에러 발생
 * 9: 연결 실패(해당 포트 없음)
 * 10: 연결 끊어짐 이유 1 (바이트 읽을 수 없음)
 * 11: 연결 끊어짐 이유 2 (동작 에러)
 * 12: 포트 이미 열려 있음
 * 13: 매니저를 다시 Activate함
 * 14: 현재 포트 상태 출력
 * 15: Delay 속성 변경 알림
 * 16: 쓰기 시간 초과
 *********************************/
