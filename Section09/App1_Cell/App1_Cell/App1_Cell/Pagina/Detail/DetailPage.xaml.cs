using System;
using App1_Cell.Model;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App1_Cell.Pagina.Detail
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class DetailPage : ContentPage
    {
        public DetailPage(Funcionario funcionario)
        {
            InitializeComponent();

            TxtNome.Text = funcionario.Nome;
        }
    }
}