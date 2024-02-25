using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class LogsManager
    {
        private List<LogEntry> logEntries = new List<LogEntry>();

        public void Log(string log)
        {
            var logEntry = new LogEntry
            {
                DateAndTimeForLog = DateTime.Now,
                LogMessage = log,
            };
            logEntries.Add(logEntry);
        }

        public string Logs()
        {
            return string.Join(Environment.NewLine, logEntries);
        }

        public void SaveLogs(string fileName)
        {
            File.WriteAllText(fileName, Logs());
        }
    }
}
