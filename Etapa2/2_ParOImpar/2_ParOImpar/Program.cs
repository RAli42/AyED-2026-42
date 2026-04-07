using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_ParOImpar
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ingrese un numero: ");
            int num = int.Parse(Console.ReadLine());
            int num1 = num % 2;
            if( num1 == 0)
            {
                Console.WriteLine("Su numero es par.");
            }else
            {
                Console.WriteLine("Su numero es impar.");
            }
            Console.ReadKey();
        }
    }
}
