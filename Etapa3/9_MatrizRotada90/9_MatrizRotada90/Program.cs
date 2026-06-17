using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9_MatrizRotada90
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int n = 0;
            Console.WriteLine("Ingrese el valor de n de la matriz: ");
            n = int.Parse(Console.ReadLine());

            int[,] matrizUno = new int[n, n];

            Console.WriteLine("");
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    matrizUno[i, j] = random.Next(1, 100);
                }
            }
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write(matrizUno[i, j] + " ");
                }
                Console.WriteLine("");
            }
            Console.WriteLine("");
            Console.WriteLine("");
            for (int i = 0; i < n; i++)
            {
                for (int j = n - 1; j >= 0; j--)
                {
                    Console.Write(matrizUno[j, i] + " ");
                }
                Console.WriteLine("");
            }
            Console.ReadKey();
        }
    }
}
