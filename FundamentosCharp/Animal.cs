using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace FundamentosCharp
{
    public abstract class Animal
    {
        public string Nome { get; set; }
        public abstract string GetInformacoes();

        public void ImprimirDados()
        {
            Console.WriteLine("Nome do Animal: " + Nome);
            Console.WriteLine("Informações: " + GetInformacoes());

        }
     
    }
}
