using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Variables
{
    class Program
    {
        static void Main(string[] args)
        {
            const float Pi = 3.14f;       
            byte numero1 = 21;
            int count1 = 10;
            float totalPrice1 = 20.95f;
            char Caracter1 = 'A';
            string firstName1 = "Daniel";
            string lastName1 = "Nuno";
            bool isWorking1 = false;

            var numero2 = 22;
            var count2 = 10;
            var totalPrice2 = 20.95f;
            var Caracter2 = 'A';
            var firstName2 = "Daniel";
            var lastName2 = "Nuno";
            var isWorking2 = false;

            Console.WriteLine(numero1);
            Console.WriteLine(count1);
            Console.WriteLine(totalPrice1);
            Console.WriteLine(Caracter1);
            Console.WriteLine(firstName1);
            Console.WriteLine(lastName1);
            Console.WriteLine(isWorking1);
            Console.WriteLine(numero2);
            Console.WriteLine(count2);
            Console.WriteLine(totalPrice2);
            Console.WriteLine(Caracter2);
            Console.WriteLine(firstName2);
            Console.WriteLine(lastName2);
            Console.WriteLine(isWorking2);

            Console.WriteLine("Byte values are: {0} to {1}",byte.MinValue, byte.MaxValue);
            Console.WriteLine("Value of Pi: {0}",Pi);
            Console.WriteLine("This is a test");
        }
    }
}
