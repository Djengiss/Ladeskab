﻿using Ladeskab.lib.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ladeskab.lib;

namespace Ladeskab.test
{
    public class TestRfidReader
    {
        private IRfidReader _uut;

        [SetUp]
        public void SetUp()
        {
            _uut = new RfidReader();
        }
        [Test]
        public void rfidReader_ScannedCorrectEventRaised()
        {
            // Arrange
            int eventRaised = 0;
            _uut.RfidChanged += (sender, args) => { eventRaised = args.Rfid; };

            // Act
            _uut.OnRfidRead(007);

            // Assert
            Assert.That(eventRaised, Is.EqualTo(007));
        }
        [Test]
        public void rfidReader_ScannedIllegalIDEventNotRaised()
        {
            // Arrange
            int eventRaised = -1;
            _uut.RfidChanged += (sender, args) => { eventRaised = args.Rfid; };

            // Act
            _uut.OnRfidRead(-7);

            // Assert
            Assert.That(eventRaised, Is.EqualTo(-1));
        }
    }
}
