using System.Net;
using Newtonsoft.Json;
using App01_ConsultarCEP.Services.Model;

namespace App01_ConsultarCEP.Services
{
    public class ViaCEPService
    {
        private static string EnderecoUrl = "https://viacep.com.br/ws/{0}/json/";

        public static Address FindAddressByCep(string cep)
        {
            string novoEnderecoUrl = string.Format(EnderecoUrl, cep);

            WebClient wc = new WebClient();
            string conteudo = wc.DownloadString(novoEnderecoUrl);

            Address address = JsonConvert.DeserializeObject<Address>(conteudo);
            return address;
        }
    }
}
