using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ladeskab.lib.Interfaces;

namespace Ladeskab.lib
{
    public class Display : IDisplay
    {
        private string displayText = "Empty";
        private int charge = 0;

        public void UpdateDisplay(string newDisplayText)
        {

        }

        public void UpdateCharge(int percentage)
        {

        }
    }
}
