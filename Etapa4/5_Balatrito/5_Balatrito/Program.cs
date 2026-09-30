using System;

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
        int t = 10;
        int q = 12;
        int j = 11;
        int k = 13;
        int a = 14;
        string[] mano = new string[5];
        int carta = 0;
        Random random = new Random();
        for (int i = 0; i < 5; i++)
        {
            carta = random.Next(2, 15);
            if (carta == t)
            {
                mano[i] = "T";
            }
            else if (carta == q)
            {
                mano[i] = "Q";
            }
            else if (carta == j)
            {
                mano[i] = "J";
            }
            else if (carta == k)
            {
                mano[i] = "K";
            }
            else if (carta == a)
            {
                mano[i] = "A";
            }
            else
            {
                mano[i] = carta.ToString();
            }
        }
        for (int i = 0; i < 5; i++)
        {
            int palo = random.Next(1, 5);
            if (palo == 1)
            {
                mano[i] = mano[i] + "H";
            }
            else if (palo == 2)
            {
                mano[i] = mano[i] + "D";
            }
            else if (palo == 3)
            {
                mano[i] = mano[i] + "C";
            }
            else if (palo == 4)
            {
                mano[i] = mano[i] + "S";
            }
        }
        return mano;
    }
    static string TipoDeMano(string[] mano)
    {
        bool Poker = false;
        bool Trio = false;
        bool Par = false;

        for (int i = 0; i < 5; i++)
        {
            int repeticiones = 0;

            for (int j = 0; j < 5; j++)
            {
                if (mano[i][0] == mano[j][0])
                {
                    repeticiones++;
                }
            }
            if (repeticiones >= 4)
            {
                Poker = true;
            }
            else if (repeticiones == 3)
            {
                Trio = true;
            }
            else if (repeticiones == 2)
            {
                Par = true;
            }
        }

        if (Poker == true)
        {
            return "Poker";
        }
        if (Trio == true && Par == true)
        {
            return "Full";
        }
        if (Trio == true)
        {
            return "Trio";
        }
        if (Par == true)
        {
            return "Par";
        }
        else
        {
            return "Nada";
        }
    }
    static int PuntajeBase(string[] mano)
    {
        int suma = 0;

        for (int i = 0; i < 5; i++)
        {
            char rango = mano[i][0];

            if (rango == 'A')
            {
                suma += 14;
            }
            else if (rango == 'K')
            {
                suma += 13;
            }
            else if (rango == 'Q')
            {
                suma += 12;
            }
            else if (rango == 'J')
            {
                suma += 11;
            }
            else if (rango == 'T')
            {
                suma += 10;
            }
            else
            {
                suma += rango - '0';
            }
        }

        return suma;
    }
    static double Multiplicador(string tipo)
    {
        if (tipo == "Par")
        {
            return 1.5;
        }
        if (tipo == "Trio")
        {
            return 2.5;
        }
        if (tipo == "Full")
        {
            return 3.5;
        }
        if (tipo == "Poker")
        {
            return 4.0;
        }
        else
        {
            return 1.0;
        }
    }
    static double AplicarJokers(double puntaje, bool x2, bool mas10)
    {
        if (x2 == true)
        {
            puntaje = puntaje * 2;
        }
        if (mas10 == true)
        {
            puntaje = puntaje + 10;
        }
        return puntaje;
    }
    static void MostrarResumen(string[] mano, string tipo, int basePts, double mult, double total)
    {
        for(int i = 0; i < 5; i++)
        {
            Console.Write("[" + mano[i] + "]");
        }
        Console.WriteLine("");
        Console.WriteLine("Mejor combinacion encontrada: " + tipo);
        Console.WriteLine("La suma de los valores de todas las cartas: " + basePts);
        Console.WriteLine("Multiplicacion: x" + mult);
        Console.WriteLine("Puntaje total: " + total);
        Console.ReadKey();
    }
}