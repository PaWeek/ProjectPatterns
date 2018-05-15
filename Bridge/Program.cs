using System;

namespace Bridge
{
    class Program
    {
        static void Main(string[] args)
        {
            IRTVDevice radio = new Radio();
            IRTVDevice tv = new TV();            
            RemoteController remote = new RemoteController(radio, tv);
            remote.Start();
            remote.SetChannel(2);
            remote.SetChannel(5);
            remote.BackChannel();          
            remote.Stop();
        }
    }
}
