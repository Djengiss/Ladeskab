using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ladeskab.lib.Interfaces;

namespace Ladeskab.lib
{
    public class FileLogger : ILog
    {
        //private LogFile;
        private string logFilePath;
        public FileLogger(string filePath)
        {
            logFilePath = filePath;
        }
        public void ReadLog()
        {
            try
            {
                // Read and display the contents of the log file
                string logContents = File.ReadAllText(logFilePath);
                Console.WriteLine("Log contents:");
                Console.WriteLine(logContents);
            }
            catch (IOException ex)
            {
                Console.WriteLine($"Error reading log file: {ex.Message}");
            }
        }
        public void LogDoorUnlocked()
        {
            LogToFile("Door unlocked");
        }
        public void LogDoorLocked()
        {
            LogToFile("Door locked");
        }
        private void LogToFile(string logMessage)
        {
            try
            {
                // Append the log message with current date and time to the log file
                using (StreamWriter writer = File.AppendText(logFilePath))
                {
                    writer.WriteLine($"{DateTime.Now}: {logMessage}");
                }
            }
            catch (IOException ex)
            {
                Console.WriteLine($"Error writing to log file: {ex.Message}");
            }
        }

    }
}
