using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0_Nombre
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese su nombre: ");
            string entrada = Console.ReadLine();
            saludarA(entrada);
            Console.ReadKey();
        }
        static void saludarA(string nombre)
        {
            Console.WriteLine("Hola " + nombre);
        }
    }
}

