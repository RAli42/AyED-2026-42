using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16_WhileYWhile
{
    class Program
    {
        static void Main(string[] args)
        {
            bool impares = false;
            bool pares = false;
            bool ceroACien = false;
            bool cienACero = false;
            bool multiplosTres = false;
            bool multiplosTresYDos = false;

            Console.WriteLine(" ");
            Console.WriteLine(" ");
            Console.WriteLine("Numeros ImPares: ");
            // Numero Impares
            while (impares == false)
            {
                int contador = 0;
                while (contador <= 100)
                {
                    if (contador % 2 == 0)
                    {
                        contador = contador + 1;
                    }
                    else
                    {
                        Console.Write("-" + contador);
                        contador = contador + 1;
                    }
                }
                impares = true;
            }

            Console.WriteLine(" ");
            Console.WriteLine(" ");
            Console.WriteLine("Numeros Pares: ");
            // Numero Pares
            while (pares == false)
            {
                int contador = 0;
                while (contador <= 100)
                {
                    if (contador % 2 == 0)
                    {
                        Console.Write("-" + contador);
                        contador = contador + 1;
                    }
                    else
                    {
                        contador = contador + 1;
                    }
                }
                pares = true;
            }

            Console.WriteLine(" ");
            Console.WriteLine(" ");
            Console.WriteLine("Numeros de cero a cien: ");
            // Numero de cero a cien
            while (ceroACien == false)
            {
                int contador = 0;
                while (contador <= 100)
                {
                    Console.Write("-" + contador);
                    contador = contador + 1;
                }
                ceroACien = true;
            }

            Console.WriteLine(" ");
            Console.WriteLine(" ");
            Console.WriteLine("Numeros de cien a cero: ");
            // Numero de cien a cero
            while (cienACero == false)
            {
                int contador = 100;
                while (contador >= 0)
                {
                    Console.Write("-" + contador);
                    contador = contador - 1;
                }
                cienACero = true;
            }

            Console.WriteLine(" ");
            Console.WriteLine(" ");
            Console.WriteLine("Numeros multiplos de 3: ");
            // Multiplos de 3
            while (multiplosTres == false)
            {
                int contador = 0;
                while (contador <= 100)
                {
                    if (contador % 3 == 0)
                    {
                        Console.Write("-" + contador);
                        contador = contador + 1;
                    }
                    else
                    {
                        contador = contador + 1;
                    }
                }
                multiplosTres = true;
            }

            Console.WriteLine(" ");
            Console.WriteLine(" ");
            Console.WriteLine("Numeros multiplos de 3 y 2: ");
            // Multiplos de 3
            while (multiplosTresYDos == false)
            {
                int contador = 0;
                while (contador <= 100)
                {
                    if (contador % 3 == 0 && contador % 2 == 0)
                    {
                        Console.Write("-" + contador);
                        contador = contador + 1;
                    }
                    else
                    {
                        contador = contador + 1;
                    }
                }
                multiplosTresYDos = true;
            }
            Console.ReadKey();
        }
    }
}
