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
        public string ReadRfid()
        {
            return string.Empty;
        }
        public void OnRfidRead(int id)
        {
        }

        //event EventHandler RfidChanged;
    }
}
