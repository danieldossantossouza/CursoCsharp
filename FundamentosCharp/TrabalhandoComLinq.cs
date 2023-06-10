using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FundamentosCharp
{
    public class TrabalhandoComLinq
    {

        public void AulaLinq()
        {
            string nomeCompleto = "DANIEL SOUZA XPTO";
            var resultado = nomeCompleto.Where(l => l == 'A');
            foreach (var letra in resultado)
            {
                Console.WriteLine(letra);
            }

            // Exemplo com numeros 

            var numeros = new int[] { 10, 6, 5, 23, 54, 66, 3, 7 };
            var resultadonumero = numeros.Where(n => n >= 10);
            foreach (var num in resultadonumero)
            {
                Console.WriteLine(num);
            }

        }
    }
}
