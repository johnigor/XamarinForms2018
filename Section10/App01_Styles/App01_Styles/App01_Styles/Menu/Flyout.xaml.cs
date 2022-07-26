using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App01_Styles.Menu
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Flyout : FlyoutPage
    {
        public Flyout()
        {
            InitializeComponent();
        }

        private void GoImplicitStyle(object sender, EventArgs args)
        {
            Detail = new NavigationPage(new Page.ImplicitStylePage());
        }
        
        private void GoExplicitStyle(object sender, EventArgs args)
        {
            Detail = new NavigationPage(new Page.ExplicitStylePage());
        }
        private void GoGlobalStyle(object sender, EventArgs args)
        {
            Detail = new NavigationPage(new Page.GlobalStylePage());
        }
        private void GoInheritStyle(object sender, EventArgs args)
        {
            Detail = new NavigationPage(new Page.InheritStylePage());
        }
    }
}