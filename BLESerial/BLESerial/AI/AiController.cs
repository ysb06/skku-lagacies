using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLESerial.AI
{
    public class AiController : IModule
    {
        public event CommunicationEventHandler OnMessageBroadcasted;
        public event EventHandler Disposed;

        private readonly AiView view;

        public AiController()
        {
            view = new AiView();
            view.FormClosed += View_FormClosed;
        }

        private void View_FormClosed(object sender, System.Windows.Forms.FormClosedEventArgs e)
        {
            Dispose();
        }

        public void Activate()
        {
            view.Show();
        }

        public void ReceiveMessage(string message)
        {

        }

        public void SendMessage(string message)
        {
            CommunicationEventArgs e = new CommunicationEventArgs
            {
                Message = message,
                OriginAddress = "Ai System"
            };
            OnMessageBroadcasted(this, e);
        }

        public void Dispose()
        {
            if (!view.IsDisposed)
            {
                view.Dispose();
            }

            Disposed?.Invoke(this, new EventArgs());
        }
    }
}
