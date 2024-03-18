using UsbSimulator;

namespace Ladeskab.lib.Interfaces
{
    public interface IChargeControl
    {
        void SubscribeToEvent(UsbChargerSimulator source);
    }
}