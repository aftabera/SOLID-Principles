using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public interface ILogShare
    {
        void EmailLogs();
        void ZipLogs();
    }

    public interface IPrintLogs
    {
        void PrintLogs();
    }
}
