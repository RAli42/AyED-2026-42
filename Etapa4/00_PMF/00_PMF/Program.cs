using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _00_PMF
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 3, b = 5, c = 2;
            saludarA("Raed");
            Console.WriteLine(sumar(5, 3));
            Console.WriteLine(sumar(3, 2));
            Console.WriteLine(sumar(sumar(a, sumarDos(sumar(c, b))), a));
            Console.WriteLine(sumar(sumar(5, 3), sumar(3, 2)));
            Console.ReadKey();
        }
        static void saludarA(string nombre)
        {
            Console.WriteLine("Hola " + nombre);
        }
        static int sumarDos(int n)
        {
            int resultado = n + 2;
            return resultado;
        }
        static int sumar(int n, int n2)
        {
            int resultado = n + n2;
            return resultado;
        }
    } 
}
