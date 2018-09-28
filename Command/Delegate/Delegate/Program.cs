using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegate
{
    class Program
    {
        // declare delegate
        public delegate void Print(int value);

        static void Main(string[] args)
        {
            // Print delegate points to PrintNumber
            Print printDel = PrintNumber;

            printDel(100000);
            printDel(200);

            // Print delegate points to PrintMoney
            printDel = PrintMoney;

            printDel(10000);
            printDel(200);

            // Print delegate points to PrintMoney
            printDel = AddAndPrintNumber;
            printDel(10000);
            printDel(200);

            // Print delegate points to PrintMoney
            printDel = AddAndPrintMoney;
            printDel(10000);
            printDel(200);

        }

        public static void PrintNumber(int num)
        {
            Console.WriteLine("Print Number: {0,-12:N0}", num);
        }

        public static void PrintMoney(int money)
        {
            Console.WriteLine("Print Money: {0:C}", money);
        }

        public static void AddAndPrintNumber(int num)
        {
            num += 10;
            Console.WriteLine("Add and Print Number: {0,-12:N0}", num);
        }

        public static void AddAndPrintMoney(int money)
        {
            money += 10;
            Console.WriteLine("Add and Print Money: {0:C}", money);
        }

    }
}
