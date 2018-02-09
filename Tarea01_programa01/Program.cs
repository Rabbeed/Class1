using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea01_programa01
{
    class Program
    {
        static void Main(string[] args)
        {
            string opcion = "";
            double angulo = 0, res = 0, rad, grad;

            Console.WriteLine("Angulo original en R o G?");
            opcion = Console.ReadLine();
            Console.WriteLine("Angulo a convertir?");
            angulo = Double.Parse(Console.ReadLine());
            rad = 180 / Math.PI;
            grad = Math.PI / 180;

            if (opcion.ToUpper() == "R")
            {
                res = angulo*grad;
                Console.WriteLine("{0} Radianes equivalen a {1} grados",angulo, res );

            }else if (opcion.ToUpper() == "G")
            {
                res = angulo*rad;
                Console.WriteLine("{0} Grados equivalen a {1} radianes", angulo, res);
            }
            else
            {
                Console.WriteLine("Seleccion incorrecta");

            }
            Console.ReadLine();

        }
    }
}
