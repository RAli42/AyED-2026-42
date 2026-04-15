using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_Cumplidos
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Escriba su edad: ");
            int edad = int.Parse(Console.ReadLine());
            while (edad > 0)
            {
                Console.WriteLine(edad);
                edad = edad - 1;
            }
            Console.ReadKey();
        }
    }
}
