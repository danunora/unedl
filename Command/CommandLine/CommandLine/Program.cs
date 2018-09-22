using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandLine
{
    class Program
    {
        static void Main(string[] args)
        {
            if (args.Length == 0)
            {
                usage();
            }
            else
            {
                evalParams(args);
            }       
        }

        public static int usage()
        {
            Console.WriteLine("Please enter an argument");
            Console.WriteLine("Usage: ");
            return 1;
        }

        public static void evalParams(string[] args)
        {
            foreach (string arg in args)
            {
                Console.WriteLine("argument: {0}",arg);
                switch (arg)
                {
                    case "-b":
                        Console.WriteLine("valor -b :{0}", arg);
                        break;
                }
            }

        }
    
    }
}
