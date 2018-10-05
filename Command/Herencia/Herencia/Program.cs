using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herencia
{
    class Program
    {
        static void Main(string[] args)
        {
            Automovil vocho = new Automovil();
            vocho.setMarca("Volkswagen");
            vocho.setModelo("Sedan");
            vocho.setPuertas(2);
            vocho.setTransmision("manual");
            vocho.encenderVehiculo();
            
            Console.WriteLine("Vocho Marca   : " + vocho.getMarca());
            Console.WriteLine("Vocho Modelo  : " + vocho.getModelo());
            Console.WriteLine("Vocho Puertas : " + vocho.getPuertas());
            Console.WriteLine("Vocho Trans   : " + vocho.getTransmision());
            Console.WriteLine("Vocho Motor   : " + vocho.getEstadoMotor());

            AutoDeportivo mustang = new AutoDeportivo();
            mustang.setMarca("Ford");
            mustang.setModelo("Mustang");
            mustang.encenderVehiculo();
            
            Console.WriteLine("Mustang Marca   : " + mustang.getMarca());
            Console.WriteLine("Mustang Modelo  : " + mustang.getModelo());
            Console.WriteLine("Mustang Puertas : " + mustang.getPuertas());
            Console.WriteLine("Mustang Trans   : " + mustang.getTransmision());
            Console.WriteLine("Mustang Motor   : " + mustang.getEstadoMotor());
        }
    }
}
