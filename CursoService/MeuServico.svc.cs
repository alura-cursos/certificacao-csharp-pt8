using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace CursoService
{
    public class MeuServico : IMeuServico
    {
        public string GetValor(int chave)
        {
            string resultado = "chave inválida";
            switch (chave)
            {
                case 1:
                    resultado = "70-483 - Programming in C# Parte 1 (Criar tipos)";
                    break;
                case 2:
                    resultado = "70-483 - Programming in C# Parte 2 (Consumir tipos)";
                    break;
                case 3:
                    resultado = "70-483 - Programming in C# Parte 3 (Encapsulamento e Hierarquia de Classes)";
                    break;
                case 4:
                    resultado = "70-483 - Programming in C# Parte 4 (Fluxo de Programa)";
                    break;
                case 5:
                    resultado = "70-483 - Programming in C# Parte 5 (Ciclo de vida de Objetos, Manipulação de Strings)";
                    break;
                case 6:
                    resultado = "70-483 - Programming in C# Parte 6 (Coleções  e JSON)";
                    break;
                case 7:
                    resultado = "70-483 - Programming in C# Parte 7 (Lambda e LINQ)";
                    break;
                case 8:
                    resultado = "70-483 - Programming in C# Parte 8 (Entrada e Saída de Dados)";
                    break;
                case 9:
                    resultado = "70-483 - Programming in C# Parte 9 (Depurar Aplicativos)";
                    break;
                case 10:
                    resultado = "70-483 - Programming in C# Parte 10 (Reflection)";
                    break;
                case 11:
                    resultado = "70-483 - Programming in C# Parte 11 (Multithreading)";
                    break;
                case 12:
                    resultado = "70-483 - Programming in C# Parte 12 (Validar Segurança)";
                    break;
            }
            return resultado;
        }
    }
}
