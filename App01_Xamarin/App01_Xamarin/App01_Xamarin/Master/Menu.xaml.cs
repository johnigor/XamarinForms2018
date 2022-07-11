using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App01_Xamarin.Master
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Menu : FlyoutPage
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void GoForProfile1Page(object sender, EventArgs args)
        {
            Detail = new NavigationPage(new Pages.Profile1());
            IsPresented = false;
        }

        private void GoForXamarinPage(object sender, EventArgs args)
        {
            Detail = new NavigationPage(new Pages.Xamarin());
            IsPresented = false;
        }
    }
}