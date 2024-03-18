using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ladeskab.lib.Interfaces;
using UsbSimulator;

namespace Ladeskab.lib
{
    public class ChargeControl : IChargeControl
    {
        IUsbCharger _usbCharger;

        public void SubscribeToEvent(UsbChargerSimulator source)
        {
            source.CurrentValueEvent += OnCurrentValueEventReceived;
        }

        ChargeControl(IUsbCharger usbCharger)
        {
            _usbCharger = usbCharger;
        }

        private void OnCurrentValueEventReceived(object sender, CurrentEventArgs e)
        {
            Console.WriteLine("The threshold was reached.");

            if (_usbCharger.Connected == true && _usbCharger.CurrentValue > 5 && _usbCharger.CurrentValue <= 500)
            {
                _usbCharger.StartCharge();
            }
            else _usbCharger?.StopCharge();
        }
    }
}
