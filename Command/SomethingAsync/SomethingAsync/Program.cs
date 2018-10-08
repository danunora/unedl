using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SomethingAsync
{
    class Program
    {
        const int SIZE = 50;
        static void Main(string[] args)
        {
            DoSomething();
            DoSomethingAsync();
            DoSomethingElse();
            Console.ReadKey();
        }

        public static async Task DoSomething()
        {
            await Task.Run(() =>
            {
                for (int i = 0; i < SIZE; i++)
                {
                    Console.WriteLine(" Doing Something ");
                }
            });
        }
        public static async Task DoSomethingAsync()
        {
            int val = 13;
            await Task.Delay(TimeSpan.FromSeconds(1));
            val *= 2;
            await Task.Delay(TimeSpan.FromSeconds(1));
            Console.WriteLine("Doing Something Async: "+ val);
        }

        public static void DoSomethingElse()
        {
            for (int i = 0; i < 25; i++)
            {
                Console.WriteLine(" Doing Something Else ");
            }
        }

    }
}
