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
    public partial class RegisterPage : ContentPage
    {
        List<TiposDocs> tiposDocs;
       
        public RegisterPage()
        {
            InitializeComponent();
            InitApp();
        }

         void InitApp()
        {
            tiposDocs= new List<TiposDocs>();
            tiposDocs.Add(new TiposDocs { idTipoDocumento = 1, nombreTipoDocumento = "CC" });
            tiposDocs.Add(new TiposDocs { idTipoDocumento = 1, nombreTipoDocumento = "TI" });
            tiposDocs.Add(new TiposDocs { idTipoDocumento = 1, nombreTipoDocumento = "CE" });
            tiposDocs.Add(new TiposDocs { idTipoDocumento = 1, nombreTipoDocumento = "PASAPORTE" });


            foreach(var tipodoc in tiposDocs) {
                pickerTipoDoc.Items.Add(tipodoc.nombreTipoDocumento);
            }
        }

        private async void NavToLogin_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new LoginPage());
        }

        private void pickerTipoDoc_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}