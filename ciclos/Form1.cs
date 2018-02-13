using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ciclos
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //numeros del 1 al 100 usando While
            int c, ini = 1, fin = 100, suma=0;
            c = ini;
        
            txtBSalida.Clear(); // borrar
            txtBSalida.Text = "Numeros del 1 al 100\r\n";

            while (c <= fin)
            {
             
                txtBSalida.Text += c.ToString() + "\r\n";
                suma += c;
                c++;
            }
            lblResultado.Text = "Suma: " + suma.ToString();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            //numeros del 100 al 1 usando Do While
            int c, ini = 100, fin = 1, suma = 0;
            c = ini;

            txtBSalida.Clear(); // borrar
            txtBSalida.Text = "Numeros del 100 al 1\r\n";

            do
            {
                txtBSalida.Text += c.ToString() + "\r\n";
                suma += c;
                c--;
            }
            while (c >= fin);
            lblResultado.Text = "Suma: " + suma.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            // 50 al 200 con for
            int c, ini = 50, fin = 200, suma = 0;
            c = ini;

            txtBSalida.Clear(); // borrar
            txtBSalida.Text = "Numeros del 50 al 200\r\n";

            while (c <= fin)
            {

                txtBSalida.Text += c.ToString() + "\r\n";
                suma += c;
                c++;
            }
            lblResultado.Text = "Suma: " + suma.ToString();

        }

    
        private void button4_Click(object sender, EventArgs e)
        {
            // 2 al 100 pares con for
            int c, ini = 2, fin = 100, suma = 0;
            c = ini;

            txtBSalida.Clear(); // borrar
            txtBSalida.Text = "Numeros del 2 al 100 pares\r\n";
            
            for ( c = 2;  c <= fin; c += 2)
            {
                txtBSalida.Text += c.ToString() + "\r\n";
                suma += c;
               
            }
            lblResultado.Text = "Suma: " + suma.ToString();

        }

        private void button5_Click(object sender, EventArgs e)
        {
            // 99 al 1 impares con for
            int c, ini = 99, fin = 1, suma = 0;
            c = ini;

            txtBSalida.Clear(); // borrar
            txtBSalida.Text = "Numeros del 99 al 1 impares\r\n";

            for (c = 99; c >= fin; c -= 2)
            {
                txtBSalida.Text += c.ToString() + "\r\n";
                suma += c;

            }
            lblResultado.Text = "Suma: " + suma.ToString();

        }


        private void button6_Click(object sender, EventArgs e)
        {
            // 5 al 95 con for incrementos de 5
            int c, ini = 5, fin = 95, suma = 0;
            c = ini;

            txtBSalida.Clear(); // borrar
            txtBSalida.Text = "Numeros del 5 al 95 incrementos de 5\r\n";

            for (c = 5; c <= fin; c += 5)
            {
                txtBSalida.Text += c.ToString() + "\r\n";
                suma += c;

            }
            lblResultado.Text = "Suma: " + suma.ToString();

        }

        private void button7_Click(object sender, EventArgs e)
        {
            // 40 al 272  con for incrementos de 4
            int c, ini = 40, fin = 272, suma = 0;
            c = ini;

            txtBSalida.Clear(); // borrar
            txtBSalida.Text = "Numeros del 40 al 272 incrementos de 4\r\n";

            for (c = 40; c <= fin; c += 4)
            {
                txtBSalida.Text += c.ToString() + "\r\n";
                suma += c;

            }
            lblResultado.Text = "Suma: " + suma.ToString();

        }

        private void button8_Click(object sender, EventArgs e)
        {
            this.Close();
        }

       
    }
}
