using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tarea02_programa03
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnIniciar_Click(object sender, EventArgs e)
        {
            int contador = 0 ;
            txtResIncr.Text = txtInicial.Text;
            txtResDec.Text = txtInicial.Text;
            txtCont.Text = contador.ToString();
        }

        private void btnIncr_Click(object sender, EventArgs e)
        {
            int valorInicialInc, valorInicialDec, valorInc, contador;

            contador = int.Parse(txtCont.Text);
            valorInicialInc = int.Parse(txtResIncr.Text);
            valorInicialDec = int.Parse(txtResDec.Text);
            valorInc = int.Parse(txtIncr.Text);

            txtResIncr.Text = (valorInicialInc + valorInc).ToString();
            txtResDec.Text = (valorInicialDec - valorInc).ToString();
            txtCont.Text = (contador+1).ToString();
        }

        private void btnInterc_Click(object sender, EventArgs e)
        {
            int ResD, ResI;
            ResD = int.Parse(txtResDec.Text);
            ResI = int.Parse(txtResIncr.Text);

            txtResDec.Text = ResI.ToString();
            txtResIncr.Text = ResD.ToString();
        }
    }
}
