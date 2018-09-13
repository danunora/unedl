using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperadoresLogicos
{
    class Program
    {
        static void Main(string[] args)
        {
            bool Valor1 = true;
            bool Valor2 = true;
            Console.WriteLine("Valor1 {0} && Valor2 {1}: {2}",Valor1,Valor2,Valor1 && Valor2);
            Valor2 = false;
            Console.WriteLine("Valor1 {0} && Valor2 {1}: {2}", Valor1, Valor2, Valor1 && Valor2);

        }
    }
}
