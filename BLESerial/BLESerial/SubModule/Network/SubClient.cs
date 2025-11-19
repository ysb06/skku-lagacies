using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BLESerial.Network
{
    public partial class SubClient : Form
    {

        private UdpClient udp;
        private IPEndPoint endPoint;

        private IAsyncResult ar;

        public SubClient()
        {
            InitializeComponent();
        }

        private void SubClient_Load(object sender, EventArgs e)
        {
            udp = new UdpClient();
            endPoint = new IPEndPoint(IPAddress.Any, 45000);
            udp.Client.SetSocketOption(SocketOptionLevel.Socket, SocketOptionName.ReuseAddress, true);
            udp.ExclusiveAddressUse = false;
            udp.Client.Bind(endPoint);

            ar = udp.BeginReceive(OnReceive, new object());
        }

        private void OnReceive(IAsyncResult ar)
        {
            if(this.ar == ar)
            {
                Console.WriteLine("Receive OK");
            }
            byte[] raw = udp.EndReceive(ar, ref endPoint);
            string message = Encoding.UTF8.GetString(raw);

            BeginInvoke(new Action(delegate ()
            {
                ClientTextBox.AppendText(message);
            }));

            ar = udp.BeginReceive(OnReceive, new object());
        }


    }
}
