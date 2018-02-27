using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tarea03_programa01
{
    public partial class programa01 : Form
    {
        int[] arreglo  = {59,42,33,49,27,15,25,62,24,13,11,12,83,50,94,
                         73,15,88,57,49,20,40,70,3,32,51,11,63,15,28,
                         97,99,8,86,55,38,56,40,34,65,49,79,24,17,89,
                        39,40,45,49,6 };
        public programa01()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            txtVector.Text += "[";
            for (int i = 0; i < arreglo.Length; i++)
                txtVector.Text += arreglo[i].ToString() +", ";
            txtVector.Text += "]";
        }

        private void btnPromedio_Click(object sender, EventArgs e)
        {

            lblRes.Text = arreglo.Average().ToString();
        
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double promedio = arreglo.Average();
            txtPromedio.Text += "[";
            for (int i = 0; i < arreglo.Length; i++)
            {
                if (arreglo[i] > promedio)
                    txtPromedio.Text += arreglo[i] + ", "; 
            }
            txtPromedio.Text += "]";
        }
    }
}
