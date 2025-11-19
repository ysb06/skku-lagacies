using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Sockets;
using System.Net;

namespace BLESerial.Network
{
    public class Broadcaster
    {
        public const int PORT_NUMBER = 45000;

        private UdpClient udp;
        private readonly IPEndPoint endPoint;

        public Broadcaster()
        {
            udp = new UdpClient();
            endPoint = new IPEndPoint(IPAddress.Broadcast, PORT_NUMBER);
            udp.Client.SetSocketOption(SocketOptionLevel.Socket, SocketOptionName.ReuseAddress, true);
        }

        public void SerialPort_Recevie(string serialPortName, string message)
        {
            byte[] data = Encoding.ASCII.GetBytes(message);
            udp.Send(data, data.Length, endPoint);
        }

        public void Dispose()
        {
            udp.Close();
        }
    }
}
