using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CALCULADORA
{
    public partial class Form1 : Form
    {
        double primero;
        double segundo;
        double resultado;
        string operacion; 
        public Form1()
        {
            InitializeComponent();
        }

        private void b1_Click(object sender, EventArgs e)
        {
            Pantalla.Text = Pantalla.Text + "1";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Pantalla.Text = Pantalla.Text + "0";
        }

        private void bpunto_Click(object sender, EventArgs e)
        {
            Pantalla.Text = Pantalla.Text + ".";
        }

        private void b2_Click(object sender, EventArgs e)
        {
            Pantalla.Text = Pantalla.Text + "2";
        }

        private void b3_Click(object sender, EventArgs e)
        {
            Pantalla.Text = Pantalla.Text + "3";
        }

        private void b4_Click(object sender, EventArgs e)
        {
            Pantalla.Text = Pantalla.Text + "4";
        }

        private void b5_Click(object sender, EventArgs e)
        {
            Pantalla.Text = Pantalla.Text + "5";
        }

        private void b6_Click(object sender, EventArgs e)
        {
            Pantalla.Text = Pantalla.Text + "6";
        }

        private void b7_Click(object sender, EventArgs e)
        {
            Pantalla.Text = Pantalla.Text + "7";
        }

        private void b8_Click(object sender, EventArgs e)
        {
            Pantalla.Text = Pantalla.Text + "8";
        }

        private void b9_Click(object sender, EventArgs e)
        {
            Pantalla.Text = Pantalla.Text + "9";
        }

        private void bsuma_Click(object sender, EventArgs e)
        {
            operacion = "+";
            primero = double.Parse(Pantalla.Text);
            Pantalla.Clear();
        }

        private void bresta_Click(object sender, EventArgs e)
        {
            operacion = "-";
            primero = double.Parse(Pantalla.Text);
            Pantalla.Clear();
        }

        private void bmultiplicacion_Click(object sender, EventArgs e)
        {
            operacion = "*";
            primero = double.Parse(Pantalla.Text);
            Pantalla.Clear();
        }

        private void bdivision_Click(object sender, EventArgs e)
        {
            operacion = "/";
            primero = double.Parse(Pantalla.Text);
            Pantalla.Clear();
        }

        private void bigual_Click(object sender, EventArgs e)
        {
            segundo = double.Parse(Pantalla.Text);
            switch (operacion) {
                case "+":
                    resultado = primero + segundo;
                    Pantalla.Text = resultado.ToString();
                    break;
                case "-":
                    resultado = primero - segundo;
                    Pantalla.Text = resultado.ToString();
                    break;
                case "*":
                    resultado = primero * segundo;
                    Pantalla.Text = resultado.ToString();
                    break;
                case "/":
                    resultado = primero / segundo;
                    Pantalla.Text = resultado.ToString();
                    break;
            }
        }

        private void limpiar_Click(object sender, EventArgs e)
        {
            Pantalla.Clear();

        }

        private void braiz_Click(object sender, EventArgs e)
        {
            operacion = "raiz";
            primero = double.Parse(Pantalla.Text);
            resultado = primero;
            Pantalla.Text = Math.Sqrt(primero).ToString();
        }
    }
}
