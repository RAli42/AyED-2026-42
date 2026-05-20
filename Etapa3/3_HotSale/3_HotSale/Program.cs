using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_HotSale
{
    class Program
    {
        static void Main(string[] args)
        {
            int numAlto = 0;
            int numProductoAlto = 0;
            int numBajo = 0;
            int numProductoBajo = 0;

            Console.WriteLine("Ingrese la cantidad de productos vendidos en el Hot Sale: ");
            int[] Productos = new int[int.Parse(Console.ReadLine())];
            for (int i = 0; i < Productos.Length; i++)
            {
                Console.Clear();
                Console.WriteLine("");
                Console.WriteLine("Ingrese el valor del producto " + (i + 1));
                Productos[i] = int.Parse(Console.ReadLine());
            }
            for (int i = 0; i < Productos.Length; i++)
            {
                if (numAlto <= Productos[i])
                {
                    numAlto = Productos[i];
                    numProductoAlto = i;
                }
            }
            numBajo = numAlto;
            for (int i = 0; i < Productos.Length; i++)
            {
                if (numBajo >= Productos[i])
                {
                    numBajo = Productos[i];
                    numProductoBajo = i;
                }
            }
            Console.Clear();
            Console.WriteLine("");
            Console.WriteLine("El producto de mayor valor vendido fue el producto " + numProductoAlto + " con un valor de " + numAlto );
            Console.WriteLine("");
            Console.WriteLine("El producto de menor valor vendido fue el producto " + numProductoBajo + " con un valor de " + numBajo);
            Console.ReadKey();
        }
    }
}
