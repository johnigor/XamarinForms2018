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
            IsPresented = false;
        }
        public void GoPageImage(object sender, EventArgs args)
        {
            Detail = new NavigationPage(new Pagina.ImageCellPage());
            IsPresented = false;
        }
        public void GoPageEntry(object sender, EventArgs args)
        {
            Detail = new NavigationPage(new Pagina.EntryCellPage());
            IsPresented = false;
        }
        public void GoPageSwitch(object sender, EventArgs args)
        {
            Detail = new NavigationPage(new Pagina.SwitchCellPage());
            IsPresented = false;
        }
        public void GoPageView(object sender, EventArgs args)
        {
            Detail = new NavigationPage(new Pagina.ViewCellPage());
            IsPresented = false;
        }
        public void GoPageListView(object sender, EventArgs args)
        {
            Detail = new NavigationPage(new Pagina.ListViewPage());
            IsPresented = false;
        }
        public void GoPageListViewButton(object sender, EventArgs args)
        {
            Detail = new NavigationPage(new Pagina.ListViewButtonPage());
            IsPresented = false;
        }
    }
}