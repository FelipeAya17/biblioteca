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
    public partial class HomePageAdmin : ContentPage
    {
        public HomePageAdmin()
        {
            InitializeComponent();
        }

        private async void goLibroForm(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new LibrosForm());
        }
    }
}