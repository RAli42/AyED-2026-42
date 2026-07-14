using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12_AvengersAir
{
    class Program
    {
        static void Main(string[] args)
        {
            //Random random = new Random();
            bool bucle = true;
            string[,] matrizUno = new string[80, 4];
            int[,] matrizDos = new int[80, 2];
            bool[] vectorUno = new bool[80];
            int primeraClase = 0;
            int salidaEmergencia = 0;
            int claseEconomica = 0;
            int asientosLibres = 80;
            int asientosOcupados = 0;

            while (bucle == true)
            {
                Console.Clear();
                Console.WriteLine("");
                Console.WriteLine("----------------------------------------------------------");
                Console.WriteLine("Menu Principal - Avengers Air vuelo Buenos Aires / Wakanda");
                Console.WriteLine("---------------------------------------------------------");
                Console.WriteLine("");
                Console.WriteLine("Asientos Disponibles: " + asientosLibres);
                Console.WriteLine("Asientos Ocupados: " + asientosOcupados);
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("1. Vender Asiento");
                Console.WriteLine("2. Devolver Asiento");
                Console.WriteLine("3. Modificar Asiento");
                Console.WriteLine("4. Calcular Ventas");
                Console.WriteLine("5. Buscar Pasajeros por Edad");
                Console.WriteLine("6. Obtener Asientos con DNI par");
                Console.WriteLine("7. Salir");
                Console.WriteLine("");

                int opcion = int.Parse(Console.ReadLine());
                switch (opcion)
                {
                    case 1:
                        Console.Clear();
                        Console.WriteLine("Eliga el asiento que quiere comprar: ");
                        int n = int.Parse(Console.ReadLine());
                        n = n - 1;
                        if (vectorUno[n] == false)
                        {
                            if (n < 21)
                            {
                                primeraClase++;
                                asientosOcupados++;
                                asientosLibres--;
                            }
                            else if (n < 44 && n > 39)
                            {
                                salidaEmergencia++;
                                asientosOcupados++;
                                asientosLibres--;
                            }
                            else
                            {
                                claseEconomica++;
                                asientosOcupados++;
                                asientosLibres--;
                            }
                            Console.WriteLine("Introduzca su nombre: ");
                            matrizUno[n, 0] = Console.ReadLine();
                            Console.WriteLine("");
                            Console.WriteLine("Introduzca su Apellido: ");
                            matrizUno[n, 1] = Console.ReadLine();
                            Console.WriteLine("");
                            Console.WriteLine("Introduzca su edad: ");
                            matrizDos[n, 0] = int.Parse(Console.ReadLine());
                            Console.WriteLine("");
                            Console.WriteLine("Introduzca su DNI: ");
                            matrizDos[n, 1] = int.Parse(Console.ReadLine());
                            Console.WriteLine("");
                            Console.WriteLine("Introduzca su nacionalidad: ");
                            matrizUno[n, 2] = Console.ReadLine();
                            Console.WriteLine("");
                            Console.WriteLine("Introduzca su estado de ocupacion: ");
                            matrizUno[n, 3] = Console.ReadLine();
                            Console.WriteLine("");
                            vectorUno[n] = true;
                            Console.WriteLine("Registro y venta del asiento realizados con exito.");
                        }
                        else
                        {
                            Console.WriteLine("Asiento elegido ocupado. Intente con otro.");
                        }
                        Console.WriteLine("");
                        Console.WriteLine("Aprete una telca para continuar...");
                        Console.ReadKey();
                        break;
                    case 2:
                        Console.Clear();
                        Console.WriteLine("Elija el asiento que quiere devolver: ");
                        int m = int.Parse(Console.ReadLine());
                        m = m - 1;
                        if (vectorUno[m] == true)
                        {
                            if (m < 21)
                            {
                                vectorUno[m] = false;
                                primeraClase--;
                                asientosOcupados--;
                                asientosLibres++;
                            }
                            else if (m < 44 && m > 39)
                            {
                                vectorUno[m] = false;
                                salidaEmergencia--;
                                asientosOcupados--;
                                asientosLibres++;

                            }
                            else
                            {
                                vectorUno[m] = false;
                                claseEconomica--;
                                asientosOcupados--;
                                asientosLibres++;
                            }
                            for (int i = 0; i < 4; i++)
                            {
                                matrizUno[m, i] = "0";
                            }
                            for (int i = 0; i < 2; i++)
                            {
                                matrizDos[m, i] = 0;
                            }
                            Console.WriteLine("Asiento devuelto con exito.");
                        }
                        else
                        {
                            Console.WriteLine("El Asiento elegido no fue comprado. Ingrese correctamente el asiento que quiere devolver.");
                        }
                        Console.WriteLine("");
                        Console.WriteLine("Aprete una telca para continuar...");
                        Console.ReadKey();
                        break;
                    case 3:
                        Console.Clear();
                        for (int i = 0; i < 80; i++)
                        {
                            if (vectorUno[i] == true)
                            {
                                Console.WriteLine("");
                                Console.WriteLine("Asiento num: " + i);
                                Console.Write("Nombre: " + matrizUno[i, 0]);
                                Console.Write(" | Apellido: " + matrizUno[i, 1]);
                                Console.Write(" | Edad: " + matrizDos[i, 0]);
                                Console.Write(" | DNI: " + matrizDos[i, 1]);
                                Console.Write(" | Nacionalidad: " + matrizUno[i, 2]);
                                Console.WriteLine(" | Ocupacion: " + matrizUno[i, 3]);
                            }
                        }
                        Console.WriteLine("Eliga el asiento que quiere modificar: ");
                        int j = int.Parse(Console.ReadLine());
                        j = j - 1;
                        if (vectorUno[j] == true)
                        {
                            Console.WriteLine("Introduzca su nombre: ");
                            matrizUno[j, 0] = Console.ReadLine();
                            Console.WriteLine("");
                            Console.WriteLine("Introduzca su Apellido: ");
                            matrizUno[j, 1] = Console.ReadLine();
                            Console.WriteLine("");
                            Console.WriteLine("Introduzca su edad: ");
                            matrizDos[j, 0] = int.Parse(Console.ReadLine());
                            Console.WriteLine("");
                            Console.WriteLine("Introduzca su DNI: ");
                            matrizDos[j, 1] = int.Parse(Console.ReadLine());
                            Console.WriteLine("");
                            Console.WriteLine("Introduzca su nacionalidad: ");
                            matrizUno[j, 2] = Console.ReadLine();
                            Console.WriteLine("");
                            Console.WriteLine("Introduzca su estado de ocupacion: ");
                            matrizUno[j, 3] = Console.ReadLine();
                            Console.WriteLine("");
                            Console.WriteLine("Registro del asiento realizado con exito.");
                        }
                        else
                        {
                            Console.WriteLine("Asiento elegido sin ocupar. Intente con otro.");
                        }
                        Console.WriteLine("");
                        Console.WriteLine("Aprete una telca para continuar...");
                        Console.ReadKey();
                        break;
                    case 4:
                        Console.Clear();
                        Console.WriteLine("Total de asientos vendidos: " + asientosOcupados);
                        int totalRecaudado = (primeraClase * 200) + (salidaEmergencia * 80) + (claseEconomica * 100);
                        Console.WriteLine("Total Recaudado: " + totalRecaudado);
                        if (primeraClase > 0)
                        {
                            Console.WriteLine("Asientos de primera clase vendidos: " + primeraClase);
                        }
                        if (salidaEmergencia > 0)
                        {
                            Console.WriteLine("Asientos de salida de emergencia vendidos: " + salidaEmergencia);
                        }
                        if (claseEconomica > 0)
                        {
                            Console.WriteLine("Asientos de clase economica: " + claseEconomica);
                        }
                        Console.WriteLine("");
                        Console.WriteLine("Aprete una telca para continuar...");
                        Console.ReadKey();
                        break;
                    case 5:
                        Console.Clear();
                        Console.WriteLine("Elija el filtro de edad: ");
                        int l = int.Parse(Console.ReadLine());
                        for (int i = 0; i < 80; i++)
                        {
                            if (matrizDos[i,0] == l)
                            {
                                Console.WriteLine("");
                                Console.WriteLine("Nombre: " + matrizUno[i, 0]);
                                Console.WriteLine("Asiento: " + (i + 1));
                            }
                        }
                        Console.WriteLine("");
                        Console.WriteLine("Aprete una telca para continuar...");
                        Console.ReadKey();
                        break;
                    case 6:
                        Console.Clear();
                        Console.WriteLine("Pasajeros con DNI par: ");
                        for (int i = 0; i < 80; i++)
                        {
                            if (matrizDos[i, 1] % 2 == 0)
                            {
                                Console.WriteLine("");
                                Console.WriteLine("Nombre: " + matrizUno[i, 0]);
                                Console.WriteLine("DNI: " + matrizDos[i, 1]);
                                Console.WriteLine("Asiento: " + (i + 1));
                            }
                        }
                        Console.WriteLine("");
                        Console.WriteLine("Aprete una telca para continuar...");
                        Console.ReadKey();
                        break;
                    case 7:
                        Console.WriteLine("Eligio cerrar el programa.");
                        bucle = false;
                        Console.WriteLine("");
                        Console.WriteLine("Aprete una telca para continuar...");
                        Console.ReadKey();
                        break;
                    default:
                        Console.WriteLine("Opcion no valida.");
                        break;
                }
            }
        }
    }
}
