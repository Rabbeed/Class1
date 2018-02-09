using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pro3
{
    class Program
    {
        static void Main(string[] args)
        {
            // Programa que calcula el area de un triangulo y la superficie de un circulo
            double area, labase, laaltura;
            double superficie, radio;
            string res = "";

            Console.Clear();
            Console.WriteLine("La figura es (C)irculo o (T)riangulo ?");
            res = Console.ReadLine();

            if (res.ToUpper() == "C")
            {
                Console.WriteLine("Ingrese el radio");
                radio = double.Parse(Console.ReadLine());
                superficie = Math.PI * Math.Pow(radio, 2);
                Console.WriteLine("La superficie del circulo es {0}", superficie);
                
            }
            else if (res.ToUpper() == "T")
            {
                Console.WriteLine("Dame la base");
                labase = double.Parse(s:Console.ReadLine());
                Console.WriteLine("Dame la altura");
                laaltura = double.Parse(Console.ReadLine());
                area = (labase * laaltura) / 2;
                Console.WriteLine("El area del triangulo es {0}", area);
                
            }
            else
            {
                Console.WriteLine("Seleccion incorrecta");
                
            }
            Console.ReadLine();

        }

    }
}
