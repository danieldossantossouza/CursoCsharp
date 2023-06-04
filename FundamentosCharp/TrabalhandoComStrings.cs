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
    }
}
