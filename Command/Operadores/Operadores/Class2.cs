using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operadores
{
    public class Class2
    {
        public void floatOperadores()
        {
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
        }
    }
}
