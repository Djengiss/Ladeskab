using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ladeskab.lib.Interfaces;

namespace Ladeskab.lib
{
    public class ChargeControl : IChargeControl
    {
        IUsbCharger _usbCharger;

        public bool Connected { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        ChargeControl(IUsbCharger usbCharger)
        {
            _usbCharger = usbCharger;
        }

        public bool IsConnected()
        {
            return _usbCharger.Connected;
        }

        public bool IsCharging()
        {
            if(_usbCharger.CurrentValue > 5 && _usbCharger.CurrentValue <= 500)
            {
                return true;
            }
            return false;
        }

        public void StartCharge()
        {
            _usbCharger.StartCharge();
        }
        public void StopCharge()
        {
            _usbCharger.StopCharge();
        }
    }
}
