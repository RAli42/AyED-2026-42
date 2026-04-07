using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0_MayoDeEdad
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ingrese su edad: ");
            int edad = int.Parse(Console.ReadLine());
            if(edad >= 18)
            {
                Console.WriteLine("Usted es mayor de edad");
            }else
            {
                Console.WriteLine("Usted es menor de edad");
            }
            Console.ReadKey();
        }
    }
}
