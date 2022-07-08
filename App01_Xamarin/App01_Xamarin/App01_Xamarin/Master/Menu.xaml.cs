using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App01_Xamarin.Master
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Menu : MasterDetailPage
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void GoForProfile1Page(object sender, EventArgs args)
        {
            Navigation.PushAsync(new Pages.Profile1());
        }

        private void GoForXamarinPage(object sender, EventArgs args)
        {
            Navigation.PushAsync(new Pages.Xamarin());
        }
    }
}