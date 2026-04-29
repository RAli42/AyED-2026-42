using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Menu
{
    class Program
    {
        static void Main(string[] args)
        {
            int opcion = 2;
            switch (opcion)
            {
                case 1:
                    Console.WriteLine("Seleccionó la opción 1");
                    break;
                case 2:
                    Console.WriteLine("Seleccionó la opción 2");
                    break;
                case 3:
                    Console.WriteLine("Seleccionó la opción 3");
                    break;
                default:
                    Console.WriteLine("Opción no válida");
                    break;
            }
            Console.ReadKey();
        }
    }
}
