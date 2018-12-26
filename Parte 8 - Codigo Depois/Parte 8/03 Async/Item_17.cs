using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Threading.Tasks;

namespace Listings
{
    class Item_17 //Acesso assíncrono a arquivos
    {
        static void XMain(string[] args)
        {
            //TAREFA:   IMPLEMENTAR ACESSO ASSÍNCRONO A ARQUIVOS,
            //          TANTO NA LEITURA QUANTO NA GRAVAÇÃO


            // GRAVANDO UM ARQUIVO
            using (FileStream fluxoSaida
                = new FileStream("ArquivoSaida.txt", FileMode.Create, FileAccess.Write))
            {
                string mensagemSaida = "Olá, Alura!";

                byte[] array = Encoding.UTF8.GetBytes(mensagemSaida);
                int posicao = 0;
                int tamanho = mensagemSaida.Length;
                fluxoSaida.Write(array, posicao, tamanho);
            }

            // LENDO UM ARQUIVO
            using (FileStream fluxoEntrada
                = new FileStream("ArquivoSaida.txt",
                    FileMode.Open, FileAccess.Read))
            {
                byte[] bytesLidos = new byte[fluxoEntrada.Length];
                int posicao = 0;
                fluxoEntrada.Read(bytesLidos, posicao, (int)fluxoEntrada.Length);
                string texto = Encoding.UTF8.GetString(bytesLidos);
                Console.WriteLine("Mensagem Lida: " + texto);
            }

            Console.ReadKey();
        }
    }
}
