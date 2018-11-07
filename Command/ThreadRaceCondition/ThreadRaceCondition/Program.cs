using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ThreadRaceCondition
{
    
    class Program
    {
        const int THREADS = 3;
        const int CICLOS = 10;
        public static int i;
        static Thread[] myThreads = new Thread[THREADS];

        // Each thread should be doing a countdown
        static void doCountDown()
        {
            for ( i = 0; i <= CICLOS; i++)
            {
                Console.WriteLine("THREAD: {0}, CICLO: {1}",Thread.CurrentThread.Name,i);
            }
        }

        // Main
        static void Main(string[] args)
        {            
            for (int j = 0; j < THREADS; j++)
            {
                myThreads[j] = new Thread(doCountDown);
                myThreads[j].Name = "thread number " + j;
                myThreads[j].Start();
            }
            Console.Read();
        }
    }

}

