// source: http://snipd.net/quicksort-in-c

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Quicksort
{
    class Program
    {
        public static void Quicksort(IComparable[] elements, int left, int right)
        {
            int i = left, j = right;
            IComparable pivot = elements[(left + right) / 2];

            while (i <= j)
            {
                while (elements[i].CompareTo(pivot) < 0)
                {
                    i++;
                }

                while (elements[j].CompareTo(pivot) > 0)
                {
                    j--;
                }

                if (i <= j)
                {
                    // Swap
                    IComparable tmp = elements[i];
                    elements[i] = elements[j];
                    elements[j] = tmp;

                    i++;
                    j--;
                }
            }

            // Recursive calls
            if (left < j)
            {
                Quicksort(elements, left, j);
            }

            if (i < right)
            {
                Quicksort(elements, i, right);
            }
        }

        public static void DisplayMyArray(String[] MyArray)
        {
            foreach (String i in MyArray)
                Console.Write(i + " ");
        }

        static void Main(string[] args)
        {
            // Create an unsorted array of string elements
            string[] unsorted = { "z", "e", "x", "c", "m", "q", "a" };

            Console.WriteLine("### Quick Sort ###");
            Console.WriteLine("Unsorted:");

            // Print the unsorted array
            DisplayMyArray(unsorted);
            
            // Sort the array
            Quicksort(unsorted, 0, unsorted.Length - 1);

            Console.WriteLine("\nQuick Sort:");

            // Print the sorted array
            DisplayMyArray(unsorted);

            Console.ReadLine();
        }


    }
}