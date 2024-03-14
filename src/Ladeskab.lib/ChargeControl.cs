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
        private bool _IsConnected = false;
        private bool _IsCharging = false;

        public bool IsConnected()
        {
            return _IsConnected;
        }

        public bool IsCharging()
        {
            return _IsCharging;
        }

        public void StartCharge()
        {
            _IsCharging = true;
        }
        public void StopCharge()
        {
            _IsCharging = false;
        }
        public void Connect()
        {
            _IsConnected = true;
        }
        public void Disconnect()
        {
            _IsConnected = false;
        }
    }
}
