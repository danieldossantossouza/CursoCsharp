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
            Console.WriteLine(nome.Substring(6));  // O primeiro campo é de onde vai começar a contagem o segundo é onde vai para.
                                                     // Se colocar somente um numero será exibido tudo apartir daquela posição
        }
    }
}
