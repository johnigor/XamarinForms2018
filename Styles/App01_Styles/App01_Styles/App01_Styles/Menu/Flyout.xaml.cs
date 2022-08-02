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
            IsPresented = false;
        }
        private void GoExplicitStyle(object sender, EventArgs args)
        {
            Detail = new NavigationPage(new Page.ExplicitStylePage());
            IsPresented = false;
        }
        private void GoGlobalStyle(object sender, EventArgs args)
        {
            Detail = new NavigationPage(new Page.GlobalStylePage());
            IsPresented = false;
        }
        private void GoInheritStyle(object sender, EventArgs args)
        {
            Detail = new NavigationPage(new Page.InheritStylePage());
            IsPresented = false;
        }
        private void GoDynamicStyle(object sender, EventArgs args)
        {
            Detail = new NavigationPage(new Page.DynamicStylePage());
            IsPresented = false;
        }
    }
}