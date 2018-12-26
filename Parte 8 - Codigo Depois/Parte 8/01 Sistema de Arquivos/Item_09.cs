using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Listings
{
    class Item_09 //A Classe Directory
    {
        private const string NomeDiretorio = "NovoDiretorio";

        static void XMain(string[] args)
        {
            //TAREFA:
            //Criar um novo diretório
            //Verificar se ele foi criado
            //Apagar o diretório que foi criado

            Directory.CreateDirectory(NomeDiretorio);
            if (Directory.Exists(NomeDiretorio))
            {
                Console.WriteLine("O diretório foi criado com sucesso");
            }
            Directory.Delete(NomeDiretorio);
            Console.WriteLine("O diretório foi removido com sucesso");
        }
    }
}
