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

            try
            {
                Address address = ViaCEPService.FindAddressByCep(cep);
                if (address != null)
                {
                    RESULTADO.Text = string.Format("Endereço: {0}, {1}, {2}, {3}", address.Logradouro, address.Bairro, address.Localidade, address.Uf);
                }
                else
                {
                    DisplayAlert("ERRO", "The postal code entered does not exist." + cep, "OK");
                }
            }
            catch (Exception erro)
            {
                DisplayAlert("ERRO", erro.Message, "OK");
            }
        }

        private bool IsValidCEP(string cep)
        {
            bool valid = true;
            /*if (cep.Length != 8)
            {
                DisplayAlert("ERROR", "Invalid zip code! The zip code must contain 8 characters", "OK");
                valid = false;
            }*/

            int novoCep = 0;
            if (!int.TryParse(cep, out novoCep))
            {
                DisplayAlert("ERROR", "Invalid zip code! The zip code must contain only numbers", "OK");
                valid = false;
            }
            return valid;
        }
    }
}
