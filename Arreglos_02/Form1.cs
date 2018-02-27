using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Arreglos_02
{
    public partial class Form1 : Form
    {
        int[] arreglo = new int[14];
        public Form1()
        {
            InitializeComponent();
        }
        // Procedimiento que muestra un arreglo en un cuadro de texto
        public void MostrarArreglo(int [] a, TextBox  txt)
        {
            txt.Clear();
            for ( int i= 0; i < arreglo.Length ;  i ++)
                txt.Text  +=  string.Format("[{0}] = {1}\r\n", i, arreglo[i]);
        }


        private void btnGenerar_Click(object sender, EventArgs e)
        {
            Random aleatorio = new Random();
            for ( int  i = 0; i < arreglo.Length ; i ++)
                arreglo[i] =  aleatorio.Next(0, 100);
            MostrarArreglo (arreglo, txtOriginal );
        }

        private void btnOrdenar_Click(object sender, EventArgs e)
        {
            Array.Sort(arreglo);
            // Ordena un arreglo unidimensional
            MostrarArreglo (arreglo, txtOrdenado );
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            //efectua una búsqueda lineal en el arreglo
            int pos = Array.IndexOf(arreglo,int.Parse(txtBuscar.Text));
            if (pos < 0)
                txtRes.Text = "Número no encontrado";
            else
                txtRes.Text = string.Format("El {0} esta en la posición [{1}]", arreglo[pos], pos);
        }
    }
}
