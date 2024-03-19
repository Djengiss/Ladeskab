using NUnit.Framework;
using NSubstitute;
using Ladeskab.lib.Interfaces;
using UsbSimulator;
using Ladeskab.lib;

namespace Ladeskab.test
{
    public class TestChargeControl
    {
        private ChargeControl _chargeControl;
        private IUsbCharger _usbChargerMock;
        private IDisplay _displayMock;

        [SetUp]
        public void SetUp()
        {
            _usbChargerMock = Substitute.For<IUsbCharger>();
            _displayMock = Substitute.For<IDisplay>();
            _chargeControl = new ChargeControl(_usbChargerMock, _displayMock);
        }

        [Test]
        public void StartCharge_WhenCurrentValueWithinValidRange_StartsCharge()
        {
            double expectedCurrentValue = 20.0;
            _usbChargerMock.CurrentValueEvent += Raise.EventWith(new CurrentEventArgs { Current = expectedCurrentValue });

            // Assert
            Assert.That(expectedCurrentValue, Is.EqualTo(_chargeControl.CurrentValue));
        }

        [Test]
        public void StartCharge_WhenCurrentValueBelowValidRange_StopsCharge()
        {
        }

        [Test]
        public void StartCharge_WhenCurrentValueAboveValidRange_StopsCharge()
        {
          
        }

        [Test]
        public void StopCharge_StopsCharge()
        {
           
        }

    }
}
