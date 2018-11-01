// Source: https://jj09.net/multithreading-in-csharp/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Signals
{
    class Program
    {
            static EventWaitHandle _waitHandle = new AutoResetEvent(false);

            static void Main()
            {
                new Thread(Operation).Start();
                Thread.Sleep(1000);                  // Computation...
                Console.WriteLine("Wait...");
                _waitHandle.WaitOne();               // Wait for notification
                Console.WriteLine("Notified!");
            }

            static void Operation()
            {
                Console.WriteLine("Start operation...");
                Thread.Sleep(2000);                  // Computation...
                Console.WriteLine("Operation finished!");
                _waitHandle.Set();                   // Notify the Waiter
                Thread.Sleep(1000);                  // Some other computation...
            }
        }
    }
