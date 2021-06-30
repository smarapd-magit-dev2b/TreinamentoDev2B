using System;

namespace Aula4.Exercicio4.Classes
{
    public class ItemVenda
    {
        public ItemVenda()
        {
            Id = int.Parse(Console.ReadLine());
            Descricao = Console.ReadLine();
            Quantidade = int.Parse(Console.ReadLine());
            Preco = decimal.Parse(Console.ReadLine());
        }

        public int Id { get; set; }
        public string Descricao { get; set; }
        public int Quantidade { get; set; }
        public decimal Preco { get; set; }
    }
}