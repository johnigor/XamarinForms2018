using System;
using System.Collections.Generic;
using App01_Vagas.Data;
using App01_Vagas.Models;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App01_Vagas.Pages
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MinhasVagas : ContentPage
    {
        List<Vaga> Vagas { get; set; }
        public MinhasVagas()
        {
            InitializeComponent();
            ConsultarVagas();
        }

        private void ConsultarVagas()
        {
            DataContext database = new DataContext();
            Vagas = database.Consultar();
            ListaVagas.ItemsSource = Vagas;

            lblCount.Text = Vagas.Count.ToString();
        }

        private void EditarAction(object sender, EventArgs args)
        {
            Label lblEditar = (Label)sender;
            TapGestureRecognizer tapGest = (TapGestureRecognizer)lblEditar.GestureRecognizers[0];
            Vaga vaga = tapGest.CommandParameter as Vaga;

            Navigation.PushAsync(new EditarVagaPage(vaga));

        }

        private void ExcluirAction(object sender, EventArgs args)
        {
            Label lblExcluir = (Label)sender;
            TapGestureRecognizer tapGest = (TapGestureRecognizer)lblExcluir.GestureRecognizers[0];
            Vaga vaga = tapGest.CommandParameter as Vaga;

            DataContext database = new DataContext();
            database.Excluir(vaga);

            ConsultarVagas();
        }
    }
}