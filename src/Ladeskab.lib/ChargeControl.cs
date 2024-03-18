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

        public bool Connected { get; set; }
        public double CurrentValue { get; private set; }

        public void SubscribeToEvent(UsbChargerSimulator source)
        {
            source.CurrentValueEvent += OnCurrentValueEventReceived;
        }

        ChargeControl(IUsbCharger usbCharger)
        {
            _usbCharger = usbCharger;
        }

        public void StartCharge()
        {
            if (CurrentValue > 5 && CurrentValue <= 500)
            {
                _usbCharger.StartCharge();
            }
            else StopCharge();
        }

        public void StopCharge()
        {
            _usbCharger.StopCharge();
        }

        private void OnCurrentValueEventReceived(object sender, CurrentEventArgs e)
        {
            CurrentValue = _usbCharger.CurrentValue;
            Connected = _usbCharger.Connected;
        }
    }
}
