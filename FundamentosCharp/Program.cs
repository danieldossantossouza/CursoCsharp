using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace FundamentosCharp
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Olá, vamos começar!!!");

            //Variaveis no c#
            //int idade = 34;
            //string Nome = "Daniel";
            //decimal valor = 100.99m;
            //double valordoble = 200.99;
            //float valorfloat = 300.98f;
            //char inicionome = 'D';
            //bool Ativo = true;
            //Console.WriteLine($"meu nome é {Nome} tenho {idade} de idade, devo {valor} mais com juros vou pagar {valordoble} " +
            //  $" com o juros estão querendo que eu pague {valorfloat}  primeira letra {inicionome} e esta {Ativo}");
            //Console.ReadLine();

            //-----------------------------------------    Exmplo ArrayList     -----------------------------------------------------//

            //var arryList = new ArrayList();
            ////adicionando na lista

            //arryList.Add(1);
            //arryList.Add("Daniel");
            //arryList.Add(true);

            ////precorendo a lista
            //foreach (var item in arryList)
            //{
            //    Console.WriteLine(item);

            //}
            //Console.ReadLine();

            // para remover de um a um ou utiliza o clear para limpar a lista
            //arryList.Remove(1);
            //arryList.Clear();

            //---------------------------------------   Exmplo Array Tipado   -----------------------------------------------------//

            //var arreyTipadoNumeros = new int[3] { 1,2,3};

            //Console.WriteLine(arreyTipadoNumeros[0]);
            //Console.ReadLine();

            //arreyTipadoNumeros[0] = 10;
            //arreyTipadoNumeros[1] = 20;
            //arreyTipadoNumeros[2] = 30;


            // para redefinir o tamanho do arrey 
            //Array.Resize(ref arreyTipadoNumeros, 10);
            //arreyTipadoNumeros[9] = 100;

            //foreach (var item in arreyTipadoNumeros)
            //{
            //    Console.WriteLine(item);
            //}
            //Console.ReadLine();

            // exemplo com String
            //var arreyComStrig = new string[2] { "Daniel ", "Souza" };

            //var arreyComStrig = new string[2];
            //arreyComStrig[0] = "Davi";
            //arreyComStrig[1] = "Gomes";

            //foreach (var item in arreyComStrig)
            //{
            //    Console.WriteLine(item);
            //}
            //Console.WriteLine($"meu nome é {arreyComStrig[0]} {arreyComStrig[1]}");
            // Console.ReadLine();

            //----------------------------------------------- Arrey genérico   --------------------------------------------------//
            //var lista = new List<string>(10)
            //{
            //    "Daniel",
            //    "Davi",
            //    "Antonio"
            //};

            /*

            para remover
            lista.RemoveAt(1);

            */

            //foreach (var item in lista)
            //{
            //    Console.WriteLine(item);
            //}

            //Console.ReadLine();

            //---------------------------------------  Dicionario   --------------------------------------------------------//

            //var dicionario = new Dictionary<string, string>()
            //{
            //    { "test1","Daniel"},
            //    { "test2","Davi"}
            //};

            // dicionario.Add("test3", "Rafael");
            //var te =dicionario["test2"] = "Davi@";
            //Console.WriteLine(te);
            //Console.ReadLine();

            //exemplo com foreach
            //foreach (var item in dicionario)
            //{
            //    Console.WriteLine(item.Value);
            //}

            //foreach (var item in dicionario)
            //{
            //    Console.WriteLine(item.Key);
            //}
            //Console.ReadLine();

            /*
            //outro exemplo:

            var dicionario = new Dictionary<int, string>();

            dicionario.Add(1,"DAniel");

            var nome = dicionario[1];
            Console.WriteLine(nome);
            Console.ReadLine();
            */

            //------------------------------------------------------  Queue(Fila) -----------------------------------------------------------//
            //Enqueue --> adiciona na lista 

            //var queue = new Queue<string>();
            //queue.Enqueue("Daniel");
            //queue.Enqueue("Samuel");

            //Peek --> recupera sempre o primeiro valor da pilha        
            //var nome = queue.Peek();
            //var nome2 = queue.Peek();
            //Console.WriteLine(nome);
            //Console.WriteLine(nome2);

            //Dequeu --> Tira o ultimo resultado da pilha e reordena a pilha
            //var nome = queue.Dequeue();
            //var nome2 = queue.Dequeue();
            //Console.WriteLine(nome);
            //Console.WriteLine(nome2);

            // também podemos percorrer a pilha com o foreach
            /*
            //foreach (var item in queue)
            //{
            //    Console.WriteLine(item);
            //}
            */

            //Console.ReadLine();


            //--------------------------------------------------------  Stack  ---------------------------------------------//
            // Push --> Adiciona um elemento 

            //var stack = new Stack<string>();
            //stack.Push("Davi");
            //stack.Push("Daniel");

            /*
            //var nome = stack.Pop();
            //var nome1 = stack.Pop();

            Console.WriteLine(nome);
            Console.WriteLine(nome1);
            */

            //foreach (var item in stack)
            //{
            //    Console.WriteLine(item);
            //}

            //Console.ReadLine();

            //-------------------------------------------------------  Switch -------------------------------------------------//

            //var diaDaSemana = 10;
            //switch (diaDaSemana)
            //{
            //    case 0: Console.WriteLine("Hoje é domingo !");
            //        break;
            //    case 1:
            //        Console.WriteLine("Hoje é segunda !");
            //        break;

            //    case 2:
            //        Console.WriteLine("Hoje é terça !");
            //        break;

            //    case 3:
            //        Console.WriteLine("Hoje é quarta !");
            //        break;

            //    case 4:
            //        Console.WriteLine("Hoje é quinta !");
            //        break;

            //    case 5:
            //        Console.WriteLine("Hoje é sexta !");
            //        break;

            //    case 6:
            //        Console.WriteLine("Hoje é sabado !");
            //        break;

            //    default:  //O default é para se caso não for nenhum dos case anterior 
            //        Console.WriteLine("Dia invalido !");
            //        break;
            //}
            //Console.ReadLine();

            //------------------------------------------------------------------    For     -------------------------------------------------------------/////

            //var lista = new List<string>() { "Davi", "Daniel", "Keilla", "Samuel" };

            //for (var i = 0; i < lista.Count; i++)
            //{
            //    var nome = lista[i];
            //    Console.WriteLine(nome);
            //}
            //Console.ReadLine();

            ////Tambem pode fazer de outro jeito 

            //var cont = lista.Count;

            //for (var i = 0; i < cont; i++)
            //{
            //    var nome = lista[i];
            //    Console.WriteLine(nome);
            //}
            //Console.ReadLine();

            //-------------------------------------  foreach   ------------------------------------------//
            //var lista = new List<string>() { "Davi", "Daniel", "Keilla", "Samuel" };

            //foreach (string item in lista)
            //{
            //    Console.WriteLine(item);

            //}
            //Console.ReadLine();

            //// OBS: O Foreach pode percorer o que vc colocar 
            //foreach (var letra in "Daniel")
            //{
            //    Console.WriteLine(letra);
            //}
            //Console.ReadLine();

            //------------------------------------ While / Do While  -------------------------------------//

            // While valida para depois executar.
            //var i = 0;

            //while (i < 4)
            //{
            //    Console.WriteLine("O valor de i é : " + i);
            //    i++;
            //}
            //Console.ReadLine();

            //// Do While  Primeiro execulta o codigo para depois validar

            //var j = 0;
            //do
            //{
            //    Console.WriteLine("O jalor do J é: " + j);
            //    j++;
            //} while (j > 6);
            //Console.ReadLine();

            //------------------------------------- Braeck / Continue  -------------------------//

            //var i = 0;
            //while (i < 5)
            //{
            //    Console.WriteLine("O Valor de i é : " + i);
            //    i++;

            //    if (i == 2)
            //    {
            //        Console.WriteLine("O Valor de é agora é 2 !");
            //        break; // sai de dentro do seu laço.


            //        //i++; // Utiliza essa inplementação para o continue.
            //        //continue;
            //    }

            //}
            //Console.ReadLine();

            //-------------------------------------- Herança  ------------------------------------------//
            //AulaHeraca();

            //--------------------------------------  Classe selada -----------------------------------//

            // Não conseguimos herdar os atributos ou métodos de uma classe selada
            //AulaCasseSelada();

            //--------------------------------------- Classe Abstrata  -----------------------------------//
            // Vc Não consegue criar uma estacia atraves de uma classe Abstrata (NEW) papel principal
            // é servir como uma super classe para subClasses 
            //
            //AulaClasseAbstrata();

            //-------------------------------------- Interface -----------------------------------------//
            // Interface é um contrato que quando uma classe herda a mesma ela obriga a implementação dos atributos e métodos da Interface.
            //AulaInterface();
            //Console.ReadLine();

            //------------------------------------- TrayParse  ----------------------------------------//
            // Conversor();

            //------------------------------------- ToLower  ------------------------------------------//
            //Como converter uma cadeia de caracéres em letras minuscula.
            //TrabalhaStrigs();
            //Console.ReadLine();

            //------------------------------------- ToUpper  -----------------------------------------//
            //Como converter uma cadeia de caracéres em letras maiuscula.
            //TrabalhaStrigs();
            //Console.ReadLine();

            //-------------------------------------  Trabalhando com String ---------------------------------------//

            //TrabalhaStrigs();
            //Console.ReadLine();

            //------------------------------------- Trabalhando Com Datas ------------------------//
            TrabalhandoComData();
            Console.ReadLine();

        }
        private static void AulaHeraca()
        {

            var pessoaFisica = new FundamentosCharp.PessoaFisica();
            pessoaFisica.Id = 1;
            pessoaFisica.Endereco = "Rua qualquer";
            pessoaFisica.Cidade = "São Paulo";
            pessoaFisica.Cep = "04892-120";
            pessoaFisica.Cpf = "363.111.111-22";

            pessoaFisica.ImprimirDados();
            pessoaFisica.ImprimirCpf();

            Console.ReadLine();


        }

        private static void AulaCasseSelada()
        {
            // Podemos fazer dessa maneira 

            //var configuracao = new FundamentosCharp.Configuracao();
            //configuracao.Host = "Classe Selada";


            var configuracao = new FundamentosCharp.Configuracao()
            {
                Host= "Classe selada"
            };

            Console.WriteLine(configuracao.Host);
            Console.ReadLine();
        }

        private static void AulaClasseAbstrata()
        {
            var cachorro = new FundamentosCharp.Cachorro();
            cachorro.Nome = "Kiara";
            cachorro.ImprimirDados();
            Console.ReadLine();
        }

        private static void AulaInterface()
        {
            var notificacaoCliente = new FundamentosCharp.NotificacaoCliente();
            notificacaoCliente.Descricao = "Esse é ´Cliente!";
            notificacaoCliente.Notificar();
            notificacaoCliente.NotificarOutros();


            //---------------

            FundamentosCharp.INotificacao notificacao = new FundamentosCharp.NotificarFuncionarios();
            notificacao.Descricao = "Esse é o Funcionario!";
            notificacao.Notificar();

            // Dessa maneira não aceita pois ela vai exigir somente o que esta no contrato que esta na classe INotificacao
            //notificacao.NotificarOutros();

        }

        private static void Conversor()
        {
            var conversor = new FundamentosCharp.AulaTrayParse();
            conversor.aulatrayParse();
            Console.ReadLine();
        
        }

        private static void TrabalhaStrigs()
        {
            //var trabalhandoCmStrings = new FundamentosCharp.TrabalhandoComStrings();
            //trabalhandoCmStrings.ConverterParaLetraMinuscula();

            //var letrasMaiuscula = new FundamentosCharp.TrabalhandoComStrings();
            //letrasMaiuscula.ConvertendoParaLetrasMaiusculas();

            //var subString = new FundamentosCharp.TrabalhandoComStrings();
            //subString.AulaSbtring();

            //var contains = new FundamentosCharp.TrabalhandoComStrings();
            //contains.AulaContains();

            //var trim = new FundamentosCharp.TrabalhandoComStrings();
            //trim.AulaTrim();


            //var startWithEndWith = new FundamentosCharp.TrabalhandoComStrings();
            //    startWithEndWith.AulaStartWithEndWith();

            var aulaReplace = new FundamentosCharp.TrabalhandoComStrings();
            aulaReplace.AulaReplace();

        }

        private static void TrabalhandoComData()
        {
            var trabalhaComData = new FundamentosCharp.TrabalnhandoComDatas();
            trabalhaComData.AulaDateTime();
        }
    }
}
