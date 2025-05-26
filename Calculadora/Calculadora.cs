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
    public partial class Fcalculadora : Form
    {
        public Fcalculadora()
        {
            InitializeComponent();
            //bDivideX.Text = "\u215F";
        }

        double Numero1 = 0, Numero2 = 0;
        char Operador;
        private void agregar_numero(object sender, EventArgs e)
        {
            var boton = ((Button)sender);

            if (tBpantalla.Text == "0")
            {
                tBpantalla.Text = "";
            }
            
            tBpantalla.Text += boton.Text;
            
        }

        private void bIgual_Click(object sender, EventArgs e)
        {
            Numero2 = Convert.ToDouble(tBpantalla.Text);

            switch (Operador)
            {
                case '+':
                    tBpantalla.Text = (Numero1 + Numero2).ToString();
                    Numero1 = Convert.ToDouble(tBpantalla.Text);
                    break;
                case '-':
                    tBpantalla.Text = (Numero1 - Numero2).ToString();
                    Numero1 = Convert.ToDouble(tBpantalla.Text);
                    break;
                case '*':
                    tBpantalla.Text = (Numero1 * Numero2).ToString();
                    Numero1 = Convert.ToDouble(tBpantalla.Text);
                    break;
                case '/':
                    tBpantalla.Text = (Numero1 / Numero2).ToString();
                    Numero1 = Convert.ToDouble(tBpantalla.Text);
                    break;
                case '%':
                    tBpantalla.Text = ((Numero1/100) * Numero2).ToString();
                    Numero1 = Convert.ToDouble(tBpantalla.Text);
                    break;
                default:
                    break;
            }
        }

        private void bRetro_Click(object sender, EventArgs e)
        {
            if (tBpantalla.Text.Length > 1)
            {
                tBpantalla.Text = tBpantalla.Text.Substring(0, tBpantalla.Text.Length - 1);
            }
            else 
            {
                tBpantalla.Text = "0";
            }
        }

        private void bBorrarTodo_Click(object sender, EventArgs e)
        {
            Numero1 = 0;
            Numero2 = 0;
            Operador = '\0';
            tBpantalla.Text = "0";
        }

        private void bPunto_Click(object sender, EventArgs e)
        {
            if(!tBpantalla.Text.Contains("."))
            {
                tBpantalla.Text += ".";
            }
        }

        private void bSigno_Click(object sender, EventArgs e)
        {
            Numero1 = Convert.ToDouble(tBpantalla.Text);
            Numero1 *= -1;
            tBpantalla.Text =Numero1.ToString();
        }

        private void Click_Operador(object sender, EventArgs e)
        {
            var boton = ((Button)sender);

            Numero1 = Convert.ToDouble(tBpantalla.Text);
            Operador = Convert.ToChar(boton.Text);
            tBpantalla.Text = "0";
        }

        private void bRaizC_Click(object sender, EventArgs e)
        {
            var boton= ((Button)sender);
            Numero1 = Convert.ToDouble(tBpantalla.Text);
            Operador= Convert.ToChar(boton.Tag);
            Numero1 = Math.Sqrt(Numero1);
            tBpantalla.Text = Numero1.ToString();
        }

        private void bCuadrado_Click(object sender, EventArgs e)
        {
            var boton = ((Button)sender);
            Numero1 = Convert.ToDouble(tBpantalla.Text);
            Operador = Convert.ToChar(boton.Tag);
            Numero1 = Math.Pow(Numero1,2);
            tBpantalla.Text = Numero1.ToString();
        }

        private void bBorrar_Click(object sender, EventArgs e)
        {
            tBpantalla.Text ="0";
        }

        private void bDivideX_Click(object sender, EventArgs e)
        {
            var boton = ((Button)sender);
            Numero1 = Convert.ToDouble(tBpantalla.Text);
            Operador = Convert.ToChar(boton.Tag);
            Numero1 = 1/Numero1;
            tBpantalla.Text = Numero1.ToString();
        }

        private void Click_OperadorEspecial(object sender, EventArgs e)
        {
            var boton = ((Button)sender);

            Numero1 = Convert.ToDouble(tBpantalla.Text);
            Operador = Convert.ToChar(boton.Tag);
            tBpantalla.Text = "0";
        }
    }
}
