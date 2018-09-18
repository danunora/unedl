using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Clases.Personas;
using Clases.Vehiculos;


namespace Clases
{
    class Program
    {
        static void Main(string[] args)
        {
            Persona persona = new Persona();
            persona.saludo();
            persona.namePersona = "Daniela";
            persona.saludo();

            Persona persona2 = new Persona();
            persona2.saludo();
            persona2.namePersona = "Sergio";
            persona2.lastPersona = "Herrera";
            persona2.saludo();

            Vehiculo vehiculo = new Vehiculo();
            vehiculo.info();
            vehiculo.encender();
            vehiculo.apagar();

        }
    }
}
