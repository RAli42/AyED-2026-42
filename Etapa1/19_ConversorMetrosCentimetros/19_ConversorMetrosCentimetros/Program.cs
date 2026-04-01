using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _19_ConversorMetrosCentimetros
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Introduzca una medida en metros: ");
            int metro = int.Parse(Console.ReadLine());
            float cm = metro * 100;
            float ml = metro * 1000;
            Console.WriteLine("Sus " + metro + "m en cm es: " + cm + " y en ml es: " + ml);
            Console.ReadKey();
        }
    }
}
