using Parcial.Xamarin.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Parcial.Xamarin.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class DomiciliosPage : ContentPage
    {
        public DomiciliosPage()
        {
            InitializeComponent();
            lsvProductos.ItemsSource = ProductoService.GetProducts();
        }
    }
}