using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BLESerial.AI
{
    public partial class AiView : Form
    {
        public AiView()
        {
            InitializeComponent();
        }

        private void Gv_TileClicked(object sender, TileClickedEventArgs e)
        {
            Console.WriteLine("Clicked: " + e.ClickedPoint.X + ", " + e.ClickedPoint.Y);
        }

        private void OnButtonClicked(object sender, EventArgs e)
        {
            gv.SetColorAt(0, 0, Color.Red);
            gv.SetTextAt(0, 0, "OK");
        }

        private void AiView_MouseDown(object sender, MouseEventArgs e)
        {
            Console.WriteLine(Cursor.Position);
        }
    }
}
