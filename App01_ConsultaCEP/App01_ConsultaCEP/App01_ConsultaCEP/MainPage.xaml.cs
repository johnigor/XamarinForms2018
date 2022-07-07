using System;
using Xamarin.Forms;
using App01_ConsultaCEP.Services;
using App01_ConsultaCEP.Services.Model;

namespace App01_ConsultaCEP
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();

            BOTAO.Clicked += BuscarCEP;
        }

        private void BuscarCEP(object sender, EventArgs args)
        {
            string cep = CEP.Text.Trim();
            Address address = ViaCEPService.FindAddressByCep(cep);

            RESULTADO.Text = string.Format("Endereço: {0}, {1}, {2}", address.Localidade, address.Uf, address.Logradouro);
        }
    }
}
