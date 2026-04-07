using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_EstadoDeAgua
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ingrese la temperatura del agua: ");
            int temp = int.Parse(Console.ReadLine());
            if (temp >= 100)
            {
                Console.WriteLine("El Agua esta hirviendo.");
            }
            if ((temp < 100) && (temp > 0))
            {
                Console.WriteLine("El Agua esta en estado liquido.");
            }
            if (temp <= 0)
            {
                Console.WriteLine("El Agua esta congelada.");
            }
            Console.ReadKey();
        }
    }
}
