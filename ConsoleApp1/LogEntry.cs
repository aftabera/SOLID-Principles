using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class BaseLogEntry
    {
        public DateTime DateAndTimeForLog { get; set; } = DateTime.Now;

        public string LogMessage { get; set; }
        
        public override string ToString()
        {
            return $"{DateAndTimeForLog}: {JsonConvert.SerializeObject(this)}";
        }
    }
}
