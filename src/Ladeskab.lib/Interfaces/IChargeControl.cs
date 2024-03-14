namespace Ladeskab.lib.Interfaces
{
    public interface IChargeControl
    {
        public bool Connected { get; set; }

        void Connect();
        void Disconnect();
        bool IsCharging();
        bool IsConnected();
        void StartCharge();
        void StopCharge();
    }
}