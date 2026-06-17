using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11_CalificacionesEstudiantes
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int n = 0;
            Console.WriteLine("Ingrese la cantidad de estudiantes: ");
            n = int.Parse(Console.ReadLine());

            string[,] matrizUno = new string[n, 3];

            Console.WriteLine("");
            for (int i = 0; i < n; i++)
            {
                Console.Clear();
                Console.WriteLine("Introduzca el nombre del estudiante numero " + (i + 1));
                matrizUno[i, 0] = Console.ReadLine();
                Console.WriteLine("");
                Console.WriteLine("Introduzca la edad del estudiante numero " + (i + 1));
                matrizUno[i, 1] = Console.ReadLine();
                Console.WriteLine("");
                Console.WriteLine("Introduzca la calificacion del estudiante numero " + (i + 1));
                matrizUno[i, 2] = Console.ReadLine();
                Console.WriteLine("");
            }
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < 3; j++) 
                {
                    Console.Write(matrizUno[i, j] + " ");
                }
                Console.WriteLine("");
            }
            Console.ReadKey();
            }
        }
    }

