using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LanzarDados
{
    public partial class Form1 : Form
    {
        Random numeroAleatorio = new Random();
        //  Crea  unobjeto aleatorio
        int [] frecuencia = new int[7];


        public Form1()
        {
            InitializeComponent();
            txtDespliega.Hide();
        }

        private void btnLanzar_Click(object sender, EventArgs e)
        {
            // pasa las etiquetas a un  metodo  que
            // aleatoriamente asigna la cara al dado 
            DespliegaDado(lblDado1);
            DespliegaDado(lblDado2);
            DespliegaDado(lblDado3);
            DespliegaDado(lblDado4);
            DespliegaDado(lblDado5);
            DespliegaDado(lblDado6);
            DespliegaDado(lblDado7);
            DespliegaDado(lblDado8);
            DespliegaDado(lblDado9);
            DespliegaDado(lblDado10);
            DespliegaDado(lblDado11);
            DespliegaDado(lblDado12);
            txtDespliega.Show();
            double  total = 0 ;
            for( int i = 1; i < 7; i++)
                total += frecuencia[i];
                txtDespliega.Text = "Cara\t\t\tFrecuencia\t\t\tProcentaje\r\n";

            // imprime los valores de las frecuencias
            for( int  x = 1; x < frecuencia.Length ; x++)
            {
                txtDespliega.Text += x + "\t\t\t" + 
                frecuencia[x] + "\t\t\t\t" + String.Format("{0:N}",
                frecuencia[x] / total * 100) + "%\r\n";
            }
        }

        private void DespliegaDado(Label lblDado)
        {
            int cara = numeroAleatorio.Next(1, 7);
            lblDado.Image  = Image.FromFile(
                Directory.GetCurrentDirectory() +
            "\\imagenes\\dado"  + cara +  ".jpg "
            );
            frecuencia[cara]++;
        }
    }
}
