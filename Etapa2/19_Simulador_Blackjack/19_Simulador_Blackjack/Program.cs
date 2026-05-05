using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _19_Simulador_Blackjack
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int puntajeJugador = 0;
            int puntajeCrupier = 0;
            int partidasGanadas = 0;
            int carta = 0;
            int cartasPedidasJugador = 0;
            int cartasPedidasCrupier = 0;
            int puntajeCarta = 0;
            int opcion = 0;
            int q = 11;
            int j = 12;
            int k = 13;
            int a = 14;
            bool asActivadoJugador = false;
            bool asActivadoCrupier = false;
            bool salir = false;
            bool partida = false;
            while (partida == false)
            {
                Console.WriteLine("========== BlackJack Simple ==========");
                Console.WriteLine("");
                Console.WriteLine("Partidas Ganadas = " + partidasGanadas);
                Console.WriteLine("Cartas Pedidas por el jugador = " + cartasPedidasJugador);
                Console.WriteLine("");
                Console.WriteLine("Puntaje del jugador: " + puntajeJugador);
                Console.WriteLine("Puntaje del Crupier: oculto");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("1. Pedir cartas");
                Console.WriteLine("2. Plantarse");
                Console.WriteLine("3. Ver reglas");
                Console.WriteLine("4. Salir");
                Console.WriteLine("");
                opcion = int.Parse(Console.ReadLine());
                switch (opcion)
                {
                    case 1:
                        Console.WriteLine("");
                        Console.WriteLine("Seleccionó Pedir Cartas");
                        Console.WriteLine("");
                        Console.WriteLine("Aprete una tecla para continuar. ");
                        carta = random.Next(1, 14);
                        cartasPedidasJugador++;
                        Console.ReadKey();
                        Console.Clear();
                        Console.WriteLine("");
                        if (carta == q)
                        {
                            Console.WriteLine("Te salió Q (10)");
                            puntajeCarta = 10;
                        }else if (carta == j)
                        {
                            Console.WriteLine("Te salió J (10)");
                            puntajeCarta = 10;
                        }
                        else if (carta == k)
                        {
                            Console.WriteLine("Te salió K (10)");
                            puntajeCarta = 10;
                        }
                        else if (carta == a)
                        {
                            Console.WriteLine("Te salió As (1/11)");
                            asActivadoJugador = true;
                            if (puntajeJugador + 11 >= 22)
                            {
                                puntajeCarta = 1;
                                asActivadoJugador = false;
                            }else
                            {
                                puntajeCarta = 11;
                            }
                        }else if(carta <= 11)
                        {
                            puntajeCarta = carta;
                            Console.WriteLine("Te salió " + puntajeCarta);
                        }
                        if (asActivadoJugador == true && puntajeJugador + 11 > 21)
                        {
                            puntajeJugador = puntajeJugador + 1;
                            asActivadoJugador = false;
                            Console.WriteLine("Tu as ahora es un 1.");
                        }
                        else
                        {
                            puntajeJugador = puntajeJugador + puntajeCarta;
                        }
                        Console.WriteLine("Tu Puntaje es " + puntajeJugador);
                        Console.WriteLine("");
                        Console.WriteLine("Aprete una tecla para continuar. ");
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    case 2:
                        Console.WriteLine("");
                        Console.WriteLine("Seleccionó plantarse");
                        Console.WriteLine("");
                        Console.WriteLine("Aprete una tecla para continuar. ");
                        Console.ReadKey();
                        Console.Clear();
                        while (puntajeCrupier < 17)
                        {
                            carta = random.Next(1, 14);
                            cartasPedidasCrupier++;
                            Console.WriteLine("");
                            if (carta == q)
                            {
                                Console.WriteLine("Le salió Q (10)");
                                puntajeCarta = 10;
                            }
                            else if (carta == j)
                            {
                                Console.WriteLine("Le salió J (10)");
                                puntajeCarta = 10;
                            }
                            else if (carta == k)
                            {
                                Console.WriteLine("Le salió J (10)");
                                puntajeCarta = 10;
                            }
                            else if (carta == a)
                            {
                                Console.WriteLine("Le salió As (1/11)");
                                asActivadoCrupier = true;
                                if (puntajeCrupier + 11 >= 22)
                                {
                                    puntajeCarta = 1;
                                    asActivadoCrupier = false;
                                }
                                else
                                {
                                    puntajeCarta = 11;
                                }
                            }
                            else if (carta <= 11)
                            {
                                puntajeCarta = carta;
                                Console.WriteLine("Le salió " + puntajeCarta);
                            }
                            if (asActivadoCrupier == true && puntajeCrupier + 11 > 21)
                            {
                                puntajeCrupier = puntajeCrupier + 1;
                                asActivadoCrupier = false;
                                Console.WriteLine("Su as ahora es un 1.");
                            }
                            else
                            {
                                puntajeCrupier = puntajeCrupier + puntajeCarta;
                            }
                            Console.WriteLine("Tu Puntaje es " + puntajeJugador);
                            Console.WriteLine("El Puntaje del Crupier es " + puntajeCrupier);
                            Console.WriteLine("");
                            Console.WriteLine("Cartas Pedidas por el jugador = " + cartasPedidasJugador);
                            Console.WriteLine("Cartas Pedidas por el Crupier = " + cartasPedidasCrupier);
                            Console.WriteLine("");
                            Console.WriteLine("Aprete una tecla para continuar. ");
                            Console.ReadKey();
                            Console.Clear();
                        }
                        if (puntajeCrupier > 21)
                        {
                            Console.WriteLine("El Crupier se pasó, Ganaste");
                            partidasGanadas++;
                            puntajeJugador = 0;
                            puntajeCrupier = 0;
                            carta = 0;
                            cartasPedidasJugador = 0;
                            cartasPedidasCrupier = 0;
                            asActivadoJugador = false;
                            asActivadoCrupier = false;
                            Console.WriteLine("");
                            Console.WriteLine("Aprete una tecla para continuar. ");
                            Console.ReadKey();
                            Console.Clear();
                        }else if(puntajeCrupier > puntajeJugador)
                        {
                            Console.WriteLine("El Crupier te ganó con " + puntajeCrupier);
                            Console.WriteLine("Tu tenias " + puntajeJugador);
                            Console.WriteLine("");
                            puntajeJugador = 0;
                            puntajeCrupier = 0;
                            carta = 0;
                            cartasPedidasJugador = 0;
                            cartasPedidasCrupier = 0;
                            asActivadoJugador = false;
                            asActivadoCrupier = false;
                            Console.WriteLine("");
                            Console.WriteLine("Aprete una tecla para continuar. ");
                            Console.ReadKey();
                            Console.Clear();
                        }else if(puntajeCrupier == puntajeJugador)
                        {
                            Console.WriteLine("El Crupier te empató con " + puntajeCrupier);
                            Console.WriteLine("");
                            puntajeJugador = 0;
                            puntajeCrupier = 0;
                            carta = 0;
                            cartasPedidasJugador = 0;
                            cartasPedidasCrupier = 0;
                            asActivadoJugador = false;
                            asActivadoCrupier = false;
                            Console.WriteLine("");
                            Console.WriteLine("Aprete una tecla para continuar. ");
                            Console.ReadKey();
                            Console.Clear();
                        }
                        else if (puntajeCrupier < puntajeJugador)
                        {
                            Console.WriteLine("El Crupier perdio con " + puntajeCrupier);
                            Console.WriteLine("Tu tenias " + puntajeJugador);
                            Console.WriteLine("");
                            partidasGanadas++;
                            puntajeJugador = 0;
                            puntajeCrupier = 0;
                            carta = 0;
                            cartasPedidasJugador = 0;
                            cartasPedidasCrupier = 0;
                            asActivadoJugador = false;
                            asActivadoCrupier = false;
                            Console.WriteLine("");
                            Console.WriteLine("Aprete una tecla para continuar. ");
                            Console.ReadKey();
                            Console.Clear();
                        }
                        break;
                    case 3:
                        Console.WriteLine("");
                        Console.WriteLine("Seleccionó ver las reglas");
                        Console.WriteLine("");
                        Console.WriteLine("Aprete una tecla para continuar. ");
                        Console.ReadKey();
                        Console.Clear();
                        Console.WriteLine("El objetivo es acercarse lo más posible a 21 puntos sin pasarse.");
                        Console.WriteLine("Cada carta suma puntos al puntaje total del jugador o del crupier.");
                        Console.WriteLine("Si el jugador supera los 21 puntos, pierde la partida automáticamente.");
                        Console.WriteLine("Si el jugador decide plantarse, deja de pedir cartas y comienza el turno del crupier.");
                        Console.WriteLine("El crupier debe pedir cartas automáticamente mientras tenga menos de 17 puntos.");
                        Console.WriteLine("Cuando el crupier llega a 17 puntos o más, se planta.");
                        Console.WriteLine("Si el crupier supera los 21 puntos, gana el jugador.");
                        Console.WriteLine("Si ninguno se pasa de 21, gana quien tenga el puntaje más alto.");
                        Console.WriteLine("Si ambos terminan con el mismo puntaje, la partida queda empatada.");
                        Console.WriteLine("");
                        Console.WriteLine("Aprete una tecla para continuar. ");
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    case 4:
                        Console.WriteLine("");
                        Console.WriteLine("Seleccionó salir");
                        Console.WriteLine("");
                        salir = true;
                        partida = true;
                        Console.WriteLine("Aprete una tecla para continuar. ");
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    default:
                        Console.WriteLine("Opción no válida");
                        break;
                }
                if (puntajeJugador > 21 && salir == false)
                {
                    Console.WriteLine("Tu puntaje es mayor que 21, Has perdido.");
                    Console.WriteLine("");
                    puntajeJugador = 0;
                    puntajeCrupier = 0;
                    carta = 0;
                    cartasPedidasJugador = 0;
                    cartasPedidasCrupier = 0;
                    asActivadoJugador = false;
                    asActivadoCrupier = false;
                    Console.WriteLine("Aprete una tecla para continuar. ");
                    Console.ReadKey();
                    Console.Clear();
                }

            }  
        }
    }
}
