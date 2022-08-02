using System;
using App01_Vagas.Models;
using App01_Vagas.Data;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App01_Vagas.Pages
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class EditarVagaPage : ContentPage
    {
        private Vaga vaga { get; set; }
        public EditarVagaPage(Vaga cargo)
        {
            InitializeComponent();

            vaga = cargo;

            Cargo.Text = vaga.Cargo;
            Empresa.Text = vaga.Empresa;
            Quantidade.Text = vaga.Quantidade.ToString();
            Cidade.Text = vaga.Cidade;
            Salario.Text = vaga.Salario.ToString();
            Descricao.Text = vaga.Descricao;
            TipoContratacao.IsToggled = (vaga.TipoContratacao == "CLT") ? false : true;
            Telefone.Text = vaga.Telefone;
            Email.Text = vaga.Email;
        }

        public void SalvarAction(object sender, EventArgs args)
        {
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
            database.Atualizar(vaga);

            Application.Current.MainPage = new NavigationPage(new ConsultarVagas());
        }
    }
}