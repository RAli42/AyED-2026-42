using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _21_SueldoTotal
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Introduzca una cantidad de horas trabajadas: ");
            int hora = int.Parse(Console.ReadLine());
            Console.Write("Introduzca la cantidad de paga por hora trabajada: ");
            float paga = float.Parse(Console.ReadLine());
            float resultado = hora * paga;
            Console.WriteLine("La cantidad de paga por " + hora + "h es: " + resultado);
            Console.ReadKey();
        }
    }
}
