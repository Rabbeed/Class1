using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SumaElementosdeArreglos
{
    class Program
    {
        static void Main(string[] args)
        {
            int
            [] a = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            int  total = 0;
            for (int  i  = 0; i < a.Length ; i  ++)
                total += a[i];
                MessageBox.Show( "Total de elementos del arreglo " + total,
                "Suma de los elementos de un Arreglo" ,
                 MessageBoxButtons.OK,
                 MessageBoxIcon.Information
            );
        }
    }
}
