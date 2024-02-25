﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class LogEntry
    {
        public DateTime DateAndTimeForLog { get; set; }
        public string LogMessage { get; set; }
        
        public override string ToString()
        {
            return $"{DateAndTimeForLog} - {LogMessage}";
        }
    }
}
