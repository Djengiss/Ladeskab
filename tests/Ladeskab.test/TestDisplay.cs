﻿using Ladeskab.lib.Interfaces;
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
            
        }

        [Test]
        public void display_tilslutTlf_messageShown()
        {
            // Arrange
            _uut.ClearDisplay();

            // Act
            _uut.TilslutTlf();

            // Assert
        }

        [Test]
        public void display_action_assertation()
        {
            // Arrange

            // Act

            // Assert
        }

        [Test]
        public void display_action_assertation()
        {
            // Arrange

            // Act

            // Assert
        }

        [Test]
        public void display_action_assertation()
        {
            // Arrange

            // Act

            // Assert
        }

        [Test]
        public void display_action_assertation()
        {
            // Arrange

            // Act

            // Assert
        }

        [Test]
        public void display_action_assertation()
        {
            // Arrange

            // Act

            // Assert
        }
    }
}
