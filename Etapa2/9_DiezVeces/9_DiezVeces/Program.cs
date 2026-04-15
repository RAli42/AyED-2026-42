using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9_DiezVeces
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Escriba una palabra: ");
            string palabra = Console.ReadLine();
            int contador = 1;
            while (contador <= 10)
            {
                Console.WriteLine(palabra);
                contador = contador + 1;
            }
            Console.ReadKey();
        }
    }
}
