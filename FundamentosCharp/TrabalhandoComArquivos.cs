using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FundamentosCharp
{
    public class TrabalhandoComArquivos
    {
        public void AulaCriandoArquivo()
        {
            //Biblioteca para trabalhar com arquivos
            var escrever = new StreamWriter("C:\\Users\\daniel.souza\\Desktop\\Estudo\\AulaArquivos\\Cadastro.txt", true); //Dessa forma ele vai inserindo os nomes no mesmo arquivo
            Console.Write("Informe o nome: ");
            var nome = Console.ReadLine();
           // escrever.WriteLine("ID...: " + Random.Shared.Next(1,100)); ////Para criar Id aleatorio não funciona nesse projeto por calsa da versão. 
            escrever.WriteLine("nome: " + nome);
            escrever.WriteLine("------------------//----------------- " );
            escrever.Close();
        }

        public void AulaLeituraDeArquivo()
        {
            var conteudo = File.ReadAllText("C:\\Users\\daniel.souza\\Desktop\\Estudo\\AulaArquivos\\Cadastro.txt");
            Console.WriteLine(conteudo);

            //Para fazer a leitura de linha por linha podemos fazer da maneira a baixo.
            var lerLinhaPorLinha = new StreamReader("C:\\Users\\daniel.souza\\Desktop\\Estudo\\AulaArquivos\\Cadastro.txt");
            while (!lerLinhaPorLinha.EndOfStream)
            {
                var linha = lerLinhaPorLinha.ReadLine();
                Console.WriteLine(linha);
            }
            lerLinhaPorLinha.Close();
        }

        public void AulaExcluirArquivos()
        {
            if (File.Exists("C:\\Users\\daniel.souza\\Desktop\\Estudo\\AulaArquivos\\Cadastro.txt"))
            {
                File.Delete("C:\\Users\\daniel.souza\\Desktop\\Estudo\\AulaArquivos\\Cadastro.txt");
            }
        }


    }
}
