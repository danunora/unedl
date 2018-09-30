using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arreglos
{
    class Program
    {
        public static void printArray(string letrero, int[] arreglo)
        {
            foreach (var numero in arreglo)
            {
                Console.WriteLine("{0} : {1}",letrero,numero);
            }
        }
        static void Main(string[] args)
        {
            var numeros = new[] { 3, 7, 9, 2, 4, 5, 6, 8, 0, 1 };
            printArray("Element", numeros);
            Console.WriteLine("Lenght: " + numeros.Length);
            Console.WriteLine("Which number: ");
            var numberead = int.Parse(Console.ReadLine());
            var index = Array.IndexOf(numeros, numberead);
            Console.WriteLine("Index of: " + index);
            var numcopy = new int[4];
            Array.Copy(numeros, numcopy, numcopy.Length);
            printArray("Element Copied", numcopy);
            Array.Sort(numeros);
            printArray("Element Sorted", numeros);
        }
    }
}
