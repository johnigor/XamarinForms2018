using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using App01_Vagas.Models;

namespace App01_Vagas.Pages
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class DetalharVaga : ContentPage
    {
        public DetalharVaga(Vaga vaga)
        {
            InitializeComponent();

            DisplayAlert("MSG", vaga.Cargo, "OK");

            BindingContext = vaga;
        }
    }
}