using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FundamentosCharp
{
    public class NotificarFuncionarios : INotificacao
    {
        public string Descricao { get ; set ; }

        public void Notificar()
        {
            Console.WriteLine(Descricao);
            Console.WriteLine(" Notificando Funcionario ! ");
           
        }


        
        public void NotificarOutros()
        {
            Console.WriteLine(" Notificando outros funcionarios !");
            
        }
    }
}
