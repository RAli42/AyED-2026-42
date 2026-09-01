using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_Sumando2Numeros
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ingrese un numero para sumarlo: ");
            int n = int.Parse(Console.ReadLine());
            Console.Write("Ingrese otro numero para sumarlo: ");
            int n2 = int.Parse(Console.ReadLine());
            Console.WriteLine("El resultado de la suma es: " + skibidi(n, n2));
            Console.ReadKey();
        }
        static int skibidi(int n, int n2)
        {
            int resultado = n + n2;
            return resultado;
        }
    }
}
