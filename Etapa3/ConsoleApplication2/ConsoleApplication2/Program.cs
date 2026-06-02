using System;

namespace ConsoleApplication2
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numeros;
            numeros = new int[8];
            int contador = 0;

            for (int i = 0; i < numeros.Length; i++)
            {
                Console.Write("Ingrese un numero: ");
                numeros[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("Números pares:");


            for (int i = 0; i < numeros.Length; i++)
            {

                if (numeros[i] % 2 == 0)
                {
                    Console.WriteLine(numeros[i]);

                    contador++;
                }
            }

            Console.WriteLine("Cantidad de pares: " + contador);
            Console.ReadKey();
        }
    }
}
