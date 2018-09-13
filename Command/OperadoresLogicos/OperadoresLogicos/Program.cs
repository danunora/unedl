using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperadoresLogicos
{
    class Program
    {
        static void Main(string[] args)
        {
            bool Valor1 = true;
            bool Valor2 = true;
            Console.WriteLine("Valor1 {0} && Valor2 {1}: {2}",Valor1,Valor2,Valor1 && Valor2);
            Valor2 = false;
            Console.WriteLine("Valor1 {0} && Valor2 {1}: {2}",Valor1,Valor2,Valor1 && Valor2);
            int a = 1;
            int b = 2;
            int c = 3;
            Console.WriteLine("a = {0}, b = {1}, c = {2}",a,b,c);
            Console.WriteLine("a != b && c > a : {0}", a != b && c > a);
            //c = 1;
            Console.WriteLine("a = {0}, b = {1}, c = {2}", a, b, c);
            Console.WriteLine("a == b || c > a : {0}", a == b || c > a);
        }
    }
}
