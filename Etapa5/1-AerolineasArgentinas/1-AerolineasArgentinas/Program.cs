using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_AerolineasArgentinas
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("envido");
            string nombre;
            string destino;
            int clase;
            int cantidad;
            int recaudacionTotal = 0;
            int asientosTotales = 0;
            int numeroMayorImporte = 0;
            int nombreMayorImporte = 0;
            int comprasMasDoscientos = 0;
            int procentajeDoscientos = 0;


            compra[] registroCompras = new compra[10];

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("===========================================");
                Console.WriteLine("");
                Console.WriteLine("Registro de compra N°" + (i + 1));
                Console.WriteLine("");
                Console.WriteLine("Ingrese su nombre: ");
                nombre = Console.ReadLine();
                Console.WriteLine("");
                Console.WriteLine("Ingrese el destino: ");
                destino = Console.ReadLine();
                Console.WriteLine("");
                Console.WriteLine("Eliga la clase ingresando 1 o 2");
                Console.WriteLine("Basico (35k$): 1");
                Console.WriteLine("Alta (55k$): 2");
                clase = int.Parse(Console.ReadLine());
                while (clase != 1 && clase != 2)
                {
                    Console.WriteLine("");
                    Console.WriteLine("Eliga la clase ingresando 1 o 2");
                    Console.WriteLine("Basico (35k$): 1");
                    Console.WriteLine("Alta (55k$): 2");
                    clase = int.Parse(Console.ReadLine());
                }
                Console.WriteLine("");
                Console.WriteLine("Ingrese la cantidad de asientos");
                cantidad = int.Parse(Console.ReadLine());
                compra registro = new compra(i + 1, nombre, destino, clase, cantidad);
                registroCompras[i] = registro;
            }

            for (int i = 0; i < 10; i++)
            {
                recaudacionTotal = recaudacionTotal + registroCompras[i].getPrecio();
            }

            for (int i = 0; i < 10; i++)
            {
                asientosTotales = asientosTotales + registroCompras[i].getCantidadAsientos();
            }

            int importePromedio = recaudacionTotal / asientosTotales;

            for (int i = 0; i < 10; i++)
            {
                if (numeroMayorImporte < registroCompras[i].getPrecio())
                {
                    numeroMayorImporte = registroCompras[i].getPrecio();
                    nombreMayorImporte = i;
                }

            }

            for (int i = 0; i < 10; i++)
            {
                if (200000 < registroCompras[i].getPrecio())
                {
                    comprasMasDoscientos++;
                }
            }

            procentajeDoscientos = (comprasMasDoscientos * 100) / 10;

            Console.WriteLine("");
            Console.WriteLine("===========================================");
            Console.WriteLine("");
            Console.WriteLine("Recaudacion total: " + recaudacionTotal);
            Console.WriteLine("");
            Console.WriteLine("Asientos totales vendidos: " + asientosTotales);
            Console.WriteLine("");
            Console.WriteLine("Importe promedio de las compras realizadas: " + importePromedio);
            Console.WriteLine("");
            Console.WriteLine("Nombre del pasajero que realizo el mayor importe: " + registroCompras[nombreMayorImporte].getnombre());
            Console.WriteLine("");
            Console.WriteLine("Cantidad de compras que superaron los 200k$: " + comprasMasDoscientos);
            Console.WriteLine("");
            Console.WriteLine("Porcentaje de compras que superaron los 200k$: " + procentajeDoscientos + "%");
            Console.WriteLine("");
            Console.WriteLine("Destino del pasajero que realizo el mayor importe: " + registroCompras[nombreMayorImporte].getDestino());
            Console.ReadKey();

        }
    }
    class compra
    {
        private int codigo;
        private string nombre;
        private string destino;
        private int precio;
        private int cantidadAsientos;

        public compra(int codigo, string nombre, string destino, int precio, int cantidadAsientos)
        {
            this.codigo = codigo;
            this.nombre = nombre;
            this.destino = destino;
            this.precio = precio;
            this.cantidadAsientos = cantidadAsientos;
        }

        public string getnombre()
        {
            return nombre;
        }

        public int getPrecio()
        {
            if (precio == 1)
            {
                precio = cantidadAsientos * 35000;
            }else if(precio == 2)
            {
                precio = cantidadAsientos * 55000;
            }
            return precio;
        }

        public int getCodigo()
        {
            return codigo;
        }

        public string getDestino()
        {
           return destino;
        }

        public int getCantidadAsientos()
        {
            return cantidadAsientos;
        }


    }
}