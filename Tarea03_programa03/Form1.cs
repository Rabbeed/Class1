using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tarea03_programa03
{
    public partial class Form1 : Form
    {
        int[] arregloO = new int[20];
        double[] arregloR = new double[20];

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            txtO.Text += "[";
            Random r = new Random();
            for (int i = 0; i < arregloO.Length; i++)
            {
                arregloO[i] = r.Next(0, 100);
                txtO.Text += arregloO[i] + " ";
            }
            txtO.Text += "]";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtR.Text += "[";
            for (int i = 0; i < arregloR.Length; i++)
            {
                //  arregloR[i] = Math.Pow(3, Double.Parse(arregloO[i].ToString()));
                arregloR[i] = arregloO[i] * arregloO[i] * arregloO[i];
                txtR.Text += arregloR[i] + " ";
            }
            txtR.Text += "]";
        }

    }
}
