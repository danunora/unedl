using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases.Vehiculos
{
    public class Vehiculo
    {
        public String marcaVehiculo = "Volkswagen";
        public String modeloVehiculo = "Sedan" ;

        public void info()
        {
            Console.WriteLine("Marca: {0}, Modelo: {1}", marcaVehiculo, modeloVehiculo);
        }

        public void encender()
        {
            Console.WriteLine("El motor ha sido encendido");
        }

        public void apagar()
        {
            Console.WriteLine("El motor ha sido apagado");
        }

    }
}
