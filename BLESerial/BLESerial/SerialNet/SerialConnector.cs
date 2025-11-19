using System;
using System.Collections.Generic;
using System.Text;
using System.IO.Ports;
using System.Threading;
using System.IO;

namespace BLESerial.SerialNet
{
    public enum StandartBaudrate { B110, B300, B600, B1200, B2400, B4800, B9600, B14400, B19200, B28800, B38400, B56000, B57600, B115200,
            B128000, B153600, B230400, B256000, B460800, B921600 }

    public class SerialConnector
    {
        public static int[] StandardBaudrate = { 110, 300, 600, 1200, 2400, 4800, 9600, 14400, 19200, 28800, 38400, 56000, 57600, 115200,
            128000, 153600, 230400, 256000, 460800, 921600 };

        public event NetDataReceivedEventHandler OnDataReceived;
        public event SystemEventHandler OnSystemEventOccurred;

        private SerialPort serialPort;
        private List<Thread> activeNetThreads;

        #region Trasmition Options
        public bool AddLineFeed { get; set; }
        #endregion

        #region Receiving Options
        public int ReceivingDelay { get; set; }

        public bool IsConnected
        {
            get { return serialPort.IsOpen; }
        }
        public string Name { get; private set; }
        #endregion

        public SerialConnector(int port, int baudrate)
        {
            serialPort = new SerialPort
            {
                PortName = "COM" + port,
                BaudRate = baudrate,
                Parity = Parity.None,
                StopBits = StopBits.One,
                Handshake = Handshake.None,
                WriteTimeout = 5000
            };
            Name = serialPort.PortName;
        }

        public SerialConnector(int port, StandartBaudrate baudrate)
        {
            serialPort = new SerialPort
            {
                PortName = "COM" + port,
                BaudRate = StandardBaudrate[(int)baudrate],
                Parity = Parity.None,
                StopBits = StopBits.One,
                Handshake = Handshake.None,
                WriteTimeout = 5000
            };

            Name = serialPort.PortName;
        }


        public void Initialize()
        {
            ReceivingDelay = 0;
            activeNetThreads = new List<Thread>();

            serialPort.DtrEnable = true;
            serialPort.RtsEnable = true;

            serialPort.Open();

            serialPort.DataReceived += SerialPort_DataReceived;
            OnSystemEventOccurred(this, new SystemEventArgs(SystemEvent.Connected, "연결 성공 : " + serialPort.PortName));
        }

        private void SerialPort_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            if (ReceivingDelay != 0)
            {
                Thread receiveThread = new Thread(ReceiveMessage);

                foreach (Thread thread in activeNetThreads)
                {
                    if(!thread.IsAlive)
                    {
                        activeNetThreads.Remove(thread);
                    }
                }
                activeNetThreads.Add(receiveThread);
                receiveThread.Start();

                Console.WriteLine("Active Threads: " + activeNetThreads.Count);
            }
            else
            {
                ReceiveMessage();
            }
        }

        private void ReceiveMessage()
        {
            string bufferString = "";
            bufferString = serialPort.ReadExisting();

            var args = new DataReceivedEventArgs(bufferString, serialPort.PortName, NetStatus.Normal);
            OnDataReceived?.Invoke(this, args);

            Thread.Sleep(ReceivingDelay);
        }

        public void Send(string message)
        {
            try
            {
                serialPort.Write(message);
            }
            catch(TimeoutException)
            {
                OnSystemEventOccurred(this, new SystemEventArgs(SystemEvent.Timeout, "메시지 전송 실패"));
            }
            catch(InvalidOperationException)
            {
                if(serialPort.IsOpen)
                {
                    OnSystemEventOccurred(this, new SystemEventArgs(SystemEvent.Unknown, "알 수 없는 오류"));
                }
                else
                {
                    OnSystemEventOccurred(this, new SystemEventArgs(SystemEvent.Disconnected, "포트 닫힘"));
                }
            }
        }

        public void Dispose()
        {
            serialPort.Close();
            serialPort.Dispose();
        }
    }
}
