using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace FundamentosCharp
{
    public class PessoaFisica : Pessoa
    {
        public string Cpf { get; set; }

        public void ImprimirCpf()
        {
          
                Console.WriteLine("Cpf: " + Cpf);

        }

    }
}
