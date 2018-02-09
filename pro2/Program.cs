using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pro2
{
    class Program
    {
        static void Main()
        {
            string nombre;
            int horas;
            float tasa, paga, pb, pn, imp;

            System.Console.WriteLine("Calculo de la paga de un trabajador\n\n");
            System.Console.WriteLine("Ingrese nombre: ");
            nombre = System.Console.ReadLine();
            System.Console.WriteLine("Ingrese horas trabajadas: ");
            horas = int.Parse(System.Console.ReadLine());
            System.Console.WriteLine("Paga por hora: ");
            paga = float.Parse(System.Console.ReadLine());
            System.Console.WriteLine("Tasa de impuesto: ");
            tasa = float.Parse(System.Console.ReadLine());

            //Calculos
            pb = horas * paga;
            imp = pb * tasa;
            pn = pb - imp;

            //Salida
            System.Console.WriteLine("El Trabajador {0}", nombre);
            System.Console.WriteLine("trabajó {0}", horas);
            System.Console.WriteLine("con una paga de {0} y una tasa de {1} %", paga, tasa);
            System.Console.WriteLine("Impuesto = {0}, Paga bruta = {1}, Paga neta = {2}", imp, pb, pn);
            System.Console.ReadLine();
        }
    }
}
