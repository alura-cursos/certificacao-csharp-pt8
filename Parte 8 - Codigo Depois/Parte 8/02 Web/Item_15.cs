using System;
using System.Collections.Generic;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Listings
{
    class Item_15 //WebClient async
    {
        static async Task XMain(string[] args)
        {
            //TAREFA:
            //Conectar-se site da caelum (http://www.caelum.com.br)
            //apenas para obter e exibir o conteúdo da página do site
            //de forma ASSÍNCRONA

            string textoDoSite = await LerTextoDoSite();
            Console.WriteLine(textoDoSite);
            Console.ReadKey();
        }

        private static async Task<string> LerTextoDoSite()
        {
            WebClient webClient = new WebClient();
            var textoDoSite = await webClient.DownloadStringTaskAsync("http://www.caelum.com.br");
            return textoDoSite;
        }
    }
}
