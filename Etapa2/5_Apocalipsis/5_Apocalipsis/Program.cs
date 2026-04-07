using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5_Apocalipsis
{
    class Program
    {
        static void Main(string[] args)
        {
            int contador = 0;
            Console.WriteLine("Tiene un refugio? (si/no)");
            if(Console.ReadLine().ToLower() == "si")
            {
                bool refu = true;
            }
            Console.WriteLine("Tiene comida? (true/false)");
            bool comi = bool.Parse(Console.ReadLine());
            Console.WriteLine("Tiene un bate? (true/false)");
            bool bate = bool.Parse(Console.ReadLine());
            Console.WriteLine("Tiene agua? (true/false)");
            bool agua = bool.Parse(Console.ReadLine());
            Console.WriteLine("Tiene una mochila? (true/false)");
            bool mochila = bool.Parse(Console.ReadLine());
            Console.WriteLine("Tiene un botiquin? (true/false)");
            bool boti = bool.Parse(Console.ReadLine());
            if ((refu == true ) || (mochila == true))
            {
                contador = contador + 1;
            }
            if ((comi == true) || (agua == true))
            {
                contador = contador + 1;
            }
            if ((bate == true) || (boti == true))
            {
                contador = contador + 1;
            }
            if(contador >= 2)
            {
                Console.WriteLine("Sobreviviras al apocalipsis.");
            }
            if (contador <= 1)
            {
                Console.WriteLine("No sobreviviras al apocalipsis.");
            }
            Console.ReadKey();
        }
    }
}
