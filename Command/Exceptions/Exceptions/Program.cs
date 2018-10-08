using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exceptions
{

    public class TempIsZeroException : Exception
    {
        // Constructor
        public TempIsZeroException(string message) : base(message)
        {
        }
    }

    public class Temperature
    {
        int temperature = 10;
        public void showTemp()
        {
            if (temperature == 0)
            {
                throw (new TempIsZeroException("Zero Temperature found"));
            }
            else
            {
                Console.WriteLine("Temperature: {0}", temperature);
            }
        }
    }

    public class DivideEnteros
    {
        int resultado;

        // Constructor
        DivideEnteros()
        {
            resultado = 0;
        }

        public void divideEnteros(int entero1, int entero2)
        {
            try
            {
                resultado = entero1 / entero2;
            }
            catch (DivideByZeroException dze)
            {
                Console.WriteLine("Exception caught: {0}", dze);
            }
            finally
            {
                Console.WriteLine("Resultado: {0}", resultado);
            }
        }

        // Main program
        static void Main(string[] args)
        {
            Temperature temp = new Temperature();
            try
            {
                    temp.showTemp();
            }
            catch (TempIsZeroException e)
            {
                    Console.WriteLine("TempIsZeroException: {0}", e.Message);
            }
            DivideEnteros d = new DivideEnteros();
            d.divideEnteros(25, 5);
            d.divideEnteros(25, 0);
            Console.ReadKey();
        }
    }

}
