using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace solucao03_Cracha
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            formatarCracha.setNome(textBox1.Text);

            textBox2.Text = formatarCracha.getUltimoSobrenome() + ", " + formatarCracha.getIniciais();
        }
    }
}
