using System;
using App01_Vagas.Models;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App01_Vagas.Pages
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class VagasDisponiveisPage : ContentPage
    {
        public VagasDisponiveisPage()
        {
            InitializeComponent();
        }
        private void GoCadastro(object sender, EventArgs args)
        {
            Navigation.PushAsync(new CadastroVagaPage());
        }

        private void GoVagas(object sender, EventArgs args)
        {
            Navigation.PushAsync(new VagasDisponiveisPage());
        }

        private void MaisDetalhes(object sender, EventArgs args)
        {
            Label lblDetalhes = (Label)sender;
            TapGestureRecognizer tapGest = (TapGestureRecognizer)lblDetalhes.GestureRecognizers[0];
            Vaga vaga = tapGest.CommandParameter as Vaga;
            Navigation.PushAsync(new DetalhesVagaPage(vaga));
        }
    }
}