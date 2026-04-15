using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14_HastaQueSi
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Desea terminar el programa? ");
            string resp = Console.ReadLine();
            while (resp != "SI")
            {
                Console.Write("Respuesta no valida. ");
                Console.Write("Desea terminar el programa? ");
                resp = Console.ReadLine();
            }
            Console.ReadKey();
            
        }
    }
}
