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
        IChargeControl _chargeControl;
        public string displayText { get; private set; }

        public Display() 
        {    
        }

        public void ClearDisplay()
        {
            displayText = string.Empty;
        }

        public void TilslutTlf()
        {
            displayText = "Bruger info: Tilslut Telefon.";
            Console.WriteLine("Bruger info: Tilslut Telefon.");
        }

        public void IndlæsRFID()
        {
            displayText = "Bruger info: Indlæs RFID.";
            Console.WriteLine("Bruger info: Indlæs RFID.");
        }

        public void Tilslutningsfejl()
        {
            displayText = "Bruger info: Tilslutningsfejl.";
            Console.WriteLine("Bruger info: Tilslutningsfejl.");
        }

        public void Optaget()
        {
            displayText = "Bruger info: Ladeskab Optaget.";
            Console.WriteLine("Bruger info: Ladeskab Optaget.");
        }

        public void RFIDfejl()
        {
            displayText = "Bruger info: RFID Fejl";   
            Console.WriteLine("Bruger info: RFID Fejl.");
        }

        public void FjernTlf()
        {
            displayText = "Bruger info: Fjern Telefon";
            Console.WriteLine("Bruger info: Fjern Telefon");
        }

        public void IsCharging()
        {
            displayText = "Ladestatus: Telefon lader.";
            Console.WriteLine("Ladestatus: Telefon lader.");
        }

        public void IsNotCharging()
        {
            displayText = "Ladestatus: Telefon lader ikke.";   
            Console.WriteLine("Ladestatus: Telefon lader ikke.");
        }
    }
}
