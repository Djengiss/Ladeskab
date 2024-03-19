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
        IDisplay _display;

        public bool Connected { get; set; }
        public double CurrentValue { get; private set; }

        public void SubscribeToEvent(IUsbCharger source)
        {
            source.CurrentValueEvent += OnCurrentValueEventReceived;
        }

        public ChargeControl(IUsbCharger usbCharger, IDisplay display)
        {
            _usbCharger = usbCharger;
            _display = display;
        }

        public void StartCharge()
        {
            if (CurrentValue > 5 && CurrentValue <= 500)
            {
                _usbCharger.StartCharge();
                _display.IsCharging();
            }
            else
            {
                StopCharge();
                _display.IsNotCharging();
            }
        }

        public void StopCharge()
        {
            _usbCharger.StopCharge();
            _display.IsNotCharging();
        }

        private void OnCurrentValueEventReceived(object sender, CurrentEventArgs e)
        {
            CurrentValue = e.Current;
        }
    }
}
