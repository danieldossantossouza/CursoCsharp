using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace FundamentosCharp
{
    public class Pessoa
    {
        public int Id { get; set; }
        public string Endereco { get; set; }
        public string Cidade { get; set; }
        public string Cep { get; set; }

        public void ImprimirDados() 
        {
            Console.WriteLine("Id: " + Id);
            Console.WriteLine("Endereco: " + Endereco);
            Console.WriteLine("Cidade: " + Cidade);
            Console.WriteLine("Cep: " + Cep);
            
        }

    }
}
