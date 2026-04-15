using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11_CuentaRegresiva
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Escriba un numero: ");
            int num = int.Parse(Console.ReadLine());
            while (num >= 0)
            {
                Console.WriteLine(num);
                num = num - 1;
            }
            Console.ReadKey();
        }
    }
}
