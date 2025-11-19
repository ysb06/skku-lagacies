using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLESerial
{
    public class CommunicationEventArgs : EventArgs
    {
        public string Message { get; set; }
        public string OriginAddress { get; set; }
    }
}
