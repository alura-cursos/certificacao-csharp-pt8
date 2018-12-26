using System;
using System.IO;

namespace Listings
{
    class Item_07 //Informações do drive
    {
        private const int KILOBYTE = 1024;

        static void XMain(string[] args)
        {
            //TAREFA:
            //=======
            //Nome do drive
            //Verificar se o drive está pronto
            //Tipo do drive
            //Formato do drive
            //Espaço livre, em bytes, KB, MB, GB e TB

            var drives = DriveInfo.GetDrives();

            foreach (var drive in drives)
            {
                Console.WriteLine("Nome: {0}", drive.Name);
                if (!drive.IsReady)
                {
                    Console.WriteLine("O drive não está pronto.");
                    continue;
                }
                Console.WriteLine("Tipo: {0}", drive.DriveType);
                Console.WriteLine("Formato: {0}", drive.DriveFormat);

                Console.WriteLine("Espaço livre:");

                long bytes = drive.TotalFreeSpace;
                Console.WriteLine("{0} bytes", bytes);

                double kb = bytes / KILOBYTE;
                Console.WriteLine("{0:N2} KB", kb);

                double mb = kb / KILOBYTE;
                Console.WriteLine("{0:N2} MB", mb);

                double gb = mb / KILOBYTE;
                Console.WriteLine("{0:N2} GB", gb);

                double tb = gb / KILOBYTE;
                Console.WriteLine("{0:N2} TB", tb);

                Console.WriteLine();
            }
        }
    }
}
