using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tarea02_programa02
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCocinar_Click(object sender, EventArgs e)
        {
            string imprimir;
            if (rbPeq.Checked)
            {
                imprimir = "Pizza Pequeña\r\n";
            } else if (rbMed.Checked)
            {
                imprimir = "Pizza Mediana\r\n";
            } else
                imprimir = "Pizza Grande\r\n";

            if (rbAqui.Checked)
            {
                imprimir += "Para comer aquí\r\n";
            } else
                imprimir += "Para llevar\r\n";

            if (rbCubiertaD.Checked)
            {
                imprimir += "De cubierta delgada\r\n";
            }else
                imprimir += "De cubierta gruesa\r\n";

            if (cbExtrQ.Checked | cbCham.Checked | cbClavo.Checked | cbCebolla.Checked | cbComino.Checked | cbTomate.Checked) {
                imprimir += "Con los siguientes ingredientes:\r\n";

                if (cbCham.Checked)
                {
                    imprimir += "Extra Queso\r\n";
                }

                if (cbExtrQ.Checked)
                {
                    imprimir += "Champiñones\r\n";
                }

                if (cbClavo.Checked)
                {
                    imprimir += "Clavos\r\n";
                }

                if (cbCebolla.Checked)
                {
                    imprimir += "Cebolla\r\n";
                }

                if (cbComino.Checked)
                {
                    imprimir += "Cominos\r\n";
                }

                if (cbTomate.Checked)
                {
                    imprimir += "Tomates\r\n";
                }
                
            }
            MessageBox.Show(imprimir, "Tu pizza", MessageBoxButtons.OK);

        }
    }
}
