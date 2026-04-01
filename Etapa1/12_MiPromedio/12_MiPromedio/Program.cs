using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12_MiPromedio
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Introduzca un numero: ");
            float numero = float.Parse(Console.ReadLine());
            Console.Write("Introduzca otro numero: ");
            float numero1 = float.Parse(Console.ReadLine());
            Console.Write("Introduzca otro numero: ");
            float numero2 = float.Parse(Console.ReadLine());
            float promedio = (numero + numero1 + numero2) / 3;
            Console.WriteLine("El promedio de sus 3 numeros es: " + promedio);
            Console.ReadKey();
        }
    }
}
