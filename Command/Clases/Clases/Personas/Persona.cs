using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases.Personas
{
    public class Persona
    {
        public String namePersona = "Daniel";
        public String lastPersona = "Nuno";

        public void saludo()
        {
            Console.WriteLine("Hola {0} {1}!", namePersona, lastPersona);
        }

    }
}
