using System;
using System.Collections.Generic;
using App1_Cell.Model;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App1_Cell.Pagina
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ListViewPage : ContentPage
    {
        public ListViewPage()
        {
            InitializeComponent();

            List<Funcionario> list = new List<Funcionario>()
            {
                new Funcionario(){ Nome = "José", Cargo = "Presidente", },
                new Funcionario(){ Nome = "Maria", Cargo = "Gerente de vendas", },
                new Funcionario(){ Nome = "Elaine", Cargo = "Gerente de marketing", },
                new Funcionario(){ Nome = "Felipe", Cargo = "Entregador", },
                new Funcionario(){ Nome = "João", Cargo = "Vendedor", }
            };
            ListaFuncionario.ItemsSource = list;
        }

        private void ItemSelecionadoAction(object sender, SelectedItemChangedEventArgs args)
        {
            Funcionario funcionario = (Funcionario)args.SelectedItem;

            Navigation.PushAsync(new Detail.DetailPage(funcionario));
        }

        private void FeriasAction(object sender, EventArgs args)
        {
            MenuItem menuItem = (MenuItem)sender;
            Funcionario funcionario = (Funcionario)menuItem.CommandParameter;

            DisplayAlert("Título: " + funcionario.Nome, "Mensagem: " + funcionario.Nome + " - " + funcionario.Cargo, "OK");
        }

        private void AbonoAction(object sender, EventArgs args)
        {
        }
    }
}