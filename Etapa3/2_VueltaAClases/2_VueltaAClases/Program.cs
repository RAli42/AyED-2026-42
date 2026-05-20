using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_VueltaAClases
{
    class Program
    {
        static void Main(string[] args)
        {
            int promedioTps = 0;
            int promedioExamenes = 0;
            bool aprobado = false;

            Console.WriteLine("Ingrese la cantidad de TP´s entregados: ");
            int[] tps = new int[int.Parse(Console.ReadLine())];
            Console.WriteLine("Ingrese la cantidad de examenes entregados: ");
            int[] examenes = new int[int.Parse(Console.ReadLine())];
            for (int i = 0; i < tps.Length; i++)
            {
                Console.Clear();
                Console.WriteLine("");
                Console.WriteLine("Ingrese la nota de su tp " + (i + 1));
                int nota = int.Parse(Console.ReadLine());
                tps[i] = nota;
                while (nota > 10 || nota < 0)
                {
                    Console.WriteLine("");
                    Console.WriteLine("Ingrese la nota de su tp " + (i + 1));
                    nota = int.Parse(Console.ReadLine());
                    tps[i] = nota;
                    Console.Clear();

                }
            }
            for (int i = 0; i < examenes.Length; i++)
            {
                Console.Clear();
                Console.WriteLine("");
                Console.WriteLine("Ingrese la nota de su examen " + (i + 1));
                int nota = int.Parse(Console.ReadLine());
                examenes[i] = nota;
                while (nota > 10 || nota < 0)
                {
                    Console.WriteLine("");
                    Console.WriteLine("Ingrese la nota de su examen " + (i + 1));
                    nota = int.Parse(Console.ReadLine());
                    examenes[i] = nota;
                    Console.Clear();

                }
            }
            for (int i = 0; i < examenes.Length; i++)
            {
                promedioExamenes = promedioExamenes + examenes[i];
            }
            for (int i = 0; i < tps.Length; i++)
            {
                if (tps[i] >= 6)
                {
                    promedioTps++;
                }
            }
            if (promedioTps >= (tps.Length * 0.75))
            {
                if (promedioExamenes / examenes.Length >= 6)
                {
                    aprobado = true;
                }
            }
            if (aprobado == true)
            {
                Console.Clear();
                Console.WriteLine("");
                Console.WriteLine("------------------");
                Console.WriteLine("");
                Console.WriteLine("usted a aprobado con un promedio de examenes de " + promedioExamenes / examenes.Length);
                Console.WriteLine("y con " + promedioTps + " TP´s aprobados");
                Console.WriteLine("");
                Console.WriteLine("------------------");
                Console.ReadKey();
            }
            else
            {
                Console.Clear();
                Console.WriteLine("");
                Console.WriteLine("------------------");
                Console.WriteLine("");
                Console.WriteLine("usted a desaprobado con un promedio de examenes de " + promedioExamenes / examenes.Length);
                Console.WriteLine("y con " + promedioTps + " TP´s aprobados");
                Console.WriteLine("");
                Console.WriteLine("------------------");
                Console.ReadKey();
            }
            Console.ReadKey();
        }
    }
}
