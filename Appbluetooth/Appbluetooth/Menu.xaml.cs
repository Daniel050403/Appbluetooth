using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Appbluetooth
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Menu : ContentPage
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void Mostrar_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Mostrar());
        }

        private void Agregar_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Registrar());
        }
    }
}