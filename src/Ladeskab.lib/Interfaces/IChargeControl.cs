namespace Ladeskab.lib.Interfaces
{
    public interface IChargeControl
    {
        bool IsCharging();
        bool IsConnected();
        void StartCharge();
        void StopCharge();
    }
}