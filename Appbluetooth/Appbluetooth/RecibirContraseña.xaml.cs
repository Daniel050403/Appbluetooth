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
    public partial class RecibirContraseña : ContentPage
    {
        public RecibirContraseña()
        {
            InitializeComponent();
        }

        private void Validar_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Menu());
        }
    }
    
}