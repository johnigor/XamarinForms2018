using System;
using App01_Vagas.Data;
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

            DataContext database = new DataContext();
            ListaVagas.ItemsSource = database.Consultar();
        }
        private void EditarAction(object sender, EventArgs args)
        {

        }

        private void ExcluirAction(object sender, EventArgs args)
        {

        }
    }
}