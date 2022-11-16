using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Calculadora221115
{
    public partial class MainPage : ContentPage
    {
        private double Numero1;
        private double Numero2;
        private string Operador;
        
        public MainPage()
        {
            InitializeComponent();
        }

        private void clicNumero(object sender, EventArgs e)
        {
            Button tmp = (Button)sender;
            if (txtResultado.Text == "0")
            {
                txtResultado.Text = tmp.Text;
            }
            else {
                txtResultado.Text += tmp.Text;
            }
            
        }

        private void clicSuma(object sender, EventArgs e)
        {
            Operador = "+";
            Numero1 = Double.Parse(txtResultado.Text);
            txtResultado.Text = "0";
        }

        private void clicIgual(object sender, EventArgs e)
        {

            Numero2 = Double.Parse(txtResultado.Text);

            double operacionFinal = 0;

            if (Operador == "+") {
                operacionFinal = Numero1 + Numero2;

            }


            txtResultado.Text = operacionFinal.ToString();

        }
    }
}
