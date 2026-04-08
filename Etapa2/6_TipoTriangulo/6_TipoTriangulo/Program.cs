using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6_TipoTriangulo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Introduzca la medida de un lado: ");
            int lado1 = int.Parse(Console.ReadLine());
            Console.Write("Introduzca la medida de otro lado: ");
            int lado2 = int.Parse(Console.ReadLine());
            Console.Write("Introduzca la medida de otro lado: ");
            int lado3 = int.Parse(Console.ReadLine());
            if (lado1 > lado2)
            {
                if (lado1 > lado3)
                {
                    if (lado2 + lado3 > lado1)
                    {
                        Console.WriteLine("Su figura es un triangulo");
                    }else
                    {
                        Console.WriteLine("Su figura no es un triangulo");
                    }
                }else
                {
                    if (lado2 + lado1 > lado3)
                    {
                        Console.WriteLine("Su figura es un triangulo");
                    }
                    else
                    {
                        Console.WriteLine("Su figura no es un triangulo");
                    }
                }
            }
            if (lado2 > lado3)
            {
                if (lado2 > lado3)
                {
                    if (lado1 + lado3 > lado2)
                    {
                        Console.WriteLine("Su figura es un triangulo");
                    }
                    else
                    {
                        Console.WriteLine("Su figura no es un triangulo");
                    }
                }
                else
                {
                    if (lado2 + lado1 > lado3)
                    {
                        Console.WriteLine("Su figura es un triangulo");
                    }
                    else
                    {
                        Console.WriteLine("Su figura no es un triangulo");
                    }
                }
            }
            if (lado3 > lado1)
            {
                if (lado3 > lado2)
                {
                    if (lado1 + lado2 > lado3)
                    {
                        Console.WriteLine("Su figura es un triangulo");
                    }
                    else
                    {
                        Console.WriteLine("Su figura no es un triangulo");
                    }
                }
                else
                {
                    if (lado3 + lado1 > lado2)
                    {
                        Console.WriteLine("Su figura es un triangulo");
                    }
                    else
                    {
                        Console.WriteLine("Su figura no es un triangulo");
                    }
                }
            }
            if ((lado1 == lado2) && (lado3 == lado2))
            {
                Console.WriteLine("Su figura es un triangulo");
                Console.WriteLine("Ademas, su figura es un triangulo Equilatero");
            }
            if (((lado1 == lado2) && (lado1 != lado3)) || ((lado1 == lado3) && (lado1 != lado2)) || ((lado2 == lado3) && (lado2 != lado1)))
            {
                Console.WriteLine("Ademas, su figura es un triangulo Isosceles");
            }
            if ((lado1 != lado2) && (lado2 != lado3))
            {
                Console.WriteLine("Ademas, su figura es un triangulo Escaleno");
            }
                Console.ReadKey();
        }
    }
}
