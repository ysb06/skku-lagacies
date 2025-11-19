using System;

namespace BLESerial
{
    public interface IModule : IDisposable
    {
        event CommunicationEventHandler OnMessageBroadcasted;
        event EventHandler Disposed;
        void ReceiveMessage(string message);
        void Activate();
    }
}