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
            vehiculo.setModelo("Sedan");
            vehiculo.setNumeroSerie("3872HERW");

            // Se obtiene el valor (se lee desde el HEAP)
            // Se imprime en la pantalla
            Console.WriteLine("Marca  : " + vehiculo.getMarca());
            Console.WriteLine("Modelo : " + vehiculo.getModelo());
            Console.WriteLine("Serie  : " + vehiculo.getNumeroSerie());
            vehiculo.encenderVehiculo();
            Console.WriteLine("Estado Motor : " + vehiculo.getEncendido());

            // Herencia AutoCompacto hereda de Vehiculo
            AutoCompacto ferrari = new AutoCompacto();
            ferrari.setMarca("Ferrari");
            ferrari.setModelo("F40");
            ferrari.setNumeroSerie("9872KOW");
            Console.WriteLine("Marca : " + ferrari.getMarca());
            Console.WriteLine("Modelo : " + ferrari.getModelo());
            Console.WriteLine("Serie  : " + ferrari.getNumeroSerie());
            ferrari.encenderVehiculo();
            Console.WriteLine("Estado Motor : " + ferrari.getEncendido());

            AutoCompacto camaro = new AutoCompacto("Chevrolet");
            Console.WriteLine("Marca: " + camaro.getMarca());
            
        }

    }
}
