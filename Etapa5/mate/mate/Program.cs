using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mate
{
    class Program
    {
        static void Main(string[] args)
        {
            mate mateFran = new mate(10, 4, 70, true, "Madera ");

            Console.WriteLine(mateFran.getCantAgua());

            mate mateRojo = new mate(10, 5, 80, false, "Vidrio ");

            Console.WriteLine(mateRojo.getCantAgua());

            mate mateChiquitoPiernas = new mate(6, 2.5, 20, true, "Aluminio ");

            Console.WriteLine(mateChiquitoPiernas.getCantAgua());

            mate mateChiquito = new mate(4, 2.5, 20, false, "Aluminio ");

            Console.WriteLine(mateChiquito.getCantAgua());

            mate matePlug = new mate(10,3,70,false, "nosexd ");

            Console.WriteLine(matePlug.getCantAgua());

            mate matePablo = new mate(8,2.5,60,false,"ceramica ");

            Console.WriteLine(matePablo.getCantAgua());

            Console.ReadKey();


        }
    }
    class mate
    {
        //atributos
        private int altura;
        private double radio;
        private int capacidad;
        private bool tieneBombilla;
        private string material;
        private int CantidadDeAgua;

        //constructor
        public mate(int altura, double radio, int capacidad, bool tieneBombilla, string material)
        {
            this.altura = altura;
            this.radio = radio;
            this.capacidad = capacidad;
            this.tieneBombilla = tieneBombilla;
            this.material = material;
        }

        // metodos
        public void cebar()
        {
            CantidadDeAgua = capacidad;
        }

        public void tomar (int tomar)
        {
            CantidadDeAgua -= tomar;
        }   

        public int getCantAgua()
        {
            return CantidadDeAgua;
        }
    }
}
