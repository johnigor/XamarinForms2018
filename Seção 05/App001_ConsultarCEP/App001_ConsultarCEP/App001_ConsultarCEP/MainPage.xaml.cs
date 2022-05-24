using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using App001_ConsultarCEP.Servico.Modelo;
using App001_ConsultarCEP.Servico;

namespace App001_ConsultarCEP
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();

            Button.Clicked += BuscarCEP;
        }

        private void BuscarCEP(object sender, EventArgs args)
        {
            string cep = CEP.Text.Trim();
            if (IsValidCep(cep))
            {
                try
                {
                    Endereco end = ViaCepServico.BuscarEnderecoViaCEP(cep);
                    if (end != null)
                    {
                        Result.Text = string.Format("Endereço: {0} - {1}, {2}", end.Localidade, end.Uf, end.Logradouro);
                    }
                    else
                    {
                        DisplayAlert("ERRO", "O endereço não foi encontrado para o CEP informado: " + cep, "OK");
                    }
                }
                catch (Exception e)
                {
                    DisplayAlert("ERRO CRÍTICO", e.Message, "OK");
                }
            }
        }

        private bool IsValidCep(string cep)
        {
            bool valido = true;
            if (cep.Length != 8)
            {
                DisplayAlert("ERRO", "CEP inválido! O CEP deve conter oito caracteres.", "OK");
                valido = false;
            }
            int novoCep = 0;
            if (!int.TryParse(cep, out novoCep))
            {
                DisplayAlert("ERRO", "CEP inválido! O CEP deve ser composto apenas por números.", "OK");
                valido = false;
            }
            return valido;
        }
    }
}
