﻿using System;
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

        public void AulaOrdenacao()
        {
            // Exemplo com números
            var numeros = new int[] { 2, 4, 6, 8, 10 };
            var ordenando = numeros.OrderBy(n => n);

            foreach (var num in ordenando)
            {
                Console.WriteLine(num);
            }
            Console.WriteLine("---------------//-------------");

            // Exemplo com string
            var nome = new string[] { "Davi", "Daniel", "Keilla", "Samuel" };
            // var ordenandoNome = nome.OrderBy(n=>n); //// Ordenação asc
            var ordenandoNome = nome.OrderByDescending(n => n); //Ordenação desc

            foreach (var nom in ordenandoNome)
            {
                Console.WriteLine(nom);
            }
           
        }

        public void AulaTake()
        {
            var numeros = new int[] { 10, 2, 4, 22, 50, 66, 3 ,88};
            //var take = numeros.Take(3); // Busca os 3 primeiros numeros
            //var take = numeros.Take(3).OrderBy(n => n); // Busca os 3 primeiros numeros ordenando-os
            var take = numeros.Where(n => n > 10).Take(2); //Busca os 2 primeiros numeros maiores que 10

            foreach (var num in take) 
            {
                Console.WriteLine(num);
            }
        }

        public void AulaCount()
        {
            var numeros = new int[] { 10, 2, 5, 33, 66, 44, 6, 7, 88 };

            //var cont = numeros.Count();// Conta a quantidade que tem dentro da lista 

            var cont = numeros.Count(n=> n > 10); // Conta a quantidade que tem dentro da lista maior que 10
            Console.WriteLine(cont);  
         
        }

        public void AulaFirstFirstOrDefault()
        {
            //var numero = new int[] { 10, 30, 4, 2, 66, 77, 88, 4, 8 };
            //var resultado = numero.First(); // Busca o primeiro da lista esse tipo da erro se a lista estiver vazia

            var numero = new int[] { 10, 30, 4, 2, 66, 77, 88, 4, 8 };
            var resultado = numero.FirstOrDefault(n => n >10); // Busca o primeiro da lista e não da erro na aplicação se vier vazia a lista
           

            Console.WriteLine(resultado);
        }
    }
}
