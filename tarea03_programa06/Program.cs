using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tarea03_programa06
{
    class Program
    {
        public static int[] arregloA = new int[10];
        public static int[] arregloB = new int[10];
        public static int[] arregloC = new int[10];
        public static string respuesta;
        
        static void Main(string[] args)
        {
            for(int i = 0; i < arregloA.Length; i++)
            {
                System.Console.Write("Ingresa el valor del Arreglo A[{0}] ", i);
                respuesta = Console.ReadLine();
                arregloA[i] = int.Parse(respuesta);
       
            }
            System.Console.Write("\n\n");
            for (int j = 0; j < arregloB.Length; j++)
            {
                System.Console.Write("Ingresa el valor del Arreglo B[{0}] ", j);
                respuesta = Console.ReadLine();
                arregloB[j] = int.Parse(respuesta);

            }
            System.Console.Write("\n\n Multiplicacion inversa");
            Multiplicacion();
            Console.Clear();
            System.Console.Write("\n\n Arreglos A, B y C\n");
            Imprimir();
            Console.ReadLine();

        }

        public static void Multiplicacion()
        {
            int temp = arregloB.Length - 1;
                
            for(int i = 0; i < arregloA.Length; i++)
            {
                arregloC[i] = arregloA[i] * (arregloB[temp - i]);
            }

        }

        public static void Imprimir()
        {
            for (int j = 0; j < arregloA.Length; j++)
            {
                System.Console.Write("Arreglo A [{0}] = {1} \n", j , arregloA[j].ToString());
        
            }
            System.Console.Write("\n\n");
            for (int i = 0; i < arregloB.Length; i++)
            {
                System.Console.Write("Arreglo B [{0}] = {1} \n", i, arregloB[i].ToString());

            }
            System.Console.Write("\n\n");
            for (int K = 0; K < arregloC.Length; K++)
            {
                System.Console.Write("Arreglo C [{0}] = {1} \n", K, arregloC[K].ToString());

            }
        }

    }
}
