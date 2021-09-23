using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ex319___Calculadora
{
    public partial class CALCULADORA : Form
    {
        int valor1 = 0;
        int valor2 = 0;
        char operador;
        int resultado;
        
        public CALCULADORA()
        {
            InitializeComponent();
            resultado = 0;
        }

        private void button1_Click(object sender, EventArgs e)
        { //agregar numero
            resultado = resultado * 10 + Convert.ToInt32(((Button)sender).Text);
            textBox1.Text = resultado.ToString();

        }

        private void button11_Click(object sender, EventArgs e)
        {   //borrar
            resultado = 0;
            textBox1.Text = " ";
        }

        private void button16_Click(object sender, EventArgs e)
        {
            //resultado
            valor2 = resultado;

            if (operador == '+')
            {
                resultado = valor1 + valor2;
                textBox1.Text = resultado.ToString();
              
            }
            else if (operador == '-')
            {
                resultado = valor1 - valor2;
                textBox1.Text = resultado.ToString();

            }
            else if (operador == 'x')
            {
                resultado = valor1 *  valor2;
                textBox1.Text = resultado.ToString();
            }
            else if (operador == '/')
            {
                if (valor2 != 0 )
                {
                    resultado = valor1 / valor2;
                    textBox1.Text = resultado.ToString();
                }
                else
                {
                    MessageBox.Show("No se puede dividir por cero!!");
                }
            }
        }

        private void button12_Click(object sender, EventArgs e)
        {
            //Operador
            valor1 = resultado;
            resultado = 0;
            textBox1.Text = "";
            operador = Convert.ToChar(((Button)sender).Text);
            
        }
    }

    
}
