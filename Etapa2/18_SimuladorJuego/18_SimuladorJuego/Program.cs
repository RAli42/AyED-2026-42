using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _18_SimuladorJuego
{
    class Program
    {
        static void Main(string[] args)
        {
            // --------------------------------------------- variables
            Random random = new Random();
            int probabilidad = 0;
            int dificultad = 0;
            int materialesNecesariosRefugio = 3;
            int materialesNecesariosFogata = 1;
            int vida = 10;
            int hambre = 10;
            int dia = 1;
            int comidaCruda = 0;
            int comidaCocida = 0;
            int materiales = 0;
            int minimo = 0;
            int malTiempo = 0;
            bool salir = false;
            bool muerte = false;
            bool refugio = false;
            bool fogata = false;
            bool eleccionDificultad = false;
            bool final = false;

            // --------------------------------------------- Contexto
            Console.WriteLine(" ");
            Console.WriteLine("Despiertas en una isla desconocida luego de un accidente.");
            Console.WriteLine("No tienes recursos y debes tomar decisiones para mantenerte con vida.");
            Console.WriteLine("Para lograrlo, tendras que buscar comida, explorar, construir un refugio, encender una fogata, cocinar y descansar.");
            Console.WriteLine(" ");
            Console.WriteLine("El juego funciona mediante un sistema de opciones (1,2,3,4,...).");
            Console.WriteLine("Cada decision tomada tiene consecuencias distintas y hara avanzar el tiempo. ");
            Console.WriteLine(" ");
            Console.Write("Aprete una tecla para continuar. ");
            Console.ReadKey();
            Console.Clear();

            while (eleccionDificultad == false)
            {
                // --------------------------------------------- Dificultad
                Console.WriteLine(" ");
                Console.WriteLine("--Seleccione una dificultad--");
                Console.WriteLine("1 = facil");
                Console.WriteLine("2 = normal");
                Console.WriteLine("3 = dificil");
                dificultad = int.Parse(Console.ReadLine());
                switch (dificultad)
                {
                    case 1:
                        Console.WriteLine("Seleccionó dificultad Facil.");
                        Console.WriteLine(" ");
                        Console.Write("Aprete una tecla para continuar. ");
                        Console.ReadKey();
                        Console.Clear();
                        eleccionDificultad = true;
                        break;
                    case 2:
                        Console.WriteLine("Seleccionó dificultad Normal.");
                        Console.WriteLine(" ");
                        Console.Write("Aprete una tecla para continuar. ");
                        Console.ReadKey();
                        Console.Clear();
                        eleccionDificultad = true;
                        break;
                    case 3:
                        Console.WriteLine("Seleccionó dificultad Dificil.");
                        Console.WriteLine(" ");
                        Console.Write("Aprete una tecla para continuar. ");
                        Console.ReadKey();
                        Console.Clear();
                        eleccionDificultad = true;
                        break;
                    default:
                        Console.WriteLine("Opcion no valida");
                        Console.Write("Aprete una tecla para continuar. ");
                        Console.ReadKey();
                        Console.Clear();
                        break;
                }
            }
            while (final == false)
            {
                if (dificultad == 1)
                {
                    minimo = 0;
                }
                if (dificultad == 2)
                {
                    minimo = 20;
                    malTiempo = 10;
                }
                if (dificultad == 3)
                {
                    minimo = 30;
                    malTiempo = 5;
                }
                if (hambre <= 0)
                {
                    hambre = 0;
                }

                Console.Clear();
                Console.WriteLine("");
                Console.WriteLine("Dia: " + dia);
                Console.WriteLine("");
                Console.WriteLine("Vida: " + vida);
                Console.WriteLine("");
                Console.WriteLine("Hambre: " + hambre);
                Console.WriteLine("");
                if (comidaCruda > 0)
                {
                    Console.WriteLine("Comida Cruda = " + comidaCruda);
                    Console.WriteLine("");
                }
                if (comidaCocida >= 1)
                {
                    Console.WriteLine("Comida Cocida = " + comidaCocida);
                    Console.WriteLine("");
                }
                if (materiales > 0)
                {
                    Console.WriteLine("Materiales = " + materiales);
                    Console.WriteLine("");
                }
                if (refugio == false)
                {
                    Console.WriteLine("Sin refugio todavia");
                    Console.WriteLine("Materiales requeridos: " + materialesNecesariosRefugio);
                    Console.WriteLine("");
                }
                else
                {
                    Console.WriteLine("Con refugio, por ahora");
                    Console.WriteLine("");
                }
                if (fogata == false)
                {
                    Console.WriteLine("Sin Fogata todavia");
                    Console.WriteLine("Materiales requeridos: " + materialesNecesariosFogata);
                    Console.WriteLine("");
                }
                else
                {
                    Console.WriteLine("Con fogata, por ahora");
                    Console.WriteLine("");
                }

                Console.WriteLine(" ");
                Console.WriteLine(" -- Que haras hoy? --");
                Console.WriteLine("1 = Buscar Comida ");
                Console.WriteLine("2 = Explorar la Isla");
                Console.WriteLine("3 = Construir un Refugio");
                Console.WriteLine("4 = Encender una Fogata");
                Console.WriteLine("5 = Cocinar Comida");
                Console.WriteLine("6 = Comer Comida Cocida");
                Console.WriteLine("7 = Descansar ");
                Console.WriteLine("8 = Salir ");
                Console.WriteLine("");
                int opcion = int.Parse(Console.ReadLine());
                switch (opcion)
                {
                    // --------------------------------------------- Buscar Comida ---------------------------------------------

                    case 1:
                        hambre--;
                        dia++;
                        Console.WriteLine("");
                        Console.WriteLine("Seleccionó Buscar Comida.");
                        Console.WriteLine(" ");
                        probabilidad = random.Next(minimo, 100);
                        Console.Write("Aprete una tecla para continuar. ");
                        Console.ReadKey();
                        Console.Clear();
                        if (probabilidad >= 0 && probabilidad <= 39)
                        {
                            if (probabilidad < 20)
                            {
                                Console.Clear();
                                Console.WriteLine("");
                                Console.WriteLine("Intentaste Pescar durante todo el dia.");
                                Console.WriteLine("");
                                Console.WriteLine("Aprete una tecla para continuar. ");
                                Console.ReadKey();
                                Console.Clear();
                                Console.WriteLine("");
                                Console.WriteLine("Sin embargo, no encontraste nada y paso un dia.");
                                Console.WriteLine("Ademas, el cansancio de pescar todo el dia te gastó un punto de hambre");
                                Console.WriteLine("");
                                Console.WriteLine("Comida Cruda = " + comidaCruda);
                                Console.WriteLine("");
                                Console.Write("Aprete una tecla para continuar. ");
                                Console.ReadKey();
                                Console.Clear();
                            }
                            else if (probabilidad > 19)
                            {
                                Console.Clear();
                                Console.WriteLine("");
                                Console.WriteLine("Intentaste Adentrarte en el bosque y cazar.");
                                Console.WriteLine("");
                                Console.Write("Aprete una tecla para continuar. ");
                                Console.ReadKey();
                                Console.Clear();
                                Console.WriteLine("");
                                Console.WriteLine("Sin embargo, no encontraste nada y paso un dia.");
                                Console.WriteLine("Ademas, el cansancio de cazar todo el dia te gastó un punto de hambre");
                                Console.WriteLine("");
                                Console.WriteLine("Comida Cruda = " + comidaCruda);
                                Console.WriteLine("");
                                Console.Write("Aprete una tecla para continuar. ");
                                Console.ReadKey();
                                Console.Clear();
                            }
                        }
                        else if (probabilidad > 39)
                        {
                            comidaCruda = comidaCruda + 2;
                            if (probabilidad <= 59)
                            {
                                Console.Clear();
                                Console.WriteLine("");
                                Console.WriteLine("Intentaste Pescar durante todo el dia.");
                                Console.WriteLine("");
                                Console.Write("Aprete una tecla para continuar. ");
                                Console.ReadKey();
                                Console.Clear();
                                Console.WriteLine("");
                                Console.WriteLine("Por suerte, lograste cazar algunos peces y paso un dia.");
                                Console.WriteLine("Sin embargo, el cansancio de pescar todo el dia te gastó un punto de hambre");
                                Console.WriteLine("");
                                Console.WriteLine("Comida Cruda = " + comidaCruda);
                                Console.WriteLine("");
                                Console.Write("Aprete una tecla para continuar. ");
                                Console.ReadKey();
                                Console.Clear();

                            }
                            else if (probabilidad > 59)
                            {
                                Console.Clear();
                                Console.WriteLine("");
                                Console.WriteLine("Intentaste Adentrarte en el bosque y cazar.");
                                Console.WriteLine("");
                                Console.Write("Aprete una tecla para continuar. ");
                                Console.ReadKey();
                                Console.Clear();
                                Console.WriteLine("");
                                Console.WriteLine("Por suerte, lograste cazar algunos animales pequeños y paso un dia.");
                                Console.WriteLine("Sin embargo, el cansancio de cazar todo el dia te gastó un punto de hambre");
                                Console.WriteLine("");
                                Console.WriteLine("Comida Cruda = " + comidaCruda);
                                Console.WriteLine("");
                                Console.Write("Aprete una tecla para continuar. ");
                                Console.ReadKey();
                                Console.Clear();
                            }
                        }
                        break;

                    // --------------------------------------------- Buscar Materiales ---------------------------------------------

                    case 2:
                        hambre--;
                        dia++;
                        Console.WriteLine(" ");
                        Console.WriteLine("Seleccionó Explorar la Isla.");
                        Console.WriteLine(" ");
                        Console.WriteLine(" ");
                        probabilidad = random.Next(minimo, 100);
                        Console.Write("Aprete una tecla para continuar. ");
                        Console.ReadKey();
                        Console.Clear();
                        if (probabilidad >= 0 && probabilidad <= 49)
                        {
                            materiales++;
                            if (probabilidad < 26)
                            {
                                Console.Clear();
                                Console.WriteLine("");
                                Console.WriteLine("Intentaste Adentrarte en el bosque y explorar.");
                                Console.WriteLine("");
                                Console.Write("Aprete una tecla para continuar. ");
                                Console.ReadKey();
                                Console.Clear();
                                Console.WriteLine("");
                                Console.WriteLine("Por suerte, lograste extraer materiales de un arbol caido y paso un dia.");
                                Console.WriteLine("Sin embargo, el cansancio de explorar todo el dia te gastó un punto de hambre");
                                Console.WriteLine("");
                                Console.WriteLine("Materiales = " + materiales);
                                Console.WriteLine("");
                                Console.Write("Aprete una tecla para continuar. ");
                                Console.ReadKey();
                                Console.Clear();
                            }
                            else if (probabilidad > 25)
                            {
                                Console.Clear();
                                Console.WriteLine("");
                                Console.WriteLine("Intentaste explorar cerca de la playa.");
                                Console.WriteLine("");
                                Console.Write("Aprete una tecla para continuar. ");
                                Console.ReadKey();
                                Console.Clear();
                                Console.WriteLine("");
                                Console.WriteLine("Por suerte, lograste extraer materiales de una de las partes del accidente y paso un dia.");
                                Console.WriteLine("Sin embargo, el cansancio de explorar todo el dia te gastó un punto de hambre");
                                Console.WriteLine("");
                                Console.WriteLine("Materiales = " + materiales);
                                Console.WriteLine("");
                                Console.Write("Aprete una tecla para continuar. ");
                                Console.ReadKey();
                                Console.Clear();
                            }
                        }
                        else if (probabilidad > 49 && probabilidad <= 80)
                        {
                            if (probabilidad < 65)
                            {
                                Console.Clear();
                                Console.WriteLine("");
                                Console.WriteLine("Intentaste Adentrarte en el bosque y explorar.");
                                Console.WriteLine("");
                                Console.Write("Aprete una tecla para continuar. ");
                                Console.ReadKey();
                                Console.Clear();
                                Console.WriteLine("");
                                Console.WriteLine("Sin embargo, no lograste extraer materiales de ningun lado y paso un dia.");
                                Console.WriteLine("Ademas, el cansancio de explorar todo el dia te gastó un punto de hambre");
                                Console.WriteLine("");
                                Console.WriteLine("Materiales = " + materiales);
                                Console.WriteLine("");
                                Console.Write("Aprete una tecla para continuar. ");
                                Console.ReadKey();
                                Console.Clear();
                            }
                            else if (probabilidad > 25)
                            {
                                Console.Clear();
                                Console.WriteLine("");
                                Console.WriteLine("Intentaste explorar cerca de la playa.");
                                Console.WriteLine("");
                                Console.Write("Aprete una tecla para continuar. ");
                                Console.ReadKey();
                                Console.Clear();
                                Console.WriteLine("");
                                Console.WriteLine("Sin embargo, diste una vuelta por toda la costa sin encontrar nada y paso un dia.");
                                Console.WriteLine("Ademas, el cansancio de explorar todo el dia te gastó un punto de hambre");
                                Console.WriteLine("");
                                Console.WriteLine("Materiales = " + materiales);
                                Console.WriteLine("");
                                Console.Write("Aprete una tecla para continuar. ");
                                Console.ReadKey();
                                Console.Clear();
                            }
                        }
                        else if (probabilidad > 80)
                        {
                            vida--;
                            if (probabilidad <= 90)
                            {
                                Console.Clear();
                                Console.WriteLine("");
                                Console.WriteLine("Intentaste Adentrarte en el bosque y explorar.");
                                Console.WriteLine("");
                                Console.Write("Aprete una tecla para continuar. ");
                                Console.ReadKey();
                                Console.Clear();
                                Console.WriteLine("");
                                Console.WriteLine("Por desgracia, te lastimaste extrayendo materiales de un arbol caido y paso un dia.");
                                Console.WriteLine("Ademas, el cansancio de explorar todo el dia y la herida te gastaron un punto de hambre y uno de vida");
                                Console.WriteLine("");
                                Console.WriteLine("Materiales = " + materiales);
                                Console.WriteLine("Vida = " + vida);
                                Console.WriteLine("");
                                Console.Write("Aprete una tecla para continuar. ");
                                Console.ReadKey();
                                Console.Clear();
                            }
                            else if (probabilidad > 90)
                            {
                                Console.Clear();
                                Console.WriteLine("");
                                Console.WriteLine("Intentaste explorar cerca de la playa.");
                                Console.WriteLine("");
                                Console.Write("Aprete una tecla para continuar. ");
                                Console.ReadKey();
                                Console.Clear();
                                Console.WriteLine("");
                                Console.WriteLine("por desgracia, te tropezaste con una roca oculta en la arena, dañandote en el proceso y paso un dia.");
                                Console.WriteLine("Ademas, el cansancio de explorar y la herida te gastaron un punto de hambre y uno de vida");
                                Console.WriteLine("");
                                Console.WriteLine("Materiales = " + materiales);
                                Console.WriteLine("Vida = " + vida);
                                Console.WriteLine("");
                                Console.Write("Aprete una tecla para continuar. ");
                                Console.ReadKey();
                                Console.Clear();
                            }
                        }
                        break;

                    // --------------------------------------------- Construir un refugio ---------------------------------------------

                    case 3:
                        hambre--;
                        dia++;
                        Console.WriteLine(" ");
                        Console.WriteLine("Seleccionó Construir un Refugio.");
                        Console.WriteLine(" ");
                        Console.WriteLine(" ");
                        probabilidad = random.Next(0, 100);
                        Console.Write("Aprete una tecla para continuar. ");
                        Console.ReadKey();
                        Console.Clear();
                        if (refugio == true)
                        {
                            Console.Clear();
                            Console.WriteLine("");
                            Console.WriteLine("Intentaste Construir un refugio con " + materiales + " materiales.");
                            Console.WriteLine("");
                            Console.Write("Aprete una tecla para continuar. ");
                            Console.ReadKey();
                            Console.Clear();
                            Console.WriteLine("");
                            Console.WriteLine("Debido a que ya tienes un refugio, no lograste construir nada");
                            Console.WriteLine("Lo unico que lograste fue hacer nada...");
                            Console.WriteLine("Ademas, el cansancio de ´´construir´´ todo el dia te gastó un punto de hambre");
                            Console.WriteLine("");
                            Console.WriteLine("Con Refugio, por ahora.");
                            Console.WriteLine("");
                            Console.WriteLine("");
                            Console.Write("Aprete una tecla para continuar. ");
                            Console.ReadKey();
                            Console.Clear();
                        }
                        if (refugio == false)
                        {
                            if (materiales == 0)
                            {
                                Console.Clear();
                                Console.WriteLine("");
                                Console.WriteLine("Intentaste Construir un refugio con " + materiales + " materiales.");
                                Console.WriteLine("");
                                Console.Write("Aprete una tecla para continuar. ");
                                Console.ReadKey();
                                Console.Clear();
                                Console.WriteLine("");
                                Console.WriteLine("Debido a que no tenias materiales, no lograste construir nada");
                                Console.WriteLine("Lo unico que lograste fue encontrar un lugar donde construir...");
                                Console.WriteLine("Ademas, el cansancio de ´´construir´´ todo el dia te gastó un punto de hambre");
                                Console.WriteLine("");
                                Console.WriteLine("Sin Refugio todavia");
                                Console.WriteLine("");
                                Console.WriteLine("Materiales requeridos: " + materialesNecesariosRefugio);
                                Console.WriteLine("");
                                Console.Write("Aprete una tecla para continuar. ");
                                Console.ReadKey();
                                Console.Clear();
                            }
                            if (materiales >= 1)
                            {
                                // --------------------------------------------- primeros pasos de la construccion

                                if (materialesNecesariosRefugio == 3)
                                {
                                    if (materiales == 1)
                                    {
                                        Console.Clear();
                                        Console.WriteLine("");
                                        Console.WriteLine("Intentaste Construir un refugio con " + materiales + " materiales.");
                                        Console.WriteLine("");
                                        Console.Write("Aprete una tecla para continuar. ");
                                        Console.ReadKey();
                                        Console.Clear();
                                        Console.WriteLine("");
                                        Console.WriteLine("Debido a que no tenias todos los materiales, no lograste construir todo el refugio.");
                                        Console.WriteLine("Empezaste con el piso, te faltan las paredes y el techo.");
                                        Console.WriteLine("Ademas, el cansancio de construir todo el dia te gastó un punto de hambre");
                                        Console.WriteLine("");
                                        Console.WriteLine("Sin Refugio todavia");
                                        Console.WriteLine("");
                                        materialesNecesariosRefugio--;
                                        materiales--;
                                        Console.WriteLine("Materiales faltantes: " + materialesNecesariosRefugio);
                                        Console.WriteLine("");
                                        Console.Write("Aprete una tecla para continuar. ");
                                        Console.ReadKey();
                                        Console.Clear();
                                    }
                                    else if (materiales == 2)
                                    {
                                        Console.Clear();
                                        Console.WriteLine("");
                                        Console.WriteLine("Intentaste Construir un refugio con " + materiales + " materiales.");
                                        Console.WriteLine("");
                                        Console.Write("Aprete una tecla para continuar. ");
                                        Console.ReadKey();
                                        Console.Clear();
                                        Console.WriteLine("");
                                        Console.WriteLine("Debido a que no tenias todos los materiales, no lograste construir todo el refugio.");
                                        Console.WriteLine("Empezaste con el piso y las paredes, te falta el techo.");
                                        Console.WriteLine("Ademas, el cansancio de construir todo el dia te gastó un punto de hambre");
                                        Console.WriteLine("");
                                        Console.WriteLine("Sin Refugio todavia");
                                        Console.WriteLine("");
                                        materialesNecesariosRefugio = materialesNecesariosRefugio - 2;
                                        materiales = materiales - 2;
                                        Console.WriteLine("Materiales faltantes: " + materialesNecesariosRefugio);
                                        Console.WriteLine("");
                                        Console.Write("Aprete una tecla para continuar. ");
                                        Console.ReadKey();
                                        Console.Clear();
                                    }
                                    else if (materiales >= 3)
                                    {
                                        Console.Clear();
                                        Console.WriteLine("");
                                        Console.WriteLine("Intentaste Construir un refugio con " + materiales + " materiales.");
                                        Console.WriteLine("");
                                        Console.Write("Aprete una tecla para continuar. ");
                                        Console.ReadKey();
                                        Console.Clear();
                                        Console.WriteLine("");
                                        Console.WriteLine("Debido a que tenias todos los materiales, lograste construir todo el refugio.");
                                        Console.WriteLine("Empezaste con el piso, las paredes y terminaste rapidamente el techo.");
                                        Console.WriteLine("Ademas, el cansancio de construir todo el dia te gastó un punto de hambre");
                                        Console.WriteLine("");
                                        Console.WriteLine("Con Refugio, por ahora.");
                                        Console.WriteLine("");
                                        materialesNecesariosRefugio = materialesNecesariosRefugio - 3;
                                        materiales = materiales - 3;
                                        refugio = true;
                                        Console.WriteLine("");
                                        Console.Write("Aprete una tecla para continuar. ");
                                        Console.ReadKey();
                                        Console.Clear();
                                    }
                                }

                                // --------------------------------------------- segundos pasos de la construccion

                                else if (materialesNecesariosRefugio == 2)
                                {
                                    if (materiales == 1)
                                    {
                                        Console.Clear();
                                        Console.WriteLine("");
                                        Console.WriteLine("Intentaste Construir un refugio con " + materiales + " materiales.");
                                        Console.WriteLine("");
                                        Console.Write("Aprete una tecla para continuar. ");
                                        Console.ReadKey();
                                        Console.Clear();
                                        Console.WriteLine("");
                                        Console.WriteLine("Debido a que no tenias todos los materiales, no lograste construir todo el refugio.");
                                        Console.WriteLine("Empezaste con las paredes, te falta el techo.");
                                        Console.WriteLine("Ademas, el cansancio de construir todo el dia te gastó un punto de hambre");
                                        Console.WriteLine("");
                                        Console.WriteLine("Sin Refugio todavia");
                                        Console.WriteLine("");
                                        materialesNecesariosRefugio--;
                                        materiales--;
                                        Console.WriteLine("Materiales faltantes: " + materialesNecesariosRefugio);
                                        Console.WriteLine("");
                                        Console.Write("Aprete una tecla para continuar. ");
                                        Console.ReadKey();
                                        Console.Clear();
                                    }
                                    else if (materiales >= 2)
                                    {
                                        Console.Clear();
                                        Console.WriteLine("");
                                        Console.WriteLine("Intentaste Construir un refugio con " + materiales + " materiales.");
                                        Console.WriteLine("");
                                        Console.Write("Aprete una tecla para continuar. ");
                                        Console.ReadKey();
                                        Console.Clear();
                                        Console.WriteLine("");
                                        Console.WriteLine("Debido a que tenias todos los materiales, lograste construir todo el refugio.");
                                        Console.WriteLine("Empezaste las paredes y terminaste con el techo rapidamente.");
                                        Console.WriteLine("Ademas, el cansancio de construir todo el dia te gastó un punto de hambre");
                                        Console.WriteLine("");
                                        Console.WriteLine("Con Refugio, por ahora.");
                                        Console.WriteLine("");
                                        materialesNecesariosRefugio = materialesNecesariosRefugio - 2;
                                        materiales = materiales - 2;
                                        refugio = true;
                                        Console.WriteLine("");
                                        Console.Write("Aprete una tecla para continuar. ");
                                        Console.ReadKey();
                                        Console.Clear();
                                    }
                                }

                                // --------------------------------------------- ultimos pasos construccion

                                else if (materialesNecesariosRefugio == 1)
                                {
                                    if (materiales >= 1)
                                    {
                                        Console.Clear();
                                        Console.WriteLine("");
                                        Console.WriteLine("Intentaste Construir un refugio con " + materiales + " materiales.");
                                        Console.WriteLine("");
                                        Console.Write("Aprete una tecla para continuar. ");
                                        Console.ReadKey();
                                        Console.Clear();
                                        Console.WriteLine("");
                                        Console.WriteLine("Debido a que tenias todos los materiales, lograste construir todo el refugio.");
                                        Console.WriteLine("Terminaste el techo.");
                                        Console.WriteLine("Ademas, el cansancio de construir todo el dia te gastó un punto de hambre");
                                        Console.WriteLine("");
                                        Console.WriteLine("Con Refugio, por ahora");
                                        Console.WriteLine("");
                                        materialesNecesariosRefugio--;
                                        materiales--;
                                        refugio = true;
                                        Console.WriteLine("");
                                        Console.Write("Aprete una tecla para continuar. ");
                                        Console.ReadKey();
                                        Console.Clear();
                                    }
                                }
                            }
                        }
                        break;

                    // --------------------------------------------- Construir fogata ---------------------------------------------

                    case 4:
                        hambre--;
                        dia++;
                        Console.WriteLine(" ");
                        Console.WriteLine("Seleccionó Encender una fogata.");
                        Console.WriteLine(" ");
                        probabilidad = random.Next(minimo, 100);
                        Console.Write("Aprete una tecla para continuar. ");
                        Console.ReadKey();
                        Console.Clear();
                        if (fogata == true)
                        {
                            Console.Clear();
                            Console.WriteLine("");
                            Console.WriteLine("Intentaste encender una fogata con " + materiales + " materiales.");
                            Console.WriteLine("");
                            Console.Write("Aprete una tecla para continuar. ");
                            Console.ReadKey();
                            Console.Clear();
                            Console.WriteLine("");
                            Console.WriteLine("Sin embargo ya tienes una fogata...");
                            Console.WriteLine("Lo unico que lograste fue hacer nada...");
                            Console.WriteLine("Ademas, el cansancio de ´´encender fogatas´´ todo el dia te gastó un punto de hambre");
                            Console.WriteLine("");
                            Console.WriteLine("Con Fogata, por ahora.");
                            Console.WriteLine("");
                            Console.WriteLine("");
                            Console.Write("Aprete una tecla para continuar. ");
                            Console.ReadKey();
                            Console.Clear();
                        }
                        if (fogata == false)
                        {
                            if (materiales == 0)
                            {
                                Console.Clear();
                                Console.WriteLine("");
                                Console.WriteLine("Intentaste Construir una fogata con " + materiales + " materiales.");
                                Console.WriteLine("");
                                Console.Write("Aprete una tecla para continuar. ");
                                Console.ReadKey();
                                Console.Clear();
                                Console.WriteLine("");
                                Console.WriteLine("Debido a que no tienes materiales para armar y encender la fogata, no lograste nada.");
                                Console.WriteLine("Sin embargo, encontraste un lugar perfecto donde encender una fogata.");
                                Console.WriteLine("Ademas, el cansancio de ´´encender fogatas´´ todo el dia te gastó un punto de hambre");
                                Console.WriteLine("");
                                Console.WriteLine("Sin fogata");
                                Console.WriteLine("");
                                Console.WriteLine("Materiales faltantes: " + materialesNecesariosFogata);
                                Console.WriteLine("");
                                Console.Write("Aprete una tecla para continuar. ");
                                Console.ReadKey();
                                Console.Clear();
                            }
                            else if (materiales >= 1)
                            {
                                Console.Clear();
                                Console.WriteLine("");
                                Console.WriteLine("Intentaste Construir una fogata con " + materiales + " materiales.");
                                Console.WriteLine("");
                                Console.Write("Aprete una tecla para continuar. ");
                                Console.ReadKey();
                                Console.Clear();
                                Console.WriteLine("");
                                Console.WriteLine("Tienes materiales para armar y encender la fogata exitosamente.");
                                Console.WriteLine("Lograste encender la fogata con exito, sin embargo perdiste 1 material.");
                                Console.WriteLine("Ademas, el cansancio de encender la fogata todo el dia te gastó un punto de hambre");
                                Console.WriteLine("");
                                Console.WriteLine("Con fogata, por ahora");
                                fogata = true;
                                materiales--;
                                Console.WriteLine("");
                                Console.WriteLine("");
                                Console.Write("Aprete una tecla para continuar. ");
                                Console.ReadKey();
                                Console.Clear();
                            }
                        }
                        break;

                    // --------------------------------------------- Cocinar comida ---------------------------------------------

                    case 5:
                        hambre--;
                        dia++;
                        Console.WriteLine(" ");
                        Console.WriteLine("Seleccionó cocinar comida cruda.");
                        Console.WriteLine(" ");
                        probabilidad = random.Next(minimo, 100);
                        Console.Write("Aprete una tecla para continuar. ");
                        Console.ReadKey();
                        Console.Clear();
                        if (comidaCruda == 0)
                        {
                            Console.Clear();
                            Console.WriteLine("");
                            Console.WriteLine("Intentaste cocinar comida cruda.");
                            Console.WriteLine("");
                            Console.Write("Aprete una tecla para continuar. ");
                            Console.ReadKey();
                            Console.Clear();
                            Console.WriteLine("");
                            Console.WriteLine("Sin embargo no tienes comida cruda que cocinar...");
                            Console.WriteLine("Lo unico que lograste fue hacer nada...");
                            Console.WriteLine("Ademas, el cansancio de cocinar aire todo el dia te gastó un punto de hambre");
                            Console.WriteLine("");
                            Console.WriteLine("");
                            Console.Write("Aprete una tecla para continuar. ");
                            Console.ReadKey();
                            Console.Clear();
                        }
                        if (comidaCruda >= 1)
                        {
                            if (fogata == false)
                            {
                                Console.Clear();
                                Console.WriteLine("");
                                Console.WriteLine("Intentaste cocinar comida cruda.");
                                Console.WriteLine("");
                                Console.Write("Aprete una tecla para continuar. ");
                                Console.ReadKey();
                                Console.Clear();
                                Console.WriteLine("");
                                Console.WriteLine("Sin embargo no tienes una fogata donde cocinarla...");
                                Console.WriteLine("Lo unico que lograste fue hacer nada...");
                                Console.WriteLine("Ademas, el cansancio de cocinar aire todo el dia te gastó un punto de hambre");
                                Console.WriteLine("");
                                Console.WriteLine("");
                                Console.Write("Aprete una tecla para continuar. ");
                                Console.ReadKey();
                                Console.Clear();
                            }
                            else if (fogata == true)
                            {
                                Console.Clear();
                                Console.WriteLine("");
                                Console.WriteLine("Intentaste cocinar comida cruda.");
                                Console.WriteLine("");
                                Console.Write("Aprete una tecla para continuar. ");
                                Console.ReadKey();
                                Console.Clear();
                                Console.WriteLine("");
                                Console.WriteLine("Tu fogata vino de maravilla para cocinar esa carne!!!");
                                Console.WriteLine("Lograste cocinar 1 pedazo de carne");
                                Console.WriteLine("Ademas, el cansancio de cocinar todo el dia te gastó un punto de hambre");
                                Console.WriteLine("");
                                comidaCruda--;
                                comidaCocida++;
                                Console.WriteLine("");
                                Console.Write("Aprete una tecla para continuar. ");
                                Console.ReadKey();
                            }
                        }
                        break;
                    // --------------------------------------------- Comer Comida ---------------------------------------------
                    case 6:
                        dia++;
                        Console.WriteLine(" ");
                        Console.WriteLine("Seleccionó comer comida cocida.");
                        Console.WriteLine(" ");
                        probabilidad = random.Next(minimo, 100);
                        Console.Write("Aprete una tecla para continuar. ");
                        Console.ReadKey();
                        Console.Clear();
                        if (comidaCocida == 0)
                        {
                            hambre--;
                            Console.Clear();
                            Console.WriteLine("");
                            Console.WriteLine("Intentaste comer comida cocida.");
                            Console.WriteLine("");
                            Console.Write("Aprete una tecla para continuar. ");
                            Console.ReadKey();
                            Console.Clear();
                            Console.WriteLine("");
                            Console.WriteLine("Sin embargo no tienes un comida cocida...");
                            Console.WriteLine("Lo unico que lograste fue hacer nada...");
                            Console.WriteLine("Ademas, el cansancio de comer aire todo el dia te gastó un punto de hambre");
                            Console.WriteLine("");
                            Console.WriteLine("");
                            Console.Write("Aprete una tecla para continuar. ");
                            Console.ReadKey();
                            Console.Clear();
                        }
                        else if (comidaCocida >= 1)
                        {
                            Console.Clear();
                            Console.WriteLine("");
                            Console.WriteLine("Intentaste comer comida cocida.");
                            Console.WriteLine("");
                            Console.Write("Aprete una tecla para continuar. ");
                            Console.ReadKey();
                            Console.Clear();
                            Console.WriteLine("");
                            Console.WriteLine("Comiste la carne cocida y de lo rico que estaba te dormiste");
                            Console.WriteLine("Despertaste y termino el dia...");
                            Console.WriteLine("");
                            comidaCocida--;
                            if (hambre <= 6)
                            {
                                hambre = hambre + 4;
                            }
                            else if (hambre == 7)
                            {
                                hambre = hambre + 3;
                            }
                            else if (hambre == 8)
                            {
                                hambre = hambre + 2;
                            }
                            else if (hambre == 9)
                            {
                                hambre = hambre + 1;
                            }
                            Console.WriteLine("");
                            Console.Write("Aprete una tecla para continuar. ");
                            Console.ReadKey();
                        }
                        break;
                    case 7:
                        dia++;
                        hambre--;
                        Console.WriteLine(" ");
                        Console.WriteLine("Seleccionó descansar.");
                        Console.WriteLine(" ");
                        probabilidad = random.Next(minimo, 100);
                        Console.Write("Aprete una tecla para continuar. ");
                        Console.ReadKey();
                        Console.Clear();
                        if (vida == 10)
                        {
                            Console.Clear();
                            Console.WriteLine("");
                            Console.WriteLine("Intentaste descansar.");
                            Console.WriteLine("");
                            Console.Write("Aprete una tecla para continuar. ");
                            Console.ReadKey();
                            Console.Clear();
                            Console.WriteLine("");
                            Console.WriteLine("Sin embargo no estabas cansado...");
                            Console.WriteLine("Aun asi te hechaste una siesta, que duro todo el dia...");
                            Console.WriteLine("Ademas, el cansancio de dormir todo el dia te gastó un punto de hambre");
                            Console.WriteLine("");
                            Console.WriteLine("");
                            Console.Write("Aprete una tecla para continuar. ");
                            Console.ReadKey();
                            Console.Clear();
                        }
                        if (vida <= 9)
                        {
                            if (refugio == false)
                            {
                                Console.Clear();
                                Console.WriteLine("");
                                Console.WriteLine("Intentaste descansar.");
                                Console.WriteLine("");
                                Console.Write("Aprete una tecla para continuar. ");
                                Console.ReadKey();
                                Console.Clear();
                                Console.WriteLine("");
                                Console.WriteLine("Sin embargo no tienes un refugio donde dormir comodo...");
                                Console.WriteLine("Descansaste un poco y recuperaste algo de vida");
                                Console.WriteLine("Ademas, el cansancio de dormir todo el dia te gastó un punto de hambre");
                                Console.WriteLine("");
                                vida++;
                                Console.WriteLine("");
                                Console.Write("Aprete una tecla para continuar. ");
                                Console.ReadKey();
                                Console.Clear();
                            }
                            else if (refugio == true)
                            {
                                Console.Clear();
                                Console.WriteLine("");
                                Console.WriteLine("Intentaste descansar.");
                                Console.WriteLine("");
                                Console.Write("Aprete una tecla para continuar. ");
                                Console.ReadKey();
                                Console.Clear();
                                Console.WriteLine("");
                                Console.WriteLine("Tienes un refugio donde dormir comodo por suerte!!!");
                                Console.WriteLine("Descansaste un poco y recuperaste algo de vida");
                                Console.WriteLine("Ademas, el cansancio de dormir todo el dia te gastó un punto de hambre");
                                Console.WriteLine("");
                                if (vida <= 7)
                                {
                                    vida = vida + 3;
                                }
                                else if (vida == 8)
                                {
                                    vida = vida + 2;
                                }
                                else if (vida == 9)
                                {
                                    vida = vida + 1;
                                }
                                Console.WriteLine("");
                                Console.Write("Aprete una tecla para continuar. ");
                                Console.ReadKey();
                            }
                        }
                        break;
                    case 8:
                        Console.WriteLine("Seleccionó Salir.");
                        Console.WriteLine(" ");
                        Console.WriteLine("");
                        Console.Write("Aprete una tecla para continuar. ");
                        Console.ReadKey();
                        Console.Clear();
                        final = true;
                        salir = true;
                        break;
                    default:
                        Console.WriteLine("Opcion no valida");
                        Console.WriteLine("");
                        Console.Write("Aprete una tecla para continuar. ");
                        Console.ReadKey();
                        Console.Clear();
                        break;
                }
                if (dificultad >= 2)
                {
                    probabilidad = random.Next(0, 100);
                    if (dia % malTiempo == 0)
                    {
                        vida = vida - 2;
                        Console.WriteLine("Un mal tiempo destruyo muchas cosas a su paso.");
                        Console.WriteLine("Habra roto algo importante??");
                        Console.WriteLine(" ");
                        Console.WriteLine("Pierdes dos puntos de vida.");
                        Console.WriteLine(" ");
                        Console.Write("Aprete una tecla para continuar. ");
                        Console.ReadKey();
                        Console.Clear();
                        if (probabilidad > 50)
                        {
                            Console.WriteLine("Su fogata salio volando.");
                            Console.WriteLine("Deberas encenderla desde 0.");
                            fogata = false;
                            materialesNecesariosFogata = 1;
                        }
                        if (probabilidad > 74 || probabilidad < 25)
                        {
                            if (refugio == true)
                            {
                                Console.WriteLine("Su refugio salio volando.");
                                Console.WriteLine("Deberas empezar desde 0 la construccion.");
                                refugio = false;
                                materialesNecesariosRefugio = 3;
                                Console.WriteLine(" ");
                                Console.Write("Aprete una tecla para continuar. ");
                                Console.ReadKey();
                                Console.Clear();
                            }
                            if ((refugio == false) && (materialesNecesariosRefugio <= 2))
                            {
                                Console.WriteLine("Su refugio en proceso salio volando.");
                                Console.WriteLine("Deberas empezar desde 0 la construccion.");
                                refugio = false;
                                materialesNecesariosRefugio = 3;
                                Console.WriteLine(" ");
                                Console.Write("Aprete una tecla para continuar. ");
                                Console.ReadKey();
                                Console.Clear();
                            }
                        }
                    }
                }
                if (hambre <= 0)
                {
                    vida = vida - 2;
                }
                if (vida <= 0)
                {
                    Console.Clear();
                    Console.WriteLine("Has Muerto");
                    final = true;
                    muerte = true;
                    Console.WriteLine("");
                    Console.WriteLine("Aprete una tecla para continuar. ");
                    Console.ReadKey();
                    Console.Clear();
                }

                Console.Clear();
                while (muerte == true)
                {
                    Console.WriteLine("Sobreviviste " + dia + " dias!!");
                    Console.WriteLine("Mejor suerte la proxima!!!");
                    Console.WriteLine("");
                    Console.Write("Aprete una tecla para salir. ");
                    muerte = false;
                    salir = false;
                    Console.ReadKey();
                }
                while (salir == true)
                {
                    Console.WriteLine("Sobreviviste " + dia + " dias!!");
                    Console.WriteLine("");
                    Console.Write("Aprete una tecla para salir. ");
                    salir = false;
                    Console.ReadKey();
                }
            }
        }
    }
}
