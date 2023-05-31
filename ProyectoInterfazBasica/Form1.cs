using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoInterfazBasica
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSumar_Click(object sender, EventArgs e)
        {
            int valor1, valor2, suma;

            valor1 = Convert.ToInt32(textValor1.Text);
            valor2 = Convert.ToInt32(textValor2.Text);

            suma = valor1 + valor2;

            textResultado.Text = ""; //Inicializacion
            textResultado.Text = textResultado.Text + suma;
        }

        private void btnDivision_Click(object sender, EventArgs e)
        {
            float valor1, valor2, division;

            valor1 = Convert.ToInt32(textValor1.Text);
            valor2 = Convert.ToInt32(textValor2.Text);

            division = valor1 / valor2;

            textResultado.Text = ""; //Inicializacion
            textResultado.Text = textResultado.Text + division;
        }

        private void btnSacarMayor_Click(object sender, EventArgs e)
        {
            float valor1, valor2, mayor;

            valor1 = Convert.ToInt32(textValor1.Text);
            valor2 = Convert.ToInt32(textValor2.Text);

            if (valor1 > valor2)
            {
                mayor = valor1;
                textResultado.Text = ""; //Inicializacion
                textResultado.Text = textResultado.Text + mayor;
            }
            else if (valor1 < valor2) 
            {
                mayor = valor2;
                textResultado.Text = ""; //Inicializacion
                textResultado.Text = textResultado.Text + mayor;
            }
            else 
            {
                string msj = "No hay Numero Mayor ";
                textResultado.Text = ""; //Inicializacion
                textResultado.Text = textResultado.Text + msj;
            }
        }

        private void btnAsteriscos_Click(object sender, EventArgs e)
        {
            float valor1, cont;

            valor1 = Convert.ToInt32(textValor1.Text);
            cont = 1;

            textResultado.Text = ""; //Inicializacion

            while (cont <= valor1)
            {             
                textResultado.Text = textResultado.Text + "*";
                cont++; 
            }
        }

        private void btnContarVocales_Click(object sender, EventArgs e)
        {
            string cad = textCadena.Text;
            int cont = 0, suma = 0;

            textCadena.Text = "";

            while (cont < cad.Length)
            {
                if(cad[cont] == 'a')
                {
                    suma = suma + 1;
                }
                if (cad[cont] == 'e')
                {
                    suma = suma + 1;
                }
                if (cad[cont] == 'i')
                {
                    suma = suma + 1;
                }
                if (cad[cont] == 'o')
                { 
                    suma = suma + 1;
                }
                if (cad[cont] == 'u')
                {
                    suma = suma + 1;
                }
                cont++;
            }
            textResultado.Text = "La palabra tiene " + suma + " vocales";   
        }

        private void btnAsteriscos2_Click(object sender, EventArgs e)
        {
            int cont = 0;
            string cad = textCadena.Text;

            textCadena.Text = "";

            while (cont < cad.Length)
            {
                textResultado.Text = textResultado.Text + "*";
                cont++;
            }
        }
    }
}
