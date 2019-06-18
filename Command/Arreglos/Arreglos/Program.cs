using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arreglos
{
    class Program
    {
        /**
         * Regresar un arreglo al reves
         */
        public static int[] reverseArray(int[] arreglo)
        {
            int[] reverso = new int[arreglo.Length];
            int j = 0;
            for (var i = arreglo.Length - 1; i >= 0; i--)
            {
                reverso[j] = arreglo[i];
                j++;
            }
            return reverso;
        }

        /**
         * Imprimir el arreglo dado
        */
        public static void printArray(string letrero, int[] arreglo)
        {
            foreach (var numero in arreglo)
            {
                Console.WriteLine("{0} : {1}", letrero, numero);
            }
        }


        /**
         * Shift Left
         * 1,2,3,4,5 => 1 left rotation  => 2,3,4,5,1
         * 1,2,3,4,5 => 2 left rotations => 3,4,5,1,2
         */
        public static int[] shiftleft(int shifts, int[] arreglo)
        {
            int[] shiftleft = new int[arreglo.Length];
            int j = 0;
            if (shifts != 0)
            {
                for (var i = shifts; i < arreglo.Length; i++)
                {
                    shiftleft[j] = arreglo[i];
                    j++;
                }
                Console.WriteLine("test");
                int k = arreglo.Length - j;
                for (var i = 0; i < k;  i++)
                {
                    shiftleft[j] = arreglo[i];
                    j++;
                }
                return shiftleft;
            }
            else
            {
                return arreglo;
            }
        }

        /*
         * Main
         */
        public static void Main(string[] args)
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
            int[] reverso = reverseArray(numeros);
            printArray("Reverso", reverso);
            int[] sl = shiftleft(0, numeros);
            printArray("ShiftLeft", sl);
        }
    }
}
