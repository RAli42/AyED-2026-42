using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numeros = new int[10];
            int ultimoNumero;

            for (int i = 0; i < 10; i++)
            {
                Console.Write("Ingrese un número: ");
                numeros[i] = int.Parse(Console.ReadLine());
            }

            ultimoNumero = numeros[9];

            Console.WriteLine("Números múltiplos del último número ingresado:");
            
            for (int i = 0; i < 10; i++)
            {
                if (numeros[i] % ultimoNumero == 0)
                {
                    Console.WriteLine(numeros[i]);
                }
            }

            Console.ReadKey();
        }
    }
} 
