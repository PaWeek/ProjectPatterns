namespace Bridge
{
    public class RemoteController
    {
        private int currentChannel;
        private int previousChannel;

        protected IRTVDevice[] devices;

        public RemoteController(params IRTVDevice[] devices)
        {
            this.devices = devices;
            currentChannel = -1;
            previousChannel = -1;
        }

        public void Start()
        {
            foreach(IRTVDevice device in devices)
            {
                device.Start();
            }
        }

        public void Stop()
        {
            foreach(IRTVDevice device in devices)
            {
                device.Stop();
            }
        }

        public void SetChannel(int newChannel)
        {
            previousChannel = currentChannel;
            currentChannel = newChannel;

            foreach(IRTVDevice device in devices)
                {
                    device.SetChannel(newChannel);
                }
        }

        public void BackChannel()
        {
            SetChannel(previousChannel);
        }
    }
}