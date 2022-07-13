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

            List<Pessoa> lista = new List<Pessoa>();
            lista.Add(new Pessoa { Nome = "José", Idade = "20" });
            lista.Add(new Pessoa { Nome = "Felipe", Idade = "22" });
            lista.Add(new Pessoa { Nome = "Maria", Idade = "22" });
            lista.Add(new Pessoa { Nome = "Joao", Idade = "24" });
            lista.Add(new Pessoa { Nome = "Paulo", Idade = "26" });

            ListaPessoas.ItemsSource = lista;
        }
    }
}