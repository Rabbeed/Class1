using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tarea03_programa02
{
    public partial class programa02 : Form
    {
        int[] arregloA = new int[15];
        int[] arregloB = new int[15];
        int[] arregloC = new int[15];

        public programa02()
        {
            InitializeComponent();
        }

        private void mostrar(int[] a, TextBox txt)
        {
            txt.Clear();
            txt.Text += "[";
            for (int i = 0; i < a.Length; i++)
                txt.Text += a[i] + " ";
            txt.Text += "]";
        }

        private void programa02_Load(object sender, EventArgs e)
        {
           
            Random aleatorio = new Random();
            for (int i = 0; i < arregloA.Length; i++)
            {
                arregloA[i] = aleatorio.Next(0, 100);
                arregloB[i] = aleatorio.Next(0, 100);
                mostrar(arregloA, txtA);
                mostrar(arregloB, txtB);
            }
            
        }

        private void txtRes_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnSuma_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < arregloA.Length; i++)
            {
                arregloC[i] = arregloA[i] + arregloB[i];
                mostrar(arregloC, txtRes);
            }
        }
    }
}
