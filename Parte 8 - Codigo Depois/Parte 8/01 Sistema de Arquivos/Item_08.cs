using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Listings
{
    class Item_08 //Informações de arquivo
    {
        static void XMain(string[] args)
        {
            const string caminho = "Arquivo.txt";
            //TAREFA:
            //1. Gravar um texto em Arquivo.txt
            //2. Obter informações desse arquivo:
            //      Nome
            //      Caminho completo (diretório + nome do arquivo)
            //      Data e hora do último acesso
            //      Tamanho do arquivo (bytes)
            //      Atributos do arquivo
            //      Adicionar atributo somente-leitura
            //      Verificar os atributos novamente
            //      Remover atributo somente-leitura
            //      Verificar os atributos novamente

            File.WriteAllText(caminho, "Texto inicial do arquivo");
            FileInfo info = new FileInfo(caminho);
            Console.WriteLine("Nome {0}", info.Name);
            Console.WriteLine("Caminho completo: {0}", info.FullName);
            Console.WriteLine("Último acesso: {0}", info.LastAccessTime);
            Console.WriteLine("Tamanho: {0} bytes", info.Length);
            Console.WriteLine("Atributos: {0}", info.Attributes);
            info.Attributes = info.Attributes | FileAttributes.ReadOnly;
            Console.WriteLine("Atributos: {0}", info.Attributes);
            info.Attributes = info.Attributes & ~FileAttributes.ReadOnly;
            Console.WriteLine("Atributos: {0}", info.Attributes);
        }
    }
}
