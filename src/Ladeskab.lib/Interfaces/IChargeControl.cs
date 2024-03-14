namespace Ladeskab.lib.Interfaces
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