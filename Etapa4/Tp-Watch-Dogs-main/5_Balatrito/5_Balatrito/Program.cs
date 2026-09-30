using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5_Balatrito
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("=== MINI BALATRO ===");
            Console.WriteLine();
            // Generar una mano aleatoria de 5 cartas
            string[] mano = GenerarManoAleatoria();
            // Analizar que tipo de mano se obtuvo
            string tipo = TipoDeMano(mano);
            // Calcular el valor de las cartas
            int basePts = PuntajeBase(mano);
            // Obtener el multiplicador de la jugada
            double mult = Multiplicador(tipo);
            // Calcular puntaje antes de Jokers
            double total = basePts * mult;
            // Jokers disponibles
            bool jokerX2 = true;
            bool jokerMas10 = true;
            // Aplicar los efectos de los Jokers
            total = AplicarJokers(total, jokerX2, jokerMas10);
            // Mostrar el resultado
            MostrarResumen(mano, tipo, basePts, mult, total);
        }
        // ====================================================
        // CREAR TODAS LAS FUNCIONES NECESARIAS DEBAJO DEL MAIN
        // ====================================================

        static string[] GenerarManoAleatoria()
        {
            string[] rangos = { "A", "K", "Q", "J", "T", "9", "8", "7", "6", "5", "4", "3", "2" };
            string[] palos = { "H", "D", "C", "S" };

            string[] mano = new string[5];
            Random random = new Random();

            for (int i = 0; i < 5; i++)
            {
                string rango = rangos[random.Next(0, rangos.Length)];
                string palo = palos[random.Next(0, palos.Length)];
                mano[i] = rango + palo;
            }

            return mano;

        }
        static string TipoDeMano(string[] mano)
        {
            string[] rangos = { "A", "K", "Q", "J", "T", "9", "8", "7", "6", "5", "4", "3", "2" };
            int[] conteos = new int[rangos.Length];
            for (int i = 0; i < mano.Length; i++)
            {
                char rangoCarta = mano[i][0];
                for (int j = 0; j < rangos.Length; j++)
                {
                    if (rangoCarta.ToString() == rangos[j])
                    {
                        conteos[j]++;
                        break;
                    }
                }
            }

            bool hayTrio = false;
            bool hayPar = false;   
            for (int i = 0; i < conteos.Length; i++)
            {
                if (conteos[i] == 4)
                {
                    return "Poker";
                }
                if (conteos[i] == 3)
                {
                    hayTrio = true;
                }
                if (conteos[i] == 2)
                {
                    hayPar = true;
                }
            } 
            if (hayTrio && hayPar)
            {
                return "Full";
            } 
            if (hayTrio)
            {
                return "Trio";
            }
            if (hayPar)
            {
                return "Par";
            }
            return "Nada";

        }
        static int PuntajeBase(string[] mano)
        {
            int suma = 0;
            for (int i = 0; i< mano.Length; i++)
            {
                char rango = mano[i][0];
                switch (rango)
                {
                    case 'A': suma += 14; break;
                    case 'K': suma += 13; break;
                    case 'Q': suma += 12; break;
                    case 'J': suma += 11; break;
                    case 'T': suma += 10; break;
                    default:
                        suma += int.Parse(rango.ToString());
                        break;
                }
            }
            return suma;

        }
        static double Multiplicador(string tipo)
        {
            switch (tipo)
            {
                case "Poker"; return 4.0;
                case "Full"; return 3.5;
                case "Trio"; return 2.5;
                case "Par"; return 1.5;
                default: return 1.0;
            }
        }

    }
}
