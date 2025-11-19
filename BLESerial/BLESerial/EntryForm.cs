using BLESerial.Network;
using BLESerial.USBChecker;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLESerial.AI;
using BLESerial.SerialNet;

namespace BLESerial
{
    public partial class EntryForm : Form
    {
        public EntryForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 메뉴 선택 이벤트 발생 시 제어 코드
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OnMenuStripItems_Click(object sender, EventArgs e)
        {
            if(sender == msiSerialPort)
            {
                SerialCommForm serialFrom = new SerialCommForm();
                lsbModuleList.Items.Add(serialFrom);
                serialFrom.Disposed += Controller_Disposed;
                serialFrom.Show();
            }
            else if(sender == msiTilemap)
            {
                AiController controller = new AiController();
                lsbModuleList.Items.Add(controller);
                controller.Disposed += Controller_Disposed;
                controller.Activate();
            }
            else if(sender == msiUSB)
            {
            }
            else if(sender == msiBroadcast)
            {
            }
            else if(sender == msiQuit)
            {
                Close();
            }
        }

        private void Controller_Disposed(object sender, EventArgs e)
        {
            lsbModuleList.Items.Remove(sender);
        }

        private void EntryForm_Load(object sender, EventArgs e)
        {
            
        }

        private void OnButtonClicked(object sender, EventArgs e)
        {
            MessageBox.Show(((ListViewItem)lsbModuleList.Items[0]).Text);
            Invalidate();
        }
    }
}
