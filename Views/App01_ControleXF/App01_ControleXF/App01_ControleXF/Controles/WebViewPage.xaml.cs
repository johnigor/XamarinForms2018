using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App01_ControleXF.Controles
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class WebViewPage : ContentPage
    {
        public WebViewPage()
        {
            InitializeComponent();
        }
        public void GoPage(object sender, EventArgs args)
        {
            Navegador.Source = EnderecoSite.Text;
        }
        public void GoProximo(object sender, EventArgs args)
        {
            if (Navegador.CanGoForward) Navegador.GoForward();
        }
        public void GoVoltar(object sender, EventArgs args)
        {
            if (Navegador.CanGoBack) Navegador.GoBack();
        }
        public void ActionCarregando(object sender, EventArgs args)
        {
            LblStatus.Text = "Carregando...";
        }
        public void ActionCarregado(object sender, EventArgs args)
        {
            LblStatus.Text = "Finalizado.";
        }
    }
}