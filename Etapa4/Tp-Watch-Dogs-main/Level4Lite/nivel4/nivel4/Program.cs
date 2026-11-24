using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nivel4
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Nivel 4 – Cifrado +1 (LITE)");
            string msg = "ctOS";
            string enc = Level4.CaesarPlusOne(msg);
            bool ok = enc == "duPT"; // c->d, t->u, O->P, S->T
            Console.WriteLine(ok ? "✔ UNLOCK → Código final: CT-ACCESS-OK" : "🔒 LOCKED");
        }
    }

    static class Level4
    {
        public static string CaesarPlusOne(string s)
        {
            string resultado = "";
            char letra;

            for (int i = 0; i < s.Length; i++)
            {
                letra = s[i];

                if (char.IsLetter(letra))
                {
                    if (letra == 'z')
                    {
                        resultado = resultado + 'a';
                    }
                    else if (letra == 'Z')
                    {
                        resultado = resultado + 'A';
                    }
                    else
                    {
                        resultado = resultado + (char)(letra + 1);
                    }
                }
                else
                {
                    resultado = resultado + letra;
                }
            }

            return resultado;
        }
    }
