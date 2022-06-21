using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Modulo1
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new Modulo1.ParOuImpar();
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
