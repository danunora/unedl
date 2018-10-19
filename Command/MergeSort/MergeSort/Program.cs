/*
 * C# Program to Perform Merge Sort
 * source: https://www.sanfoundry.com/csharp-program-merge-sort/
 */

using System;
using System.Collections.Generic;
using System.Text;
namespace prog
{

    class Program
    {
        static public void mergemethod(int[] numbers, int left, int mid, int right)
        {
            int[] temp = new int[25];
            int i, left_end, num_elements, tmp_pos;        
            left_end = (mid - 1);
            tmp_pos = left;
            num_elements = (right - left + 1);
            while ((left <= left_end) && (mid <= right))
            {
                if (numbers[left] <= numbers[mid])
                    temp[tmp_pos++] = numbers[left++];
                else
                    temp[tmp_pos++] = numbers[mid++];
            }
            while (left <= left_end)
                temp[tmp_pos++] = numbers[left++];
            while (mid <= right)
                temp[tmp_pos++] = numbers[mid++];
            for (i = 0; i < num_elements; i++)
            {
                numbers[right] = temp[right];
                right--;
            }
        }

        static public void sortmethod(int[] numbers, int left, int right)
        {
            int mid;
            if (right > left)
            {
                mid = (right + left) / 2;
                sortmethod(numbers, left, mid);
                sortmethod(numbers, (mid + 1), right);
                mergemethod(numbers, left, (mid + 1), right);
            }
        }

        static void DisplayMyArray(int[] myArray)
        {
            foreach (int i in myArray)
                Console.Write(i + " ");
        }

        static void Main(string[] args)
        {
            int len = 9;
            int[] numbers = { 3, 8, 7, 5, 2, 1, 9, 6, 4 };

            Console.WriteLine("### Merge Sort ###");

            Console.WriteLine("Unsorted :");
            DisplayMyArray(numbers);

            sortmethod(numbers, 0, len - 1);

            Console.WriteLine("\nMerge Sort :");
            DisplayMyArray(numbers);
            Console.Read();
        }

    }
}