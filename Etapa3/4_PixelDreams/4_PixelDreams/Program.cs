using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_PixelDreams
{
    class Program
    {
        static void Main(string[] args)
        {
            int puntajeAlto = 0;
            int puntajeBajo = 0;

            Console.WriteLine("Ingrese la cantidad de jugadores: ");
            int[] jugadores = new int[int.Parse(Console.ReadLine())];
            for (int i = 0; i < jugadores.Length; i++)
            {
                Console.Clear();
                Console.WriteLine("");
                Console.WriteLine("Ingrese el puntaje del jugador " + (i + 1));
                jugadores[i] = int.Parse(Console.ReadLine());
            }
            for (int i = 0; i < jugadores.Length; i++)
            {
                if (puntajeAlto <= jugadores[i])
                {
                    puntajeAlto = jugadores[i];
                }
            }
            puntajeBajo = puntajeAlto;
            for (int i = 0; i < jugadores.Length; i++)
            {
                if (puntajeBajo >= jugadores[i])
                {
                    puntajeBajo = jugadores[i];
                }
            }
            Array.Sort(jugadores);
            Array.Reverse(jugadores);
            Console.Clear();
            Console.WriteLine("");
            Console.WriteLine("Mas puntos: " + puntajeAlto);
            Console.WriteLine("");
            Console.WriteLine("Menos puntos: " + puntajeBajo);
            Console.WriteLine("");
            Console.WriteLine("Este es el orden: ");
            Console.WriteLine("");
            for (int i = 0; i < jugadores.Length; i++)
            {
                Console.WriteLine("Puntos: " + jugadores[i] );
            }
            Console.ReadKey();
        }
    }
}
