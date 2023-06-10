using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FundamentosCharp
{
    public class TrabalhandoComException
    {

        public void AuladeException()
        {
			// O Try evita que o sistema seja encerrado apos um erro 
			try
			{
				Console.Write("Informe um momento: ");
				var numero = Console.ReadLine();
				var resultado = 500 / int.Parse(numero);
				Console.WriteLine("Resultado: " + resultado);

			}
			// existem classes de exceções customizadas 
			catch (DivideByZeroException ex) 
			{
				// A vantagem é que vc pode especificar o tipo de erro 
                Console.WriteLine("Ocorreu um erro de divisão! " + ex.Message); //Capiturando a mensagem do erro
                Console.WriteLine("Stack " + ex.StackTrace); // Capitura a linha que deu o erro
            }
			catch (Exception ex)
			{
				Console.WriteLine("Ocorreu um erro! " + ex.Message); //Capiturando a mensagem do erro
				Console.WriteLine("Stack " + ex.StackTrace); // Capitura a linha que deu o erro
			}
        }
    }
}
