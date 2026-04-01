using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7_MiResto
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ingrese un numero: ");
            float numero1 = float.Parse(Console.ReadLine());
            Console.Write("Ingrese otro numero: ");
            float numero2 = float.Parse(Console.ReadLine());
            float resultado = numero1 % numero2;
            Console.WriteLine("El resto del primer numero por el segundo es: " + resultado);
            Console.ReadKey();
        }
    }
}
