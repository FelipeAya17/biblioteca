using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace biblioteca1.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class HomePage : ContentPage
    {
        public HomePage()
        {
            InitializeComponent();
        }

        private async void goPrestamo(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Prestamo());
        }

        private async void goPerfil(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Perfil());
        }

        private async void goLibros(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Libros());
        }

        private async void goMultas(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Multas());
        }
    }
}