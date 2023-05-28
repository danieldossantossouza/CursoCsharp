using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FundamentosCharp
{
    public interface INotificacao
    {
        string Descricao { get; set; }
        void Notificar();
    }
}
