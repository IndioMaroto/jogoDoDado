using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

//Claudio de Jesus Junior - 555835
//BSI

namespace JogoDado
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            label3.Text = "0";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            button2.Enabled = false;
            button1.Enabled = true;
        }

        private void LimparVariaveis()
        {
            valor1 = 0;
            ptjogador1 = 0;
            ptjogador2 = 0;
            label3.Text = "0";
            label4.Text = " ";
            label5.Text = " ";
        }

        int valor1 = 0;
        int ptjogador1 = 0;
        int ptjogador2 = 0;

        private void button1_Click(object sender, EventArgs e)
        {
            Random dado1 = new Random();
            valor1 = dado1.Next(1, 7);
            label3.Text = Convert.ToString(valor1);
            InverteBotoes();
        }

        private void InverteBotoes()
        {
            button1.Enabled = !button1.Enabled;
            button2.Enabled = !button2.Enabled;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Random dado2 = new Random();
            int valor2 = dado2.Next(1, 7);
            label3.Text = Convert.ToString(valor2);

            if (valor1 > valor2)
            {
                ptjogador1++;
            }
            else if (valor1 < valor2)
            {
                ptjogador2++;
            }

            InverteBotoes();

            label4.Text = Convert.ToString(ptjogador1);
            label5.Text = Convert.ToString(ptjogador2);

            if(ptjogador1 == 2)
            {
                MessageBox.Show("Jogador 1 venceu!");
                LimparVariaveis();
            }
            else if(ptjogador2 == 2)
            {
                MessageBox.Show("Jogador 2 venceu!");
                LimparVariaveis();
            }

        }
    }
}
