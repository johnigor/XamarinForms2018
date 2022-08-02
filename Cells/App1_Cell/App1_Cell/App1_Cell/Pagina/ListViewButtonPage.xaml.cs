using System;
using System.Collections.Generic;
using App1_Cell.Model;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App1_Cell.Pagina
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ListViewButtonPage : ContentPage
    {
        public ListViewButtonPage()
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

        private void FeriasAction(object sender, EventArgs args)
        {
            Button btnFerias = (Button)sender;
            Funcionario funcionario = (Funcionario)btnFerias.CommandParameter;

            DisplayAlert("Férias", "Funcionário: " + funcionario.Nome, "OK");
        }
    }
}