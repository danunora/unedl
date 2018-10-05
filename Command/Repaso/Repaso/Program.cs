using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repaso
{
    class Program
    {
        static void Main(string[] args)
        {
            // Instanciando la clase, se reserva memoria para el objeto
            Vehiculos vehiculo = new Vehiculos();

            // Seteando un valor (se guarda en el HEAP)
            vehiculo.setMarca("Volkswagen");

            // Se obtiene el valor (se lee desde el HEAP)
            // Se imprime en la pantalla
            Console.WriteLine("Marca : " + vehiculo.getMarca());

            vehiculo.encenderVehiculo();
            Console.WriteLine("Estado Motor : " + vehiculo.getEncendido());

            // Herencia AutoCompacto hereda de Vehiculo
            AutoCompacto ferrari = new AutoCompacto();
            ferrari.setMarca("Ferrari");
            ferrari.encenderVehiculo();
            Console.WriteLine("Marca : " + ferrari.getMarca());
            Console.WriteLine("Encendido :" + ferrari.getEncendido());
            Console.WriteLine("Estado Motor : " + ferrari.getEncendido());

            AutoCompacto porshe = new AutoCompacto("porshe");
        }
    }
}
