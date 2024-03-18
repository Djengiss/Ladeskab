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
        private int _currentRFID = 0;
        public event EventHandler<int> RfidChanged;
        public void OnRfidRead(int id)
        {
            _currentRFID = id;
            RfidChanged?.Invoke(this, _currentRFID);
            _currentRFID = 0;
        }
    }
}
