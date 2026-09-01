using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_ElEternota
{
    class Program
    {
        static void Main(string[] args)
        {
            int opcion;
            int refugios = 0;
            int[,] datosRefugio = new int[20, 5];

            do
            {
                Console.Clear();
                Console.WriteLine("==== MENÚ DEL ETERNOTA ====");
                Console.WriteLine("1. Agregar refugio");
                Console.WriteLine("2. Mostrar todos los refugios");
                Console.WriteLine("3. Ocupar refugio");
                Console.WriteLine("4. Mostrar ocupados");
                Console.WriteLine("5. Refugio con más suministros");
                Console.WriteLine("6. Promedio por zona");
                Console.WriteLine("7. Filtrar por zona");
                Console.WriteLine("8. Salir");
                Console.Write("Opción: ");
                opcion = int.Parse(Console.ReadLine());
                Console.WriteLine("");
                switch (opcion)
                {
                    case 1:
                        if (refugios == 20)
                        {
                            Console.WriteLine("No hay refugios... ¡Vamos a morir!.");
                        }
                        else
                        {
                            Console.Write("Indique el Codigo del Refugio: ");
                            datosRefugio[refugios, 0] = int.Parse(Console.ReadLine());
                            for (int i = 0; i < 20; i++)
                            {
                                if (i == refugios)
                                {

                                } else
                                {
                                    while (datosRefugio[refugios, 0] == datosRefugio[i, 0])
                                    {
                                        Console.WriteLine("Codigo en uso.");
                                        Console.Write("Indique otro codigo para el Refugio: ");
                                        datosRefugio[refugios, 0] = int.Parse(Console.ReadLine());
                                    }
                                }
                            }
                            Console.Write("Indique la capacidad maxima: ");
                            datosRefugio[refugios, 1] = int.Parse(Console.ReadLine());
                            Console.Write("Indique los suministros disponibles: ");
                            datosRefugio[refugios, 2] = int.Parse(Console.ReadLine());
                            Console.WriteLine("Indique la zona.");
                            Console.WriteLine("1. Norte");
                            Console.WriteLine("2. Sur");
                            Console.WriteLine("3. Oeste");
                            Console.WriteLine("4. Centro");
                            datosRefugio[refugios, 3] = int.Parse(Console.ReadLine());
                            Console.WriteLine("Indique si esta ocupado el refugio. ");
                            Console.WriteLine("1. Si");
                            Console.WriteLine("0. No");
                            datosRefugio[refugios, 4] = int.Parse(Console.ReadLine());
                        }
                        refugios++;
                        break;
                    case 2:
                        for (int i = 0; i < 20 && i < refugios; i++)
                        {
                            Console.WriteLine("Codigo del Refugio: " + datosRefugio[i, 0]);
                            Console.WriteLine("Capacidad maxima: " + datosRefugio[i, 1]);
                            Console.WriteLine("Suministros disponibles: " + datosRefugio[i, 2]);
                            if (datosRefugio[i, 3] == 1)
                            {
                                Console.WriteLine("Zona: Norte.");
                            } else if (datosRefugio[i, 3] == 2)
                            {
                                Console.WriteLine("Zona: Sur.");
                            } else if (datosRefugio[i, 3] == 3)
                            {
                                Console.WriteLine("Zona: Oeste.");
                            }
                            else if (datosRefugio[i, 3] == 4)
                            {
                                Console.WriteLine("Zona: Centro.");
                            }
                            if (datosRefugio[i, 4] == 1)
                            {
                                Console.WriteLine("Refugio Lleno. ");
                            }
                            else
                            {
                                Console.WriteLine("Refugio con espacio.");
                            }
                            Console.WriteLine("");
                        }
                        break;
                    case 3:
                        for (int i = 0; i < refugios; i++)
                        {
                            if (datosRefugio[i, 4] == 1)
                            {
                                Console.WriteLine("Refugio: " + (i + 1));
                                Console.WriteLine("Codigo de refugio: " + datosRefugio[i, 0]);
                                Console.WriteLine("Capacidad maxima: " + datosRefugio[i, 1]);
                                Console.WriteLine("Suministros disponibles: " + datosRefugio[i, 2]);
                                if (datosRefugio[i, 3] == 1)
                                {
                                    Console.WriteLine("Zona: Norte.");
                                }
                                else if (datosRefugio[i, 3] == 2)
                                {
                                    Console.WriteLine("Zona: Sur.");
                                }
                                else if (datosRefugio[i, 3] == 3)
                                {
                                    Console.WriteLine("Zona: Oeste.");
                                }
                                else if (datosRefugio[i, 3] == 4)
                                {
                                    Console.WriteLine("Zona: Centro.");
                                }
                                Console.WriteLine("");
                            }
                        }
                        Console.WriteLine("Eliga el refugio para ocupar: ");
                        datosRefugio[(int.Parse(Console.ReadLine()) - 1), 4] = 1;
                        break;
                    case 4:
                        for (int i = 0; i < refugios; i++)
                        {
                            if (datosRefugio[i, 4] == 0)
                            {
                                Console.WriteLine("Refugio: " + (i + 1));
                                Console.WriteLine("Codigo de refugio: " + datosRefugio[i, 0]);
                                Console.WriteLine("Capacidad maxima: " + datosRefugio[i, 1]);
                                Console.WriteLine("Suministros disponibles: " + datosRefugio[i, 2]);
                                if (datosRefugio[i, 3] == 1)
                                {
                                    Console.WriteLine("Zona: Norte.");
                                }
                                else if (datosRefugio[i, 3] == 2)
                                {
                                    Console.WriteLine("Zona: Sur.");
                                }
                                else if (datosRefugio[i, 3] == 3)
                                {
                                    Console.WriteLine("Zona: Oeste.");
                                }
                                else if (datosRefugio[i, 3] == 4)
                                {
                                    Console.WriteLine("Zona: Centro.");
                                }
                                Console.WriteLine("");
                            }
                        }
                        break;
                    case 5:
                        int masSuministros = 0;
                        int codMasSuministros = 0;
                        for (int i = 0; i < refugios; i++)
                        {
                            if (datosRefugio[i, 2] > masSuministros)
                            {
                                masSuministros = datosRefugio[i,2];
                                codMasSuministros = i;
                            }
                        }
                        Console.WriteLine("Refugio: " + (codMasSuministros + 1));
                        Console.WriteLine("Codigo de refugio: " + datosRefugio[codMasSuministros, 0]);
                        Console.WriteLine("Suministros disponibles: " + datosRefugio[codMasSuministros, 2]);
                        if (datosRefugio[codMasSuministros, 3] == 1)
                        {
                            Console.WriteLine("Zona: Norte.");
                        }
                        else if (datosRefugio[codMasSuministros, 3] == 2)
                        {
                            Console.WriteLine("Zona: Sur.");
                        }
                        else if (datosRefugio[codMasSuministros, 3] == 3)
                        {
                            Console.WriteLine("Zona: Oeste.");
                        }
                        else if (datosRefugio[codMasSuministros, 3] == 4)
                        {
                            Console.WriteLine("Zona: Centro.");
                        }
                        if (datosRefugio[codMasSuministros, 4] == 1)
                        {
                            Console.WriteLine("Refugio Lleno. ");
                        }
                        else
                        {
                            Console.WriteLine("Refugio con espacio.");
                        }
                        Console.WriteLine("");
                        for (int i = 0; i < 20; i++)
                        {
                            if (i == codMasSuministros)
                            {

                            }
                            else if (datosRefugio[codMasSuministros,2] == datosRefugio[i,2])
                            {
                                Console.WriteLine("Otro refugio con la misma cantidad de suministros: ");
                                Console.WriteLine("");
                                Console.WriteLine("Refugio: " + (i + 1));
                                Console.WriteLine("Codigo de refugio: " + datosRefugio[i, 0]);
                                Console.WriteLine("Suministros disponibles: " + datosRefugio[i, 2]);
                                if (datosRefugio[i, 3] == 1)
                                {
                                    Console.WriteLine("Zona: Norte.");
                                }
                                else if (datosRefugio[i, 3] == 2)
                                {
                                    Console.WriteLine("Zona: Sur.");
                                }
                                else if (datosRefugio[i, 3] == 3)
                                {
                                    Console.WriteLine("Zona: Oeste.");
                                }
                                else if (datosRefugio[i, 3] == 4)
                                {
                                    Console.WriteLine("Zona: Centro.");
                                }
                                if (datosRefugio[i, 4] == 1)
                                {
                                    Console.WriteLine("Refugio Lleno. ");
                                }
                                else
                                {
                                    Console.WriteLine("Refugio con espacio.");
                                }
                                Console.WriteLine("");
                            }
                        }

                        break;
                    case 6:
                        int promedioNorte = 0;
                        int promedioSur = 0;
                        int promedioOeste = 0;
                        int promedioCentro = 0;
                        int cantidadNorte = 0;
                        int cantidadSur = 0;
                        int cantidadOeste = 0;
                        int cantidadCentro = 0;
                        for (int i = 0; i < refugios; i++)
                        {
                            if (datosRefugio[i,3] == 1)
                            {
                                promedioNorte = promedioNorte + datosRefugio[i, 1];
                                cantidadNorte++;
                            }
                        }
                        for (int i = 0; i < refugios; i++)
                        {
                            if (datosRefugio[i, 3] == 2)
                            {
                                promedioSur = promedioSur + datosRefugio[i, 1];
                                cantidadSur++;
                            }
                        }
                        for (int i = 0; i < refugios; i++)
                        {
                            if (datosRefugio[i, 3] == 3)
                            {
                                promedioOeste = promedioOeste + datosRefugio[i, 1];
                                cantidadOeste++;
                            }
                        }
                        for (int i = 0; i < refugios; i++)
                        {
                            if (datosRefugio[i, 3] == 4)
                            {
                                promedioCentro = promedioCentro + datosRefugio[i, 1];
                                cantidadCentro++;
                            }
                        }
                        promedioNorte = promedioNorte / cantidadNorte;
                        promedioSur = promedioSur / cantidadSur;
                        promedioOeste = promedioOeste / cantidadOeste;
                        promedioCentro = promedioCentro / cantidadCentro;
                        Console.WriteLine("");
                        Console.WriteLine("Estos son los promedios de capacidad maxima por zona: ");
                        Console.WriteLine("Zona Norte: " + promedioNorte);
                        Console.WriteLine("Zona Sur: " + promedioSur);
                        Console.WriteLine("Zona Oeste: " + promedioOeste);
                        Console.WriteLine("Zona Centro: " + promedioCentro);
                        break;
                    case 7:
                        Console.WriteLine("Eliga por que zona filtrar la lista de refugios: ");
                        Console.WriteLine("1. Norte");
                        Console.WriteLine("2. Sur");
                        Console.WriteLine("3. Oeste");
                        Console.WriteLine("4. Centro");
                        int filtroZona = int.Parse(Console.ReadLine());
                        for (int i = 0; i < 20 && i < refugios; i++)
                        {
                            if (datosRefugio[i, 4] == filtroZona)
                            {
                                Console.WriteLine("Codigo del Refugio: " + datosRefugio[i, 0]);
                                Console.WriteLine("Capacidad maxima: " + datosRefugio[i, 1]);
                                Console.WriteLine("Suministros disponibles: " + datosRefugio[i, 2]);
                                if (datosRefugio[i, 3] == 1)
                                {
                                    Console.WriteLine("Zona: Norte.");
                                }
                                else if (datosRefugio[i, 3] == 2)
                                {
                                    Console.WriteLine("Zona: Sur.");
                                }
                                else if (datosRefugio[i, 3] == 3)
                                {
                                    Console.WriteLine("Zona: Oeste.");
                                }
                                else if (datosRefugio[i, 3] == 4)
                                {
                                    Console.WriteLine("Zona: Centro.");
                                }
                                if (datosRefugio[i, 4] == 1)
                                {
                                    Console.WriteLine("Refugio Lleno. ");
                                }
                                else
                                {
                                    Console.WriteLine("Refugio con espacio.");
                                }
                                Console.WriteLine("");
                            }
                        }
                        break;
                    case 8:
                        Console.WriteLine("Saliendo del sistema... ¡Que la nevada no te atrape!");
                        break;
                    default:
                        Console.WriteLine("Opción no válida. Intente de nuevo.");
                        break;
                }
                Console.WriteLine("Presione una tecla para continuar...");
                Console.ReadKey();
            } while (opcion != 8);
        }
    }
}
