using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public static class LogEntryFactory
    {
        public static BaseLogEntry CreateDefault(string log)
        {
            return CreateWithSeverity(log, LogSeverityEnum.None);
        }

        public static BaseLogEntry CreateWithSeverity(string log, LogSeverityEnum severity)
        {
            return new LogEntryWithSeverity
            {
                LogMessage = log,
                Severity = severity
            };
        }
    }
}
