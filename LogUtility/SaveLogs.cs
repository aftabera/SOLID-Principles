using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogUtility
{
    public static class SaveLogs
    {
        public static void Save(string fileName, string logs)
        {
            File.WriteAllText(fileName, logs);
        }
    }
}
