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
                string logContents = File.ReadAllText(logFilePath);
                Console.WriteLine("Log contents:");
                Console.WriteLine(logContents);
            }
            catch (IOException ex)
            {
                Console.WriteLine($"Error reading log file: {ex.Message}");
            }
        }
        public void LogDoorUnlocked(int rfid_ID)
        {
            LogToFile($"Door unlocked by {rfid_ID}");
        }
        public void LogDoorLocked(int rfid_ID)
        {
            LogToFile($"Door locked by {rfid_ID}");
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
