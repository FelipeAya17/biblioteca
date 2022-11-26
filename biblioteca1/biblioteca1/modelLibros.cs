using System;
using System.Collections.Generic;
using System.Text;

namespace biblioteca1
{
    public class modelLibros
    {
        public int idLibro { get; set; }
        public string nombreLibro { get; set; }
        public int idAutor { get; set; }
        public DateTime fechaPublicacion { get; set; }
        public int idCategoriaLibro { get; set; }
    }
}
    