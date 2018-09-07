using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conversion
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 1;
//            byte b = i;

            byte c = (byte)i;

//            Console.WriteLine("Value of b: {0}",b);
            Console.WriteLine("Value of c: {0}",c);

            string Numero = "1234";
//            int j = (int)Numero;
            int j = Convert.ToInt32(Numero);
            Console.WriteLine("Numero 2 int :{0}",j);
            try
            {
                byte d = Convert.ToByte(Numero);
                Console.WriteLine("Numero 2 byte : {0}", d);
            }
            catch (Exception)
            {
                Console.WriteLine("The number {0} could not be converted to a byte",Numero);
            }

            string str = "true";
            try
            {
                bool e = Convert.ToBoolean(str);
                Console.WriteLine("str {0} to boolean {1}",str,e);
            }
            catch (Exception)
            {
                Console.WriteLine("The str {0} could not be converted to boolean", str);
            }

        }
    }
}
