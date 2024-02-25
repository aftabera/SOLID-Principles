using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class LogEntryWithSeverity : BaseLogEntry
    {
        public LogSeverityEnum Severity { get; set; } = LogSeverityEnum.None;
    }
}
