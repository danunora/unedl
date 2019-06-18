using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnsafeCode_Pointers
{
    class Program
    {
        static void Main(string[] args)
        {
            //Pointers1();

//            Console.WriteLine("Hello World !");
            //Console.ReadKey();
            Pointers2();
            //Console.ReadKey();
            //Pointers3();
        }


        unsafe private static void Pointers1()
        {
            fixed (char* valor = "Hello World !\n")
            {
                char* ptr = valor;
                while (*ptr != '\0')
                {
                    Console.Write(*ptr);
                    ++ptr;
                }
            }
        }

        unsafe private static void Pointers2()
        {
            int var = 100;
            int* p = &var;
            Console.WriteLine("var: {0}", var);
            Console.WriteLine("p->ToString(): {0}", p->ToString());
            Console.WriteLine("Address: {0}", (int)p);
        }

        unsafe private static void Pointers3()
        {
            int* a = stackalloc int[10];
            for (int i = 0; i < 10; ++i)
                Console.WriteLine(a[i]);   // Print raw memory
        }
    }
}
