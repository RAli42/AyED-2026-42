using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _17_MiPrimerMenu
{
    class Program
    {
        static void Main(string[] args)
        {
            bool done = false;

            Console.WriteLine("--Menu--");
            Console.WriteLine("Opcion 1");
            Console.WriteLine("Opcion 2");
            Console.WriteLine("Opcion 3");
            Console.WriteLine("Opcion 4");
            Console.WriteLine(" ");
            Console.WriteLine("Eliga una opcion");
            Console.Write("Opcion ");
            while (done == false)
            {
                int opcion = int.Parse(Console.ReadLine());
                switch (opcion)
                {
                    case 1:
                        Console.WriteLine("Seleccionó la opción 1");
                        Console.Write("Introduzca un numero: ");
                        int num1 = int.Parse(Console.ReadLine());
                        Console.Write("Introduzca un numero: ");
                        int num2 = int.Parse(Console.ReadLine());
                        int suma = num1 + num2;
                        Console.WriteLine("El resultado de la suma de sus dos numeros es: " + suma);
                        break;
                    case 2:
                        Console.WriteLine("Seleccionó la opción 2");
                        Console.Write("Introduzca un numero: ");
                        int num3 = int.Parse(Console.ReadLine());
                        Console.Write("Introduzca un numero: ");
                        int num4 = int.Parse(Console.ReadLine());
                        int resta = num3 - num4;
                        Console.WriteLine("El resultado de la resta de sus dos numeros es: " + resta);
                        break;
                    case 3:
                        Console.WriteLine("Seleccionó la opción 3");
                        Console.Write("Introduzca un numero: ");
                        int num5 = int.Parse(Console.ReadLine());
                        Console.Write("Introduzca un numero: ");
                        int num6 = int.Parse(Console.ReadLine());
                        int multiplicacion = num5 * num6;
                        Console.WriteLine("El resultado de la multiplicacion de sus dos numeros es: " + multiplicacion);
                        break;
                    case 4:
                        Console.WriteLine("Seleccionó la opción 4");
                        Console.Write("Introduzca un numero: ");
                        int num7 = int.Parse(Console.ReadLine());
                        Console.Write("Introduzca un numero: ");
                        int num8 = int.Parse(Console.ReadLine());
                        double division = num7 / num8;
                        Console.WriteLine("El resultado de la division de sus dos numeros es: " + division);
                        break;
                    default:
                        Console.WriteLine("Opcion no valida");
                        done = true;
                        break;
                }
            }
            Console.ReadKey();
        }
    }
}