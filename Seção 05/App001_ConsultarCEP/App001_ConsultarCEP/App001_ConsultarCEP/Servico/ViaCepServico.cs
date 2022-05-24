using System;
using System.Collections.Generic;
using System.Text;
using System.Net;
using App001_ConsultarCEP.Servico.Modelo;
using Newtonsoft.Json;

namespace App001_ConsultarCEP.Servico
{
    public class ViaCepServico
    {
        private static string EnderecoURL = "https://viacep.com.br/ws/{0}/json/";

        public static Endereco BuscarEnderecoViaCEP(string cep)
        {
            string novoEnderecoUrl = string.Format(EnderecoURL, cep);

            WebClient wc = new WebClient();
            string conteudo = wc.DownloadString(novoEnderecoUrl);

            Endereco end = JsonConvert.DeserializeObject<Endereco>(conteudo);

            return end;
        }
    }
}
