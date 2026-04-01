using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20_MinutosAHoras
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Introduzca una cantidad de minutos: ");
            int min = int.Parse(Console.ReadLine());
            int hora = min / 60;
            int rest = min % 60;
            Console.WriteLine("Los minutos que introdujo en horas es: " + hora + "h con " + rest + "min");
            Console.ReadKey();
        }
    }
}
