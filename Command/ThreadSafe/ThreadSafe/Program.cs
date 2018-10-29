using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ThreadSafe
{
    class Program
    {
        static bool done;

        static readonly object locker = new object();

        static void Main(string[] args)
        {
            new Thread(Go).Start();
            Go();
        }

        static void Go()
        {
            lock (locker)
            {
                if (!done)
                {                    
                    Console.WriteLine("Done");
                    done = true;
                }
            }
        }
    }
}
