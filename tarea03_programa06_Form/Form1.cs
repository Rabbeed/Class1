using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tarea03_programa06_Form
{
    public partial class Form1 : Form
    {
        // arreglos dinamicos
        List<int> A = new List<int>();
        List<int> B = new List<int>();
        List<int> C = new List<int>();
      

        public Form1()
        {
            InitializeComponent();
        }

        private void comboBox1_KeyPress(object sender, KeyPressEventArgs e)
        { 
            // si presiona Enter, agregar el valor a la lista y luego al arreglo A
            if(e.KeyChar == 13)
            {
                cboA.Items.Add(cboA.Text);
                A.Add(int.Parse(cboA.Text));
            }

        }

        private void cboB_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                cboB.Items.Add(cboB.Text);
                B.Add(int.Parse(cboB.Text));
            }
        }

        private void btnMult_Click(object sender, EventArgs e)
        {
            int temp = A.Count;

            for (int i = 0, j = temp - 1; i < temp; i++, j--)
            {
                C.Add(A[i] * B[j]);
            }

            for (int k = 0; k < temp; k++)
            {
                txtC.Text += C[k] + "\r\n";
            }
    
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
