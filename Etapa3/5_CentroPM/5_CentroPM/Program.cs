using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5_CentroPM
{
    class Program
    {
        static void Main(string[] args)
        {

            // ----------------Variables

            Random random = new Random();
            int[] vidasPokemon = new int[6];
            int ataqueSalvaje = 0;
            int promedio = 0;
            int pokemonMenosVida = 0;
            int pokemonMasVida = 0;
            int pokemonDebilitado = 0;
            int cantidad = 0;
            int numCuracion = 0;
            int numDaño = 0;
            int daño = 0;
            int curacion = 0;
            bool bucle = false;
            while (bucle == false)
            {
                Console.Clear();
                Console.WriteLine("----------- Centro Poke-Remedio -----------");
                Console.WriteLine("");
                Console.WriteLine("1. Registrar un nuevo Pokemon");
                Console.WriteLine("2. Mostrar la vida de todos los Pokemones");
                Console.WriteLine("3. Curar a un Pokemon");
                Console.WriteLine("4. Dañar a un Pokemon");
                Console.WriteLine("5. Curar a todos los Pokemones");
                Console.WriteLine("6. Mostrar Pokemones debilitados");
                Console.WriteLine("7. Mostrar el Pokemon con mayor vida");
                Console.WriteLine("8. Mostrar el Pokemon con menor vida");
                Console.WriteLine("9. Calcular promedio de vida del equipo");
                Console.WriteLine("10. Ordenar Pokemones por vida de menor a mayor");
                Console.WriteLine("11. Ordenar Pokemones por vida de mayor a menor");
                Console.WriteLine("12. Simular ataque enemigo a todo el equipo");
                Console.WriteLine("13. Salir");
                Console.WriteLine("");
                Console.WriteLine("");
                int opcion = int.Parse(Console.ReadLine());
                switch (opcion)
                {
                    case 1:
                        
                        if (cantidad != 6)
                        {
                            Console.Clear();
                            Console.WriteLine("Introduzca la vida de su pokemon numero " + (cantidad + 1));
                            vidasPokemon[cantidad] = int.Parse(Console.ReadLine());
                            while (vidasPokemon[cantidad] < 0 || vidasPokemon[cantidad] > 100)
                            {
                                Console.WriteLine("Introduzca la vida de su pokemon numero " + (cantidad + 1));
                                vidasPokemon[cantidad] = int.Parse(Console.ReadLine());
                            }
                            Console.WriteLine("");
                            Console.WriteLine("La vida del pokemon " + (cantidad + 1) + " es: " + vidasPokemon[cantidad]);
                            Console.WriteLine("");
                            Console.WriteLine("Aprete una tecla para continuar");
                            Console.ReadKey();
                        }
                        else if (cantidad >= 6)
                        {
                            Console.WriteLine("");
                            Console.WriteLine("Ya ingreso la vida de todos los pokemon");
                            Console.WriteLine("");
                            Console.WriteLine("Aprete una tecla para continuar");
                            Console.ReadKey();
                        }
                        cantidad++;
                        break;
                    case 2:
                        Console.Clear();
                        for ( int i = 0; cantidad != i; i++)
                        {
                            Console.WriteLine("Vida del pokemon " + (i + 1) + " es: " + vidasPokemon[i]);
                        }
                        Console.WriteLine("");
                        Console.WriteLine("Aprete una tecla para continuar");
                        Console.ReadKey();
                        break;
                    case 3:
                        Console.Clear();
                        Console.WriteLine("Ingrese el numero del pokemon que quiere curar: ");
                        numCuracion = int.Parse(Console.ReadLine()) - 1;
                        Console.WriteLine("Ingrese cuanta vida quiere curarle: ");
                        curacion = int.Parse(Console.ReadLine());
                        vidasPokemon[numCuracion] = vidasPokemon[numCuracion] + curacion;
                        if (vidasPokemon[numCuracion] > 100)
                        {
                            vidasPokemon[numCuracion] = 100;
                        }
                        if (vidasPokemon[numCuracion] < 0)
                        {
                            vidasPokemon[numCuracion] = 0;
                        }
                        Console.WriteLine("");
                        Console.WriteLine("El Pokemon fue curado");
                        Console.WriteLine("Vida actual del pokemon: " + vidasPokemon[numCuracion]);
                        Console.WriteLine("");
                        Console.WriteLine("Aprete una tecla para continuar");
                        Console.ReadKey();
                        break;
                    case 4:
                        Console.Clear();
                        Console.WriteLine("Ingrese el numero del pokemon que quiere dañar: ");
                        numDaño = int.Parse(Console.ReadLine()) - 1;
                        Console.WriteLine("Ingrese cuanta vida quiere sacarle: ");
                        daño = int.Parse(Console.ReadLine());
                        vidasPokemon[numDaño] = vidasPokemon[numDaño] - daño;
                        if (vidasPokemon[numDaño] > 100)
                        {
                            vidasPokemon[numDaño] = 100;
                        }
                        if (vidasPokemon[numDaño] < 0)
                        {
                            vidasPokemon[numDaño] = 0;
                        }
                        Console.WriteLine("");
                        Console.WriteLine("El Pokemon fue dañado");
                        Console.WriteLine("Vida actual del pokemon: " + vidasPokemon[numDaño]);
                        Console.WriteLine("");
                        Console.WriteLine("Aprete una tecla para continuar");
                        Console.ReadKey();
                        break;
                    case 5:
                        Console.Clear();
                        Console.WriteLine("Ingrese cuanta vida quiere curarle al equipo: ");
                        curacion = int.Parse(Console.ReadLine());
                        for (int i = 0; cantidad != i; i++)
                        {
                            vidasPokemon[i] = vidasPokemon[i] + curacion;
                            if(vidasPokemon[numCuracion] > 100)
                            {
                                vidasPokemon[numCuracion] = 100;
                            }
                            if (vidasPokemon[numCuracion] < 0)
                            {
                                vidasPokemon[numCuracion] = 0;
                            }
                            Console.WriteLine("Vida del pokemon " + (i + 1) + " es: " + vidasPokemon[i]);
                        }
                        Console.WriteLine("");
                        Console.WriteLine("Aprete una tecla para continuar");
                        Console.ReadKey();
                        break;
                    case 6:
                        Console.Clear();
                        pokemonDebilitado = 0;
                        Console.WriteLine("Pokemones debilitados: ");
                        Console.WriteLine("");
                        for (int i = 0; cantidad != i; i++)
                        {
                            if (vidasPokemon[i] == 0)
                            {
                                Console.WriteLine("Pokémon debilitado en posicion: " + (i + 1));
                                pokemonDebilitado++;
                            }
                        }
                        if (pokemonDebilitado != 0)
                        {
                            Console.WriteLine("");
                            Console.WriteLine("Cantidad de Pokemones debilitados: " + pokemonDebilitado);
                        }else if (pokemonDebilitado == 0)
                        {
                            Console.WriteLine("");
                            Console.WriteLine("No Hay pokemons Debilitados");
                        }
                        Console.WriteLine("");
                        Console.WriteLine("Aprete una tecla para continuar");
                        Console.ReadKey();
                        break;
                    case 7:
                        Console.Clear();
                        for (int i = 0; cantidad != i; i++)
                        {
                            if (vidasPokemon[i] >= pokemonMasVida)
                            {
                                pokemonMasVida = i;
                            }
                        }
                        Console.WriteLine("El pokemon con mas vida es el numero " + pokemonMasVida);
                        Console.WriteLine("tiene esta cantidad de vida: " + vidasPokemon[pokemonMasVida]);
                        Console.WriteLine("");
                        Console.WriteLine("Aprete una tecla para continuar");
                        Console.ReadKey();
                        break;
                    case 8:
                        Console.Clear();
                        for (int i = 0; cantidad != i; i++)
                        {
                            if (vidasPokemon[i] <= pokemonMenosVida)
                            {
                                pokemonMenosVida = i;
                            }
                        }
                        Console.WriteLine("El pokemon con menos vida es el numero " + pokemonMenosVida);
                        Console.WriteLine("tiene esta cantidad de vida: " + vidasPokemon[pokemonMenosVida]);
                        Console.WriteLine("");
                        Console.WriteLine("Aprete una tecla para continuar");
                        Console.ReadKey();
                        break;
                    case 9:
                        for (int i = 0; cantidad != i; i++)
                        {
                            promedio = promedio + vidasPokemon[i];
                        }
                        promedio = promedio / cantidad;
                        if (promedio >= 70)
                        {
                            Console.WriteLine("El equipo esta en buen estado.");
                        }else if (promedio >= 31 && promedio <= 69)
                        {
                            Console.WriteLine("El equipo necesita curacion.");
                        }else if (promedio <= 30)
                        {
                            Console.WriteLine("El equipo esta en peligro.");
                        }
                        Console.WriteLine("");
                        Console.WriteLine("Aprete una tecla para continuar");
                        Console.ReadKey();
                        break;
                    case 10:
                        for (int y =0; y < cantidad; y++)
                        {
                            for (int x = 0; x < cantidad - 1; x++)
                            {
                                if (vidasPokemon[x] > vidasPokemon[x + 1])
                                {
                                    int z = vidasPokemon[x];
                                    vidasPokemon[x] = vidasPokemon[x + 1];
                                    vidasPokemon[x + 1] = z;
                                }
                            }
                        }
                        break;
                    case 11:
                        Array.Sort(vidasPokemon);
                        Array.Reverse(vidasPokemon);
                        break;
                    case 12:
                        Console.Clear();
                        Console.WriteLine("Un pokemon salvaje ataco a tu equipo!!! ");
                        ataqueSalvaje = random.Next(5, 25);
                        for (int i = 0; cantidad != i; i++)
                        {
                            vidasPokemon[i] = vidasPokemon[i] - ataqueSalvaje;
                            if (vidasPokemon[i] < 0)
                            {
                                vidasPokemon[i] = 0;
                            }
                        }
                        Console.WriteLine("");
                        Console.WriteLine("Daño recibido a todos: " + ataqueSalvaje);
                        Console.WriteLine("");
                        Console.WriteLine("Aprete una tecla para continuar");
                        Console.ReadKey();
                        break;
                    case 13:
                        bucle = true;
                        Console.WriteLine("");
                        Console.WriteLine("Aprete una tecla para continuar");
                        Console.ReadKey();
                        break;
                    default:
                        Console.WriteLine("Opcion incorrecta");
                        Console.WriteLine("");
                        Console.WriteLine("Aprete una tecla para continuar");
                        Console.ReadKey();
                        break;
                }  
            }

        }
    }
}
