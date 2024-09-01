using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace Gerador_de_Malling_CNPJ.ConectaApi.ApiReceitaws
{
    internal class Conectaws
    {
        public async Task<DadosCnpj> Intergracao(string cnpj)
        {
            var uri = "https://receitaws.com.br/v1/cnpj/";
            HttpClient client = new HttpClient();
            var response = await client.GetAsync(uri+cnpj);
            var jsonstring = await response.Content.ReadAsStringAsync();
            var jsonobj = JsonConvert.DeserializeObject<DadosCnpj>(jsonstring);
            return jsonobj;
        }
    }
}
