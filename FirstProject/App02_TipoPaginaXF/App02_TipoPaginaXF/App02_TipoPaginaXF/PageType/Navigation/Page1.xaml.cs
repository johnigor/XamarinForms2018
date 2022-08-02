using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App02_TipoPaginaXF.PageType.Navigation
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Page1 : ContentPage
    {
        public Page1()
        {
            InitializeComponent();
        }

        private void ChangeToPage2(object sender, EventArgs args)
        {
            Navigation.PushAsync(new Page2());
        }

        private void GetModal(object sender, EventArgs args)
        {
            Navigation.PushModalAsync(new Modal());
        }

        private void GetMaster(object sender, EventArgs args)
        {
            Application.Current.MainPage = new Master.Master();
        }
    }
}