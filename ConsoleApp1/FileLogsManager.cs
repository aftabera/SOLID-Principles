using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class FileLogsManager : BaseLogsManager
    {
        private readonly string _fileName;

        public FileLogsManager(string fileName)
        {
            _fileName = fileName;
        }

        public override void AppendLogs(BaseLogEntry log)
        {
            File.AppendAllText(_fileName, Environment.NewLine + log.ToString());
        }
    }
}
