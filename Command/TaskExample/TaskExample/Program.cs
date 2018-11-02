using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskExample
{
    class Program
    {
        // initial Write method
        public static void Write(char c)
        {
            int i = 1000;
            while(i --> 0)
            {
                Console.Write(c);
            }
        }
        
        // overloading Write
        public static void Write(object o)
        {
            int i = 1000;
            while (i-- > 0)
            {
                Console.Write(o);
            }
        }

        static void Main(string[] args)
        {
            // Test 1 using Write (char)
            Task.Factory.StartNew(() => Write('.'));
            var t1 = new Task(() => Write('?'));
            t1.Start();
            Write('-');

            // Test 2 using Write (object)
            var t2 = new Task(Write, "hello");
            t2.Start();
            Task.Factory.StartNew(Write, 123);

            Console.WriteLine("Main program done");
            Console.ReadKey();
        }
    }
}
