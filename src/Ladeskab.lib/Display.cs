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
        private string displayText = "Tilslut Telefon.";
        private int charge = 0;

        public Display() { }

        public void TilslutTlf()
        {
            displayText = "Tilslut Telefon.";
        }

        public void IndlæsRFID()
        {
            displayText = "Indlæs RFID.";
        }

        public void Tilslutningsfejl()
        {
            displayText = "Tilslutningsfejl.";
        }

        public void Optaget()
        {
            displayText = "Ladeskab Optaget.";
        }

        public void RFIDfejl()
        {
            displayText = "RFID Fejl.";
        }

        public void FjernTlf()
        {
            displayText = "Fjern Telefon.";
        }
    }
}
