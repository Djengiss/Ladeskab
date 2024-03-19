using Ladeskab.lib.Interfaces;
using Ladeskab.lib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ladeskab.test
{
    internal class TestDisplay
    {
        private IDisplay _uut;

        [SetUp]
        public void SetUp()
        {
            _uut = new Display();
        }

        [Test]
        public void display_clear_emptyString()
        {
            // Arrange
            _uut.TilslutTlf();
            Assert.That(_uut.displayText, Is.Not.EqualTo(""));

            // Act
            _uut.ClearDisplay();

            // Assert
            Assert.That(_uut.displayText, Is.EqualTo(""));
            
        }

        [Test]
        public void display_tilslutTlf_messageShown()
        {
            // Arrange
            _uut.ClearDisplay();

            // Act
            _uut.TilslutTlf();

            // Assert
            Assert.That(_uut.displayText, Is.EqualTo("Bruger info: Tilslut Telefon."));

        }

        [Test]
        public void display_indlæsRFID_messageShown()
        {
            // Arrange
            _uut.ClearDisplay();

            // Act
            _uut.IndlæsRFID();

            // Assert
            Assert.That(_uut.displayText, Is.EqualTo("Bruger info: Indlæs RFID."));

        }

        [Test]
        public void display_tilslutningsfejl_messageShown()
        {
            // Arrange
            _uut.ClearDisplay();

            // Act
            _uut.Tilslutningsfejl();

            // Assert
            Assert.That(_uut.displayText, Is.EqualTo("Bruger info: Tilslutningsfejl."));

        }

        [Test]
        public void display_optaget_messageShown()
        {
            // Arrange
            _uut.ClearDisplay();

            // Act
            _uut.Optaget();

            // Assert
            Assert.That(_uut.displayText, Is.EqualTo("Bruger info: Ladeskab Optaget."));

        }

        [Test]
        public void display_RFIDfejl_messageShown()
        {
            // Arrange
            _uut.ClearDisplay();

            // Act
            _uut.RFIDfejl();

            // Assert
            Assert.That(_uut.displayText, Is.EqualTo("Bruger info: RFID Fejl"));

        }

        [Test]
        public void display_fjernTlf_messageShown()
        {
            // Arrange
            _uut.ClearDisplay();

            // Act
            _uut.FjernTlf();

            // Assert
            Assert.That(_uut.displayText, Is.EqualTo("Bruger info: Fjern Telefon"));

        }

        [Test]
        public void display_isCharging_messageShown()
        {
            // Arrange
            _uut.ClearDisplay();

            // Act
            _uut.IsCharging();

            // Assert
            Assert.That(_uut.displayText, Is.EqualTo("Ladestatus: Telefon lader."));

        }

        [Test]
        public void display_isNotCharging_messageShown()
        {
            // Arrange
            _uut.ClearDisplay();

            // Act
            _uut.IsNotCharging();

            // Assert
            Assert.That(_uut.displayText, Is.EqualTo("Ladestatus: Telefon lader ikke."));

        }
    }
}
