using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _17_PerimetroCuadrado
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Introduzca la medida del lado de un cuadrado: ");
            int lado = int.Parse(Console.ReadLine());
            float perimetro = lado * 4;
            float superficie = lado * lado;
            Console.WriteLine("El perimetro de su cuadrado es: " + perimetro + " y la superficies es: " + superficie);
            Console.ReadKey();
        }

    }
}
