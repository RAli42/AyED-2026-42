using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13_PERO
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rand = new Random();

            bool[] vectorUno = new bool[30];
            int[,] matrizDos = new int[30, 4];
            int[] vectorEstados = new int[30];

            int cantidadMisiones = 0;
            int opcion;

            do
            {
                Console.Clear();
                Console.WriteLine("==== MENÚ DEL P.E.R.O. ====");
                Console.WriteLine("1. Registrar nueva misión");
                Console.WriteLine("2. Ver todas las misiones");
                Console.WriteLine("3. Cambiar estado de una misión");
                Console.WriteLine("4. Listar misiones en curso");
                Console.WriteLine("5. Misión con más objetos a extraer");
                Console.WriteLine("6. Promedio de pegrilo por mapa");
                Console.WriteLine("7. Filtrar por mapa");
                Console.WriteLine("8. Salir");
                Console.Write("Opción: ");
                opcion = int.Parse(Console.ReadLine());

                switch (opcion)
                {
                    case 1:
                        Console.Clear();
                        if (cantidadMisiones >= 30)
                        {
                            Console.WriteLine("¡Demasiadas misiones!");
                        }
                        else
                        {
                            int indiceLibre = -1;
                            for (int i = 0; i < 30; i++)
                            {
                                if (vectorUno[i] == false)
                                {
                                    indiceLibre = i;
                                    break;
                                }
                            }

                            if (indiceLibre != -1)
                            {
                                int idMision = indiceLibre + 1;
                                matrizDos[indiceLibre, 0] = idMision;

                                int mapaElegido = 0;
                                bool mapaValido = false;
                                while (mapaValido == false)
                                {
                                    Console.Write("Ingrese número de Mapa (1 = Hagwarts, 2 = La Casa del Viejo, 3 = El Laboratorio): ");
                                    mapaElegido = int.Parse(Console.ReadLine());
                                    if (mapaElegido >= 1 && mapaElegido <= 3)
                                    {
                                        mapaValido = true;
                                    }
                                    else
                                    {
                                        Console.WriteLine("Ese mapa no es de este juegazo.");
                                    }
                                }
                                matrizDos[indiceLibre, 1] = mapaElegido;

                                int objetosAExtraer = rand.Next(1, 71);
                                matrizDos[indiceLibre, 2] = objetosAExtraer;
                                Console.WriteLine("Objetos a extraer asignados automáticamente: " + objetosAExtraer);

                                int nivelPeligro = 0;
                                bool peligroValido = false;
                                while (peligroValido == false)
                                {
                                    Console.Write("Ingrese nivel de peligro (1 a 5): ");
                                    nivelPeligro = int.Parse(Console.ReadLine());
                                    if (nivelPeligro >= 1 && nivelPeligro <= 5)
                                    {
                                        peligroValido = true;
                                    }
                                    else
                                    {
                                        Console.WriteLine("Este nivel es demasiado PEGRILOSO...");
                                    }
                                }
                                matrizDos[indiceLibre, 3] = nivelPeligro;

                                vectorEstados[indiceLibre] = 0;
                                vectorUno[indiceLibre] = true;
                                cantidadMisiones++;
                                Console.WriteLine("");
                                Console.WriteLine("Misión ID " + idMision + " registrada con éxito!");
                            }
                        }
                        break;

                    case 2:
                        Console.Clear();
                        Console.WriteLine("=== TODAS LAS MISIONES REGISTRADAS ===");
                        bool hayMisiones = false;
                        for (int i = 0; i < 30; i++)
                        {
                            if (vectorUno[i] == true)
                            {
                                hayMisiones = true;
                                string nombreMapa = "";
                                if (matrizDos[i, 1] == 1)
                                {
                                    nombreMapa = "Hagwarts";
                                }
                                else if (matrizDos[i, 1] == 2)
                                {
                                    nombreMapa = "La Casa del Viejo";
                                }
                                else if (matrizDos[i, 1] == 3)
                                {
                                    nombreMapa = "El Laboratorio";
                                }

                                string nombreEstado = "";
                                if (vectorEstados[i] == 0)
                                {
                                    nombreEstado = "Pendiente";
                                }
                                else if (vectorEstados[i] == 1)
                                {
                                    nombreEstado = "En curso";
                                }
                                else if (vectorEstados[i] == 2)
                                {
                                    nombreEstado = "Finalizado";
                                }

                                Console.WriteLine("ID: " + matrizDos[i, 0] + " | Mapa: " + nombreMapa + " | Objetos: " + matrizDos[i, 2] + " | Peligro: " + matrizDos[i, 3] + "/5 | Estado: " + nombreEstado);
                            }
                        }
                        if (hayMisiones == false)
                        {
                            Console.WriteLine("No hay misiones registradas todavía.");
                        }
                        break;

                    case 3:
                        Console.Clear();
                        Console.WriteLine("=== CAMBIAR ESTADO DE UNA MISIÓN ===");
                        Console.Write("Ingrese el ID de la misión a modificar: ");
                        int idBuscado = int.Parse(Console.ReadLine());
                        int indiceMision = idBuscado - 1;

                        if (indiceMision >= 0 && indiceMision < 30 && vectorUno[indiceMision] == true)
                        {
                            if (vectorEstados[indiceMision] == 0)
                            {
                                vectorEstados[indiceMision] = 1;
                                Console.WriteLine("La misión " + idBuscado + " cambió automáticamente de 'Pendiente' a 'En curso'.");
                            }
                            else if (vectorEstados[indiceMision] == 1)
                            {
                                vectorEstados[indiceMision] = 2;
                                Console.WriteLine("La misión " + idBuscado + " cambió automáticamente de 'En curso' a 'Finalizado'.");
                            }
                            else
                            {
                                Console.WriteLine("La misión " + idBuscado + " ya se encuentra 'Finalizada' y no puede avanzar más.");
                            }
                        }
                        else
                        {
                            Console.WriteLine("No se encontró ninguna misión registrada con ese ID.");
                        }
                        break;

                    case 4:
                        Console.Clear();
                        Console.WriteLine("=== MISIONES EN CURSO ===");
                        bool hayEnCurso = false;
                        for (int i = 0; i < 30; i++)
                        {
                            if (vectorUno[i] == true && vectorEstados[i] == 1)
                            {
                                hayEnCurso = true;
                                string nombreMapa = "";
                                if (matrizDos[i, 1] == 1)
                                {
                                    nombreMapa = "Hagwarts";
                                }
                                else if (matrizDos[i, 1] == 2)
                                {
                                    nombreMapa = "La Casa del Viejo";
                                }
                                else if (matrizDos[i, 1] == 3)
                                {
                                    nombreMapa = "El Laboratorio";
                                }

                                Console.WriteLine("ID: " + matrizDos[i, 0] + " | Mapa: " + nombreMapa + " | Objetos: " + matrizDos[i, 2] + " | Peligro: " + matrizDos[i, 3] + "/5");
                            }
                        }
                        if (hayEnCurso == false)
                        {
                            Console.WriteLine("No hay misiones en curso actualmente.");
                        }
                        break;

                    case 5:
                        Console.Clear();
                        Console.WriteLine("=== MISIÓN / MISIONES CON MÁS OBJETOS ===");

                        int maxObjetos = -1;
                        for (int i = 0; i < 30; i++)
                        {
                            if (vectorUno[i] == true)
                            {
                                if (matrizDos[i, 2] > maxObjetos)
                                {
                                    maxObjetos = matrizDos[i, 2];
                                }
                            }
                        }

                        if (maxObjetos != -1)
                        {
                            for (int i = 0; i < 30; i++)
                            {
                                if (vectorUno[i] == true && matrizDos[i, 2] == maxObjetos)
                                {
                                    string nombreMapa = "";
                                    if (matrizDos[i, 1] == 1)
                                    {
                                        nombreMapa = "Hagwarts";
                                    }
                                    else if (matrizDos[i, 1] == 2)
                                    {
                                        nombreMapa = "La Casa del Viejo";
                                    }
                                    else if (matrizDos[i, 1] == 3)
                                    {
                                        nombreMapa = "El Laboratorio";
                                    }

                                    Console.WriteLine("ID: " + matrizDos[i, 0] + " | Mapa: " + nombreMapa + " | Objetos: " + matrizDos[i, 2] + " (Máximo de objetos asignados)");
                                }
                            }
                        }
                        else
                        {
                            Console.WriteLine("No hay misiones cargadas.");
                        }
                        break;

                    case 6:
                        Console.Clear();
                        Console.WriteLine("=== PROMEDIO DE PELIGRO POR MAPA ===");

                        double sumaPeligroM1 = 0;
                        double sumaPeligroM2 = 0;
                        double sumaPeligroM3 = 0;
                        int cantM1 = 0;
                        int cantM2 = 0;
                        int cantM3 = 0;

                        for (int i = 0; i < 30; i++)
                        {
                            if (vectorUno[i] == true)
                            {
                                if (matrizDos[i, 1] == 1)
                                {
                                    sumaPeligroM1 = sumaPeligroM1 + matrizDos[i, 3];
                                    cantM1 = cantM1 + 1;
                                }
                                else if (matrizDos[i, 1] == 2)
                                {
                                    sumaPeligroM2 = sumaPeligroM2 + matrizDos[i, 3];
                                    cantM2 = cantM2 + 1;
                                }
                                else if (matrizDos[i, 1] == 3)
                                {
                                    sumaPeligroM3 = sumaPeligroM3 + matrizDos[i, 3];
                                    cantM3 = cantM3 + 1;
                                }
                            }
                        }

                        if (cantM1 > 0)
                        {
                            Console.WriteLine("- Hagwarts: Promedio de peligro " + (sumaPeligroM1 / cantM1));
                        }
                        else
                        {
                            Console.WriteLine("- Hagwarts: Sin misiones registradas.");
                        }

                        if (cantM2 > 0)
                        {
                            Console.WriteLine("- La Casa del Viejo: Promedio de peligro " + (sumaPeligroM2 / cantM2));
                        }
                        else
                        {
                            Console.WriteLine("- La Casa del Viejo: Sin misiones registradas.");
                        }

                        if (cantM3 > 0)
                        {
                            Console.WriteLine("- El Laboratorio: Promedio de peligro " + (sumaPeligroM3 / cantM3));
                        }
                        else
                        {
                            Console.WriteLine("- El Laboratorio: Sin misiones registradas.");
                        }
                        break;

                    case 7:
                        Console.Clear();
                        Console.WriteLine("=== FILTRAR POR MAPA ===");

                        int mapaFiltrar = 0;
                        bool mapaFiltrarValido = false;
                        while (mapaFiltrarValido == false)
                        {
                            Console.Write("Ingrese número de Mapa a filtrar (1 = Hagwarts, 2 = La Casa del Viejo, 3 = El Laboratorio): ");
                            mapaFiltrar = int.Parse(Console.ReadLine());
                            if (mapaFiltrar >= 1 && mapaFiltrar <= 3)
                            {
                                mapaFiltrarValido = true;
                            }
                            else
                            {
                                Console.WriteLine("Ese mapa no es de este juegazo.");
                            }
                        }

                        string txtMapa = "";
                        if (mapaFiltrar == 1)
                        {
                            txtMapa = "Hagwarts";
                        }
                        else if (mapaFiltrar == 2)
                        {
                            txtMapa = "La Casa del Viejo";
                        }
                        else if (mapaFiltrar == 3)
                        {
                            txtMapa = "El Laboratorio";
                        }

                        Console.WriteLine("");
                        Console.WriteLine("--- Misiones en " + txtMapa + " ---");
                        bool seEncontroMision = false;
                        for (int i = 0; i < 30; i++)
                        {
                            if (vectorUno[i] == true && matrizDos[i, 1] == mapaFiltrar)
                            {
                                seEncontroMision = true;
                                string nombreEstado = "";
                                if (vectorEstados[i] == 0)
                                {
                                    nombreEstado = "Pendiente";
                                }
                                else if (vectorEstados[i] == 1)
                                {
                                    nombreEstado = "En curso";
                                }
                                else if (vectorEstados[i] == 2)
                                {
                                    nombreEstado = "Finalizado";
                                }

                                Console.WriteLine("ID: " + matrizDos[i, 0] + " | Objetos: " + matrizDos[i, 2] + " | Peligro: " + matrizDos[i, 3] + " | Estado: " + nombreEstado);
                            }
                        }

                        if (seEncontroMision == false)
                        {
                            Console.WriteLine("No hay misiones cargadas en este mapa.");
                        }
                        break;

                    case 8:
                        Console.WriteLine("Saliendo del sistema... ¡Esperemos que el PERO no sea letal!");
                        break;

                    default:
                        Console.WriteLine("Opción no válida. Intente de nuevo.");
                        break;
                }
                Console.WriteLine("");
                Console.WriteLine("Presione una tecla para continuar...");
                Console.ReadKey();
            } while (opcion != 8);
        }
    }
}