//#define DEBUG
//#define LOGLEVEL

//#define LOGLEVEL1
// LOGLEVELS:
// LOGLEVEL1, Notice
// LOGLEVEL2, Warning
// LOGLEVEL3, Errors
// LOGLEVEL5, All (Notice, Warnings, Errors)
// Comment, No log level 


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PreProcessor
{
    public class TestClass
    {
        static void Main(string[] args)
        {
#if DEBUG
            Console.WriteLine("Debugger is Enabled");
#endif
#if LOGLEVEL1
            Console.WriteLine("Log level is notice");
#elif LOGLEVEL2
            Console.WriteLine("Log level is warning");
#elif LOGLEVEL3
            Console.WriteLine("Log level is errors");
#elif LOGLEVEL4
            Console.WriteLine("Log level is all");
#else
      Console.WriteLine("No log level was used");
#endif
        }
    }
}