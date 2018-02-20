using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace inicializarArreglos
{
    class Program
    {
        static void Main(string[] args)
        {
            string salida ="";
            int  [] x;
            // Declara la referencia a un arreglo
            x = new int [10];
            //  Reserva memoria y estable no de elementos
            // Lista de inicializadores, especifica el numero de elementos
            // y el valor de cada elemento
            int [] y = { 32, 27, 64, 18, 95, 14, 90, 70, 60, 37 };
            const  int  TAMANO_ARREGLO = 10;
            // constante con nombre
            int  [] z;
            // referencia a un arreglo
            // reserva memoria para TAMANO_ARREGLO(ej., 10) elementos
            z =  new  int  [TAMANO_ARREGLO];
            // pone valores en el arreglo
            for  (  int  i  = 0;  i  <  z.Length  ;  i  ++)
                z[i] = 2 + 2 * i;
                salida += "Subindice \tArreglo x\tArreglo y\tArreglo z\n";
            // salida de los valores para cada arreglo
            for(int i = 0;i < TAMANO_ARREGLO; i++)
                salida  += i  +  "\t"+ x[i] +"\t"+ y[i] +"\t"+ z[i] +"\n";
            MessageBox.Show  ( salida, "Inicializando un arreglo con valores enteros",
            MessageBoxButtons.OK ,
            MessageBoxIcon.Information
            );
        }
    }
}
