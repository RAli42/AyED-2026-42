using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_Calculando
{
    class Program
    {
        static void Main(string[] args)
        {
            calculadora();
        }
        static void calculadora()
        {
            bool bucle = true;
            int n = 0;
            int n2 = 0;
            while (bucle)
            {
                Console.WriteLine("Seleccione una funcion: ");
                Console.WriteLine("");
                Console.WriteLine("1. Sumar");
                Console.WriteLine("2. Restar");
                Console.WriteLine("3. Multiplicar");
                Console.WriteLine("4. Dividir");
                Console.WriteLine("5. Salir");
                int opcion = int.Parse(Console.ReadLine());

                switch (opcion)
                {
                    case 1:
                        Console.Clear();
                        Console.Write("Ingrese el primer numero: ");
                        n = int.Parse(Console.ReadLine());
                        Console.Write("Ingrese el segundo numero: ");
                        n2 = int.Parse(Console.ReadLine());
                        Console.WriteLine("El resultado de la suma es: " + sumar(n, n2));
                        break;
                    case 2:
                        Console.Clear();
                        Console.Write("Ingrese el primer numero: ");
                        n = int.Parse(Console.ReadLine());
                        Console.Write("Ingrese el segundo numero: ");
                        n2 = int.Parse(Console.ReadLine());
                        Console.WriteLine("El resultado de la resta es: " + restar(n, n2));
                        break;
                    case 3:
                        Console.Clear();
                        Console.Write("Ingrese el primer numero: ");
                        n = int.Parse(Console.ReadLine());
                        Console.Write("Ingrese el segundo numero: ");
                        n2 = int.Parse(Console.ReadLine());
                        Console.WriteLine("El resultado de la multiplicacion es: " + multiplicar(n, n2));
                        break;
                    case 4:
                        Console.Clear();
                        Console.Write("Ingrese el primer numero: ");
                        n = int.Parse(Console.ReadLine());
                        Console.Write("Ingrese el segundo numero: ");
                        n2 = int.Parse(Console.ReadLine());
                        Console.WriteLine("El resultado de la division es: " + dividir(n, n2));
                        break;
                    case 5:
                        Console.Clear();
                        bucle = false;
                        break;
                    default:
                        Console.WriteLine("Opción no válida");
                        break;
                }
                Console.WriteLine("Presione para continuar.");
                Console.ReadKey();
                Console.Clear();
            }
        }
        static int sumar(int n, int n2)
        {
            int resultado = n + n2;
            return resultado;
        }
        static int restar(int n, int n2)
        {
            int resultado = n - n2;
            return resultado;
        }
        static int multiplicar(int n, int n2)
        {
            int resultado = n * n2;
            return resultado;
        }
        static int dividir(int n, int n2)
        {
            int resultado = n / n2;
            return resultado;
        }
    }
}