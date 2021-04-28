using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AndresRamosExamen
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Registro : ContentPage
    {
        String usuario;
        double totalCurso = 0;
        public Registro(String user, String password)
        {
            usuario = user;            
            InitializeComponent();
        }

        private void OnButtonClickedCalcular(object sender, EventArgs args)
        {
            int curso = 1800;

            double cuota = (( curso - double.Parse("0" + txtMontoInicial.Text)) /3 ) + (1800 * 0.05);

            txtPagoMensual.Text = cuota.ToString();

            totalCurso = double.Parse(txtMontoInicial.Text) + (cuota * 3);
        }

        private async void OnButtonClickedGrabar(object sender, EventArgs args)
        {
            await DisplayAlert("Mensaje Información", "El grabado con éxito!", "Aceptar");
            await Navigation.PushAsync(new Resumen(usuario, txtNombre.Text,  totalCurso.ToString()));
        }
    }
}