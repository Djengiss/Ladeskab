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
        private bool _connected = false;
        private bool _charging = false;

        public bool IsConnected()
        {
            return _connected;
        }

        public bool IsCharging()
        {
            return _charging;
        }

        public void StartCharge()
        {
            _charging = true;
        }
        public void StopCharge()
        {
            _charging = false;
        }
        public void Connect()
        {
            _connected = true;
        }
        public void Disconnect()
        {
            _connected = false;
        }
    }
}
