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

            Console.WriteLine(
                $"Logradouro: " +
                $"\nBairro: " +
                $"\nMunicípio: " +
                $"\nUF: " +
                $"\nCEP: ");

            Console.ReadKey();
        }
    }
}
