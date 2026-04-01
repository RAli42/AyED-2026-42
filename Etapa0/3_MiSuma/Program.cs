using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_MiSuma
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese un numero: ");
            int numero1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese otro numero: ");
            int numero2 = int.Parse(Console.ReadLine());
            int resultado = numero1 + numero2;
            Console.WriteLine("El resultado de la suma de ambos numeros es: " + resultado);
            Console.ReadKey();
        }
    }
}
