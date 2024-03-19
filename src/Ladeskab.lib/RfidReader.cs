using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ladeskab.lib.Interfaces;

namespace Ladeskab.lib
{
    public class RfidReader : IRfidReader
    {
        private int _currentRFID = -1;
        public event EventHandler<int> RfidChanged;
        public void OnRfidRead(int id)
        {
            if (id>0 && id< 999999999) //If Legal RFID
            {
                _currentRFID = id;
                RfidChanged?.Invoke(this, _currentRFID);
                _currentRFID = -1;
            }
        }
    }
}
