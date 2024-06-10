using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculadora
{
    public partial class Form1 : Form

    {
        private double num1;
        private double num2;

        private double resultado;

        private int operacion;

        public Form1()
        {
            InitializeComponent();
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            //numero 0
            txtDisplay.Text = txtDisplay.Text + "0";

        }

        private void btn1_Click(object sender, EventArgs e)
        {
            //numero1
            txtDisplay.Text = txtDisplay.Text + "1";



        }

        private void btn2_Click(object sender, EventArgs e)
        {
            //numero2
            txtDisplay.Text = txtDisplay.Text + "2";

        }

        private void btn3_Click(object sender, EventArgs e)
        {
            //numero 3
            txtDisplay.Text = txtDisplay.Text + "3";
                    
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            //numero4
            txtDisplay.Text = txtDisplay.Text + "4";

        }

        private void btn5_Click(object sender, EventArgs e)
        {
            //numero5
            txtDisplay.Text = txtDisplay.Text + "5";


        }

        private void btn6_Click(object sender, EventArgs e)
        {
            //numero6
            txtDisplay.Text = txtDisplay.Text + "6";

        }

        private void btn7_Click(object sender, EventArgs e)
        {
            //numero7
            txtDisplay.Text = txtDisplay.Text + "7";

        }

        private void btn8_Click(object sender, EventArgs e)
        {
            //numero8
            txtDisplay.Text = txtDisplay.Text + "8";

        }

        private void btn9_Click(object sender, EventArgs e)
        {
            //numero9
            txtDisplay.Text = txtDisplay.Text + "9";

        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            //Boton Limpiar
            txtDisplay.Text = "";
        }

        private void btnIgual_Click(object sender, EventArgs e)
        {
            //Boton igual
           
            num2 = Convert.ToDouble(txtDisplay.Text);

            resultado = num1 + num2;

            switch (operacion)
            {
                case 1:
                    resultado = num1 + num2;
                    break;

                    case 2:
                    resultado = num1 - num2;
                    break;

                case 3:
                    resultado = num1 * num2;
                    break;
                 
                case 4:
                    resultado = num1 / num2;
                    break;



            }

            txtDisplay.Text = resultado.ToString();
           

        }

        private void btnSumar_Click(object sender, EventArgs e)
        {
            operacion = 1;
            num1 = Convert.ToDouble(txtDisplay.Text);
            txtDisplay.Text = "";
        }

        private void btnRestar_Click(object sender, EventArgs e)
        {
            //boton resta
            operacion = 2;
            num1 = Convert.ToDouble(txtDisplay.Text);


            txtDisplay.Text = "";

        }

        private void btnMultiplicar_Click(object sender, EventArgs e)
        {
            //boton Multiplicar
            operacion = 3;
            num1 = Convert.ToDouble(txtDisplay.Text);
            txtDisplay.Text = "";


        }

        private void btnDividir_Click(object sender, EventArgs e)
        {
            operacion = 4;
            num1 = Convert.ToDouble(txtDisplay.Text);
            txtDisplay.Text = "";



        }

        private void btnPunto_Click(object sender, EventArgs e)
        {
            //boton punto
            txtDisplay.Text = txtDisplay.Text + ",";
        }
    }
}
