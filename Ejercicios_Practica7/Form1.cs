using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicios_Practica7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void suma_Click(object sender, EventArgs e)
        {
            label3.Text = "la suma es->" + sumar(Convert.ToDouble(textBox1.Text), Convert.ToDouble(textBox2.Text)).ToString();
        }
        private double sumar(double numero1, double numero2)
        {
            double suma = numero1 + numero2;
            return suma;
        }

        private void resta_Click(object sender, EventArgs e)
        {
            label3.Text = "la resta es->" + resta(Convert.ToDouble(textBox1.Text), Convert.ToDouble(textBox2.Text)).ToString();
        }
        private double resta(double numero1, double numero2)
        {
            double resta = numero1 + numero2;
            return resta;
        }

        private void multiplicar_Click(object sender, EventArgs e)
        {
            label3.Text = "la multiplicacion es->" + multiplicar(Convert.ToDouble(textBox1.Text), Convert.ToDouble(textBox2.Text)).ToString();
        }
        private double multiplicar(double numero1, double numero2)
        {
            double multiplicar = numero1 * numero2;
            return multiplicar;
        }

        private void dividir_Click(object sender, EventArgs e)
        {
            label3.Text = "la division es->" + dividir(Convert.ToDouble(textBox1.Text), Convert.ToDouble(textBox2.Text)).ToString();
        }
        private double dividir(double numero1, double numero2)
        {
            double dividir = numero1 / numero2;
            return dividir;
        }
        private void limpiar_Click(object sender, EventArgs e)
        {

        }
        private void limpiar()
        {
            textBox1.Clear();
            textBox2.Clear();
        }
    }
}
