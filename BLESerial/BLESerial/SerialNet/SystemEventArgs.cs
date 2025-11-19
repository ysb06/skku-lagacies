using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLESerial.SerialNet
{
    public class SystemEventArgs : EventArgs
    {
        public SystemEvent EventName { get; }
        public string Description { get; }

        public SystemEventArgs(SystemEvent eventType, string description)
        {
            EventName = eventType;
            Description = description;
        }
    }
}
