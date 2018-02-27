using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArregloDosDimensiones
{
    class Program
    {
        static void Main(string[] args)
        {
            // declaración e inicialización de un arreglo rectangular
            int[,] arreglo1 = new int[,] { { 1, 2, 3 }, { 4, 5, 6 } };
            // declaración e inicialización de arreglos dentados
            int[][] arreglo2 = new int[3][];
            arreglo2[0] = new
            int  [] { 1, 2 };
            arreglo2[1] =  new int [] { 3 };
            arreglo2[2] =  new int [] { 4, 5, 6 };
            Console.WriteLine("\nValores en arreglo1 por renglón son\n" );
            
            // output values in arreglo1
            for(int i = 0; i < arreglo1.GetLength(0); i ++)
            {
                for ( int  j = 0; j < arreglo1.GetLength(1); j++)
                    Console.Write(  " {0} "  , arreglo1[i, j]);
                Console.WriteLine();
            }
            Console.WriteLine("\nValores en arreglo2 por renglón son\n");
            // salida de los elementos en el arreglo2
            for(int i = 0; i  < arreglo2.Length; i ++)
            {
                for ( int j = 0; j < arreglo2[i].Length; j++)
                    Console.Write(" {0} ", arreglo2[i][j]);
                Console.WriteLine ();
            }
            Console.ReadLine();
        }
    }
}
