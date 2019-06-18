using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnsafeTest
{
    //{
    //    class Program
    //    {
    //        static unsafe void Main(string[] args)
    //        {
    //            char val = 'A';
    //            char* ptr = &val;

    //            Console.WriteLine("The character value is: {0} ", val);
    //            Console.WriteLine("Address of the value is: {0}", (int)ptr);
    //        }
    //    }
    //}

class Program { 
        private static void Main()
        {
            unsafe
            {
                int* arr = stackalloc int[3];
                arr[0] = 97;
                arr[1] = 98;
                arr[2] = 99;
                Console.WriteLine("\t Values");
                for (int i = 0; i <= 2; i++)
                {
                    Console.WriteLine($ "Value at {i}: {arr[i]}");
                }
                Console.WriteLine("\n\tChars");
                for (int i = 0; i <= 2; i++)
                {
                    Console.WriteLine($ "Char at {i}: {(char)*(arr + i)}");
                }

            }

        }
    }
