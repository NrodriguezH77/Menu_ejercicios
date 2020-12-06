using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calcjuladora
{
    public partial class Form1 : Form
    {


       Operaciones operacion = new Operaciones();

        public Form1()
        {
            InitializeComponent();
        }

        string cadena = "";
        double num1, num2, resulado;
        string operador;        
        
        





        private void btn1_Click(object sender, EventArgs e)
        {
            cadena += btn1.Text;
            txtconcatena.Text += btn1.Text; 

        }

        private void btn2_Click(object sender, EventArgs e)
        {
            cadena += btn2.Text;
            txtconcatena.Text += btn2.Text;

        }

        private void bnt3_Click(object sender, EventArgs e)
        {
            cadena += btn3.Text;
            txtconcatena.Text += btn3.Text;
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            cadena  += btn4.Text;
            txtconcatena.Text += btn4.Text;
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            cadena += btn5.Text;
            txtconcatena.Text += btn5.Text;
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            cadena += btn6.Text;
            txtconcatena.Text += btn6.Text;

        }

        private void btn7_Click(object sender, EventArgs e)
        {
            cadena += btn7.Text;
            txtconcatena.Text += btn7.Text;
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            cadena += btn8.Text;
            txtconcatena.Text += btn8.Text;
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            cadena += btn9.Text;
            txtconcatena.Text += btn9.Text;
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            cadena += btn0.Text;
            txtconcatena.Text += btn0.Text;
        }

        private void btnigual_Click(object sender, EventArgs e)
        {
            num2 = Convert.ToDouble(txtconcatena.Text);
            txtconcatena.Text = cadena;
            //label2.Text = cadena;
            

            switch (operador)
            {
                case " + ":
                    resulado = (operacion.suma(num1, num2));
                    txtresultado.Text = Convert.ToString(resulado);

                    break;

                case " - ":
                    resulado = (operacion.resta(num1, num2));
                    txtresultado.Text = Convert.ToString(resulado);

                    break;

                case " * ":
                    resulado = (operacion.multiplicacion(num1, num2));
                    txtresultado.Text = Convert.ToString(resulado);
                    break;

                case " / ":
                    resulado = (operacion.division(num1, num2));
                    if (num2 == 0)
                    {
                        txtresultado.Text = "No se puede dividir entre 0";
                        
                    }
                    else
                    {
                        txtresultado.Text = Convert.ToString(resulado);
                    }
                    break;

                case " % ":
                    resulado = (operacion.porcentaje(num1, num2));
                    txtresultado.Text = Convert.ToString(resulado);

                    break;

                case " ! ":
                    resulado = (operacion.factorial(num1));
                    txtresultado.Text = Convert.ToString(resulado);

                    break;
            }
        }

        private void punto_Click(object sender, EventArgs e)
        {
            cadena += btnpunto.Text;
            txtconcatena.Text += btnpunto.Text;
        }

        

        private void btnporcentaje_Click(object sender, EventArgs e)
        {
            cadena += btnporcentaje.Text;
            operador = " % ";
            

            
        }

        private void btnborrar_Click(object sender, EventArgs e)
        {
            cadena = "";
            txtconcatena.Clear();
            txtresultado.Clear();
        }

        private void btnfactorial_Click(object sender, EventArgs e)
        {
            cadena += btnfactorial.Text;
            operador = " ! ";
            num1 = Convert.ToDouble(txtconcatena.Text);

           

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cadena = "";
            txtconcatena.Clear();
            txtresultado.Clear();
        }

        private void btnsuma_Click(object sender, EventArgs e)
        {
            
            cadena += btnsuma.Text;
            operador = " + ";
            num1 = Convert.ToDouble(txtconcatena.Text);

            txtconcatena.Clear();

        }

        private void btnresta_Click(object sender, EventArgs e)
        {
            cadena += btnresta.Text;
            operador = " - ";
            num1 = Convert.ToDouble(txtconcatena.Text);

            txtconcatena.Clear();
        }

        private void btnmultiplicacion_Click(object sender, EventArgs e)
        {
            cadena += btnmultiplicacion.Text;
            operador = " * ";
            num1 = Convert.ToDouble(txtconcatena.Text);

            txtconcatena.Clear();
        }

        private void btndivision_Click(object sender, EventArgs e)
        {
            cadena +=btndivision.Text;
            operador = " / ";
            num1 = Convert.ToDouble(txtconcatena.Text);

            txtconcatena.Clear();
        }
    }
}
