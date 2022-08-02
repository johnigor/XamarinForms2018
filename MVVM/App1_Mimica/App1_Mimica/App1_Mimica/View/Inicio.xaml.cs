using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App1_Mimica.View
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Inicio : ContentPage
    {
        public Inicio()
        {
            InitializeComponent();

            BindingContext = new ViewModel.InicioViewModel();
        }
    }
}