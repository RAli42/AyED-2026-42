using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _18_AreaTriangulo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Introduzca la medida de la base de un triangulo: ");
            int base1 = int.Parse(Console.ReadLine());
            Console.Write("Introduzca la medida de la altura de un triangulo: ");
            int altura = int.Parse(Console.ReadLine());
            float area = (base1 * altura) / 2;
            Console.WriteLine("El area de su triangulo es: " + area);
            Console.ReadKey();
        }
    }
}
