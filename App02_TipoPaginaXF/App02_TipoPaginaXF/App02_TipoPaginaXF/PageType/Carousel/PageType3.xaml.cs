using System;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App02_TipoPaginaXF.PageType.Carousel
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PageType3 : ContentPage
    {
        public PageType3()
        {
            InitializeComponent();
        }

        private void ChangePage(object sender, EventArgs args)
        {
            Application.Current.MainPage = new NavigationPage(new Navigation.Page1()) { BarBackgroundColor = Color.Blue };
        }
    }
}