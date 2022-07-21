using System;
using App1_Cell.Model;
using System.Collections.Generic;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App1_Cell.Pagina
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ViewCellPage : ContentPage
    {
        public ViewCellPage()
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
    }
}