using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArregloDoble
{
    class Program
    {
        static int[][] califs;
        static int estudiantes , examenes;
        static void Main(string[] args)
        {
            califs = new int[3][];
            califs[0] = new int[] { 77, 68, 86, 73 };
            califs[1] = new int[] { 96, 87, 89, 81 };
            califs[2] = new int[] { 70, 90, 86, 81 };
            estudiantes = califs.Length;
            // numero de estudiantes
            examenes = califs[0].Length;
            // numero de examenes
            // relleno de lineade encabezados
            Console.Write("           ");
            // imprime encabezados de columnas
            for (int i = 0; i < examenes; i++)
                Console.Write(" [{0}] ", i);
            // imprime renglones
            for (int i = 0; i < estudiantes; i++)
            {
                Console.Write("\ncalifs[{0}]   ", i);
            for (int j = 0; j < examenes; j++)
                    Console.Write("{0}   ", califs[i][j]);
            }
            Console.Write
            ("\n\nCalificación más baja: {0}\n", Minima());
            Console.Write("Calificación más alta: {0} \n\n", Maxima());
            for (int i = 0; i < estudiantes; i++)
                Console.WriteLine("El promedio del estudiante {0} es {1}", i + 1, Promedio(califs[i]));
            Console.ReadLine();
        }

        static public int Minima()
        {
            int califMinima = 100;
            for (int i = 0; i < estudiantes; i++)
                for (int j = 0; j < examenes; j++)
                    if (califs[i][j] < califMinima)
                        califMinima = califs[i][j];
            return califMinima;
        }

        static public int Maxima()
        {
            int califMaxima = 0;
            for (int i = 0; i < estudiantes; i++)
                for (int j = 0; j < examenes; j++)
                    if (califs[i][j] > califMaxima)
                        califMaxima = califs[i][j];
            return califMaxima;
        }

        public static double Promedio(int[] conjuntoCalifs)
        {
            int total = 0;
            for (int i = 0; i < conjuntoCalifs.Length; i++)
                total += conjuntoCalifs[i];
            return (double)total / conjuntoCalifs.Length;
        }

    }
}
