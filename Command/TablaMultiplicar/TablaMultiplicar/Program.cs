using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TablaMultiplicar
{
    class Program
    {
        static void Main(string[] args)
        {
            int Tabla = 0 ;
            int i = 1;

            Console.WriteLine("Digite la tabla de multiplicar: ");
            Tabla = int.Parse(Console.ReadLine());

            if (Tabla >= 1 && Tabla <= 10)
            {
                i = 1;
                do
                {
                    Console.WriteLine(Tabla + " X " + i + " = " + Tabla * i);
                    i++;
                } while (i <= 10);
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine("del 1 al 10 unicamente");
            }
        }
    }
}