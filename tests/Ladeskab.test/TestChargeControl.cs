﻿using NUnit.Framework;
using NSubstitute;
using Ladeskab.lib.Interfaces;
using UsbSimulator;
using Ladeskab.lib;

namespace Ladeskab.test
{
    public class TestChargeControl
    {
        private ChargeControl _uut;
        private IUsbCharger _usbChargerMock;
        private IDisplay _displayMock;

        [SetUp]
        public void SetUp()
        {
            _usbChargerMock = Substitute.For<IUsbCharger>();
            _displayMock = Substitute.For<IDisplay>();
            _uut = new ChargeControl(_usbChargerMock, _displayMock);
        }

        [Test]
        public void StartCharge_WhenCurrentValueChangesEvent()
        {
            // Arrange
            double expectedCurrentValue = 20.0; // Adjust the expected value
            _uut.SubscribeToEvent(_usbChargerMock);

            // Act
            _usbChargerMock.CurrentValueEvent += Raise.EventWith(new CurrentEventArgs { Current = expectedCurrentValue });
            

            // Assert
            Assert.That(expectedCurrentValue, Is.EqualTo(_uut.CurrentValue)); // Update assertion
        }

        [Test]
        public void StartCharge_WhenCurrentValueBelowValidRange_StopsCharge()
        {
            
        }

        [Test]
        public void StartCharge_WhenCurrentValueAboveValidRange_StopsCharge()
        {
            // Arrange
            double expectedCurrentValue = 501.0; // Adjust the expected value
            _uut.SubscribeToEvent(_usbChargerMock);

            // Act
            _usbChargerMock.StartCharge();
            _usbChargerMock.CurrentValueEvent += Raise.EventWith(new CurrentEventArgs { Current = expectedCurrentValue });

            // assert
            _usbChargerMock.Received(1).StopCharge();
        }

        [Test]
        public void StopCharge_StopsCharge()
        {
            // act
            _uut.StopCharge();

            // assert
            _usbChargerMock.Received(1).StopCharge();

        }

    }
}
