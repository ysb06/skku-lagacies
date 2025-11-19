using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLESerial.SerialNet
{
    public enum NetStatus { Normal, UnknownError }

    public class DataReceivedEventArgs : EventArgs
    {
        public string Message { get; }
        public string Origin { get; }
        public NetStatus Status { get; }

        public DataReceivedEventArgs(string message, string origin, NetStatus status)
        {
            Message = message;
            Status = status;
        }
    }
}
