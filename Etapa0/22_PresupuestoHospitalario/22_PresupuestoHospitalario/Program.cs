using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _22_PresupuestoHospitalario
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Introduzca un presupuesto anual para un hospital: ");
            float presupuesto = float.Parse(Console.ReadLine());
            float gine = presupuesto * 40 / 100;
            float trauma = presupuesto * 30 / 100;
            Console.WriteLine("El presupuesto para Ginecologia es: " + gine + "$");
            Console.WriteLine("El presupuesto para Traumatologia es: " + trauma + "$");
            Console.WriteLine("El presupuesto para Pediatria es: " + trauma + "$");
            Console.ReadKey();
        }
    }
}
