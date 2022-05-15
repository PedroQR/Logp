using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace idade_em_meses
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnidade_Click(object sender, EventArgs e)
        {
            int idade = int.Parse(txtNerd.Text);
            int meses;

            meses = idade * 12;

            lbldesigngráficopaixão.Text = ("idade em meses: " + meses);
        }
    }
}
