using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EncuestaEstudiantes
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] respuestas = { 1, 2, 6, 4, 8, 5, 9, 7, 8, 10, 1,
                                 6, 3, 8, 6, 10, 3, 8, 2, 7, 6, 5,
                                 7, 6, 8, 6, 7, 5, 6, 6, 5, 6, 7, 5,
                                 6, 4, 8, 6, 8, 10 };
            int  [] frecuencia = new int [11];
            string salida = "";
            // incrementa la frecuencia para cada respuesta
            for(int respuesta  = 0;  respuesta  < respuestas.Length ;  respuesta++)
                ++frecuencia[respuestas[respuesta]];

            salida += "tasa\tfrecuencia\n";

            // salida de los resultados
            for(int tasa = 1; tasa < frecuencia.Length ; tasa++)
                salida += tasa +  "\t"+ frecuencia[tasa] +"\n";

            MessageBox.Show(salida,  "Encuesta de estudiantes" ,
            MessageBoxButtons.OK,
            MessageBoxIcon.Information
            );


        }
    }
}
