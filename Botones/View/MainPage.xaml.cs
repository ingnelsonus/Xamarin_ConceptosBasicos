using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Botones.View
{
    public partial class MainPage : ContentPage
    {

        double N1,N2,Resultado;


        public MainPage()
        {
            InitializeComponent();
        }

        private void btnHola_Clicked(object sender, EventArgs e)
        {
            DisplayAlert("Esto es una prueba", "Hola", "OK");
        }

        private void btnCasa_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new PrimerPagina());
        }

        private void btnCalcular_Clicked(object sender, EventArgs e)
        {
            Calcular();
        }

        private void Calcular()
        {
            if (!string.IsNullOrEmpty(txtNumero1.Text) && !string.IsNullOrEmpty(txtNumero2.Text))
            {
                N1 = Convert.ToDouble(txtNumero1.Text);
                N2 = Convert.ToDouble(txtNumero2.Text);
                Resultado = N1 * N2;
                DisplayAlert("Resultado", Resultado.ToString(), "OK");
            }
            else
                DisplayAlert("Error", "Ingrese el numero 1, numero 2", "Aceptar");


           
        }

    }
}
