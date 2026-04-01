using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9_CelsiusFarenheit
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese una cantidad de grados C");
            float c = float.Parse(Console.ReadLine());
            double f = c * 1.8 + 32;
            double k = c + 237.15;
            Console.WriteLine("Los grados que ingreso en Fahrenheit es: " + f);
            Console.WriteLine("Los grados que ingreso en Kelvin es: " + k);
            Console.ReadKey();
        }
    }
}
