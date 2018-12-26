﻿using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace Listings
{
    class Item_16 //HttpClient
    {
        static async Task XMain(string[] args)
        {
            //TAREFA:
            //Conectar-se site da caelum (http://www.caelum.com.br)
            //de forma ASSÍNCRONA, porém o código precisa rodar em 
            // 
            // - Aplicações Windows (Windows Forms, WPF)
            // - Aplicações Web (ASP.NET e ASP.NET Core)
            // - Xamarin (aplicativos de celular / tablet)
            // - Windows Universal Application Platform

            HttpClient cliente = new HttpClient();
            var textoDoSite = await cliente.GetStringAsync("http://www.caelum.com.br");
            Console.WriteLine(textoDoSite);
            Console.ReadKey();
        }
    }
}
