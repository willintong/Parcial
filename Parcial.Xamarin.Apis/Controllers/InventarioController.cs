using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Parcial.Xamarin.Domain;

namespace Parcial.Xamarin.Apis.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class InventarioController : ControllerBase
    {
        [HttpGet]
        public List<Producto> Get()
        {
            var productos = new List<Producto>()
            {
                new Producto { Id= 1, Nombre = "Acetaminofen", Precio = 1200, Stock= 100, Imagen = "https://www.farmalisto.com.co/95434-thickbox_default/comprar-acetaminofen-500-mg-caja-con-20-tabletas-precio-7707193640282.jpg"},
                new Producto { Id= 2, Nombre = "Ibuprofeno", Precio = 5000, Stock= 10, Imagen = "http://www.unimarksa.com/sites/default/files/styles/productosgrande/public/imgproductos/ibuprofeno-400-mg.png?itok=iFtrMJqq"},
                new Producto { Id= 3, Nombre = "Paracetamol", Precio = 2500, Stock= 2, Imagen = "http://www.isalaboratorios.com.ar/img/estuches/venta-libre/paracetamol-isa.png"},
                new Producto { Id= 4, Nombre = "Toxol", Precio = 35000, Stock= 5, Imagen = "https://larebajavirtual.com/images/productos/sii/F/300x300/tos_xol-32206-1547811966.png"},
                new Producto { Id= 5, Nombre = "Aciclovir", Precio = 8000, Stock= 20, Imagen = "https://locatelcolombia.vteximg.com.br/arquivos/ids/191483-1000-1000/7706569000712.png?v=636101418582200000"}
            };

            return productos;
        }
    }
}