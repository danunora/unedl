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
            intOperadores();

            Class2 class2 = new Class2();
            class2.floatOperadores();

            Class1 class1 = new Class1();
            class1.varOperadores();
        }

        public static void intOperadores()
        {
            int a = 10;
            int b = 2;
            Console.WriteLine("#### Operadores Aritmeticos con Integers ####");
            Console.WriteLine("int a = 10;");
            Console.WriteLine("int b = 2;");
            Console.WriteLine("a + b: {0}", a + b);
            Console.WriteLine("a - b: {0}", a - b);
            Console.WriteLine("a * b: {0}", a * b);
            Console.WriteLine("a / b: {0}", a / b);
            Console.WriteLine("a % b: {0}", a % b);
            Console.WriteLine("a++: {0}", a++);
            Console.WriteLine("++a: {0}", ++a);
            Console.WriteLine("                  ");
        }

    }
}
 