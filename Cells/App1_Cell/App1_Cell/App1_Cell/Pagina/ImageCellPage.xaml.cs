using System;
using App1_Cell.Model;
using System.Collections.Generic;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App1_Cell.Pagina
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ImageCellPage : ContentPage
    {
        public ImageCellPage()
        {
            InitializeComponent();

            List<Funcionario> list = new List<Funcionario>()
            {
                new Funcionario(){ Nome = "José", Cargo = "Presidente", Foto = "https://cdn-sites-images.46graus.com/files/photos/f2706dc0/4bd50964-a57e-42fa-914d-99b6ae380f3a/fd-fotografia-_-andav_retratos-71-256x256.jpg"},
                new Funcionario(){ Nome = "Maria", Cargo = "Gerente de vendas", Foto = "https://cdn-sites-images.46graus.com/files/photos/aaf6ba9a/2e09daa3-4a70-4397-8d8d-7b80e953c544/pensando-mulher-relogio-256x256.jpg"},
                new Funcionario(){ Nome = "Elaine", Cargo = "Advogada", Foto = "https://cdn-sites-images.46graus.com/files/photos/4b0ba119/e9897e21-5f84-407e-aefc-8a3d2f0b3bd5/retrato-isabela-advogada_111d-sh-qd-256x256.jpg"},
                new Funcionario(){ Nome = "Felipe", Cargo = "Entregador", Foto = "https://img.olx.com.br/thumbs256x256/66/665202265986593.jpg"},
                new Funcionario(){ Nome = "João", Cargo = "Vendedor", Foto = "https://cdn-sites-images.46graus.com/files/photos/f2706dc0/d00cb6d3-d017-4cc0-aed9-e9288a9ff3cb/fd-fotografia-andav_retratos-29-copy-256x256.jpg"}
            };
            ListaFuncionario.ItemsSource = list;
        }
    }
}