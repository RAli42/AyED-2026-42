using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14_CuadradoCubo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Introduzca un numero: ");
            float numero = int.Parse(Console.ReadLine());
            double cuadrado = Math.Pow(numero, 2);
            double cubo = Math.Pow(numero, 3);
            Console.WriteLine("El cuadrado de su numero es: " + cuadrado);
            Console.WriteLine("El cubo de su numero es: " + cubo);
            Console.ReadKey();
        }
    }
}
