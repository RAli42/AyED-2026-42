using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15_Vuelto
{
    class Program
    {
        static void Main(string[] args)
        {
            int billeteDiezMil = 0;
            int billeteDosMil = 0;
            int billeteMil = 0;
            int billeteQuinientos = 0;
            int billeteDoscientos = 0;
            int billeteCien = 0;
            int billeteCincuenta = 0;
            int billeteDiez = 0;
            int billeteVeinte = 0;
            int billeteUno = 0;


            Console.Write("Ingrese el monto a pagar: ");
            int monto = int.Parse(Console.ReadLine());
            Console.Write("Ingrese la cantidad de dinero utilizada para pagar: ");
            int pagado = int.Parse(Console.ReadLine());

            int vuelto = pagado - monto;
            int vueltoOriginal = vuelto;
            while (vuelto != 0)
            {
                if (vuelto / 10000 > 0)
                {
                    billeteDiezMil = vuelto / 10000;
                    vuelto = vuelto - (billeteDiezMil * 10000);
                }
                else if (vuelto / 2000 > 0)
                {
                    billeteDosMil = vuelto / 2000;
                    vuelto = vuelto - (billeteDosMil * 2000);
                }
                else if (vuelto / 1000 > 0)
                {
                    billeteMil = vuelto / 1000;
                    vuelto = vuelto - (billeteMil * 1000);
                }
                else if (vuelto / 500 > 0)
                {
                    billeteQuinientos = vuelto / 500;
                    vuelto = vuelto - (billeteQuinientos * 500);
                }
                else if (vuelto / 200 > 0)
                {
                    billeteDoscientos = vuelto / 200;
                    vuelto = vuelto - (billeteDoscientos * 200);
                }
                else if (vuelto / 100 > 0)
                {
                    billeteCien = vuelto / 100;
                    vuelto = vuelto - (billeteCien * 100);
                }
                else if (vuelto / 50 > 0)
                {
                    billeteCincuenta = vuelto / 50;
                    vuelto = vuelto - (billeteCincuenta * 50);
                }
                else if (vuelto / 20 > 0)
                {
                    billeteVeinte = vuelto / 20;
                    vuelto = vuelto - (billeteVeinte * 20);
                }
                else if (vuelto / 10 > 0)
                {
                    billeteDiez = vuelto / 10;
                    vuelto = vuelto - (billeteDiez * 10);
                }
                else if (vuelto / 1 > 0)
                {
                    billeteUno = vuelto / 1;
                    vuelto = vuelto - (billeteUno * 1);
                }
            }
            Console.WriteLine("Vuelto total : " + vueltoOriginal);

            if (billeteDiezMil != 0)
            {
                Console.WriteLine("Le tienen que devolver " + billeteDiezMil + " billetes de 10000");
            }
            if (billeteDosMil != 0)
            {
                Console.WriteLine("Le tienen que devolver " + billeteDosMil + " billetes de 2000");
            }
            if (billeteMil != 0)
            {
                Console.WriteLine("Le tienen que devolver " + billeteMil + " billetes de 1000");
            }
            if (billeteQuinientos != 0)
            {
                Console.WriteLine("Le tienen que devolver " + billeteQuinientos + " billetes de 500");
            }
            if (billeteDoscientos != 0)
            {
                Console.WriteLine("Le tienen que devolver " + billeteDoscientos + " billetes de 200");
            }
            if (billeteCien != 0)
            {
                Console.WriteLine("Le tienen que devolver " + billeteCien + " billetes de 100");
            }
            if (billeteCincuenta != 0)
            {
                Console.WriteLine("Le tienen que devolver " + billeteCincuenta + " billetes de 50");
            }
            if (billeteVeinte != 0)
            {
                Console.WriteLine("Le tienen que devolver " + billeteVeinte + " billetes de 20");
            }
            if (billeteDiez != 0)
            {
                Console.WriteLine("Le tienen que devolver " + billeteDiez + " billetes de 10");
            }
            if (billeteUno != 0)
            {
                Console.WriteLine("Le tienen que devolver " + billeteUno + " billetes de 1");
            }
            Console.ReadKey();
        }
    }
}
