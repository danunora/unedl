﻿// source: http://www.albahari.com/threading/


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ThreadTest
{
    class Program
    {
        static bool done; 

        static void Main(string[] args)
        {
            new Thread (Go).Start();
            Go();
        }

        static void Go()
        {
            if (!done)
            {
                Console.WriteLine("Done");
                done = true;
            }
        }
    }
}
