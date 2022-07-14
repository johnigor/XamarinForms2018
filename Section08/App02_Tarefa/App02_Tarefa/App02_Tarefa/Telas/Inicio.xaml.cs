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
    public partial class Inicio : ContentPage
    {
        public Inicio()
        {
            InitializeComponent();

            DataHoje.Text = DateTime.Now.DayOfWeek.ToString() + ", " + DateTime.Now.ToString("dd:MM");
        }
        private void GoCadastro(object sender, EventArgs args)
        {
            Navigation.PushAsync(new Cadastro());
        }
        public void LinhaStackLayout(Tarefa tarefa)
        {
            Image delete = new Image()
            {
                VerticalOptions = LayoutOptions.Center,
                Source = ImageSource.FromFile("Delete.png")
            };
            delete.Source = Device.RuntimePlatform == Device.UWP
                ? delete.Source = ImageSource.FromFile("Resources/Delete.png")
                : delete.Source = ImageSource.FromFile("Delete.png");

            Image prioridade = new Image()
            {
                VerticalOptions = LayoutOptions.Center,
                Source = ImageSource.FromFile(tarefa.Prioridade + "CheckOff.png")
            };
            prioridade.Source = Device.RuntimePlatform == Device.UWP
                ? prioridade.Source = ImageSource.FromFile("Resources/" + tarefa.Prioridade + ".png")
                : prioridade.Source = ImageSource.FromFile(tarefa.Prioridade + ".png");

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
                    Text = "Finalizado em: " + tarefa.DataFinalizacao.ToString("dd/MM/yyyy - HH:mm" + "h"),
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