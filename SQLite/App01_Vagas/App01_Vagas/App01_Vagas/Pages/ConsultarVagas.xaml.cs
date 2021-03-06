using System;
using System.Collections.Generic;
using System.Linq;
using App01_Vagas.Data;
using App01_Vagas.Models;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App01_Vagas.Pages
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ConsultarVagas : ContentPage
    {
        List<Vaga> Vagas { get; set; }
        public ConsultarVagas()
        {
            InitializeComponent();
            Consultar();
        }

        public void Consultar()
        {
            DataContext database = new DataContext();
            Vagas = database.Consultar();
            ListaVagas.ItemsSource = Vagas;

            lblCount.Text = Vagas.Count.ToString();
        }

        private void GoCadastro(object sender, EventArgs args)
        {
            Navigation.PushAsync(new CadastrarVaga());
        }

        private void GoVagas(object sender, EventArgs args)
        {
            Navigation.PushAsync(new MinhasVagas());
        }

        private void MaisDetalhes(object sender, EventArgs args)
        {
            Label lblDetalhes = (Label)sender;
            TapGestureRecognizer tapGest = (TapGestureRecognizer)lblDetalhes.GestureRecognizers[0];
            Vaga vaga = tapGest.CommandParameter as Vaga;
            Navigation.PushAsync(new DetalharVaga(vaga));
        }

        private void PesquisarAction(object sender, TextChangedEventArgs args)
        {
            ListaVagas.ItemsSource = Vagas.Where(x => x.Cargo.Contains(args.NewTextValue)).ToList();
        }
    }
}