using System;
using System.IO;
using DiskSpaceConsole;

namespace DiskSpaceConsole
{
    public class LogManager
    {
        private static readonly LogManager _instance = new LogManager();
        private static string logFilePath = Path.Combine(Path.GetTempPath(), "logDiskSpace.json");

        private LogManager() { }

        public static LogManager Instance
        {
            get { return _instance; }
        }

        public void Log(string message)
        {
            File.AppendAllText(logFilePath, $"{DateTime.Now}: {message}{Environment.NewLine}");
        }
    }
}
