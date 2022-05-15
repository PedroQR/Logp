using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppCalculadora
{
    public partial class calculadora : Form
    {
        public calculadora()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txtnum1_TextChanged(object sender, EventArgs e)
        {
            int var1 = int.Parse(txtnum1.Text);
            float resultado;
        }

        private void txtnum2_TextChanged(object sender, EventArgs e)
        {
            int var2 = int.Parse(txtnum1.Text);
            float resultado;
        }

        private void btnsoma_Click(object sender, EventArgs e)
        {
            int var1 = int.Parse(txtnum1.Text);
            int var2 = int.Parse(txtnum2.Text);
            float resultado;

            resultado = var1 + var2;
            MessageBox.Show("soma: " + resultado);
        }

        private void btnsub_Click(object sender, EventArgs e)
        {
            int var1 = int.Parse(txtnum1.Text);
            int var2 = int.Parse(txtnum2.Text);
            float resultado;

            resultado = var1 - var2;
            MessageBox.Show("subtração: " + resultado);
        }

        private void btnmult_Click(object sender, EventArgs e)
        {
            int var1 = int.Parse(txtnum1.Text);
            int var2 = int.Parse(txtnum2.Text);
            float resultado;

            resultado = var1 * var2;
            MessageBox.Show("multiplicação: " + resultado);
        }

        private void btndiv_Click(object sender, EventArgs e)
        {
            int var1 = int.Parse(txtnum1.Text);
            int var2 = int.Parse(txtnum2.Text);
            float resultado;

            resultado = var1 / var2;
            MessageBox.Show("divisão: " + resultado);
        }
    }
}
