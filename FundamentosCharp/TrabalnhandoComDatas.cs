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
            var data1 = new DateTime(2023, 06, 09, 18, 07, 55);
            var data2 = DateTime.Parse("2023/06/09 18:07:55");

            // Maneiras de recuperar a data atual
            var data3 = DateTime.Now;
            var data4 = DateTime.Today;

            Console.WriteLine(data1);
            Console.WriteLine(data2);
            Console.WriteLine(data3);
            Console.WriteLine(data4);

            //Para formatar da maneira que vc quer vc pode utilizar
            //o ToString(aqui vc coloca da meira que quiser)

            Console.WriteLine(data1.ToString("yyyy-MM-dd HH:mm:ss"));

            // Trabalhando com formato UTC / dateOffset
            var dataOffSet = new DateTimeOffset(DateTime.Now, new TimeSpan(-3, 0, 0));
            Console.WriteLine(dataOffSet.LocalDateTime);

            //Dessa maneira vai vir 3 horas a mais de acordo com o esperado 
            Console.WriteLine(dataOffSet.UtcDateTime);
        }

        public void AulaSubtraindoData()
        {
            var dat1 = DateTime.Now;
            var dat2 = DateTime.Parse("2022-06-10");

            var diferenca = dat1 - dat2;
            Console.WriteLine(diferenca.TotalDays);
            Console.WriteLine(diferenca.TotalHours);

            // Podemos converter para inteiro desconsiderando os numeros apos a virgula
            Console.WriteLine((int)diferenca.TotalDays);
            Console.WriteLine((int)diferenca.TotalHours);
        }

        public void AulaAdicionandoDiasMesAno()
        {
            var data = DateTime.Now;
            Console.WriteLine(data.AddDays(5).ToString("dd-MM-yy"));
            Console.WriteLine(data.AddMonths(1).ToString("dd-MM-yyyy HH:mm:ss"));
            Console.WriteLine(data.AddYears(1).ToString("dd-MM-yyyy HH:mm:ss"));
        }

        public void AulaAdicionandoHoraMinutosSegundos()
        {
            var data = DateTime.Now;
            Console.WriteLine(data.AddHours(1).ToString("HH:mm:ss"));
            Console.WriteLine(data.AddMinutes(10).ToString("HH:mm:ss"));
            Console.WriteLine(data.AddSeconds(10).ToString("HH:mm:ss"));
        }

        public void AulaDiaDaSemana()
        {
            var data = DateTime.Now;
            Console.WriteLine(data.DayOfWeek);
        }

        public void AulaDateOnly()
        {
            //Pode ser feito dessas duas maneiras porem não
            //vai rodar neste projeto pois estou com uma versão mais antiga

            //var data = new DateOnly(2023, 06, 10);
            //var date = DateOnly.Parse("2023-06-10");
            //Console.WriteLine(date.ToString("dd/MM/yyyy"));
        }

        public void AulaTimeOnly()
        {
            //Pode ser feito dessas duas maneiras porem não
            //vai rodar neste projeto pois estou com uma versão mais antiga

            //var time = new TimeOnly(15, 48,10);
            //var time = TimeOnly.Parse("HH:mm:ss");
            //Console.WriteLine(time.ToString("dd/MM/yyyy"));
        }


    }
}
