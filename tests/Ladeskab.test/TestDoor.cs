using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ladeskab.lib.Interfaces;

namespace Ladeskab.test
{
    public class TestDoor
    {
        private IDoor uut;
        public void SetUp()
        {
            uut = new Door();
        }


    }
}
