using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_Password
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Introduzca una contraseña: ");
            string contraseña = Console.ReadLine();
            string contra1 = contraseña.ToLower();
            Console.Write("Introduzca su contraseña: ");
            string contra = Console.ReadLine();
            string contra2 = contra.ToLower();
            if(contra1 == contra2)
            {
                Console.WriteLine("Contraseña Correcta.");
            }else
            {
                Console.WriteLine("Contraseña Incorrecta.");
            }
            Console.ReadKey();
        }
    }
}
