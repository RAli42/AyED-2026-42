using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15_NombreCompleto
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Introduzca su nombre: ");
            string nombre = Console.ReadLine();
            Console.Write("Introduzca su apellido: ");
            string apellido = Console.ReadLine();
            Console.WriteLine("Hola " + nombre + " " + apellido);
            Console.ReadKey();
        }
    }
}
