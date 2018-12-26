using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Listings
{
    class Item_02 //FileStream and IDisposable
    {
        static void XMain(string[] args)
        {
            // GRAVANDO UM ARQUIVO

            FileStream fluxoSaida
                = new FileStream("ArquivoSaida.txt", FileMode.Create, FileAccess.Write);

            string mensagemSaida = "Olá, Alura!";

            byte[] array = Encoding.UTF8.GetBytes(mensagemSaida);
            int posicao = 0;
            int tamanho = mensagemSaida.Length;
            fluxoSaida.Write(array, posicao, tamanho);
            fluxoSaida.Close();

            FileStream fluxoEntrada
                = new FileStream("ArquivoSaida.txt",
                    FileMode.Open, FileAccess.Read);

            byte[] bytesLidos = new byte[fluxoEntrada.Length];

            fluxoEntrada.Read(bytesLidos, posicao, (int)fluxoEntrada.Length);
            string texto = Encoding.UTF8.GetString(bytesLidos);
            fluxoEntrada.Close();

            Console.WriteLine("Mensagem Lida: " + texto);

            Console.ReadKey();
        }
    }
}