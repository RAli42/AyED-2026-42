using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_Rectangulo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese el Ancho de un rectangulo: ");
            float Ancho = float.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el Alto de un rectangulo: ");
            float Alto = float.Parse(Console.ReadLine());
            double area = Alto * Ancho;
            double perimetro = Alto + Alto + Ancho + Ancho;
            double diagonal = Math.Sqrt(Math.Pow(Alto,2) + Math.Pow(Ancho, 2));
            Console.WriteLine("El Area de su rectangulo es: " + area);
            Console.WriteLine("El Perimetro de su rectangulo es: " + perimetro);
            Console.WriteLine("La Diagonal de su rectangulo es: " + diagonal);
            Console.ReadKey();
        }
    }
}
