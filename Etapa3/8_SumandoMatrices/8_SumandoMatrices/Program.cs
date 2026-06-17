using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8_SumandoMatrices
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
            int[,] matrizDos = new int[n, n];
            int[,] matrizTres = new int[n, n];

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
                    matrizDos[i, j] = random.Next(1, 100);
                }
            }
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    matrizTres[i, j] = matrizUno[i,j] + matrizDos[i,j];
                }
            }
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write(matrizTres[i, j] + " ");
                }
                Console.WriteLine("");
            }
            Console.ReadKey();
        }
    }
}
