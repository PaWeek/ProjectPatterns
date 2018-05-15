using System;

namespace Bridge
{
    public class Radio : IRTVDevice
    {
        public void SetChannel(int channelNumber)
        {
            Console.WriteLine("Radio channel changed to: " + channelNumber);
        }

        public void Start()
        {
            Console.WriteLine("Radio started.");
        }

        public void Stop()
        {
            Console.WriteLine("Radio stoppped.");
        }
    }
}