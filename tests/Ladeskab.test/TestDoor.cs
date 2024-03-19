using NUnit.Framework;
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
        private IDoor _uut;

        [SetUp]
        public void SetUp()
        {
            _uut = new Door();
        }

        [Test]
        public void door_Closed_LockIsLocked()
        {
            // Arrange
            _uut.LockDoor();
            
            // Assert
            Assert.That(_uut.isLocked, Is.True);
        }

        [Test]
        public void door_Opened_LockIsLocked()
        {
            // Arrange
            _uut.OnDoorOpen();

            // Act 
            _uut.LockDoor();

            // Assert
            Assert.That(_uut.isLocked, Is.False);
        }

        [Test]
        public void door_Opened_LockIsUnlocked()
        {
            // Arrange
            _uut.OnDoorOpen();

            // Act
            _uut.UnlockDoor();

            // Assert
            Assert.That(_uut.isLocked, Is.False);
        }

        [Test]
        public void door_Closed_LockIsUnlocked()
        {
            // Arrange
            _uut.OnDoorClose();

            // Act
            _uut.UnlockDoor();

            // Assert
            Assert.That(_uut.isLocked, Is.False);
        }

        [Test]
        public void door_Open_RaisesDoorClosedEvent()
        {
            // Arrange
            _uut.OnDoorOpen();
            bool eventRaised = false;
            _uut.DoorEvent += (sender, args) => { eventRaised = !args.IsOpen; };

            // Act
            _uut.OnDoorClose();

            // Assert
            Assert.That(eventRaised, Is.True);
        }

        [Test]
        public void door_Closed_RaisesDoorOpenedEvent()
        {
            // Arrange
            _uut.OnDoorClose();
            bool eventRaised = false;
            _uut.DoorEvent += (sender, args) => { eventRaised = args.IsOpen; };

            // Act
            _uut.OnDoorOpen();

            // Assert
            Assert.That(eventRaised, Is.True);
        }
    }
}
