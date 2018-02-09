using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pro4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        string nombre;
        int horas;
        float imp, paga, pb, pn;
        string salida;

        private void buttonsalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Calcular_Click(object sender, EventArgs e)
        {
            nombre = textBoxnombre.Text.ToString();
            horas = int.Parse(textHorasT.Text);
            paga = float.Parse(textBoxPagoxHr.Text);
            imp = float.Parse(textBoxImpuesto.Text);

            pb = horas * paga;
            imp = pb * imp;
            pn = pb - imp;

            /* 1er opcion

            salida = string.Format("El trabajador {0} obtuvo \n\n", textBoxnombre.Text);
            salida = string.Format("El pago bruto es = {0}\n",pb);
            salida = string.Format("El pago por impuesto es = {0}\n", imp);
            salida = string.Format("El pago neto es = {0}\n", pn);
            labelRes.Text = salida;
            */ 

            //2da opcion
            labelRes.Text = "El Trabajador " + nombre.ToString() + " trabajó " + horas.ToString() + "hrs" +
            " con una paga de " + paga.ToString() + "xHr" + " y una tasa de " + imp.ToString() + "%" +
            " Impuesto = " + imp.ToString() + " Paga bruta = " + pb.ToString() + " Paga neta = " + pn.ToString();
            

        }
    }
}
