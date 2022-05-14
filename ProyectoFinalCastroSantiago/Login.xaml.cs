using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ProyectoFinalCastroSantiago
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Login : ContentPage
    {
        public Login()
        {
            InitializeComponent();
        }
        private void btnOpen_Clicked(object sender, EventArgs e)
        {
            string usuario = "";
            string validar = validarInicio(txtusuario.Text, txtContrasena.Text);
            if (validar == "Error")
            {
                DisplayAlert("Usuario o Contraseña", validar, "Continuar");
            }
            else
            {
                usuario = txtusuario.Text;
                Navigation.PushAsync(new Registro());
            }

        }
        private string validarInicio(string usuario, string pass)
        {
            string validacion = "";
            if (usuario == "santiago2022" && pass == "uisrael2022")
            {
                validacion = "";

            }
            else
            {
                validacion = "Error";
            }
            return validacion;
        }

        private void btnRegistro_Clicked(object sender, EventArgs e)
        {

        }
    }
}