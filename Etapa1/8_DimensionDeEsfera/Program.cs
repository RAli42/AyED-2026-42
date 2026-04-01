using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8_DimensionDeEsfera
{
    class Program
    {
        static void Main(string[] args)
        {
            double pi = 3.1416;
            Console.Write("Ingrese un radio: ");
            float radio = float.Parse(Console.ReadLine());
            float radio2 = radio * radio;
            float radio3 = radio * radio * radio;
            double superficie = 4 * pi * radio2;
            double volumen = radio3 * pi * 4 / 3;
            Console.WriteLine("La Superficie de su esfera es: " + superficie);
            Console.WriteLine("El Volumen de su esfera es: " + volumen);
            Console.ReadKey();

        }
    }
}
