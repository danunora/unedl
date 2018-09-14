using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operadores
{
    public class Class1
    {
        public void varOperadores()
        {
            var i = 10;
            var j = 2;
            Console.WriteLine("#### Operadores Aritmeticos con Integers ####");
            Console.WriteLine("var i = 10;");
            Console.WriteLine("var j = 2;");
            Console.WriteLine("i + j: {0}", (float)i + (float)j);
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
