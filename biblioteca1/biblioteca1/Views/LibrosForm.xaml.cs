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
    public partial class LibrosForm : ContentPage
    {
        List<modelAutor> autores;
        List<modelCategoriasLibros> categorias;
        public LibrosForm()
        {
            InitializeComponent();
            initApp();
            initApp2();
        }

        void initApp2()
        {
            categorias = new List<modelCategoriasLibros>();
            categorias.Add(new modelCategoriasLibros { idCategoriaLibro = 1, nombreCategoria = "Fantasia" });
            foreach(var categoria in categorias)
            {
                pickerCategoria.Items.Add(categoria.nombreCategoria);
            }
        }

        void initApp()
        {
            autores = new List<modelAutor>();
            autores.Add(new modelAutor { idAutor = 1, nombreAutor = "Gabriel Garcia Marquez" });


            foreach (var autor in autores)
            {
                pickerIdAutor.Items.Add(autor.nombreAutor);
            }
        }

        

    private void pickerIdAutor_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void pickerCategoria_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}