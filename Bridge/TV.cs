using System;

namespace Bridge
{
    public class TV : IRTVDevice
    {
        public void SetChannel(int channelNumber)
        {
            Console.WriteLine("TV channel changed to: " + channelNumber);
        }

        public void Start()
        {
            Console.WriteLine("TV started.");
        }

        public void Stop()
        {
            Console.WriteLine("TV stopped.");
        }
    }
}