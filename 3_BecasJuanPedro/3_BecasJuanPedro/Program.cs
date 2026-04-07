using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_BecasJuanPedro
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ingrese su edad: ");
            int edad = int.Parse(Console.ReadLine());
            Console.Write("Ingrese su ingreso mensual: ");
            int ingre = int.Parse(Console.ReadLine());
            if ((edad == 19 && ingre < 50000) || (edad < 19 && ingre == 0) || (edad > 19 && ingre <= 100000))
            {
                Console.WriteLine("Usted puede cobrar la beca Juan Pedro.");
            }
            else
            {
                Console.WriteLine("Usted no puede cobrar la beca Juan Pedro");
            }
            Console.ReadKey();
        }
    }
}
