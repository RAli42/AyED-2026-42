using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _23_CapacidadHDD
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Indique una cantidad de cilindros: ");
            int cilin = int.Parse(Console.ReadLine());
            Console.Write("Indique una cantidad de pistas por cilindro: ");
            int picilin = int.Parse(Console.ReadLine());
            Console.Write("Indique una cantidad de sectores por pista: ");
            int secto = int.Parse(Console.ReadLine());
            int bytes = cilin * picilin * secto * 512;
            float kylo = bytes / 1024;
            float mega = kylo / 1024;
            float giga = mega / 1024;
            Console.WriteLine("Su disco duro tiene " + kylo + "KB");
            Console.WriteLine("En Megabytes: " + mega + "MB");
            Console.WriteLine("Y en Gigabytes: " + giga + "GB");
            Console.ReadKey();
        }
    }
}
