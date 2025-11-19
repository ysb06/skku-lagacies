using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Management;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BLESerial.USBChecker
{
    public partial class USBCheckerForm : Form
    {
        public USBCheckerForm()
        {
            InitializeComponent();
        }

        private void USBCheckerForm_Load(object sender, EventArgs e)
        {
            UpdateList();
        }

        private void DeviceListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            USBDeviceInfo info = new USBDeviceInfo();
            try
            {
                info = (USBDeviceInfo)DeviceListBox.SelectedItem;
            }
            catch { }

            VidLabel.Text = info.DeviceID;
            PidLabel.Text = info.PNPDeviceID;
            DesLabel.Text = info.Description;
        }

        private void RefreshButton_Click(object sender, EventArgs e)
        {
            DeviceListBox.Items.Clear();
            UpdateList();
        }

        private void UpdateList()
        {
            List<USBDeviceInfo> devices = new List<USBDeviceInfo>();
            var searcher = new ManagementObjectSearcher(@"Select * From Win32_USBHub");
            ManagementObjectCollection collection = searcher.Get();

            foreach (var device in collection)
            {
                devices.Add(new USBDeviceInfo()
                {
                    DeviceID = device.GetPropertyValue("DeviceID").ToString(),
                    PNPDeviceID = device.GetPropertyValue("PNPDeviceID").ToString(),
                    Description = device.GetPropertyValue("Description").ToString(),
                });
            }
            collection.Dispose();

            foreach (var device in devices)
            {
                DeviceListBox.Items.Add(device);
            }
        }
    }

    public struct USBDeviceInfo
    {
        public string DeviceID;
        public string PNPDeviceID;
        public string Description;

        public override string ToString()
        {
            return Description;
        }
    }
}
