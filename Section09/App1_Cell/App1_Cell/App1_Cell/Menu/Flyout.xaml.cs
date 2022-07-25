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
        public void GoPageText(object sender, EventArgs args)
        {
            Detail = new NavigationPage(new Pagina.TextCellPage());
        }
        public void GoPageImage(object sender, EventArgs args)
        {
            Detail = new NavigationPage(new Pagina.ImageCellPage());
        }
        public void GoPageEntry(object sender, EventArgs args)
        {
            Detail = new NavigationPage(new Pagina.EntryCellPage());
        }
        public void GoPageSwitch(object sender, EventArgs args)
        {
            Detail = new NavigationPage(new Pagina.SwitchCellPage());
        }
        public void GoPageView(object sender, EventArgs args)
        {
            Detail = new NavigationPage(new Pagina.ViewCellPage());
        }
        public void GoPageListView(object sender, EventArgs args)
        {
            Detail = new NavigationPage(new Pagina.ListViewPage());
        }
    }
}