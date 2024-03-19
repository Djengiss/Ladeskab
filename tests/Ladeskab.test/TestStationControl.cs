using Ladeskab.lib.Interfaces;
using Ladeskab.lib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NSubstitute.Core.DependencyInjection;
using NSubstitute;

namespace Ladeskab.test
{
    internal class TestStationControl
    {
        private StationControl _uut;
        private IChargeControl _chargeControlMock;
        private IDoor _doorMock;
        private IDisplay _displayMock;
        private RfidReader _rfidReaderMock;

        [SetUp]
        public void Setup()
        {
            _chargeControlMock = Substitute.For<IChargeControl>();
            _doorMock = Substitute.For<IDoor>();
            _displayMock = Substitute.For<IDisplay>();
            _rfidReaderMock = Substitute.For<RfidReader>();
        }
    }
}
