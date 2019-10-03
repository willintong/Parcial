using System;
using System.Collections.Generic;
using System.Text;

namespace Parcial.Xamarin.Domain
{
    public class Producto
    {
        public int Id { get; set; }

        public string Nombre { get; set; }

        public decimal Precio { get; set; }

        public int Stock { get; set; }

        public string Imagen { get; set; }
    }
}
