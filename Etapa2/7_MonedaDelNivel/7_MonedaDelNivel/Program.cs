using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7_MonedaDelNivel
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ingrese la cantidad de monedas doradas recolectadas: ");
            int dorada = int.Parse(Console.ReadLine());
            Console.Write("Ingrese la cantidad de monedas plateadas recolectadas: ");
            int plateada = int.Parse(Console.ReadLine());
            int calculo = (dorada * 10) + (plateada * 2);
            if (calculo < 50)
            {
                Console.WriteLine("Nivel Insuficiente.");
            }
            if ((calculo > 49) && (calculo < 100))
            {
                Console.WriteLine("Nivel Superado.");
            }
            if (calculo > 99)
            {
                Console.WriteLine("Nivel completado con bonus.");
            }
            Console.ReadKey();
        }
    }
}
