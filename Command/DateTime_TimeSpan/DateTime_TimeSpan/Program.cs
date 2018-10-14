using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DateTime_TimeSpan
{
    class Program
    {
        static void Main(string[] args)
        {
            var fecha = new DateTime(2015, 1, 1);
            var ahora = DateTime.Now;
            var hoy = DateTime.Today;
            Console.WriteLine("La fecha de ahora  : " + ahora.Date);
            Console.WriteLine("La hora de ahora   : " + ahora.Hour);
            Console.WriteLine("El minuto de ahora : " + ahora.Minute);
            var manana = ahora.AddDays(1);
            var ayer = ahora.AddDays(-1);
            Console.WriteLine("La fecha de mañana : " + manana.Date);
            Console.WriteLine("La fecha de ayer : " + ayer.Date);
            Console.WriteLine(ahora.ToLongDateString());
            Console.WriteLine(ahora.ToShortDateString());
            Console.WriteLine(ahora.ToLongTimeString());
            Console.WriteLine(ahora.ToShortTimeString());
            Console.WriteLine(manana.ToString("yyyy-MM-dd HH:mm"));

            // timeSpan hh:mm:ss
            var timeSpan = new TimeSpan(1, 2, 3);
            var start = DateTime.Now;
            var end = DateTime.Now.AddMinutes(2);
            var duration = end - start;
            Console.WriteLine("Duration : " + duration);

            // Properties
            Console.WriteLine("Minutes : " + timeSpan.Minutes);
            Console.WriteLine("Total minutes : " + timeSpan.TotalMinutes);

            // Add & Substract
            Console.WriteLine("Add Example : " + timeSpan.Add(TimeSpan.FromMinutes(8)));
            Console.WriteLine("Sub Example : " + timeSpan.Subtract(TimeSpan.FromMinutes(2)));

            //

        }
    }
}
