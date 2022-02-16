using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculadoraCSharpe
{
    public partial class Form1 : Form
    {
        decimal valor1 = 0, valor2 = 0;
        string Operacao ="";

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button20_Click(object sender, EventArgs e)
        {
            txtResultado.Text +=  "0";
        }

        private void button15_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "1";
        }

        private void button14_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "2";
        }

        private void button13_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "3";
        }

        private void button10_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "4";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "5";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "6";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "7";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "8";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "9";
        }

        private void button19_Click(object sender, EventArgs e)
        {
            txtResultado.Text += ".";
        }

        private void button11_Click(object sender, EventArgs e)
        {
            valor2 = decimal.Parse(txtResultado.Text, CultureInfo.InvariantCulture);

            if (Operacao == "Soma")
            {
                txtResultado.Text = Convert.ToString(valor1 + valor2);
            }
            else if(Operacao == "Sub")
            {
                txtResultado.Text = Convert.ToString(valor1 - valor2);
            }
            else if (Operacao == "Mult")
            {
                txtResultado.Text = Convert.ToString(valor1 * valor2);
            }
            else if (Operacao == "Div")
            {
                txtResultado.Text = Convert.ToString(valor1 / valor2);
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if(txtResultado.Text != "")
            {
                valor1 = decimal.Parse(txtResultado.Text, CultureInfo.InvariantCulture);

                txtResultado.Text = "";
                Operacao = "Sub";
                lblOpercao.Text = "-";
            }
            else
            {
                MessageBox.Show("Informe um nunmero");
            }
          

        }

        private void button12_Click(object sender, EventArgs e)
        {
            if(txtResultado.Text != "")
            {
                valor1 = decimal.Parse(txtResultado.Text, CultureInfo.InvariantCulture);

                txtResultado.Text = "";
                Operacao = "Mult";
                lblOpercao.Text = "*";
            }
            else
            {
                MessageBox.Show("Iforme um numero");
            }
            
        }

        private void button17_Click(object sender, EventArgs e)
        {
            if(txtResultado.Text != "")
            {
                valor1 = decimal.Parse(txtResultado.Text, CultureInfo.InvariantCulture);

                txtResultado.Text = "";
                Operacao = "Div";
                lblOpercao.Text = "/";
            }
            else
            {
                MessageBox.Show("Informe um numero");
            }
          
        }

        private void button5_Click(object sender, EventArgs e)
        {
            txtResultado.Text = "";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            txtResultado.Text = "";
            valor1 = 0;
            valor2 = 0;
            lblOpercao.Text = ""; 
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if(txtResultado.Text != "") 
            {
                valor1 = decimal.Parse(txtResultado.Text, CultureInfo.InvariantCulture);

                txtResultado.Text = "";
                Operacao = "Soma";
                lblOpercao.Text = "+";
            }
            else
            {
                MessageBox.Show("Informe um numero");
            }
           
        }
    }
}
