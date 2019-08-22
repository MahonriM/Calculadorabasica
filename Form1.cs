using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        double valor1;
        double valor2;
        string operador;

        private void btn1_Click(object sender, EventArgs e)
        {
            if (txtpantalla.Text == "")
            {
                txtpantalla.Text = "1";
            }
            else
            {
                txtpantalla.Text = txtpantalla.Text + "1";
            }

        }

        private void btn2_Click(object sender, EventArgs e)
        {
            if (txtpantalla.Text == "")
            {
                txtpantalla.Text = "2";
            }
            else
            {
                txtpantalla.Text = txtpantalla.Text + "2";

            }
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            if (txtpantalla.Text == "")
            {
                txtpantalla.Text = "3";
            }
            else
            {
                txtpantalla.Text = txtpantalla.Text + "3";
            }
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            if (txtpantalla.Text == "")
            {
                txtpantalla.Text = "4";
            }
            else
            {
                txtpantalla.Text = txtpantalla.Text + "4";
            }
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            if (txtpantalla.Text == "")
            {
                txtpantalla.Text = "5";
            }
            else
            {
                txtpantalla.Text = txtpantalla.Text + "5";
            }
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            if (txtpantalla.Text == "")
            {
                txtpantalla.Text = "6";
            }
            else
                txtpantalla.Text = txtpantalla.Text + "6";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (txtpantalla.Text == "")
            {
                txtpantalla.Text = "7";
            }
            else
                txtpantalla.Text = txtpantalla.Text + "7";
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            if (txtpantalla.Text == "")
            {
                txtpantalla.Text = "8";
            }
            else
                txtpantalla.Text = txtpantalla.Text + "8";
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            if (txtpantalla.Text == "")
            {
                txtpantalla.Text = "9";
            }
            else
                txtpantalla.Text = txtpantalla.Text + "9";
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            if (txtpantalla.Text == "")
            {
                txtpantalla.Text = "0";
            }
            else
                txtpantalla.Text = txtpantalla.Text + "0";
        }

        private void btndivision_Click(object sender, EventArgs e)
        {
            valor1 = Convert.ToDouble(this.txtpantalla.Text);
            operador = "/";
            this.txtpantalla.Clear();
            this.txtpantalla.Focus();

        }

        private void btnX_Click(object sender, EventArgs e)
        {
            valor1 = Convert.ToDouble(this.txtpantalla.Text);
            operador = "X";
            this.txtpantalla.Clear();
            this.txtpantalla.Focus();
        }

        private void btnresta_Click(object sender, EventArgs e)
        {
            valor1 = Convert.ToDouble(this.txtpantalla.Text);
            operador = "-";
            this.txtpantalla.Clear();
            this.txtpantalla.Focus();
        }

        private void btnsuma_Click(object sender, EventArgs e)
        {
            valor1 = Convert.ToDouble(this.txtpantalla.Text);
            operador = "X";
            this.txtpantalla.Clear();
            this.txtpantalla.Focus();
        }

        private void btnpunto_Click(object sender, EventArgs e)
        {
            if (this.txtpantalla.Text.Contains('.') == false)
            {
                this.txtpantalla.Text = this.txtpantalla.Text + ".";
            }

        }
        private void btnigual_Click(object sender, EventArgs e)
        {
            valor2 = Convert.ToDouble(this.txtpantalla.Text);
            switch (operador)
            {
                case "+":
                    this.txtpantalla.Text = Convert.ToString(valor1 + valor2);
                    break;

                case "-":
                    this.txtpantalla.Text = Convert.ToString(valor1 - valor2);
                    break;

                case "X":
                    this.txtpantalla.Text = Convert.ToString(valor1 * valor2);
                    break;

                case "/":
                    this.txtpantalla.Text = Convert.ToString(valor1 / valor2);
                    break;

            }

        }

        private void btnC_Click(object sender, EventArgs e)
        {
             valor1 = 0;
             valor2 = 0;
             this.txtpantalla.Text = "";
        }
    }
    } 