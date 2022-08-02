using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using App01_Vagas.Data;
using App01_Vagas.Models;

namespace App01_Vagas.Pages
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class CadastrarVaga : ContentPage
    {
        public CadastrarVaga()
        {
            InitializeComponent();
        }

        public void SalvarAction(object sender, EventArgs args)
        {
            Vaga vaga = new Vaga();
            vaga.Cargo = Cargo.Text;
            vaga.Empresa = Empresa.Text;
            vaga.Quantidade = short.Parse(Quantidade.Text);
            vaga.Cidade = Cidade.Text;
            vaga.Salario = double.Parse(Salario.Text);
            vaga.Descricao = Descricao.Text;
            vaga.TipoContratacao = (TipoContratacao.IsToggled) ? "PJ" : "CLT";
            vaga.Telefone = Telefone.Text;
            vaga.Email = Email.Text;
                        
            DataContext database = new DataContext();
            database.Cadastrar(vaga);

            Application.Current.MainPage = new NavigationPage(new ConsultarVagas());
        }
    }
}