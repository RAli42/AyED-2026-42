using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5_MiMultiplicacion
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ingrese un numero: ");
            int numero1 = int.Parse(Console.ReadLine());
            Console.Write("Ingrese otro numero: ");
            int numero2 = int.Parse(Console.ReadLine());
            int resultado = numero1 * numero2;
            Console.WriteLine("El producto del primer numero por el segundo es: " + resultado);
            Console.ReadKey();
        }
    }
}
