using Parcial.Xamarin.Domain;
using Parcial.Xamarin.Helpers;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Parcial.Xamarin.Services
{
    public static class ProductoService
    {
        public static List<Producto> GetProducts()
        {
            var products = ApiHelper.Get<List<Producto>>("/api/Inventario");
            return products;
        }
    }
}
