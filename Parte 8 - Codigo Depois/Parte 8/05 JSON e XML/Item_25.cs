using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace Listings
{
    class Item_25 //Json
    {
        static async Task XMain(string[] args)
        {
            //TAREFA:
            //CONSULTAR OS DADOS DO CEP 04101-300
            //NO SERVIÇO DA http://viacep.com.br
            //E EXIBIR SEUS DADOS

            string cep = "04101300";
            string url = $"http://viacep.com.br/ws/{cep}/json/";

            using (var cliente = new HttpClient())
            {
                var json = await cliente.GetStringAsync(url);

                var endereco = JsonConvert.DeserializeObject<Endereco>(json);


                Console.WriteLine(
                    $"Logradouro: {endereco.logradouro}" +
                    $"\nBairro: {endereco.bairro}" +
                    $"\nMunicípio: {endereco.localidade}" +
                    $"\nUF: {endereco.uf}" +
                    $"\nCEP: {endereco.cep}");
            }

            Console.ReadKey();
        }
    }

    class Endereco
    {
        public string cep { get; set; }
        public string logradouro { get; set; }
        public string bairro { get; set; }
        public string localidade { get; set; }
        public string uf { get; set; }
    }
}
