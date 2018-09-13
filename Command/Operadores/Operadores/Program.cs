using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operadores
{
    class Program
    {
        static void Main(string[] args)
        {

            int a = 10;
            int b = 2;
            Console.WriteLine("#### Operadores Aritmeticos con Integers ####");
            Console.WriteLine("int a = 10;");
            Console.WriteLine("int b = 2;");
            Console.WriteLine("a + b: {0}", a + b);
//            Console.WriteLine("a + b: {0}", (float) a + (float) b);
            Console.WriteLine("a - b: {0}", a - b);
            Console.WriteLine("a * b: {0}", a * b);
            Console.WriteLine("a / b: {0}", a / b);
            Console.WriteLine("a % b: {0}", a % b);
            Console.WriteLine("a++: {0}", a++);
            Console.WriteLine("++a: {0}", ++a);
            Console.WriteLine("                  ");

            float d = 23.5f;
            float e = 12.1f;
            float f = 0.0f;
            float h = 0.0f;
            Console.WriteLine("#### Operadores Aritmeticos con Float ####");
            Console.WriteLine("float d = 23.5f;");
            Console.WriteLine("float e = 12.1f;");
            Console.WriteLine("d + e: {0}", d + e);
            Console.WriteLine("d - e: {0}", d - e);
            Console.WriteLine("d * e: {0}", d * e);
            Console.WriteLine("d / e: {0}", d / e);
            Console.WriteLine("d % e: {0}", d % e);
            f = d++;
            Console.WriteLine("f=d++: {0}", f);
            h = ++d;
            Console.WriteLine("h=++d: {0}", h);
            Console.WriteLine("                  ");

            var i = 10;
            var j = 2;
            Console.WriteLine("#### Operadores Aritmeticos con Integers ####");
            Console.WriteLine("var i = 10;");
            Console.WriteLine("var j = 2;");
            Console.WriteLine("i + j: {0}", (float) i + (float)j);
            Console.WriteLine("i - j: {0}", i - j);
            Console.WriteLine("i * j: {0}", i * j);
            Console.WriteLine("i / j: {0}", i / j);
            Console.WriteLine("i % j: {0}", i % j);
            Console.WriteLine("i++: {0}", i++);
            Console.WriteLine("++i: {0}", ++i);
            Console.WriteLine("                  ");

        }
    }
}
