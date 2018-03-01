using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Primer_Examen_Parcial
{
    public partial class Form1 : Form
    {

        List<int> A = new List<int>();
        int cont = 0;
     

        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void comboBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
               {
                int val = int.Parse(cboA.Text);
                    if (val <= 100)
                    {
                        if (cont != 50)
                        {
                        cboA.Items.Add(cboA.Text);
                        A.Add(int.Parse(cboA.Text));
                        cont++;
                        }
                         else {
                            cboA.Enabled = false;
                            MessageBox.Show("Haz alcanzado el tamaño max. 50");
                         }
                    }
                    else
                    {
                    MessageBox.Show("Edad incorrecta");

                    }
                    
                }
        
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            double media = 0, var = 0;
            imprimirMatriz();
            cantidad();
            elementoMayor();
            elementoMenor();
            media = promedio();
            txtRes.Text += "La media: " + media + "\r\n";
            var = varianza(media);
            txtRes.Text += "La varianza: " + var + "\r\n";
            desviacionE(var);
        }


        private void imprimirMatriz()
        {
            if (A.Count != 0)
            {
                int tam = A.Count;
                txtDatos.Text += "\r\n\n";
                for (int i = 0, j = 0; i < tam; i++, j++)
                {
                    if (j == 5)
                    {
                        i--;
                        txtDatos.Text += "\r\n";
                        j = -1;

                    }
                    else txtDatos.Text += "         " + A[i];
                }
                btnCalcular.Enabled = false;
                cboA.Enabled = false;
            }
            else
            {
                btnCalcular.Enabled = true;
                MessageBox.Show("Aun no se introduce ningun dato!");
            }
        }

        private void cantidad()
        {
            int tam = A.Count;
            if(tam != 0)
            {
                txtRes.Text += "Total de elementos: " + tam.ToString() + "\r\n";
            }
            
        }

        private void elementoMayor()
        {
            int tam = A.Count;
            if (tam != 0)
            {
                int mayor = 0;

                for (int i = 0; i < tam; i++)
                {
                    if (A[i] >= mayor)
                    {
                        mayor = A[i];
                    }
                }
                txtRes.Text += "Elemento mayor: " + mayor + "\r\n";
            }
        }


        private void elementoMenor()
        {
            int tam = A.Count;
            if (tam != 0)
            {
                int menor = A[0];

                for (int i = 0; i < tam; i++)
                {
                    if (A[i] < menor)
                    {
                        menor = A[i];
                    }
                }
                txtRes.Text += "Elemento menor: " + menor + "\r\n";
            }
        }

        private float promedio()
        {
            int tam = A.Count;
            float total = 0;
            if (tam != 0)
            {
 
                for (int i = 0; i < tam; i++)
                {
                    total += A[i];
                }
               
            }
            return total / tam;
        }

        private double varianza(double media)
        {
            int tam = A.Count;
            double varianza = 0, total = 0;
            if (tam != 0)
            {
                for(int i = 0; i < tam; i++)
                {
                    varianza += Math.Pow((Convert.ToDouble(A[i]) - Convert.ToDouble(media)), 2);

                }
                total = varianza / (tam);
              
                
            }
            return total;
        }

        private void desviacionE(double varianza)
        {
            int tam = A.Count;
            if (tam != 0)
            {
                double varianzaT = Math.Sqrt(varianza);
                txtRes.Text += "La desviación estándar: " + varianzaT + "\r\n";
            }
        }
    }
}
