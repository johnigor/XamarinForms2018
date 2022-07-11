using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App01_ControleXF.Menu
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Master : FlyoutPage
    {
        public Master()
        {
            InitializeComponent();
        }

        private void GoActivityIndicatorPage(object sender, EventArgs args)
        {
            Detail = new NavigationPage(new Controles.ActivityIndicatorPage());
        }
    }
}