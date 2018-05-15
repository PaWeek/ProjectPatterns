namespace Bridge
{
    public interface IRTVDevice
    {
        void Start();
        void Stop();
        void SetChannel(int channelNumber);
    }
}