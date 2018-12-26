using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Item17
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            txtTimer.Text = DateTime.Now.ToString("HH:mm:ss:fff");
        }

        private async void btnIniciar_Click(object sender, EventArgs e)
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
                await fluxoSaida.WriteAsync(array, posicao, tamanho);
                await Task.Delay(2000);
            }

            // LENDO UM ARQUIVO
            using (FileStream fluxoEntrada
                = new FileStream("ArquivoSaida.txt",
                    FileMode.Open, FileAccess.Read))
            {
                byte[] bytesLidos = new byte[fluxoEntrada.Length];
                int posicao = 0;
                await fluxoEntrada.ReadAsync(bytesLidos, posicao, (int)fluxoEntrada.Length);
                string texto = Encoding.UTF8.GetString(bytesLidos);
                Console.WriteLine("Mensagem Lida: " + texto);
            }
        }
    }
}
