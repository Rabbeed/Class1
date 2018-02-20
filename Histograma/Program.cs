using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Histograma
{
    class Program
    {
        static void Main(string[] args)
        {
            int
            [] n = { 19, 3, 15, 7, 11, 9, 13, 5, 17, 1 };
            string salida = "" ; 
            salida +=  "Elemento \tvalor \tHistograma\n";
            //  construye  salida

            for(int i = 0; i < n.Length ; i++)
            {
                salida +=  "\n" + i + "\t" + n[i] + "\t";
                for(int j = 1; j <= n[i]; j++)
                    // imprime barra
                    salida += "*";
            }
            MessageBox.Show(salida,"Impresion de Histograma",
            MessageBoxButtons.OK,
            MessageBoxIcon.Information
            );
        }
    }
}
