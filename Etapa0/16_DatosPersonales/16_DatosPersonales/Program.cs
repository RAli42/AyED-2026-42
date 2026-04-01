using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16_DatosPersonales
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Introduzca su nombre: ");
            string nombre = Console.ReadLine();
            Console.Write("Introduzca su edad: ");
            string edad = Console.ReadLine();
            Console.Write("Introduzca su ciudad: ");
            string ciudad = Console.ReadLine();
            Console.WriteLine("Hola " + nombre + ", usted tiene " + edad + " y vive en " + ciudad);
            Console.ReadKey();
        }
    }
}
