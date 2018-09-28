using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClaseCuadrado
{
    class ClaseCuadrado
    {
        public int Lado;

        public ClaseCuadrado(int MyLado)
        {
            Lado = MyLado;
        }

        public void Inicializar()
        {
            if (Lado == 0)
            {
                Console.WriteLine("Ingrese valor de lado: ");
                Lado = int.Parse(Console.ReadLine());
            }             
        }

        public void ImprimirPerimetro()
        {
            Console.WriteLine("El perimetro es: {0}", Lado * 4);
        }

        public void ImprimirSuperficie()
        {
            Console.WriteLine("La superficie es: {0}", Lado * Lado);
        }

        static void Main(string[] args)
        {
            ClaseCuadrado cuadrado1 = new ClaseCuadrado(8);
            cuadrado1.Inicializar();
            cuadrado1.ImprimirPerimetro();
            cuadrado1.ImprimirSuperficie();
        }
    }
}
