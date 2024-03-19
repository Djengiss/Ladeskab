using NUnit.Framework;
using System;
using System.IO;
using Ladeskab.lib.Interfaces;
using Ladeskab.lib;

namespace Ladeskab.test
{
    public class TestFileLogger
    {
        private string testLogFilePath = "testLog.txt";
        private ILog _uut;

        [SetUp]
        public void SetUp()
        {
            _uut = new FileLogger(testLogFilePath);
        }

        [TearDown]
        public void TearDown()
        {
            // Clean up: delete the test log file after each test
            File.Delete(testLogFilePath);
        }

        [Test]
        public void LogDoorUnlocked_WritesToLogFile()
        {
            // Arrange
            int rfidId = 123;

            // Act
            _uut.LogDoorUnlocked(rfidId);

            // Assert
            string[] logLines = File.ReadAllLines(testLogFilePath);
            Assert.That(logLines.Length, Is.EqualTo(1));
            Assert.That(logLines[0].Contains($"Door unlocked by {rfidId}"), Is.True);
        }

        [Test]
        public void LogDoorLocked_WritesToLogFile()
        {
            // Arrange
            int rfidId = 456;

            // Act
            _uut.LogDoorLocked(rfidId);

            // Assert
            string[] logLines = File.ReadAllLines(testLogFilePath);
            Assert.That(logLines.Length, Is.EqualTo(1));
            Assert.That(logLines[0].Contains($"Door locked by {rfidId}"), Is.True);
        }

        [Test]
        public void ReadLog_ReadsLogFileContents()
        {
            string logMessage1 = "Door unlocked by 123";
            string logMessage2 = "Door locked by 456";
            File.AppendAllText(testLogFilePath, $"{DateTime.Now}: {logMessage1}\n");
            File.AppendAllText(testLogFilePath, $"{DateTime.Now}: {logMessage2}\n");

            // Capture console output before calling ReadLog
            using (StringWriter sw = new StringWriter())
            {
                Console.SetOut(sw);

                // Act
                _uut.ReadLog();

                // Assert
                string consoleOutput = sw.ToString();
                Assert.That(consoleOutput.Contains(logMessage1), Is.True);
                Assert.That(consoleOutput.Contains(logMessage2), Is.True);
            }
        }
    }
}
