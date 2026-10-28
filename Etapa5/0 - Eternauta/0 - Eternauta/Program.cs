using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0___Eternauta
{
    class Program
    {
        static void Main(string[] args)
        {
            refugio refugio101 = new refugio(101, 20, 12);
            refugio refugio102 = new refugio(102, 15, 10);
            refugio refugio103 = new refugio(103, 30, 25);
            Console.WriteLine("=== Refugios ===");
            Console.WriteLine("");
            refugio101.mostrarInformacion();
            Console.WriteLine("");
            refugio102.mostrarInformacion();
            Console.WriteLine("");
            refugio103.mostrarInformacion();
            Console.WriteLine("");
            Console.WriteLine("=== RESUMEN ===");
            int cantidadAlojados = refugio101.getCantidadAlojados() + refugio102.getCantidadAlojados() + refugio103.getCantidadAlojados();
            int cantidadDisponibles = refugio101.calcularDisponibles() + refugio102.calcularDisponibles() + refugio103.calcularDisponibles();
            int refugioMasCantidad;
            if (refugio101.getCantidadPersonas() > refugio102.getCantidadPersonas() && refugio101.getCantidadPersonas() > refugio103.getCantidadPersonas())
            {
                refugioMasCantidad = refugio101.getCodigo();
            }else if(refugio102.getCantidadPersonas() > refugio101.getCantidadPersonas() && refugio102.getCantidadPersonas() > refugio103.getCantidadPersonas())
            {
                refugioMasCantidad = refugio102.getCodigo();
            }else
            {
                refugioMasCantidad = refugio103.getCodigo();
            }
            Console.WriteLine("Cantidad total alojados = " + cantidadAlojados);
            Console.WriteLine("Cantidad total Disponibles = " + cantidadDisponibles);
            Console.WriteLine("Refugio de mayor capacidad = " + refugioMasCantidad);
            Console.ReadKey();
        }
    }
    class refugio
    {
        private int codigo;
        private int cantidadPersonas;
        private int personasAlojadas;
        private int cantidadDispo;

        public refugio(int codigo, int cantidadPersonas, int personasAlojadas)
        {
            this.codigo = codigo;
            this.cantidadPersonas = cantidadPersonas;
            this.personasAlojadas = personasAlojadas;
        }

        public int getCantidadPersonas()
        {
            return cantidadPersonas;
        }

        public int getCantidadAlojados()
        {
            return personasAlojadas;
        }

        public int getCodigo()
        {
            return codigo;
        }

        public int calcularDisponibles()
        {
            cantidadDispo = cantidadPersonas - personasAlojadas;
            return cantidadDispo;
        }
        public void mostrarInformacion()
        {
            calcularDisponibles();
            Console.WriteLine("Refugio " + codigo);
            Console.WriteLine("Capacidad: " + cantidadPersonas);
            Console.WriteLine("Alojados: " + personasAlojadas);
            Console.WriteLine("Disponibles: " + cantidadDispo);
        }
    }
}
