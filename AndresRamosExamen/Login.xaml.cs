using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;


namespace AndresRamosExamen
{
    public partial class Login : ContentPage
    {
        public Login()
        {
            InitializeComponent();
        }

        private async void OnButtonClicked(object sender, EventArgs args)
        {
          
            if (txtUsuario.Text != "estudiante2021" && txtPassword.Text != "uisrael2021")
            {
                await Navigation.PushAsync(new Registro(txtUsuario.Text, txtPassword.Text));
            }
            else
            {
                await DisplayAlert("Mensaje de bienvenida", "El usuario " + txtUsuario.Text + " es incorrecto!", "Aceptar");
            }
            
        }
    }
}
