using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nivel3
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Nivel 3 – Firewalls adyacentes (LITE)");
            int[,] g =
            {
            {0,1,0},
            {1,0,1},
            {0,1,0}
        };
            bool ok = Level3.CountAdjacent(g, 1, 1) == 4
                   && Level3.CountAdjacent(g, 0, 0) == 2;
            Console.WriteLine(ok ? "✔ UNLOCK → Fragmento: -OK" : "🔒 LOCKED");
        }
    }

    static class Level3
    {
        public static int CountAdjacent(int[,] grid, int row, int col)
        {
            int total = 0;
            int filas = grid.GetLength(0);
            int columnas = grid.GetLength(1);

            if (row - 1 >= 0 && row - 1 < filas && col >= 0 && col < columnas)
            {
                if (grid[row - 1, col] == 1)
                {
                    total++;
                }
            }

            if (row + 1 >= 0 && row + 1 < filas && col >= 0 && col < columnas)
            {
                if (grid[row + 1, col] == 1)
                {
                    total++;
                }
            }

            if (row >= 0 && row < filas && col - 1 >= 0 && col - 1 < columnas)
            {
                if (grid[row, col - 1] == 1)
                {
                    total++;
                }
            }

            if (row >= 0 && row < filas && col + 1 >= 0 && col + 1 < columnas)
            {
                if (grid[row, col + 1] == 1)
                {
                    total++;
                }
            }

            return total;
        }
    }
}
