namespace Ladeskab.lib
{
    public interface IChargeControl
    {
        void Connect();
        void Disconnect();
        bool IsCharging();
        bool IsConnected();
        void StartCharge();
        void StopCharge();
    }
}