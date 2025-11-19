using System;
using System.Collections.Generic;
using System.Text;

namespace BLESerialCore.Serial
{
    public enum StandardBaudrate { B110, B300, B600, B1200, B2400, B4800, B9600, B14400, B19200, B28800, B38400, B56000, B57600, B115200,
            B128000, B153600, B230400, B256000, B460800, B921600 };

    public class SerialReceiver
    {
        public int[] StandardBaudrate = { 110, 300, 600, 1200, 2400, 4800, 9600, 14400, 19200, 28800, 38400, 56000, 57600, 115200,
            128000, 153600, 230400, 256000, 460800, 921600 };

        public SerialReceiver(int port, int baudrate)
        {

        }
    }
}
