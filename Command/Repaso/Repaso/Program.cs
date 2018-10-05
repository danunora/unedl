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
            vehiculo.Encender();
            Console.WriteLine("Estado Motor : " + vehiculo.getEstadoMotor());

            // Herencia AutoCompacto hereda de Vehiculo
            AutoCompacto ferrari = new AutoCompacto();
            ferrari.setMarca("Ferrari");
            ferrari.setModelo("F40");
            ferrari.setNumeroSerie("9872KOW");
            Console.WriteLine("Marca : " + ferrari.getMarca());
            Console.WriteLine("Modelo : " + ferrari.getModelo());
            Console.WriteLine("Serie  : " + ferrari.getNumeroSerie());
            ferrari.Encender();
            Console.WriteLine("Estado Motor : " + ferrari.getEstadoMotor());

            AutoCompacto camaro = new AutoCompacto("Chevrolet");
            Console.WriteLine("Marca: " + camaro.getMarca());

            AutoDeportivo mclaren = new AutoDeportivo();
            mclaren.setMarca("McLaren");
            mclaren.setModelo("PS1");
            mclaren.setNumeroSerie("673KMW2");
            Console.WriteLine("Marca : " + mclaren.getMarca());
            Console.WriteLine("Modelo : " + mclaren.getModelo());
            Console.WriteLine("Serie  : " + mclaren.getNumeroSerie());
            mclaren.Encender();
            Console.WriteLine("Estado Motor : " + mclaren.getEstadoMotor());

        }

    }
}
