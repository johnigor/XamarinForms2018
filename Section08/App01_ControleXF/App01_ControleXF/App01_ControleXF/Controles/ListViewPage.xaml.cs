using System;
using App01_ControleXF.Modelo;
using System.Collections.Generic;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App01_ControleXF.Controles
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ListViewPage : ContentPage
    {
        public ListViewPage()
        {
            InitializeComponent();

            List<Pessoa> lista = new List<Pessoa>
            {
                new Pessoa { Nome = "José", Idade = "20" },
                new Pessoa { Nome = "Felipe", Idade = "22" },
                new Pessoa { Nome = "Maria", Idade = "22" },
                new Pessoa { Nome = "Joao", Idade = "24" },
                new Pessoa { Nome = "Paulo", Idade = "26" }
            };

            ListaPessoas.ItemsSource = lista;
        }
    }
}