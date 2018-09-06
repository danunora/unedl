using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World !");
            Console.WriteLine("This is a test!");
            checked
            {
                byte numero = 255;
                numero++;
                Console.WriteLine("Numero: ", numero);
            }

        }
    }
}
