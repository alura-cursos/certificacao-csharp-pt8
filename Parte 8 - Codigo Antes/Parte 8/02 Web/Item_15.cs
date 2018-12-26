using System;
using System.Collections.Generic;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Listings
{
    class Item_15 //WebClient async
    {
        static void XMain(string[] args)
        {
            //TAREFA:
            //Conectar-se site da caelum (http://www.caelum.com.br)
            //apenas para obter e exibir o conteúdo da página do site
            //de forma ASSÍNCRONA

            WebClient webClient = new WebClient();
            var textoDoSite = webClient.DownloadString("http://www.caelum.com.br");
            Console.WriteLine(textoDoSite);
            Console.ReadKey();
        }
    }
}
