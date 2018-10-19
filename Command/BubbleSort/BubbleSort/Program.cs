﻿// source: https://www.tutorialspoint.com/Bubble-Sort-program-in-Chash
using System;

namespace BubbleSort
{
    class Program
    {        
        static void Main(string[] args)
        {
            int[] arr = { 78, 55, 45, 98, 13 };
            Console.WriteLine("UnSorted:");
            DisplayMyArray(arr);

            int temp;
            for (int j = 0; j <= arr.Length - 2; j++)
            {
                for (int i = 0; i <= arr.Length - 2; i++)
                {
                    if (arr[i] > arr[i + 1])
                    {
                        temp = arr[i + 1];
                        arr[i + 1] = arr[i];
                        arr[i] = temp;
                    }
                }
            }

            Console.WriteLine("\nSorted:");
            DisplayMyArray(arr);
            Console.Read();

        }

        // Display the array
        static void DisplayMyArray(int[] myArray)
        {
            foreach (int p in myArray)
                Console.Write(p + " ");
        }
    }
}