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
            bool refu = false;
            bool comi = false;
            bool bate = false;
            bool agua = false;
            bool mochila = false;
            bool boti = false;
            int contador = 0;
            Console.WriteLine("Tiene un refugio? (si/no)");
            if(Console.ReadLine().ToLower() == "si")
            {
                refu = true;
            }
            Console.WriteLine("Tiene comida? (true/false)");
            if (Console.ReadLine().ToLower() == "si")
            {
                comi = true;
            }
            Console.WriteLine("Tiene un bate? (true/false)");
            if (Console.ReadLine().ToLower() == "si")
            {
                bate = true;
            }
            Console.WriteLine("Tiene agua? (si/no)");
            if (Console.ReadLine().ToLower() == "si")
            {
                agua = true;
            }
            Console.WriteLine("Tiene una mochila? (true/false)");
            if (Console.ReadLine().ToLower() == "si")
            {
                mochila = true;
            }
            Console.WriteLine("Tiene un botiquin? (true/false)");
            if (Console.ReadLine().ToLower() == "si")
            {
                boti = true;
            }
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
