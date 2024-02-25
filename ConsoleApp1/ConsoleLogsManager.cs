using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class ConsoleLogsManager : BaseLogsManager
    {
        public override void AppendLogs(BaseLogEntry log)
        {
            Console.WriteLine(log.ToString());
        }
    }
}
