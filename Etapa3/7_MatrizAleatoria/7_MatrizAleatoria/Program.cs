using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7_MatrizAleatoria
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int col = 0;
            int fila = 0;
            Console.WriteLine("Ingrese una cantidad de columnas para la matriz: ");
            col = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese una cantidad de filas para la matriz: ");
            fila = int.Parse(Console.ReadLine());
            int[,] matriz = new int[col, fila];
            Console.WriteLine("");
            for (int i = 0; i < col; i++)
            {
                for (int j = 0; j < fila; j++)
                {
                    matriz[i, j] = random.Next(1,100);
                }
            }
            for (int i = 0; i < col; i++)
            {
                for (int j = 0; j < fila; j++)
                {
                    Console.Write(matriz[i, j] + " ");
                }
                Console.WriteLine("");
            }
            Console.ReadKey();
        }
    }
}
