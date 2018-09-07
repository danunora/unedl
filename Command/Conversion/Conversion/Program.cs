using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conversion
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 1;
            byte b = i;

            byte c = (byte)i;

            Console.WriteLine("Value of b: {0}",b);
            Console.WriteLine("Value of c: {0}",c);
        }
    }
}
