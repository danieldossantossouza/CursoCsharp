using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FundamentosCharp
{
    public class TrabalhandoComStrings
    {

        public void ConverterParaLetraMinuscula()
        {
            Console.Write("Digite seu nome: ");
            var nome = Console.ReadLine();
            Console.WriteLine(nome.ToLower());
        }


        public void ConvertendoParaLetrasMaiusculas()
        {
            Console.Write("Digite seu nome:");
            var nome = Console.ReadLine();
            Console.WriteLine(nome.ToUpper());
        }

        public void AulaSbtring()
        {
            Console.Write("Digite seu nome completo:");
            var nome = Console.ReadLine();
            Console.WriteLine(nome.Substring(0,6));  // O primeiro campo é de onde vai começar a contagem o segundo é onde vai para.
                                                     // Se colocar somente um numero será exibido tudo apartir daquela posição
        }

        //public void AulaRange()
        //{
        //    string nomeArquivo = "2023_06_08_backup.bak";
        //    // Não foi possível rodar essa aula pois a versão não é pompativel 
        //    string ano = nomeArquivo[..4];
        //    Console.WriteLine(ano);

        //}

        public void AulaContains()
        {
            string nomeArquivo = "2023_06_08_backup.bak";
            if (nomeArquivo.Contains("2023_06_08_backupXPTO"))
            {
                Console.WriteLine("Palavra encontrada! ");
            }
            else Console.WriteLine("Palavra Não encontrada!!!");
        }

        public void AulaTrim()
        {
            // Retira os caracteres que vc deseja (Trim)
            string nomeArquivo = "**Daniel Souza**";
            Console.WriteLine("TOTAL: " + nomeArquivo.Trim());
            Console.WriteLine("INICIO: " + nomeArquivo.TrimStart('*'));
            Console.WriteLine("fINAL: " + nomeArquivo.TrimEnd('*'));
        }

    }
}
