using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tarea03_programa05
{
    public partial class Form1 : Form
    {
        int[] arreglo = new int[15];
        int[] arregloI = new int[15];

        public Form1()
        {
            InitializeComponent();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            MostrarO();
            MostrarI();
        }

        private void MostrarO()
        {
            txtO.Text += "[";
            Random a = new Random();
            for(int i = 0; i < arreglo.Length; i++)
            {
                arreglo[i] = a.Next(1, 100);
                txtO.Text += arreglo[i] + " ";
            }
            txtO.Text += "]";
        }

        private void MostrarI()
        {          
           txtI.Text += "[";
            for (int i = arreglo.Length-1; i >= 0; i--)
            {
                arregloI[i] = arreglo[i];
                txtI.Text += arregloI[i] + " ";
            }  
  
            txtI.Text += "]";
        }



    }
}
