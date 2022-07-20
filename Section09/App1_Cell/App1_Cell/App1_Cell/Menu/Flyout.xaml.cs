using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App1_Cell.Menu
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Flyout : FlyoutPage
    {
        public Flyout()
        {
            InitializeComponent();
        }
        public void GoPage1(object sender, EventArgs args)
        {
            Detail = new NavigationPage(new Pagina.TextCellPage());
        }
    }
}