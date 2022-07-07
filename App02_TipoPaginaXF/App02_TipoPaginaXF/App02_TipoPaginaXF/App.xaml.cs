using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App02_TipoPaginaXF
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new PageType.Carousel.PageType3();
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
