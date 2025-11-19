using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InTheHand.Net;
using InTheHand.Net.Bluetooth;
using InTheHand.Net.Ports;
using InTheHand.Net.Sockets;

namespace BLESerial.BLEduinoBluetooth
{
    public class BluetoothManager
    {
        #region 싱글톤 생성 코드
        private static BluetoothManager instance;

        public static BluetoothManager GetManager()
        {
            if (instance == null)
            {
                instance = new BluetoothManager();
            }
            return instance;
        }
        #endregion

        private BluetoothManager()
        {
            
        }
    }
}
