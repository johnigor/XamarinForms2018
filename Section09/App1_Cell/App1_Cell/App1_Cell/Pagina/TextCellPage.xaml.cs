using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using App1_Cell.Model;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App1_Cell.Pagina
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class TextCellPage : ContentPage
    {
        public TextCellPage()
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