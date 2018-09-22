using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecorridoMatriz
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] arreglo = new int[4, 5]
            {
                {1,9,23,34,10},
                {2,8,67,56,23},
                {3,7,84,78,43},
                {4,5,90,98,34}
            };

            Console.WriteLine("Tamano del Arreglo: {0}", arreglo.Length);

            for (int i = 0; i <= 4; i++)
            {                
                if ( (i % 2) == 0)
                { 
                    for (int j = 0; j <= 3; j++)
                    {
                        Console.WriteLine("Elemento: {0}", arreglo[j, i]);
                    }
                }
                else
                {
                    for (int j = 3; j >= 0 ; j--)
                    {
                        Console.WriteLine("Elemento: {0}", arreglo[j, i]);
                    }
                }
            }
        }
    }
}
