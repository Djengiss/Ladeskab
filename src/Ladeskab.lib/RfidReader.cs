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
        public event EventHandler<CurrentEventArgs>? RfidEvent;
        public string Rfid = " ";
        public string ReadRfid()
        {
            Rfid = "12345678";
            RfidChanged();
            return Rfid;
        }

        //event EventHandler RfidChanged;
        private void RfidChanged()
        {
            RfidEvent?.Invoke(this, new CurrentEventArgs() { Current = this.Rfid });
        }
    }
}
