using System;
namespace ConsoleApplication3
{
    class Program
    {
        static void Main(string[] args)
        {
            
            int[] numeros = { 5, 3, 8, 10, 6, 4, 1, 9, 13, 2, 7, 11, 14, 17, 18 };
            int[] pares = new int[15];
            int[] impares = new int[15];

            int contPar = 0;
            int contImpar = 0;

            for (int i = 0; i < numeros.Length; i++)
            {
                if (numeros[i] % 2 == 0)
                {
                    pares[contPar] = numeros[i];
                    contPar++;
                }
                else
                {
                    impares[contImpar] = numeros[i];
                    contImpar++;
                }
            }

            Console.WriteLine("Pares:");
            for (int i = 0; i < contPar; i++)
            {
                Console.WriteLine(pares[i]);
            }

            Console.WriteLine("Impares:");
            for (int i = 0; i < contImpar; i++)
            {
                Console.WriteLine(impares[i]);
            }

            Console.ReadKey();
        }
    }
}
