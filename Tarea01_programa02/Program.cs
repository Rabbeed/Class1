using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea01_programa02
{
    class Program
    {
        static void Main(string[] args)
        {
            string nombre, estac;
            double pxhr, horas, horasX, resNormal, resExtra, pagaB, pagaImp;
            var pagaEst = 0;

            Console.WriteLine("Nombre del empleado: ");
            nombre = Console.ReadLine();
            Console.WriteLine("Paga por hora: ");
            pxhr = double.Parse(Console.ReadLine());
            Console.WriteLine("Horas Trabajadas: ");
            horas = double.Parse(Console.ReadLine());
            Console.WriteLine("Tipo de estacionamiento (A,B,Ninguno):");
            estac = Console.ReadLine();
            if(estac.ToUpper() == "A" | estac.ToUpper() == "B" | estac.ToUpper() == "NINGUNO")
            {
                if (horas > 40)
                {
                    horasX = horas - 40;
                    resExtra = horasX * pxhr;
                    resNormal = resExtra + (horas * pxhr);
                    pagaB = resNormal;
                    pagaImp = pagaB * 0.13;


                    if (pagaB < 1000 && estac.ToUpper() == "B")
                    {
                        pagaEst = 2;
                        imprimir(nombre, estac, pxhr, horas, pagaB, pagaImp, pagaEst);
                    }
                    if (pagaB < 1000 && estac.ToUpper() == "A")
                    {
                        pagaEst = 5;
                        imprimir(nombre, estac, pxhr, horas, pagaB, pagaImp, pagaEst);
                    }
                    if (pagaB < 1000 && estac.ToUpper() == "NINGUNO")
                    {
                        pagaEst = 0;
                        imprimir(nombre, estac, pxhr, horas, pagaB, pagaImp, pagaEst);
                    }


                    if (pagaB > 1000 && estac.ToUpper() == "B")
                    {
                        pagaEst = 3;
                        imprimir(nombre, estac, pxhr, horas, pagaB, pagaImp, pagaEst);
                    }
                    if (pagaB > 1000 && estac.ToUpper() == "A")
                    {
                        pagaEst = 7;
                        imprimir(nombre, estac, pxhr, horas, pagaB, pagaImp, pagaEst);
                    }
                    if (pagaB > 1000 && estac.ToUpper() == "NINGUNO")
                    {
                        pagaEst = 0;
                        imprimir(nombre, estac, pxhr, horas, pagaB, pagaImp, pagaEst);
                    }

                }
                else
                {

                    resNormal = horas * pxhr;
                    pagaB = resNormal;
                    pagaImp = pagaB * 0.13;


                    if (pagaB < 1000 && estac.ToUpper() == "B")
                    {
                        pagaEst = 2;
                        imprimir(nombre, estac, pxhr, horas, pagaB, pagaImp, pagaEst);
                    }
                    if (pagaB < 1000 && estac.ToUpper() == "A")
                    {
                        pagaEst = 5;
                        imprimir(nombre, estac, pxhr, horas, pagaB, pagaImp, pagaEst);
                    }
                    if (pagaB < 1000 && estac.ToUpper() == "NINGUNO")
                    {
                        pagaEst = 0;
                        imprimir(nombre, estac, pxhr, horas, pagaB, pagaImp, pagaEst);
                    }


                    if (pagaB > 1000 && estac.ToUpper() == "B")
                    {
                        pagaEst = 3;
                        imprimir(nombre, estac, pxhr, horas, pagaB, pagaImp, pagaEst);
                    }
                    if (pagaB > 1000 && estac.ToUpper() == "A")
                    {
                        pagaEst = 7;
                        imprimir(nombre, estac, pxhr, horas, pagaB, pagaImp, pagaEst);
                    }
                    if (pagaB > 1000 && estac.ToUpper() == "NINGUNO")
                    {
                        pagaEst = 0;
                        imprimir(nombre, estac, pxhr, horas, pagaB, pagaImp, pagaEst);
                    }
                }
            }
            else Console.WriteLine("Seleccion incorrecta");
            Console.ReadLine();

            void imprimir(string nom, string est, double pxr, double hrs, double pagB, double pagImp, double pagEst)
            {
                double pagN;
                pagN = pagB - pagImp - pagEst;
                Console.Clear();
                Console.WriteLine("REPORTE DE PAGO SEMANAL\n\n");
                Console.WriteLine("{0}, recibe un pago por hora de ${1}\n", nom.ToUpper(), pxr);
                Console.WriteLine("Esta semana trabajó {0} horas\n", hrs);
                Console.WriteLine("Utilizo esta semana el estacionamiento tipo {0}\n\n\n", est.ToUpper());
                Console.WriteLine("El resumen de sus pagos es:\n");
                Console.WriteLine("Paga Bruta ${0}\n", pagB);
                Console.WriteLine("\t- Pago por Impuestos: {0}\n", pagImp);
                Console.WriteLine("\t- Pago por Estacionamiento: {0}\n", pagEst);
                Console.WriteLine("Paga Neta ${0}\n", pagN);
                Console.ReadLine();
            }
        }
    }
}
