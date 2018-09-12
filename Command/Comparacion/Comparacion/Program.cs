using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Comparacion
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 10;
            int b = 2;
            Console.WriteLine("#### Operadores Comparacion con Integers ####");
            Console.WriteLine("int a = 10;");
            Console.WriteLine("int b = 2;");
            Console.WriteLine("a == b: {0}", a == b);
            Console.WriteLine("a != b: {0}", a != b);
            Console.WriteLine("greater than a > b: {0}", a > b);
            Console.WriteLine("greater or equal to a >= b: {0}", a >= b);
            Console.WriteLine("less than a < b: {0}", a < b);
            Console.WriteLine("less than or equal to a <= b: {0}", a <= b);
            Console.WriteLine("                  ");

        }
    }
}
