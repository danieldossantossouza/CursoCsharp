using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FundamentosCharp
{
    public class AulaTrayParse
    {

        public void aulatrayParse()
        {
           
           // var numero = "abc";     // Não será convertido e retornara um zero
            var numero = "12456789";  //var numero = "123456";  // sera convertido 

            // 1- a string que vc quer convrter
            // 2- (out) é o valor valor
            // 3- a outra condição é para o tipo que vc quer no nosso caso será o int
            // OBS: Esse método devolce um valor Buleano se ele não conseguir converter ele devolve false no nosso caso será o zero.

            int numeroConvertido;
            if (int.TryParse(numero, out numeroConvertido))
            {
                Console.WriteLine(" O Número foi convertido com sucesso ! ");
            }
            Console.WriteLine(numeroConvertido);
           
        
        }

    }
}
