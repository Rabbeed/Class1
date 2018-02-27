using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tarea03_programa04
{
    public partial class Form1 : Form
    {
        int[] arreglo = new int[30];
        int contN = 0, contP = 0, contC = 0;  

        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            mostrarO();
            mostrarP();
            mostrarN();
            Cantceros();
        }

        private void mostrarO()
        {
            txtOrig.Text += "[";
            Random a = new Random();

            for (int i = 0; i < arreglo.Length; i++)
            {
                arreglo[i] = a.Next(-50, 50);
                txtOrig.Text += arreglo[i] + " ";

            }
            txtOrig.Text += "]";

        }

        private void mostrarP()
        {
            txtPos.Text += "[";
            for (int i = 0; i < arreglo.Length; i++)
            {
                if (arreglo[i] > 0)
                {
                    txtPos.Text += arreglo[i] + " ";
                    contP++;
                }
            }
            txtPos.Text += "]";
            txtCantPos.Text = contP.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double cant = 0;
            for (int i = 0; i < arreglo.Length; i++)
            {
                if (arreglo[i] < 0)
                {
                    cant += arreglo[i];
                }
            }
            lblResNeg.Text = "Total: "  + cant.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            double cant = 0;
            for (int i = 0; i < arreglo.Length; i++)
            {
                if (arreglo[i] > 0)
                {
                    cant += arreglo[i];
                }
            }
            lblResPos.Text = "Total: " + cant.ToString();
        }

        private void mostrarN()
        {
            txtNeg.Text += "[";
            for (int i = 0; i < arreglo.Length; i++)
            {
                if (arreglo[i] < 0)
                {
                    txtNeg.Text += arreglo[i] + " ";
                    contN++;
                }
            }
            txtNeg.Text += "]";
            txtCantNeg.Text = contN.ToString();

        }
        
        private void Cantceros()
        {
            
            for (int i = 0; i < arreglo.Length; i++)
            {
                if (arreglo[i] == 0)
                {
                    contC++;
                }
            }
           
            txtCantCero.Text = contC.ToString();

        }
    }
}
