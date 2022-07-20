using App02_Tarefa.Modelos;
using System;
using System.Collections.Generic;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App02_Tarefa.Telas
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Inicio : ContentPage
    {
        public Inicio()
        {
            InitializeComponent();

            DataHoje.Text = DateTime.Now.DayOfWeek.ToString() + ", " + DateTime.Now.ToString("dd:MM");
            CarregarTarefas();
        }
        private void GoCadastro(object sender, EventArgs args)
        {
            Navigation.PushAsync(new Cadastro());
        }
        private void CarregarTarefas()
        {
            SL_Tarefas.Children.Clear();

            List<Tarefa> lista = new GerenciadorTarefa().Listagem();

            int i = 0;
            foreach (Tarefa tarefa in lista)
            {
                LinhaStackLayout(tarefa, i);
                i++;
            }
        }
        public void LinhaStackLayout(Tarefa tarefa, int index)
        {
            Image delete = new Image()
            {
                VerticalOptions = LayoutOptions.Center,
                Source = ImageSource.FromFile("Delete.png")
            };
            delete.Source = Device.RuntimePlatform == Device.UWP
                ? delete.Source = ImageSource.FromFile("Resources/Delete.png")
                : delete.Source = ImageSource.FromFile("Delete.png");
            
            TapGestureRecognizer deleteTap = new TapGestureRecognizer();
            deleteTap.Tapped += delegate
            {
                new GerenciadorTarefa().Deletar(index);
                CarregarTarefas();
            };
            delete.GestureRecognizers.Add(deleteTap);

            Image prioridade = new Image()
            {
                VerticalOptions = LayoutOptions.Center,
                Source = ImageSource.FromFile(tarefa.Prioridade + "CheckOff.png")
            };
            prioridade.Source = Device.RuntimePlatform == Device.UWP
                ? prioridade.Source = ImageSource.FromFile("Resources/p" + tarefa.Prioridade + ".png")
                : prioridade.Source = ImageSource.FromFile("p" + tarefa.Prioridade + ".png");

            View stackCentral = null;
            if (tarefa.DataFinalizacao == null)
            {
                stackCentral = new Label()
                {
                    VerticalOptions = LayoutOptions.CenterAndExpand,
                    HorizontalOptions = LayoutOptions.FillAndExpand,
                    Text = tarefa.Nome
                };
            }
            else
            {
                stackCentral = new StackLayout()
                {
                    VerticalOptions = LayoutOptions.Center,
                    HorizontalOptions = LayoutOptions.FillAndExpand,
                    Spacing = 0
                };
                ((StackLayout)stackCentral).Children.Add(new Label()
                {
                    Text = tarefa.Nome,
                    TextColor = Color.Gray
                });

                ((StackLayout)stackCentral).Children.Add(new Label()
                {
                    Text = "Finalizado em: " + tarefa.DataFinalizacao.Value.ToString("dd/MM/yyyy - HH:mm" + "h"),
                    TextColor = Color.Gray,
                    FontSize = 10
                });
            }

            Image check = new Image()
            {
                VerticalOptions = LayoutOptions.Center,
                Source = ImageSource.FromFile("CheckOff.png")
            };
            check.Source = Device.RuntimePlatform == Device.UWP
                ? check.Source = ImageSource.FromFile("Resources/CheckOff.png")
                : check.Source = ImageSource.FromFile("CheckOff.png");

            if (tarefa.DataFinalizacao != null)
            {
                check.Source = Device.RuntimePlatform == Device.UWP
                ? check.Source = ImageSource.FromFile("Resources/CheckOn.png")
                : check.Source = ImageSource.FromFile("CheckOn.png");
            }

            TapGestureRecognizer checkTap = new TapGestureRecognizer();
            checkTap.Tapped += delegate
            {
                new GerenciadorTarefa().Finalizar(index, tarefa);
                CarregarTarefas();
            };
            check.GestureRecognizers.Add(checkTap);

            StackLayout linha = new StackLayout()
            {
                Orientation = StackOrientation.Horizontal,
                Spacing = 15
            };

            linha.Children.Add(check);
            linha.Children.Add(stackCentral);
            linha.Children.Add(prioridade);
            linha.Children.Add(delete);
            SL_Tarefas.Children.Add(linha);
        }
    }
}