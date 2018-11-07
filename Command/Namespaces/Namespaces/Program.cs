using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using primer_namespace;
using primer_namespace.segundo_namespace;

namespace primer_namespace
{
    class Abc
    {
        public void func()
        {
            Console.WriteLine("Abc func primer namespace");
        }
    }

    namespace segundo_namespace
    {
        class Abc
        {
            public void func()
            {
                Console.WriteLine("Abc func segundo namespace");
            }
        }
        class Efg
        {
            public void func()
            {
                Console.WriteLine("Efg func segundo namespace");
            }
        }
    }
}
    class testClass
    {
        static void Main(string[] args)
        {
        Abc pc = new Abc();
        Efg sc = new Efg();
        pc.func();
        sc.func();
        Console.ReadKey();
        }
    }

