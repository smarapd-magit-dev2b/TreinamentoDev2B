﻿using System;

namespace Exercicio_1
{
    class Program
    {
        static void Main(string[] args)
        {
            ItemVenda p1;

            Console.WriteLine("Determine os topicos: ");

            //Numero do produto-------------

            Console.WriteLine("Numero do produto: ");
            int numero = Convert.ToInt32(Console.ReadLine());

            //Descrição---------------------

            Console.WriteLine("Descrição do produto: ");
            string descricao = Console.ReadLine();

            //Quantidade--------------------

            Console.WriteLine("Digite a quantidade: ");
            int quantidade = Convert.ToInt32(Console.ReadLine());

            //Preço-------------------------

            Console.WriteLine("Digite o preço: ");
            decimal preço = Convert.ToDecimal(Console.ReadLine());

            p1 = new ItemVenda(numero, descricao, quantidade, preço);

            //Mensagem----------------------

            Console.WriteLine("\n O valor da fatura R$: " + p1.ValorFatura());

        }
    }
}
