using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_LaFiestaDeStitch
{
    class Program
    {
        static void Main(string[] args)
        {
            int comida = 0;
            int promedio = 0;

            Console.WriteLine("Ingrese la cantidad de invitados");
            int num = int.Parse(Console.ReadLine());
            int[] invitados = new int[num];
            for (int i = 0; i < num; i++)
            {
                Console.Clear();
                Console.WriteLine("");
                Console.WriteLine("Ingrese la cantidad de comida aprox que consumira el invitado " + (i + 1));
                comida = int.Parse(Console.ReadLine());
                invitados[i] = comida;
                while (comida > 100 || comida < 0)
                {
                    Console.WriteLine("");
                    Console.WriteLine("Ingrese la cantidad de comida aprox que consumira el invitado " + (i + 1));
                    comida = int.Parse(Console.ReadLine());
                    invitados[i] = comida;
                    Console.Clear();

                }
            }
            for (int i = 0; i < num; i++)
            {
                promedio = promedio + invitados[i];
            }
            Console.Clear();
            Console.WriteLine("");
            Console.WriteLine("------------------");
            Console.WriteLine("");
            Console.WriteLine("usted debe comprar " + promedio / num + " de comida por invitado");
            Console.WriteLine("");
            Console.WriteLine("------------------");
            Console.ReadKey();
        }
    }
}
