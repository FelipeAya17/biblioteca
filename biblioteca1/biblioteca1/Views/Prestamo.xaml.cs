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
    public partial class Prestamo : ContentPage
    {
        List<modelLibros> libros;
        public Prestamo()
        {
            InitializeComponent();
            InitApp();
        }

        void InitApp()
        {
            libros = new List<modelLibros>();
            libros.Add(new modelLibros { idLibro = 1, nombreLibro = "100 años de soledad" });

            foreach (var libro in libros )
            {
                pickerLibro.Items.Add(libro.nombreLibro);
            }
        }

        private void pickerLibro_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}