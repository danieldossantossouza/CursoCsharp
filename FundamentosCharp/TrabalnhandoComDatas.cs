using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FundamentosCharp
{
    public class TrabalnhandoComDatas
    {
        public void AulaDateTime()
        {
            //2 formas de criar data no c#
            var data1 = new DateTime(2023,06,09,18,07,55);
            var data2 =  DateTime.Parse("2023/06/09 18:07:55");

            // Outras maneiras de recuperar a data atual
            var data3 = DateTime.Now;
            var data4 = DateTime.Today;

            Console.WriteLine(data1);
            Console.WriteLine(data2);
            Console.WriteLine(data3);
            Console.WriteLine(data4);

            //Para formatar da maneira que vc quer vc pode utilizar
            //o ToString(aqui vc coloca da meira que quiser)

            Console.WriteLine(data1.ToString("yyyy-MM-dd HH:mm:ss"));

        }
    }
}
