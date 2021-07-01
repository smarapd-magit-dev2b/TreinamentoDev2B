using System;
using System.Collections.Generic;
using System.Text;

namespace Aula5.Exercicio4
{
    class ItemVenda
    {
        public ItemVenda()
        {
            Console.WriteLine("Digite o id do item: ");
            Id = Console.ReadLine();
            Console.WriteLine("Digite a descrição do item: ");
            Descricao = Console.ReadLine();
            Console.WriteLine("Digite a quantidade de itens: ");
            Quantidade = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("digite o proço de cada unidade: ");
            PrecoUnitario = Convert.ToDecimal(Console.ReadLine());
        }

        public string Id { get; set; }
        public string Descricao { get; set; }
        public int Quantidade { get; set; }
        public decimal PrecoUnitario { get; set; }
        

    }
}
