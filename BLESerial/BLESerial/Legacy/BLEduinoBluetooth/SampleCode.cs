using InTheHand.Net;
using InTheHand.Net.Bluetooth;
using InTheHand.Net.Sockets;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace BLESerial.BLEduinoBluetooth
{
    public class SampleCode : Form
    {
        private BluetoothClient bc;
        private MainMenu mainMenu1;
        private MenuItem mnuClose;
        private MenuItem menuItem2;
        private ComboBox cmbDevices;
        private MenuItem mnuSearch;
        private MenuItem mnuConnect;
        private Label label1;
        //unique service identifier
        private Guid service = new Guid("{7A51FDC2-FDDF-4c9b-AFFC-98BCD91BF93B}");


        public SampleCode()
        {
            //
            // Required for Windows Form Designer support
            //
            InitializeComponent();

            //
            // TODO: Add any constructor code after InitializeComponent call
            //
        }
        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        protected override void Dispose(bool disposing)
        {
            base.Dispose(disposing);
        }
        #region Windows Form Designer generated code
        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SampleCode));
            mainMenu1 = new MainMenu();
            mnuClose = new MenuItem();
            menuItem2 = new MenuItem();
            mnuSearch = new MenuItem();
            mnuConnect = new MenuItem();
            cmbDevices = new ComboBox();
            label1 = new Label();
            SuspendLayout();
            // 
            // mainMenu1
            // 
            mainMenu1.MenuItems.Add(mnuClose);
            mainMenu1.MenuItems.Add(menuItem2);
            // 
            // mnuClose
            // 
            mnuClose.Text = "Close";
            mnuClose.Click += new EventHandler(mnuClose_Click);
            // 
            // menuItem2
            // 
            menuItem2.MenuItems.Add(mnuSearch);
            menuItem2.MenuItems.Add(mnuConnect);
            menuItem2.Text = "Menu";
            // 
            // mnuSearch
            // 
            mnuSearch.Text = "Search";
            mnuSearch.Click += new EventHandler(mnuSearch_Click);
            // 
            // mnuConnect
            // 
            mnuConnect.Text = "Connect";
            mnuConnect.Click += new EventHandler(mnuConnect_Click);
            // 
            // cmbDevices
            // 
            cmbDevices.Location = new Point(8, 8);
            cmbDevices.Name = "cmbDevices";
            cmbDevices.Size = new Size(160, 26);
            cmbDevices.TabIndex = 0;
            cmbDevices.Visible = false;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left
                        | AnchorStyles.Right;
            label1.Location = new Point(3, 180);
            label1.Name = "label1";
            label1.Size = new Size(234, 55);
            label1.Text = "Send a keypress: 0-9, Enter, and the Arrow-keys are supported";
            label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // RemoteControlForm
            // 
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            ClientSize = new Size(240, 266);
            Controls.Add(label1);
            Controls.Add(cmbDevices);
            Menu = mainMenu1;
            Name = "RemoteControlForm";
            Text = "Remote";
            Load += new EventHandler(Form1_Load);
            KeyUp += new KeyEventHandler(RemoteControlForm_KeyUp);
            ResumeLayout(false);

        }
        #endregion
        
        private void Form1_Load(object sender, EventArgs e)
        {
            //turn on bt radio
            BluetoothRadio radio = BluetoothRadio.PrimaryRadio;
            if (radio != null && radio.Mode == RadioMode.PowerOff)
            {
                BluetoothRadio.PrimaryRadio.Mode = RadioMode.Connectable;
            }
            bc = new BluetoothClient();
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
        }


        private void mnuSearch_Click(object sender, EventArgs e)
        {
            //this will take a while...
            Cursor.Current = Cursors.WaitCursor;
            BluetoothDeviceInfo[] bdi = bc.DiscoverDevices(12);
            //bind the combo
            cmbDevices.DataSource = bdi;
            cmbDevices.DisplayMember = "DeviceName";
            cmbDevices.ValueMember = "DeviceAddress";
            cmbDevices.Visible = true;
            cmbDevices.Focus();
            Cursor.Current = Cursors.Default;

            if (bdi.Length > 0)
            {
                mnuConnect.Enabled = true;
            }
        }

        private void mnuConnect_Click(object sender, EventArgs e)
        {
            if (cmbDevices.SelectedValue != null)
            {
                try
                {
                    bc.Connect(new BluetoothEndPoint((BluetoothAddress)cmbDevices.SelectedValue, service));
                    mnuConnect.Enabled = false;
                    Controls.Remove(cmbDevices);
                    BackColor = Color.PaleGreen;
                    Focus();
                }
                catch
                {
                    //error connecting
                    BackColor = Color.Salmon;
                }
            }
        }

        private void mnuClose_Click(object sender, EventArgs e)
        {
            bc.Close();
            Close();
        }

        private void RemoteControlForm_KeyUp(object sender, KeyEventArgs e)
        {
            try
            {
                System.IO.Stream s = bc.GetStream();
                s.Write(BitConverter.GetBytes((short)e.KeyCode), 0, 2);
            }
            catch
            {
            }

        }
    }
}
