using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11_AlReves
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Introduzca tres letras: ");
            String letras = Console.ReadLine();
            Console.Write(letras[2]);
            Console.Write(letras[1]);
            Console.Write(letras[0]);
            Console.ReadKey();
        }
    }
}
