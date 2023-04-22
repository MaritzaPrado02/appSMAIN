using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SMAIN.Views;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace SMAIN.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Login : ContentPage
    {
        public Login()
        {
            InitializeComponent();
        }

        private void TapGestureRecognizer_Tapped(object sender, EventArgs e)
        {
            
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            if(txtUsername.Text=="admin" && txtPassword.Text == "123")
            {
                Navigation.PushAsync(new HomePage());
                txtUsername.Text = "";
                txtPassword.Text = "";
            }
            else
            {
                DisplayAlert("Solicitud fallida", "El nombre de usuario o la contraseña son incorrectas", "OK");
                txtUsername.Text = "";
                txtPassword.Text = "";
            }
        }
    }
}