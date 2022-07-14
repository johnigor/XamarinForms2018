using App02_Tarefa.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App02_Tarefa.Telas
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Cadastro : ContentPage
    {
        private byte Priority { get; set; }
        public Cadastro()
        {
            InitializeComponent();
        }
        public void PrioridadeSelectAction(object sender, EventArgs args)
        {
            var stacks = SL_Prioridades.Children;

            foreach (var linha in stacks)
            {
                Label LblPrioridade = ((StackLayout)linha).Children[1] as Label;
                LblPrioridade.TextColor = Color.Gray;
            }

            ((Label)((StackLayout)sender).Children[1]).TextColor = Color.Black;
            FileImageSource source = ((Image)((StackLayout)sender).Children[0]).Source as FileImageSource;

            string prioridade = source.File.ToString().Replace("Resources/", "").Replace(".png", "").Replace("p", "");
            Priority = byte.Parse(prioridade);
        }
        public void SalvarAction(object sender, EventArgs args)
        {
            bool ErroExiste = false;
            if (TxtNome.Text == null || TxtNome.Text.Trim().Length <= 0)
            {
                ErroExiste = true;
                DisplayAlert("ERRO: ", "Tarefa não digitada", "OK");
            }
            if (Priority <= 0)
            {
                ErroExiste = true;
                DisplayAlert("ERRO: ", "Prioridade não foi escolhida!", "OK");
            }
            if (ErroExiste == false)
            {
                Tarefa tarefa = new Tarefa();
                tarefa.Nome = TxtNome.Text.Trim();
                tarefa.Prioridade = Priority;

                new GerenciadorTarefa().Salvar(tarefa);

                App.Current.MainPage = new NavigationPage(new Inicio());
            }
        }
    }
}