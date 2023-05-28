using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FundamentosCharp
{
    public class NotificacaoCliente : INotificacao
    {
        public string Descricao { get ; set; }

        public void Notificar()
        {
            Console.WriteLine(Descricao);
            Console.WriteLine(" Notificando Cliente !");
            
        }

        public void NotificarOutros()
        {
            Console.WriteLine(" Notificando outros clientes !");
          
        }
    }
}
