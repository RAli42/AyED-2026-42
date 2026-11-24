using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2___SistemaDeInventario
{
    class Program
    {
        static void Main(string[] args)
        {
            int opcion = 0;
            int id;
            string nombre;
            string material;
            int opcionCrafteable;
            string crafteable;
            int stack;
            int usos;
            int cantidad;
            int espacioDisponible;
            int faltante;
            int agregar;
            int posicion;
            int cantidadEliminar;
            int posicionesOcupadas;
            int espaciosLibres;
            int unidadesTotales;
            int objetosCrafteables;

            objeto[] inventario = new objeto[9];
            int[] cantidades = new int[9];

            for (int i = 0; i < 9; i++)
            {
                cantidades[i] = 0;
            }

            while (opcion != 6)
            {
                Console.WriteLine("===========================================");
                Console.WriteLine("");
                Console.WriteLine("Menu de Inventario");
                Console.WriteLine("");
                Console.WriteLine("1. Agregar objetos");
                Console.WriteLine("2. Mostrar inventario");
                Console.WriteLine("3. Utilizar objeto");
                Console.WriteLine("4. Eliminar objetos");
                Console.WriteLine("5. Consultar estadisticas");
                Console.WriteLine("6. Salir");
                Console.WriteLine("");
                Console.WriteLine("Ingrese una opcion: ");
                opcion = int.Parse(Console.ReadLine());

                while (opcion < 1 || opcion > 6)
                {
                    Console.WriteLine("");
                    Console.WriteLine("Opcion invalida. Ingrese una opcion del 1 al 6: ");
                    opcion = int.Parse(Console.ReadLine());
                }

                if (opcion == 1)
                {
                    Console.WriteLine("");
                    Console.WriteLine("===========================================");
                    Console.WriteLine("");
                    Console.WriteLine("Ingrese el ID del objeto: ");
                    id = int.Parse(Console.ReadLine());
                    Console.WriteLine("");
                    Console.WriteLine("Ingrese el nombre del objeto: ");
                    nombre = Console.ReadLine();
                    Console.WriteLine("");
                    Console.WriteLine("Ingrese el material del objeto: ");
                    material = Console.ReadLine();
                    Console.WriteLine("");
                    Console.WriteLine("El objeto es crafteable? Ingrese 1 o 2");
                    Console.WriteLine("Si: 1");
                    Console.WriteLine("No: 2");
                    opcionCrafteable = int.Parse(Console.ReadLine());

                    while (opcionCrafteable != 1 && opcionCrafteable != 2)
                    {
                        Console.WriteLine("");
                        Console.WriteLine("El objeto es crafteable? Ingrese 1 o 2");
                        Console.WriteLine("Si: 1");
                        Console.WriteLine("No: 2");
                        opcionCrafteable = int.Parse(Console.ReadLine());
                    }

                    if (opcionCrafteable == 1)
                    {
                        crafteable = "Si";
                    }
                    else
                    {
                        crafteable = "No";
                    }

                    Console.WriteLine("");
                    Console.WriteLine("Ingrese el stack maximo (1, 8, 16 o 64): ");
                    stack = int.Parse(Console.ReadLine());

                    while (stack != 1 && stack != 8 && stack != 16 && stack != 64)
                    {
                        Console.WriteLine("");
                        Console.WriteLine("Stack invalido. Ingrese 1, 8, 16 o 64: ");
                        stack = int.Parse(Console.ReadLine());
                    }

                    Console.WriteLine("");
                    Console.WriteLine("Ingrese los usos restantes del objeto: ");
                    usos = int.Parse(Console.ReadLine());

                    while (usos <= 0)
                    {
                        Console.WriteLine("");
                        Console.WriteLine("Los usos deben ser mayores a 0. Ingrese los usos restantes: ");
                        usos = int.Parse(Console.ReadLine());
                    }

                    Console.WriteLine("");
                    Console.WriteLine("Ingrese la cantidad de unidades a agregar: ");
                    cantidad = int.Parse(Console.ReadLine());

                    while (cantidad <= 0)
                    {
                        Console.WriteLine("");
                        Console.WriteLine("La cantidad debe ser mayor a 0. Ingrese la cantidad: ");
                        cantidad = int.Parse(Console.ReadLine());
                    }

                    espacioDisponible = 0;

                    for (int i = 0; i < 9; i++)
                    {
                        if (cantidades[i] > 0)
                        {
                            if (inventario[i].getId() == id && inventario[i].getNombre() == nombre && inventario[i].getMaterial() == material && inventario[i].getCrafteable() == crafteable && inventario[i].getStack() == stack && inventario[i].getUsos() == usos)
                            {
                                espacioDisponible = espacioDisponible + (stack - cantidades[i]);
                            }
                        }
                        else
                        {
                            espacioDisponible = espacioDisponible + stack;
                        }
                    }

                    if (cantidad > espacioDisponible)
                    {
                        Console.WriteLine("");
                        Console.WriteLine("No hay espacio suficiente en el inventario. Operacion cancelada.");
                        Console.WriteLine("");
                    }
                    else
                    {
                        faltante = cantidad;

                        for (int i = 0; i < 9; i++)
                        {
                            if (faltante > 0 && cantidades[i] > 0)
                            {
                                if (inventario[i].getId() == id && inventario[i].getNombre() == nombre && inventario[i].getMaterial() == material && inventario[i].getCrafteable() == crafteable && inventario[i].getStack() == stack && inventario[i].getUsos() == usos)
                                {
                                    if (cantidades[i] < stack)
                                    {
                                        agregar = stack - cantidades[i];
                                        if (agregar > faltante)
                                        {
                                            agregar = faltante;
                                        }
                                        cantidades[i] = cantidades[i] + agregar;
                                        faltante = faltante - agregar;
                                    }
                                }
                            }
                        }

                        for (int i = 0; i < 9; i++)
                        {
                            if (faltante > 0 && cantidades[i] == 0)
                            {
                                agregar = stack;
                                if (agregar > faltante)
                                {
                                    agregar = faltante;
                                }
                                objeto nuevoObjeto = new objeto(id, nombre, material, crafteable, stack, usos);
                                inventario[i] = nuevoObjeto;
                                cantidades[i] = agregar;
                                faltante = faltante - agregar;
                            }
                        }

                        Console.WriteLine("");
                        Console.WriteLine("Objetos agregados correctamente al inventario.");
                        Console.WriteLine("");
                    }

                    Console.ReadKey();
                    Console.Clear();
                }
                else if (opcion == 2)
                {
                    Console.WriteLine("");
                    Console.WriteLine("===========================================");
                    Console.WriteLine("");
                    Console.WriteLine("Inventario actual:");
                    Console.WriteLine("");

                    for (int i = 0; i < 9; i++)
                    {
                        Console.WriteLine("===========================================");
                        Console.WriteLine("");
                        Console.WriteLine("Posicion N°" + (i + 1));
                        Console.WriteLine("");

                        if (cantidades[i] == 0)
                        {
                            Console.WriteLine("Vacio");
                            Console.WriteLine("");
                        }
                        else
                        {
                            Console.WriteLine("ID: " + inventario[i].getId());
                            Console.WriteLine("");
                            Console.WriteLine("Nombre: " + inventario[i].getNombre());
                            Console.WriteLine("");
                            Console.WriteLine("Material: " + inventario[i].getMaterial());
                            Console.WriteLine("");
                            Console.WriteLine("Crafteable: " + inventario[i].getCrafteable());
                            Console.WriteLine("");
                            Console.WriteLine("Stack maximo: " + inventario[i].getStack());
                            Console.WriteLine("");
                            Console.WriteLine("Cantidad: " + cantidades[i]);
                            Console.WriteLine("");
                            Console.WriteLine("Usos restantes: " + inventario[i].getUsos());
                            Console.WriteLine("");
                        }
                    }

                    Console.ReadKey();
                    Console.Clear();
                }
                else if (opcion == 3)
                {
                    Console.WriteLine("");
                    Console.WriteLine("===========================================");
                    Console.WriteLine("");
                    Console.WriteLine("Ingrese la posicion del objeto a utilizar (1 a 9): ");
                    posicion = int.Parse(Console.ReadLine());

                    while (posicion < 1 || posicion > 9)
                    {
                        Console.WriteLine("");
                        Console.WriteLine("Posicion invalida. Ingrese una posicion del 1 al 9: ");
                        posicion = int.Parse(Console.ReadLine());
                    }

                    if (cantidades[posicion - 1] == 0)
                    {
                        Console.WriteLine("");
                        Console.WriteLine("La posicion seleccionada esta vacia.");
                        Console.WriteLine("");
                    }
                    else
                    {
                        inventario[posicion - 1].usarObjeto();
                        Console.WriteLine("");
                        Console.WriteLine("Se utilizo " + inventario[posicion - 1].getNombre() + ".");

                        if (inventario[posicion - 1].getUsos() == 0)
                        {
                            cantidades[posicion - 1] = cantidades[posicion - 1] - 1;
                            Console.WriteLine("Una unidad de " + inventario[posicion - 1].getNombre() + " se ha roto o consumido.");

                            if (cantidades[posicion - 1] == 0)
                            {
                                Console.WriteLine("La posicion " + posicion + " quedo vacia.");
                            }
                            else
                            {
                                inventario[posicion - 1].reiniciarUsos();
                                Console.WriteLine("Unidades restantes en la posicion: " + cantidades[posicion - 1]);
                            }
                        }
                        else
                        {
                            Console.WriteLine("Usos restantes del objeto: " + inventario[posicion - 1].getUsos());
                        }
                        Console.WriteLine("");
                    }

                    Console.ReadKey();
                    Console.Clear();
                }
                else if (opcion == 4)
                {
                    Console.WriteLine("");
                    Console.WriteLine("===========================================");
                    Console.WriteLine("");
                    Console.WriteLine("Ingrese la posicion de donde desea eliminar objetos (1 a 9): ");
                    posicion = int.Parse(Console.ReadLine());

                    while (posicion < 1 || posicion > 9)
                    {
                        Console.WriteLine("");
                        Console.WriteLine("Posicion invalida. Ingrese una posicion del 1 al 9: ");
                        posicion = int.Parse(Console.ReadLine());
                    }

                    if (cantidades[posicion - 1] == 0)
                    {
                        Console.WriteLine("");
                        Console.WriteLine("La posicion seleccionada esta vacia.");
                        Console.WriteLine("");
                    }
                    else
                    {
                        Console.WriteLine("");
                        Console.WriteLine("Cantidad actual en la posicion " + posicion + ": " + cantidades[posicion - 1]);
                        Console.WriteLine("Ingrese la cantidad de unidades a eliminar: ");
                        cantidadEliminar = int.Parse(Console.ReadLine());

                        while (cantidadEliminar <= 0 || cantidadEliminar > cantidades[posicion - 1])
                        {
                            Console.WriteLine("");
                            Console.WriteLine("Cantidad invalida. Debe ser entre 1 y " + cantidades[posicion - 1] + ": ");
                            cantidadEliminar = int.Parse(Console.ReadLine());
                        }

                        cantidades[posicion - 1] = cantidades[posicion - 1] - cantidadEliminar;
                        Console.WriteLine("");
                        Console.WriteLine("Se eliminaron " + cantidadEliminar + " unidades.");

                        if (cantidades[posicion - 1] == 0)
                        {
                            Console.WriteLine("La posicion " + posicion + " quedo vacia.");
                        }
                        else
                        {
                            Console.WriteLine("Unidades restantes en la posicion " + posicion + ": " + cantidades[posicion - 1]);
                        }
                        Console.WriteLine("");
                    }

                    Console.ReadKey();
                    Console.Clear();
                }
                else if (opcion == 5)
                {
                    posicionesOcupadas = 0;
                    espaciosLibres = 0;
                    unidadesTotales = 0;
                    objetosCrafteables = 0;

                    for (int i = 0; i < 9; i++)
                    {
                        if (cantidades[i] > 0)
                        {
                            posicionesOcupadas++;
                        }
                    }

                    for (int i = 0; i < 9; i++)
                    {
                        if (cantidades[i] == 0)
                        {
                            espaciosLibres++;
                        }
                    }

                    for (int i = 0; i < 9; i++)
                    {
                        unidadesTotales = unidadesTotales + cantidades[i];
                    }

                    for (int i = 0; i < 9; i++)
                    {
                        if (cantidades[i] > 0)
                        {
                            if (inventario[i].getCrafteable() == "Si")
                            {
                                objetosCrafteables++;
                            }
                        }
                    }

                    Console.WriteLine("");
                    Console.WriteLine("===========================================");
                    Console.WriteLine("");
                    Console.WriteLine("Estadisticas del inventario:");
                    Console.WriteLine("");
                    Console.WriteLine("Cantidad de posiciones ocupadas: " + posicionesOcupadas);
                    Console.WriteLine("");
                    Console.WriteLine("Cantidad de espacios libres: " + espaciosLibres);
                    Console.WriteLine("");
                    Console.WriteLine("Cantidad de unidades almacenadas: " + unidadesTotales);
                    Console.WriteLine("");
                    Console.WriteLine("Cantidad de objetos crafteables: " + objetosCrafteables);
                    Console.WriteLine("");

                    Console.ReadKey();
                    Console.Clear();
                }
            }

            Console.WriteLine("");
            Console.WriteLine("===========================================");
            Console.WriteLine("");
            Console.WriteLine("Saliendo del sistema...");
            Console.ReadKey();
        }
    }

    class objeto
    {
        private int id;
        private string nombre;
        private string material;
        private string crafteable;
        private int stack;
        private int usos;
        private int usosIniciales;

        public objeto(int id, string nombre, string material, string crafteable, int stack, int usos)
        {
            this.id = id;
            this.nombre = nombre;
            this.material = material;
            this.crafteable = crafteable;
            this.stack = stack;
            this.usos = usos;
            this.usosIniciales = usos;
        }

        public int getId()
        {
            return id;
        }

        public string getNombre()
        {
            return nombre;
        }

        public string getMaterial()
        {
            return material;
        }

        public string getCrafteable()
        {
            return crafteable;
        }

        public int getStack()
        {
            return stack;
        }

        public int getUsos()
        {
            return usos;
        }

        public void usarObjeto()
        {
            if (usos > 0)
            {
                usos = usos - 1;
            }
        }

        public void reiniciarUsos()
        {
            usos = usosIniciales;
        }
    }
}