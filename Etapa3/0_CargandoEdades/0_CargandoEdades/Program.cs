using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0_CargandoEdades
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese su edad y las de otras 4 personas. ");
            int[] edades = new int[5];
            for (int i = 0; i < edades.Length; i++)
            {
                edades[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("Usted ingreso estas edades: ");
            Console.WriteLine("");
            for (int i = 0; i < edades.Length; i++)
            {
                Console.WriteLine(edades[i]);
            }
            Console.ReadKey();
        }
    }
}
