using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppLista03_Logica
{
    public partial class frmExercicio01 : Form
    {
        public frmExercicio01()
        {
            InitializeComponent();
        }

        private void btnsoma_Click(object sender, EventArgs e)
        {
            float num1 = float.Parse(txtnum1.Text);
            float num2 = float.Parse(txtnum2.Text);
            float num3 = float.Parse(txtnum3.Text);
            float soma;

            soma = num1 + num2 + num3;

            MessageBox.Show("soma = " + soma);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnmedia_Click(object sender, EventArgs e)
        {
            float num1 = float.Parse(txtnum1.Text);
            float num2 = float.Parse(txtnum2.Text);
            float num3 = float.Parse(txtnum3.Text);
            float media;

            media = (num1 + num2 + num3)/3;

            MessageBox.Show("média = " + media);
        }

        private void btnporcent_Click(object sender, EventArgs e)
        {

        }
    }
}
